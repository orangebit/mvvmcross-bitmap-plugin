// (c) Copyright OrangeBit s.c.r.l. http://www.orangebit.it
// OrangeBit.MvvmCross.Plugins.Bitmap is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Sebastian Faltoni, sebastian(at)orangebit.it

using System;
using Cirrious.MvvmCross.Binding.Droid.Target;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.Binding;

namespace OrangeBit.MvvmCross.Plugins.Bitmap.Droid
{
	public class MvxBitmapBinding : MvxAndroidTargetBinding
	{
		protected ImageView ImageView
		{
			get { return (ImageView) base.Target; }
		}
		
		public  MvxBitmapBinding(ImageView view)
			: base(view)
		{
	
		}
		
		public override MvxBindingMode DefaultMode
		{
			get { return MvxBindingMode.OneWay; }
		}
		
		public override Type TargetType
		{
			get { return typeof (Android.Graphics.Bitmap); }
		}

		public override void SetValue(object value)
		{
			var imageView = this.ImageView;
			if (imageView == null)
				return;
			imageView.SetImageBitmap((Android.Graphics.Bitmap)value);
		}
	}
}

