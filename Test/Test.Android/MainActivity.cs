using Android.App;
using Android.Content.PM;
using Android.OS;
using System;

namespace Test.Droid
{
    [Activity(Label = "Test", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            Stormlion.PhotoBrowser.Droid.Platform.Init(this);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            try
            {
                LoadApplication(new App());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
    }
}
