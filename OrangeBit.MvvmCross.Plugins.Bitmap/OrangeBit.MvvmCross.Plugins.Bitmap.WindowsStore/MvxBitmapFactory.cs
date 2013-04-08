// (c) Copyright OrangeBit s.c.r.l. http://www.orangebit.it
// OrangeBit.MvvmCross.Plugins.Bitmap is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Sebastian Faltoni, sebastian(at)orangebit.it

using System;
using OrangeBit.MvvmCross.Plugins.Bitmap;

namespace OrangeBit.MvvmCross.Plugins.Bitmap.WindowsStore
{
	public class MvxBitmapFactory: IMvxBitmapFactory
	{ 
		public IMvxBitmap Create()
		{
			return new MvxWindowsStoreBitmap();
		}

	}
}

