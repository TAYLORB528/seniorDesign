using System;
using Xamarin.Essentials;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Auth0.OidcClient;
[assembly: Xamarin.Forms.Dependency(typeof(Choosr.Droid.MainActivity))]
namespace Choosr.Droid
{
    [Activity(Label = "Choosr", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize, LaunchMode = LaunchMode.SingleTask)]
    [IntentFilter(
        new[] { Intent.ActionView },
        Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable },
        DataScheme = "com.itcruisers.choosr",
        DataHost = "dev-49e0jdf0.us.auth0.com",
        DataPathPrefix = "/android/com.itcruisers.choosr/callback")]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        protected override async void OnNewIntent(Intent intent)
        {
            base.OnNewIntent(intent);

            Auth0.OidcClient.ActivityMediator.Instance.Send(intent.DataString);
        }
        public async void initiate()
        {
            var client = new Auth0Client(new Auth0ClientOptions
            {
                Domain = "dev-49e0jdf0.us.auth0.com",
                ClientId = "kqSAiP6nVLJY0nZuZnFc3o15H3LFbK6r"
            }, this);
            var loginResult = await client.LoginAsync();

        }
    }
}
