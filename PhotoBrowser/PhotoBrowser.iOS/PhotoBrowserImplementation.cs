using Ricardo.LibMWPhotoBrowser.iOS;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace Stormlion.PhotoBrowser.iOS
{
    public class PhotoBrowserImplementation : IPhotoBrowser
    {
        protected static MyMWPhotoBrower _mainBrowser;

        public void Show(PhotoBrowser photoBrowser)
        {
            _mainBrowser = new MyMWPhotoBrower(photoBrowser);
            _mainBrowser.Show();
        }

        public void Close()
        {
            if(_mainBrowser != null)
            {
                _mainBrowser.Close();
                _mainBrowser = null;
            }
        }
    }
}
