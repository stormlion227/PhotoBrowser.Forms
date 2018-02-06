using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Stormlion.PhotoBrowser.iOS
{
    public class Platform
    {
        public static void Init()
        {
            DependencyService.Register<PhotoBrowserImplementation>();
        }
    }
}
