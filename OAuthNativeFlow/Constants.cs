﻿namespace OAuthNativeFlow
{
    public static class Constants
    {
        public static string AppName = "XamarinGoogleLogin";

		// OAuth
		// For Google login, configure at https://console.developers.google.com/
		public static string iOSClientId = "<insert IOS client ID here>";
        //Esta es la clave web --> public static string AndroidClientId = "471013716354-klo2p6i3lu4m87ssp78dfancvrc16mtf.apps.googleusercontent.com";
        public static string AndroidClientId = "471013716354-ot0fg0vv74qg8u9vhcnutv266cr752ct.apps.googleusercontent.com";

        // These values do not need changing
        public static string Scope = "https://www.googleapis.com/auth/userinfo.email";
		public static string AuthorizeUrl = "https://accounts.google.com/o/oauth2/auth";
		public static string AccessTokenUrl = "https://www.googleapis.com/oauth2/v4/token";
		public static string UserInfoUrl = "https://www.googleapis.com/oauth2/v2/userinfo";

		// Set these to reversed iOS/Android client ids, with :/oauth2redirect appended
		public static string iOSRedirectUrl = "<insert IOS redirect URL here>:/oauth2redirect";
        public static string AndroidRedirectUrl = "com.googleusercontent.apps.471013716354-ot0fg0vv74qg8u9vhcnutv266cr752ct:/oauth2redirect";
    }
}
