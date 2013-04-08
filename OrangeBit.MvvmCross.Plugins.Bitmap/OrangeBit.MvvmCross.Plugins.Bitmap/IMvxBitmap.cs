// (c) Copyright OrangeBit s.c.r.l. http://www.orangebit.it
// OrangeBit.MvvmCross.Plugins.Bitmap is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Sebastian Faltoni, sebastian(at)orangebit.it

using System;

namespace OrangeBit.MvvmCross.Plugins.Bitmap
{
	public interface IMvxBitmap
	{
		void SetSource(byte[] bytes);

		void LoadFromResource(string assemblyName,string resourceName);

		int Height { get; }
		int Width { get;}

		object ToNative();
	}
}

