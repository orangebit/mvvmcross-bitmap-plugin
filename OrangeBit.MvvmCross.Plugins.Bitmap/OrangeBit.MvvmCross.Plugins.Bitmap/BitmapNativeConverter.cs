// (c) Copyright OrangeBit s.c.r.l. http://www.orangebit.it
// OrangeBit.MvvmCross.Plugins.Bitmap is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Sebastian Faltoni, sebastian(at)orangebit.it

using System;
using Cirrious.CrossCore.Converters;

namespace OrangeBit.MvvmCross.Plugins.Bitmap
{
	public class BitmapNativeConverter : MvxValueConverter<IMvxBitmap>
	{
	 	protected override System.Object Convert (IMvxBitmap value, System.Type targetType, System.Object parameter, System.Globalization.CultureInfo culture)
		{
			return value.ToNative ();
		}
	}
}

