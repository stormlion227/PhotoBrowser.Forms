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
using Com.Stfalcon.Frescoimageviewer;
using static Android.Views.View;

namespace Stormlion.PhotoBrowser.Droid
{
    public class ImageOverlayView : RelativeLayout, ImageViewer.IOnImageChangeListener
    {
        protected TextView tvDescription;

        protected ImageButton btnAction;

        protected PhotoBrowser _photoBrowser;

        protected int _currentIndex = 0;

        public ImageOverlayView(Context context, PhotoBrowser photoBrowser) : base(context)
        {
            _photoBrowser = photoBrowser;
            init();
        }

        protected void init()
        {
            View view = Inflate(Context, Resource.Layout.photo_browser_overlay, this);
            tvDescription = view.FindViewById<TextView>(Resource.Id.tvDescription);
            btnAction = view.FindViewById<ImageButton>(Resource.Id.btnShare);

            if(_photoBrowser.ActionButtonPressed != null)
            {
                btnAction.Click += (o, e) =>
                {
                    _photoBrowser.ActionButtonPressed?.Invoke(_currentIndex);
                };
            }
            else
            {
                btnAction.Visibility = ViewStates.Gone;
            }
        }

        public void OnImageChange(int p0)
        {
            tvDescription.Text = _photoBrowser.Photos[p0].Title;
            _currentIndex = p0;

            _photoBrowser.DidDisplayPhoto?.Invoke(p0);

        }
    }
}