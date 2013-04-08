// (c) Copyright OrangeBit s.c.r.l. http://www.orangebit.it
// OrangeBit.MvvmCross.Plugins.Bitmap is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Sebastian Faltoni, sebastian(at)orangebit.it

using System;
using Cirrious.CrossCore.Plugins;
using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.Binding.Binders;

namespace OrangeBit.MvvmCross.Plugins.Bitmap
{
	public class PluginLoader
		: IMvxPluginLoader
	{
		public static readonly PluginLoader Instance = new PluginLoader();
		
		public void EnsureLoaded()
		{
			var manager = Mvx.Resolve<IMvxPluginManager>();
			manager.EnsurePlatformAdaptionLoaded<PluginLoader>();
			
			Mvx.CallbackWhenRegistered<IMvxValueConverterRegistry>(RegisterValueConverters);
		}
		
		private void RegisterValueConverters()
		{
			var registry = Mvx.Resolve<IMvxValueConverterRegistry>();
			registry.Fill(this.GetType().Assembly);
		}
	}
}

