// 
// ProjectFileNodeBuilderExtension.cs
//  
// Author:
//       Evan <erbriones@gmail.com>
// 
// Copyright (c) 2010 Evan
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

using System;
using MonoDevelop.Ide.Gui.Components;
using MonoDevelop.Ide.Gui.Pads.ClassPad;
using MonoDevelop.Ide.Gui.Pads.ProjectPad;
using MonoDevelop.Projects;

namespace MonoDevelop.ClassDesigner.Extensions
{
	class GenericNodeBuilderExtension : NodeBuilderExtension
	{
		public override bool CanBuildNode (Type dataType)
		{
			if (typeof (Project).IsAssignableFrom (dataType))
				return true;
			else if (typeof (ProjectFolder).IsAssignableFrom (dataType))
				return true;
			else if (typeof (ProjectFile).IsAssignableFrom (dataType))
				return true;
			else if (typeof (NamespaceData).IsAssignableFrom (dataType))
				return true;
			else if (typeof (ClassData).IsAssignableFrom (dataType))
				return true;
			else
				return false;
		}
		
		public override Type CommandHandlerType {
			get { return typeof (GenericNodeCommandHandler); }
		}
	}
}
