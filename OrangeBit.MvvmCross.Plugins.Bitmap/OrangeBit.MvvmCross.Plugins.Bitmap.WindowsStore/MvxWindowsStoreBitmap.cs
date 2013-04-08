// (c) Copyright OrangeBit s.c.r.l. http://www.orangebit.it
// OrangeBit.MvvmCross.Plugins.Bitmap is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Sebastian Faltoni, sebastian(at)orangebit.it

using System;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Reflection;
using Windows.ApplicationModel;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml;

namespace OrangeBit.MvvmCross.Plugins.Bitmap.WindowsStore
{
    public class MvxWindowsStoreBitmap : IMvxBitmap
    {
        private BitmapImage bitmap = null;

        public MvxWindowsStoreBitmap()
        {

        }

        #region IMvxBitmap implementation

        public void SetSource(byte[] bytes)
        {
            var ms = new InMemoryRandomAccessStream();
            ms.WriteAsync(bytes.AsBuffer());
            ms.FlushAsync().AsTask().Wait();
            ms.Seek(0);
            bitmap = new BitmapImage();
            bitmap.SetSource(ms);
        }

        public void LoadFromResource(string assemblyName, MvxResourcePath resourceName)
        {
            //Package.Current.InstalledLocation.GetFileAsync()
            var path = resourceName.GetResourcePath(".", true);
            //   bitmap = new BitmapImage(new Uri("ms-appx:///" + assemblyName + "/" + path, UriKind.RelativeOrAbsolute));
            var strm = Assembly.Load(new AssemblyName(assemblyName)).GetManifestResourceStream(path);
            byte[] bts = new byte[strm.Length];
            strm.Read(bts, 0, (int)strm.Length);
            InMemoryRandomAccessStream ras = new InMemoryRandomAccessStream();

            ras.GetOutputStreamAt(0).WriteAsync(bts.AsBuffer());
            //strm.CopyToAsync(ras.AsStreamForWrite()).Wait();

            ras.Seek(0);
            bitmap = new BitmapImage();
            bitmap.SetSource(ras);
            ras.Dispose();
            strm.Dispose();
        }

        public int Height
        {
            get { return bitmap.PixelHeight; }
        }

        public int Width
        {
            get
            {
                return bitmap.PixelWidth;
            }
        }


        public object ToNative()
        {
            if (bitmap == null)
                throw new NullReferenceException("You can't get native version of an empty IMvxBitmap, set a valid source and try again");

            return bitmap;
        }

        #endregion


    }
}

