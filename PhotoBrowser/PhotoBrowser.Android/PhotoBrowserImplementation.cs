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
using Xamarin.Forms.Platform.Android;

namespace Stormlion.PhotoBrowser.Droid
{
    public class PhotoBrowserImplementation : IPhotoBrowser
    {
        protected static ImageViewer _imageViewer;

        public void Show(PhotoBrowser photoBrowser)
        {
            ImageViewer.Builder builder = new ImageViewer.Builder(Platform.Context, photoBrowser.Photos.Select(x => x.URL).ToArray());
            ImageOverlayView overlay = new ImageOverlayView(Platform.Context, photoBrowser);

            
            
            builder.SetBackgroundColor(ColorExtensions.ToAndroid(photoBrowser.BackgroundColor));

            builder.SetOverlayView(overlay);
            builder.SetContainerPaddingPx(photoBrowser.Android_ContainerPaddingPx);

            builder.SetImageChangeListener(overlay);
            builder.SetStartPosition(photoBrowser.StartIndex);
            _imageViewer = builder.Show();
        }

        public void Close()
        {
            if (_imageViewer != null)
            {
                _imageViewer.OnDismiss();
                _imageViewer = null;
            }
        }
    }
}