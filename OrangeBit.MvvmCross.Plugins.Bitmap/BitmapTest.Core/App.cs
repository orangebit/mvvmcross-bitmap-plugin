// (c) Copyright OrangeBit s.c.r.l. http://www.orangebit.it
// OrangeBit.MvvmCross.Plugins.Bitmap is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Sebastian Faltoni, sebastian(at)orangebit.it

using System;
using Cirrious.MvvmCross.ViewModels;
using BitmapTest.Core.ViewModels;

namespace BitmapTest.Core
{
	public class App
		: MvxApplication
	{
		public App()
		{
			RegisterAppStart<TestViewModel>(); 
			
		}
	}
}

