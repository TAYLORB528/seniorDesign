using System;
using Auth0.OidcClient;
using Xamarin.Forms;
[assembly: Xamarin.Forms.Dependency(typeof(Choosr.Droid.Auth0Connection))]
namespace Choosr.Droid
{
    public class Auth0Connection : ChoosrInterface
    {
        public Auth0Connection()
        {
        }

        public async void initiateAuth0()
        {
            var someyt = DependencyService.Get<MainActivity>();
            someyt.initiate();
        }
    }
}
