using System;
using System.Collections.Generic;
using System.Linq;
using Auth0.OidcClient;
using Foundation;
using Xamarin.Essentials;
using UIKit;
using IdentityModel.OidcClient.Results;
using System.Security.Claims;
using Choosr.Models;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(Choosr.iOS.AppDelegate))]
namespace Choosr.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            
            return base.FinishedLaunching(app, options);
        }

        public override bool OpenUrl(UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
        {
            ActivityMediator.Instance.Send(url.AbsoluteString);

            return true;
        }
        public async void initiate()
        {
            var client = new Auth0Client(new Auth0ClientOptions
            {
                Domain = "dev-49e0jdf0.us.auth0.com",
                ClientId = "kqSAiP6nVLJY0nZuZnFc3o15H3LFbK6r"
            });
            var loginResult = await client.LoginAsync();
            UserInfoResult userInfo = await client.GetUserInfoAsync(loginResult.AccessToken);
            var claims = userInfo.Claims;
            var userId = "";
            var name = "";
            foreach (Claim claim in claims) {
                if(claim.Type == "sub") {
                    userId = claim.Value;
                }
                if(claim.Type == "nickname") {
                    name = claim.Value;
                }
            }
            var newUser = new User { UserId = userId, isAuthenticated = true, Name = name, AccessToken = loginResult.AccessToken };
            ((App)App.Current).currUser = newUser;
        }
    }
}
