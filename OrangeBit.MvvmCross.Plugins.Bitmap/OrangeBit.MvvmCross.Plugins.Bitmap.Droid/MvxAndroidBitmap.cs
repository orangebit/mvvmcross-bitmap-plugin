// (c) Copyright OrangeBit s.c.r.l. http://www.orangebit.it
// OrangeBit.MvvmCross.Plugins.Bitmap is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Sebastian Faltoni, sebastian(at)orangebit.it

using System;
using Android.Graphics;
using System.Reflection;

namespace OrangeBit.MvvmCross.Plugins.Bitmap.Droid
{
	public class MvxAndroidBitmap : IMvxBitmap
	{
		private  Android.Graphics.Bitmap bitmap = null;

		public MvxAndroidBitmap ()
		{
		
		}

		#region IMvxBitmap implementation

		public void SetSource (byte[] bytes)
		{
			bitmap = BitmapFactory.DecodeByteArray(bytes, 0, bytes.Length);
		}

		public void LoadFromResource(string assemblyName,string resourceName)
		{
			var strm = Assembly.Load (new AssemblyName(assemblyName)).GetManifestResourceStream(resourceName);

			bitmap = BitmapFactory.DecodeStream (strm);
		}

		public int Height
		{
			get{
				return bitmap.Height;
			}
		}

		public int Width
		{
			get{
				return bitmap.Width;
			}
		}


		public object ToNative ()
		{
			if(bitmap == null)
				throw new NullReferenceException("You can't get native version of an empty IMvxBitmap, set a valid source and try again");

			return bitmap;
		}

		#endregion


	}
}

