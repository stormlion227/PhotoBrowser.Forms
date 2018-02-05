using Com.Stfalcon.Frescoimageviewer;
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

namespace Stormlion.PhotoBrowser.Droid
{
    public class PhotoBrowserImplementation : IPhotoBrowser
    {
        public void Show(PhotoBrowser photoBrowser)
        {
            new ImageViewer.Builder(Platform.Context, photoBrowser.Images).Show();
        }
    }
}