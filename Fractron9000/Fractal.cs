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
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;

using MTUtil;

namespace Fractron9000
{
	public class Fractal
	{
		public string Name = null;
		public string Version = null;

		public Affine2D CameraTransform; //The inverse of a view transform
		public float Brightness = 1.0f;
		public float Gamma = 2.0f;
		public float Vibrancy = 1.0f;
		public Vec4 BackgroundColor = new Vec4(0,0,0,1);
		public List<Branch> Branches;
		private Palette palette = null;

		public XmlNode OriginalXml = null;

		public Palette Palette{
			get{ return palette != null ? palette : Palette.DefaultPalette; }
			set{ palette = value; }
		}

		public Fractal()
		{
			CameraTransform = new Affine2D(2.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f);
			Branches = new List<Branch>();
		}

		public Fractal(Fractal src)
		{
			this.Name = src.Name;
			this.Version = src.Version;

			this.CameraTransform = src.CameraTransform;
			this.Brightness = src.Brightness;
			this.Gamma = src.Gamma;
			this.Vibrancy = src.Vibrancy;
			this.BackgroundColor = src.BackgroundColor;

			this.Branches = new List<Branch>();
			foreach(Branch branch in src.Branches)
				Branches.Add(new Branch(branch));

			this.palette = src.Palette;
			this.OriginalXml = src.OriginalXml;
		}

		public void StripUnknownAttrs()
		{
			this.OriginalXml = null;
		}

		//invents some size/scale stuff that some renderers need based on the current camera
		public void GetFlameFromCamera(
			out int xSize, out int ySize,
			out float xCenter, out float yCenter,
			out float scale, out float zoom, out float rotate)
		{
			xSize = 800;
			ySize = 600;
			xCenter = CameraTransform.Translation.X;
			yCenter = CameraTransform.Translation.Y;
			float minSize = (float)Math.Min(xSize,ySize);
			float camSpan = CameraTransform.XAxis.Length * 2.0f;
			if(camSpan == 0.0f)
				scale = 1.0f;
			else
				scale = minSize / camSpan;
			zoom = 0.0f;

			double theta = Math.Atan2(CameraTransform.XAxis.Y, CameraTransform.XAxis.X);
			rotate = (float)(theta * 180.0 / Math.PI);
		}

		public void SetCameraFromFlame(float xSize, float ySize,
			float xCenter, float yCenter,
			float scale, float zoom, float rotate)
		{
			float minSize = (float)Math.Min(xSize,ySize);
			if(scale <= 0.0f)
				scale = 1.0f;
			float camSpan = minSize / scale;
			float camScale = (camSpan/2.0f) * (float)Math.Pow(0.5f, zoom);

			double theta = (double)rotate * Math.PI / 180.0;

			float xx = (float)Math.Cos(theta) * camScale;
			float xy = (float)Math.Sin(theta) * camScale;

			CameraTransform.XAxis = new Vec2(xx,xy);
			CameraTransform.YAxis = new Vec2(-xy,xx);
			CameraTransform.Translation = new Vec2(xCenter, yCenter);
		}

		public static Fractal BuildDefault()
		{
			Fractal result = new Fractal();
			result.Name = "New Fractal";

			Branch br;
			br = new Branch();
			br.Transform = new Affine2D( 0.5f,  0.0f,  0.0f,  0.5f,  0.433f, -0.25f );
			br.Chroma = new Vec2(1.0f,  0.5f);
			result.Branches.Add(br);

			br = new Branch();
			br.Transform = new Affine2D( 0.5f,  0.0f,  0.0f,  0.5f, -0.433f, -0.25f );
			br.Chroma = new Vec2(0.25f, 0.9f );
			result.Branches.Add(br);

			br = new Branch();
			br.Transform = new Affine2D( 0.5f,  0.0f,  0.0f,  0.5f,  0.0f,  0.5f );
			br.Chroma = new Vec2(0.25f, 0.1f );
			result.Branches.Add(br);

			return result;
		}

		public static void GetNativeFractalSizes(out int nFractalSize, out int nBranchesSize, out int nVariWeightsSize)
		{
			nFractalSize = Marshal.SizeOf(typeof(NativeFractal));
			nBranchesSize = Marshal.SizeOf(typeof(NativeBranch)) * NativeFractal.MaxBranches;
			nVariWeightsSize = Marshal.SizeOf(typeof(float)) * NativeFractal.MaxBranches * NativeFractal.MaxVariations;
		}

		unsafe public void FillNativeFractal(int xRes, int yRes, NativeFractal* nFractal, NativeBranch* nBranches, float* nVariWeights)
		{
			Int32 branchCount = Math.Min(NativeFractal.MaxBranches, this.Branches.Count);
			
			nFractal->BranchCount = (uint)branchCount;

			float invAspectRatio = (xRes > 0) ? ((float)yRes / (float)xRes) : 0.0f;
			Affine2D viewTransform = this.CameraTransform.Inverse;
			Affine2D projTransform = new Affine2D(invAspectRatio, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f);
			float xHalf = (float)xRes / 2.0f;
			float yHalf = (float)yRes / 2.0f;

			Affine2D screenTransform = new Affine2D(xHalf, 0.0f, 0.0f, yHalf, xHalf, yHalf);

			nFractal->VpsTransform = screenTransform * projTransform * viewTransform;
			nFractal->Brightness = this.Brightness;
			nFractal->InvGamma = 1.0f / this.Gamma;
			nFractal->Vibrancy = this.Vibrancy;
			nFractal->BgColor = this.BackgroundColor;
		
			for(int bi = 0; bi < branchCount; bi++)
				nBranches[bi].NormWeight = (UInt32)0x00010000;

			float branchWeightSum = 0.0f;
			for(int bi = 0; bi < branchCount; bi++)
				branchWeightSum += this.Branches[bi].Weight;
			
			for(int i = 0; i < NativeFractal.MaxBranches*NativeFractal.MaxVariations; i++)
				nVariWeights[i] = 0.0f;

			UInt32 runningSum = 0;
			for(int bi = 0; bi < branchCount; bi++)
			{
				Branch branch = this.Branches[bi];

				runningSum += (UInt32)(branch.Weight / branchWeightSum * 65536.0f);
				if(bi < branchCount-1)
					nBranches[bi].NormWeight = runningSum;
				else
					nBranches[bi].NormWeight = 0x00010000;

				nBranches[bi].ColorWeight =   branch.ColorWeight;
				nBranches[bi].Chroma =        branch.Chroma;
				nBranches[bi].PreTransform =  branch.PreTransform;
				nBranches[bi].PostTransform = branch.PostTransform;
	
				foreach(Branch.VariEntry ve in branch.Variations)
					if(ve.Index >= 0 && ve.Index < NativeFractal.MaxVariations)
						nVariWeights[bi*NativeFractal.MaxVariations + ve.Index] += ve.Weight;
			}
		}

		/// <summary>
		/// Converts this fractal into a format that can be easily passed to the GPU
		/// </summary>
		public void GetNativeFractal(int xRes, int yRes, out NativeFractal nFractal, out NativeBranch[] nBranches, out float[] nVariWeights)
		{
			nFractal = new NativeFractal();
			nBranches = new NativeBranch[NativeFractal.MaxBranches];
			nVariWeights = new float[NativeFractal.MaxBranches * NativeFractal.MaxVariations];
			unsafe{
				fixed(NativeFractal* p_fractal = &nFractal){
					fixed(NativeBranch* p_branches = nBranches){
						fixed(float* p_variWeights = nVariWeights){
							FillNativeFractal(xRes, yRes, p_fractal, p_branches, p_variWeights);
						}
					}
				}
			}		
		}

	}

	public class Branch
	{
		public Affine2D Transform;
		public bool Localized;
		public Vec2 Chroma;
		public float Weight;
		public float ColorWeight;

		private List<VariEntry> variations;
		public IList<VariEntry> Variations{
			get{ return variations; }
		}

		public Affine2D PreTransform{
			get{
				if(Localized)
					return Transform.Inverse;
				else
					return Transform;
			}
		}
		
		public Affine2D PostTransform{
			get{
				if(Localized)
					return Transform;
				else
					return Affine2D.Identity;
			}
		}

		public Branch()
		{
			Transform = new Affine2D(0.5f,0.0f,0.0f,0.5f,0.0f,0.0f);
			Localized = false;
			Chroma = new Vec2(0.5f,0.5f);
			Weight = 1.0f;
			ColorWeight = 0.5f;
			variations = new List<VariEntry>();
			variations.Add(new VariEntry(0, 1.0f));
		}

		public Branch(Branch src)
		{
			Transform = src.Transform;
			Localized = src.Localized;
			Chroma = src.Chroma;
			Weight = src.Weight;
			ColorWeight = src.ColorWeight;
			variations = new List<VariEntry>();
			foreach(VariEntry v in src.Variations)
				variations.Add(v);
		}
		
		public Color GetChromaColor(Palette palette)
		{
			if(palette == null)
				return Color.Black;
			return palette.Sample(Chroma.X, Chroma.Y);
		}

		public struct VariEntry
		{
			public int Index;
			public float Weight;

			public VariEntry(int index, float weight){
				this.Index = index;
				this.Weight = weight;
			}
		}
	}
}
