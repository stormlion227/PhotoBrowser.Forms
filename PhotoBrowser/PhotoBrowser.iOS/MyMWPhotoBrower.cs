using Ricardo.LibMWPhotoBrowser.iOS;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace Stormlion.PhotoBrowser.iOS
{
    public class MyMWPhotoBrower : MWPhotoBrowserDelegate
    {
        protected PhotoBrowser _photoBrowser;

        protected List<MWPhoto> _photos = new List<MWPhoto>();

        public MyMWPhotoBrower(PhotoBrowser photoBrowser)
        {
            _photoBrowser = photoBrowser;
        }

        public void Show()
        {
            _photos = new List<MWPhoto>();

            foreach (Photo p in _photoBrowser.Photos)
            {
                MWPhoto mp = MWPhoto.FromUrl(new Foundation.NSUrl(p.URL));
                mp.Caption = p.Title;

                _photos.Add(mp);
            }

            MWPhotoBrowser browser = new MWPhotoBrowser(this);

            browser.AlwaysShowControls = true;

            UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(new UINavigationController(browser), true, null);
        }

        public override MWPhoto GetPhoto(MWPhotoBrowser photoBrowser, nuint index) => _photos[(int)index];

        public override nuint NumberOfPhotosInPhotoBrowser(MWPhotoBrowser photoBrowser) => (nuint)_photos.Count;

        public override void OnActionButtonPressed(MWPhotoBrowser photoBrowser, nuint index)
        {
            _photoBrowser.ActionButtonPressed?.Invoke((int)index);
        }
    }
}
