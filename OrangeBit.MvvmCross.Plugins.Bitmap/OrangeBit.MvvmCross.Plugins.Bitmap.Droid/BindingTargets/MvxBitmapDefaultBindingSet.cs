// (c) Copyright OrangeBit s.c.r.l. http://www.orangebit.it
// OrangeBit.MvvmCross.Plugins.Bitmap is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Sebastian Faltoni, sebastian(at)orangebit.it

using System;
using Cirrious.MvvmCross.Binding.Bindings.Target.Construction;
using Cirrious.CrossCore.Platform;
using Cirrious.CrossCore.IoC;
using Android.Widget;

namespace OrangeBit.MvvmCross.Plugins.Bitmap.Droid
{
 
	public class MvxBitmapDefaultBindingSet
	{
		public void RegisterBindings()
		{
			IMvxTargetBindingFactoryRegistry registry;
			if (!Mvx.TryResolve(out registry))
			{
				MvxTrace.Warning(
					"No binding registry available - so bitmap bindings will not be used");
				return;
			}
			
 
			registry.RegisterFactory(new MvxCustomBindingFactory<ImageView>("ImageSource",
			                                                               textView =>
			                                                               new MvxBitmapBinding(textView)));
		}
	}
}

