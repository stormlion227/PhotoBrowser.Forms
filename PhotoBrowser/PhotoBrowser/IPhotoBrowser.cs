using System;
using System.Collections.Generic;
using System.Text;

namespace Stormlion.PhotoBrowser
{
    public interface IPhotoBrowser
    {
        void Show(PhotoBrowser photoBrowser);

        void Close();
    }
}
