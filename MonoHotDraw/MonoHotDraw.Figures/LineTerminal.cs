// MonoHotDraw. Diagramming Framework
//
// Authors:
//	Manuel Cerón <ceronman@gmail.com>
//	Mario Carrión <mario@monouml.org>
//
// Copyright (C) 2006, 2007, 2008, 2009 MonoUML Team (http://www.monouml.org)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
using Cairo;
using System;
using System.Runtime.Serialization;
using MonoHotDraw.Commands;
using MonoHotDraw.Util;

namespace MonoHotDraw.Figures
{
	[Serializable]
	public abstract class LineTerminal : ICloneable, ISerializable
	{
		protected LineTerminal ()
		{
		}
		
		protected LineTerminal (SerializationInfo info, StreamingContext context)
		{
		}
		
		#region Public Api
		public abstract PointD Draw (Context context, PointD a, PointD b);
		
		public virtual RectangleD InvalidateRect (PointD b)
		{
			var r = new RectangleD (b.X, b.Y, 0.0, 0.0);
			r.Inflate (15.0, 15.0);
			
			return r;
		}
		#endregion

		#region ICloneable
		public virtual object Clone ()
		{
			return GenericCloner.Clone <LineTerminal> (this);
		}		
		#endregion
		
		#region ISerializable
		public virtual void GetObjectData (SerializationInfo info, StreamingContext context)
		{
		}
		#endregion		
	}
}
