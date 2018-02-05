using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Stormlion.PhotoBrowser
{
    public class PhotoBrowser
    {
        public List<string> Images { get; set; }

        public void Show()
        {
            DependencyService.Get<IPhotoBrowser>().Show(this);
        }
    }
}
