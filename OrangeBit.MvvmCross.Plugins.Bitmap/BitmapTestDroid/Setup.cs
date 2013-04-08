// (c) Copyright OrangeBit s.c.r.l. http://www.orangebit.it
// OrangeBit.MvvmCross.Plugins.Bitmap is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Sebastian Faltoni, sebastian(at)orangebit.it

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using BitmapTest.Core;
using BitmapTest.Core.Converters;

namespace BitmapTest.Droid
{
    public class Setup
          : MvxAndroidSetup
    {
        public Setup(Context applicationContext)
            : base(applicationContext)
        {
            
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

	 
		protected override List<System.Reflection.Assembly> ValueConverterAssemblies {
			get {
				var lst = base.ValueConverterAssemblies;
				lst.Add (typeof(BitmapSampleConverter).Assembly);
				return lst;
			}
		}

        protected override IMvxNavigationSerializer CreateNavigationSerializer()
        {
            Cirrious.MvvmCross.Plugins.Json.PluginLoader.Instance.EnsureLoaded(); 
			OrangeBit.MvvmCross.Plugins.Bitmap.PluginLoader.Instance.EnsureLoaded ();
            return new MvxJsonNavigationSerializer();
        }
    }
}