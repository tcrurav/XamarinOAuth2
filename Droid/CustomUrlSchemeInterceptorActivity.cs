using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace OAuthNativeFlow.Droid
{
	[Activity(Label = "CustomUrlSchemeInterceptorActivity", NoHistory = true, LaunchMode = LaunchMode.SingleTop)]
	[IntentFilter(
		new[] { Intent.ActionView },
		Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable },
		DataSchemes = new[] { "com.googleusercontent.apps.471013716354-ot0fg0vv74qg8u9vhcnutv266cr752ct" },
		DataPath = "/oauth2redirect")]
	public class CustomUrlSchemeInterceptorActivity : Activity
	{
        //DataSchemes = new[] { "com.googleusercontent.apps.863494635082-a617p00qkuafejrf3k7hq8s346l0u36h" },
        protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Convert Android.Net.Url to Uri
			var uri = new Uri(Intent.Data.ToString());
            Console.WriteLine("tiburcio: Intent.Data.ToString(): " + Intent.Data.ToString());

			// Load redirectUrl page
			AuthenticationState.Authenticator.OnPageLoading(uri);

            //3 líneas que tuve que meter yo
            var intent = new Intent(this, typeof(MainActivity));
            intent.SetFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
            StartActivity(intent);

            Finish();
		}
	}
}
