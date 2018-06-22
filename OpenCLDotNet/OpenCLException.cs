﻿#region License
/*
    OpenCLDotNet - Compatability layer between OpenCL and the .NET framework
    Copyright (C) 2010 Michael J. Thiesen
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
namespace OpenCL
{
	public class OpenCLException : System.Exception
	{
		public OpenCLException(string message)
			: base(message){}
	}

	public class OpenCLBufferSizeException : OpenCLException
	{
		public OpenCLBufferSizeException(string message)
			: base(message){}
	}

	public class OpenCLCallFailedException : OpenCLException
	{
		private ErrorCode errorCode;
		
		public ErrorCode ErrorCode{
			get{ return errorCode; }
		}

		public OpenCLCallFailedException(ErrorCode errorCode)
			: base("An OpenCL call failed: " + Enum.GetName(typeof(ErrorCode), (object)errorCode))
		{
			this.Data.Add("ErrorCode", errorCode);
			this.errorCode = errorCode;
		}
	}
}