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
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

using OpenTK.Graphics.OpenGL;

namespace Fractron9000
{
	abstract public class DeviceEntry
	{
		abstract public string Name{
			get;
		}

		abstract public string Api{
			get;
		}

		abstract public EngineType EngineType{
			get;
		}

		abstract public uint ID{
			get;
		}

		abstract public float PerformanceRating{
			get;
		}

		abstract public FractalEngine CreateFractalEngine(OpenTK.Graphics.IGraphicsContext graphicsContext);

		abstract public IEnumerable<KeyValuePair<string,object>> GetDeviceInfo();

		public override string ToString()
		{
			return string.Format("({0}) {1}", Api, Name.Trim());
		}

		public string GetReport()
		{
			System.IO.StringWriter text = new System.IO.StringWriter();
			text.WriteLine("[{0} Device: {1}]", Api, Name);
			text.WriteLine("  {0}: {1:f1}", "Performance Rating", PerformanceRating);
			foreach(var kv in GetDeviceInfo())
			{
				text.WriteLine("  {0}: {1}", kv.Key, kv.Value.ToString());
			}
			return text.ToString();
		}
	}
}
