using System;
using Xamarin.Forms;
[assembly: Xamarin.Forms.Dependency(typeof(Choosr.iOS.Auth0Connection))]
namespace Choosr.iOS
{
    public class Auth0Connection : ChoosrInterface
    {
        public Auth0Connection()
        {
        }
        public async void initiateAuth0()
        {
            var someyt = DependencyService.Get<AppDelegate>();
            someyt.initiate();
        }
    }
}
