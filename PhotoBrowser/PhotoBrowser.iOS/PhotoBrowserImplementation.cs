using Ricardo.LibMWPhotoBrowser.iOS;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace Stormlion.PhotoBrowser.iOS
{
    public class PhotoBrowserImplementation : IPhotoBrowser
    {
        public void Show(PhotoBrowser photoBrowser)
        {
            new MyMWPhotoBrower(photoBrowser).Show();
        }
    }
}
