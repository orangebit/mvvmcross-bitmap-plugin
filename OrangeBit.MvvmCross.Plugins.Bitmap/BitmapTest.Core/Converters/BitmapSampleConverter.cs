// (c) Copyright OrangeBit s.c.r.l. http://www.orangebit.it
// OrangeBit.MvvmCross.Plugins.Bitmap is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Sebastian Faltoni, sebastian(at)orangebit.it

using System;
using Cirrious.CrossCore.Converters;
using Cirrious.CrossCore.IoC;
using OrangeBit.MvvmCross.Plugins.Bitmap;
using Cirrious.MvvmCross.Plugins.File;

namespace BitmapTest.Core.Converters
{
	public class BitmapSampleConverter : MvxValueConverter
	{
		public override System.Object Convert (System.Object value, System.Type targetType, System.Object parameter, System.Globalization.CultureInfo culture)
		{
			if (value.ToString () == "MyValue") {
				IMvxBitmapFactory factory = Mvx.Resolve<IMvxBitmapFactory>();
				IMvxBitmap bitmap = factory.Create();

				bitmap.LoadFromResource("BitmapTest.Core","BitmapTest.Core.Assets.droid.jpeg");
				return bitmap.ToNative();
			}
			else
				return null;
		}
	}
}

