// (c) Copyright OrangeBit s.c.r.l. http://www.orangebit.it
// OrangeBit.MvvmCross.Plugins.Bitmap is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Sebastian Faltoni, sebastian(at)orangebit.it

using System;
using Cirrious.CrossCore.Plugins;
using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.Binding.Bindings.Target.Construction;

namespace OrangeBit.MvvmCross.Plugins.Bitmap.Droid
{
	public class Plugin
		: IMvxPlugin          
	{
		public void Load()
		{
			Mvx.RegisterSingleton<IMvxBitmapFactory>(new MvxBitmapFactory());
			Mvx.CallbackWhenRegistered<IMvxTargetBindingFactoryRegistry>(RegisterDefaultBindings);
		}
		
		private void RegisterDefaultBindings()
		{
			var helper = new MvxBitmapDefaultBindingSet();
			helper.RegisterBindings();
		}
	}
}

