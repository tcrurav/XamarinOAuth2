﻿using Android.App;
using Android.Content.PM;
using Android.OS;

namespace OAuthNativeFlow.Droid
{
    [Activity(Label = "OAuthNativeFlow.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
			global::Xamarin.Auth.Presenters.XamarinAndroid.AuthenticationConfiguration.Init(this, bundle);

            //Lo tuve que meter yo
            global::Xamarin.Auth.CustomTabsConfiguration.CustomTabsClosingMessage = null;

            LoadApplication(new App());
        }
    }
}
