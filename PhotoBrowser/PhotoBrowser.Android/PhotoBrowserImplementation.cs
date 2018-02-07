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
            ImageViewer.Builder builder = new ImageViewer.Builder(Platform.Context, photoBrowser.Photos.Select(x => x.URL).ToArray());
            ImageOverlayView overlay = new ImageOverlayView(Platform.Context, photoBrowser);
            builder.SetOverlayView(overlay);
            builder.SetImageChangeListener(overlay);
            builder.SetStartPosition(photoBrowser.StartIndex);
            builder.Show();
        }
    }
}