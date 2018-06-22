#region License
/*
    Fractron 9000
    Copyright (C) 2009 Michael J. Thiesen
	http://fractron9000.sourceforge.net
	mike@thiesen.us

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.
*/
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

using Fractron9000.CPUEngine;
using Fractron9000.OpenCLEngine;
using Fractron9000.CudaEngine;


namespace Fractron9000
{
	public enum FractalEngineState{Offline, Suspended, Online, Error};
	public class EngineManager
	{
		private UI.MainForm mainForm;

		private DeviceEntry[] foundDevices = null;

		/// <summary>
		/// Gets an array of possible rendering devices. Returns null if the opengl context hasn't been created. Returns an empty array if no devices are found.
		/// </summary>
		public DeviceEntry[] FoundDevices{
			get{
				if(foundDevices == null)
					foundDevices = searchForDevices();
				return foundDevices;
			}
		}

		private DeviceEntry deviceEntry;
		
		/// <summary>
		/// Gets the device used to create the current engine, or null if no device has been selected
		/// </summary>
		public DeviceEntry DeviceEntry{
			get{ return deviceEntry; }
		}

		/// <summary>
		/// Gets the current fractal engine, or null if the engine is shut down
		/// </summary>
		private FractalEngine engine;
		public FractalEngine Engine{
			get{ return engine; }
		}

		private FractalEngine.Stats stats;
		public FractalEngine.Stats Stats{
			get{ return stats; }
		}

		private Exception currentException = null;

		/// <summary>
		/// Gets the most recently thrown exception
		/// </summary>
		public Exception CurrentException{
			get{ return currentException; }
		}

		private bool paletteDirty = false;
		private bool toneMapDirty = false;
		private bool geometryDirty = false;
		private bool doneIterating = false;
		public bool DoneIterating{
			get{ return doneIterating; }
		}

		private int cycleCount = 0;
		public int CycleCount{
			get{ return cycleCount; }
		}

		private int currentItersPerCycle = 0;

		private DateTime cycleResetTime = DateTime.Now;
		private DateTime cyclePrevOutputTime = DateTime.Now;
		public double SecondsSinceReset{
			get{ return (cyclePrevOutputTime - cycleResetTime).TotalSeconds; }
		}

		private FractalEngineState desiredEngineState = FractalEngineState.Offline;
		public FractalEngineState DesiredEngineState{
			get{ return desiredEngineState; }
			set{ desiredEngineState = value; }
		}

		private Size desiredOutputSize = new Size(8,8);
		public Size DesiredOutputSize{
			get{ return desiredOutputSize; }
			set{
				desiredOutputSize = value;
				if(engine != null && engine.IsAllocated() && 
					(engine.XRes != desiredOutputSize.Width || engine.YRes != desiredOutputSize.Height))
				{
					Suspend();
				}
			}
		}

		public FractalEngineState EngineState{
			get{
				if(currentException != null)
					return FractalEngineState.Error;
				else if(engine == null)
					return FractalEngineState.Offline;
				else if(engine.IsAllocated())
					return FractalEngineState.Online;
				else
					return FractalEngineState.Suspended;
			}
		}

		public EngineManager(UI.MainForm owner)
		{
			this.mainForm = owner;
		}

		public void UpdateEngineState()
		{
			FractalEngineState rs = this.DesiredEngineState;  //the desired engine state
			switchState(rs);
		}

		/// <summary>
		/// This is the only way to get out of the error state. It clears the current exception and
		/// allows the EngineManager to try to restart the engine
		/// </summary>
		public void ClearError()
		{
			currentException = null;
		}

		private void switchState(FractalEngineState rs)
		{
			FractalEngineState cs = this.EngineState;         //the current engine state
			
			try{
				if(rs == cs)
				{
					return; //they match, do nothing
				}
				else if(cs == FractalEngineState.Online)
				{
					if(rs == FractalEngineState.Suspended) //go from online to suspended
					{
						engine.Deallocate();
					}
					else if(rs == FractalEngineState.Offline) //go from online to offline
					{
						shutdownEngine();
					}
				}
				else if(cs == FractalEngineState.Suspended)
				{
					if(rs == FractalEngineState.Online) //go from suspended to online
					{
						allocateEngine();
					}
					else if(rs == FractalEngineState.Offline) //go from suspended to offline
					{
						shutdownEngine();
					}
				}
				else if(cs == FractalEngineState.Offline)
				{
					if(rs == FractalEngineState.Online)          //go from offline to online
					{
						deviceEntry = chooseDevice();
						engine = deviceEntry.CreateFractalEngine(mainForm.Renderer.Context);
						allocateEngine();
					}
					else if(rs == FractalEngineState.Suspended)  //go from offline to suspended
					{
						deviceEntry = chooseDevice();
						engine = deviceEntry.CreateFractalEngine(mainForm.Renderer.Context);
					}
				}
				else if(cs == FractalEngineState.Error)
				{
					if(rs == FractalEngineState.Offline)             //go from error to offline
					{
						shutdownEngine();
					}
				}
			}
			catch(Exception ex) //if something goes wrong, switch to the error state
			{
				shutdownEngine();
				if(ex is NoDevicesFoundException)
					currentException = ex;
				else
					currentException = new FractalEngineStateException(deviceEntry==null ? EngineType.Auto : deviceEntry.EngineType, cs, rs, ex);
			}
		}

		private DeviceEntry[] searchForDevices()
		{
			if(mainForm.Renderer.Context == null) return null; //bail out if the GL context hasn't been created

			DeviceEntry[] eDevs = null;
			List<DeviceEntry> devList = new List<DeviceEntry>();

			try{
				OpenCLDeviceEntry.CheckSupport(); //will throw an exception if not supported

				eDevs = OpenCLDeviceEntry.GetDevices();
				if(eDevs != null)
					devList.AddRange(eDevs);
			}
			catch{}

			try{
				CudaDeviceEntry.CheckSupport(); //will throw an exception if not supported

				eDevs = CudaDeviceEntry.GetDevices();
				if(eDevs != null)
					devList.AddRange(eDevs);
			}
			catch{}

			try{
				CPUDeviceEntry.CheckSupport(); //will throw an exception if not supported

				eDevs = CPUDeviceEntry.GetDevices();
				if(eDevs != null)
					devList.AddRange(eDevs);
			}
			catch{}

			return devList.ToArray();
		}

		/// <summary>
		/// Looks through all available devices and estimates which one will have the best performance
		/// </summary>
		public DeviceEntry GetBestDevice()
		{
			DeviceEntry best = null;
			float bestRank = 0.0f;

			if(FoundDevices != null)
			{
				foreach(DeviceEntry dev in FoundDevices)
				{
					if(dev.PerformanceRating > bestRank)
					{
						bestRank = dev.PerformanceRating;
						best = dev;
					}
				}
			}

			return best;
		}

		/// <summary>
		/// Select a device to use based on the current configuration. If no device can be found, this throws NoDevicesFoundException
		/// </summary>
		private DeviceEntry chooseDevice()
		{
			if(mainForm.Renderer.Context == null || FoundDevices == null) //if there's no graphics context, bail out
				return null;

			DeviceEntry chosenDev = null;

			//first try to find a device with the same type and ID as the one in the config
			foreach(DeviceEntry dev in FoundDevices)
			{
				if(dev.EngineType == mainForm.Config.EngineType && dev.ID == mainForm.Config.DeviceID)
					chosenDev = dev;
			}

			//if no match was found, just pick the best device
			if(chosenDev == null)
				chosenDev = GetBestDevice();

			//ok, if still no device is found, then we are in trouble
			if(chosenDev == null)
			{
				Exception cpuEx = null;
				try{
					CPUDeviceEntry.CheckSupport();
				}
				catch(Exception ex){
					cpuEx = ex;
				}
				throw new NoDevicesFoundException("No compatable devices were found.", cpuEx);
			}

			return chosenDev;
		}

		private void shutdownEngine()
		{			
			Trace.WriteLine("Shutting down engine and forcing garbage collection.", "notice");
			try{
				if(engine != null)
				{
					engine.Dispose();
					engine = null;
				}
				
				//If there are any bugs involving destructors or disposing unmanaged objects, hopefully this will trigger them.
				GC.Collect();
			}
			catch(Exception ex)
			{
				Trace.WriteLine("Engine shutdown failed: "+ex.ToString(), "warning");
			}
			finally{
				engine = null;
			}
		}

		private void allocateEngine()
		{
			if(desiredOutputSize.Width <= 0 || desiredOutputSize.Height <= 0)
				return;

			engine.Allocate(desiredOutputSize.Width, desiredOutputSize.Height);
			mainForm.Config.Valid = true;

			FractalManager.NotifyPaletteChanged();
			FractalManager.NotifyGeometryChanged();
			FractalManager.NotifyToneMapChanged();
		}

		public void Suspend()
		{
			switchState(FractalEngineState.Suspended);
		}

		public void Shutdown()
		{
			switchState(FractalEngineState.Offline);
		}

		public void MarkPaletteDirty()
		{
			paletteDirty = true;
		}

		public void MarkToneMapDirty()
		{
			toneMapDirty = true;
		}

		public void MarkGeometryDirty()
		{
			geometryDirty = true;
		}

		public void DoCycle()
		{
			if(EngineState != FractalEngineState.Online) //bail if the engine is in the wrong state
				return;
			try
			{
				if(Engine.IsBusy()) //dont bother trying to do anything if the engine is busy
				{
					return;
				}
				if(paletteDirty)
					Engine.ApplyPalette(FractalManager.Fractal.Palette);

				if(toneMapDirty || geometryDirty)
					Engine.ApplyParameters(FractalManager.Fractal);

				if(geometryDirty || paletteDirty)
				{
					cycleCount = 0;
					currentItersPerCycle = 2*mainForm.Config.RedrawQuality;
					Engine.ResetOutput();
					cycleResetTime = DateTime.Now;
					doneIterating = false;
				}

				paletteDirty = geometryDirty = false;
				
				int k = (cycleCount-2)%3;

				if(doneIterating)
				{
					if(toneMapDirty){
						Engine.CalcToneMap();
						Engine.Synchronize();
						Engine.CopyToneMap();
						toneMapDirty = false;
					}
					mainForm.NotifyProgress(this, EventArgs.Empty);
				}
				else if(cycleCount < 2)
				{
					Engine.DoIterationCycle(mainForm.Config.RedrawQuality);
					Engine.CalcToneMap();
					Engine.Synchronize();
					cyclePrevOutputTime = DateTime.Now;
					Engine.CopyToneMap();
					toneMapDirty = false;

					stats = Engine.GatherStats();
					if(stats.meanDotsPerSubpixel >= mainForm.Config.TargetQuality)
						doneIterating = true;

					mainForm.NotifyProgress(this, EventArgs.Empty);

					cycleCount++;
				}
				else
				{
					if(k == 0)
					{
						Engine.DoIterationCycle(currentItersPerCycle);
						if(currentItersPerCycle < 8*mainForm.Config.RedrawQuality)
							currentItersPerCycle += mainForm.Config.RedrawQuality;
					}
					else if(k == 1)
					{
						Engine.CalcToneMap();
					}
					else
					{
						Engine.CalcToneMap();
						Engine.Synchronize();
						cyclePrevOutputTime = DateTime.Now;
						Engine.CopyToneMap();
						toneMapDirty = false;

						stats = Engine.GatherStats();
						if(stats.meanDotsPerSubpixel >= mainForm.Config.TargetQuality)
						{
							doneIterating = true;
						}
						mainForm.NotifyProgress(this, EventArgs.Empty);
					}
					cycleCount++;
				}
			}
			catch(Exception ex)
			{
				shutdownEngine();
				currentException = new FractalEngineException(deviceEntry == null ? EngineType.Auto : deviceEntry.EngineType, ex.Message, ex);			
			}
		}
	}

	/// <summary>
	/// Thrown when no fractron compatable devices are found
	/// </summary>
	public class NoDevicesFoundException : FractronException
	{
		public NoDevicesFoundException(string message) : base(message) {}
		public NoDevicesFoundException(string message, Exception innerException) : base(message, innerException){}
	}

	/// <summary>
	/// Thrown for generic fractal engine errors
	/// </summary>
	public class FractalEngineException : FractronException
	{
		/// <summary>
		/// Gets the active device when this exception was thrown, or null if no device was active
		/// </summary>
		public EngineType EngineType{
			get{
				if(Data.Contains("engineType"))
					return (EngineType)Data["engineType"];
				else
					return EngineType.Auto;
			}
		}
		public FractalEngineException(EngineType engineType, string message) : base(message)
		{
			Data.Add("engineType", engineType);
		}
		public FractalEngineException(EngineType engineType, string message, Exception innerException) : base(message, innerException)
		{
			Data.Add("engineType", engineType);
		}
	}

	/// <summary>
	/// Thrown if the engine startup, shutdown, or suspension fails
	/// </summary>
	public class FractalEngineStateException : FractalEngineException
	{
		public FractalEngineState FromState{
			get{
				if(Data.Contains("fromState"))
					return (FractalEngineState)(Data["fromState"]);
				else
					return FractalEngineState.Offline;
			}
		}
		public FractalEngineState ToState{
			get{
				if(Data.Contains("toState"))
					return (FractalEngineState)(Data["toState"]);
				else
					return FractalEngineState.Offline;
			}
		}

		public FractalEngineStateException(EngineType engineType, FractalEngineState fromState, FractalEngineState toState, Exception innerException)
			: base(engineType, "An error has occured in the fractal engine.", innerException)
		{
			this.Data["fromState"] = (object)fromState;
			this.Data["toState"] = (object)toState;
		}
	}
}
