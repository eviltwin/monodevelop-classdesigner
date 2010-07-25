// 
// DelegateFigure.cs
//  
// Author:
//       Evan Briones <erbriones@gmail.com>
// 
// Copyright (c) 2010 Evan Briones
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

using Gtk;
using System;
using System.Collections.Generic;
using System.Linq;
//using MonoDevelop.Core;

using MonoDevelop.Ide;
using MonoDevelop.Projects;
using MonoDevelop.Projects.Dom;
using MonoDevelop.Projects.Dom.Parser;

using MonoHotDraw.Figures;

namespace MonoDevelop.ClassDesigner.Figures
{
	public sealed class DelegateFigure : TypeFigure
	{
		public DelegateFigure (IType domType) : base (domType)
		{
			FillColor = new Cairo.Color (0.8, 0.1, 0.8, 0.4);
		}
		
		protected override ClassType ClassType {
			get { return ClassType.Delegate; }
		}
		
		/*
		public override void UpdateGroups ()
		{				
			var parameters = new List<TypeMemberFigure> ();
			var compartment = Compartments
				.Where (c => c.Name == "Parameters")
				.SingleOrDefault ();
			
			var invoke = Name.Methods.Where (m => m.Name == "Invoke").SingleOrDefault ();
			
			if (invoke == null)
				return;
			
			parameters.AddRange (compartment.Figures.OfType<TypeMemberFigure> ());
			 
			if (parameters.Count () == 0)
			{
				foreach (var p in invoke.Parameters) {
					var icon = ImageService.GetPixbuf (p.StockIcon, IconSize.Menu);
					parameters.Add ((IFigure) new TypeMemberFigure (icon, p, false));
				}
			}
			
			// FIXME: How does grouping change in vs.net class diagram?
			if (grouping == GroupingSetting.Alphabetical)
				compartment.AddRange (parameters.OrderBy (p => p.Name));
			else if (grouping == GroupingSetting.Kind)
				compartment.AddRange (parameters);
			else
				compartment.AddRange (parameters);
			
			compartment.AddRange (parameters);
			AddMemberGroup (compartment);
		}
		*/
	}
}