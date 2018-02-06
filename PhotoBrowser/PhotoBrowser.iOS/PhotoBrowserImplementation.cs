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
            List<MWPhoto> photos = new List<MWPhoto>();

            foreach(string imageUrl in photoBrowser.Images)
            {
                photos.Add(MWPhoto.FromUrl(new Foundation.NSUrl(imageUrl)));
            }

            MWPhotoBrowser browser = new MWPhotoBrowser(photos.ToArray());

            UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(new UINavigationController(browser), true, null);
        }
    }
}
