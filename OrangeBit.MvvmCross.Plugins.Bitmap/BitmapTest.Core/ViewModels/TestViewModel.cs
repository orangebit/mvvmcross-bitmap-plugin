// (c) Copyright OrangeBit s.c.r.l. http://www.orangebit.it
// OrangeBit.MvvmCross.Plugins.Bitmap is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Sebastian Faltoni, sebastian(at)orangebit.it

using System;
using Cirrious.MvvmCross.ViewModels;
using OrangeBit.MvvmCross.Plugins.Bitmap;
using Cirrious.CrossCore.IoC;

namespace BitmapTest.Core.ViewModels
{
	public class TestViewModel : MvxViewModel
	{
		public TestViewModel ()
		{
			this.ConverterScenario ="MyValue";

			IMvxBitmapFactory factory = Mvx.Resolve<IMvxBitmapFactory>();
			IMvxBitmap bitmap = factory.Create();
			bitmap.LoadFromResource("BitmapTest.Core","BitmapTest.Core.Assets.droidking.jpeg");

			this.PropertyScenario = bitmap;
		}



		private string _converterScenario;


		public string ConverterScenario
		{
			get{
				return _converterScenario;
			}
			set{
				_converterScenario = value;
				this.RaisePropertyChanged (() => this.ConverterScenario);
			}
		}

		private IMvxBitmap _propertyScenario=null;
		public IMvxBitmap PropertyScenario
		{
			get{
				return _propertyScenario;
			}
			set{
				_propertyScenario = value;
				this.RaisePropertyChanged (()=> this.PropertyScenario);
			}
		}
	}
}

