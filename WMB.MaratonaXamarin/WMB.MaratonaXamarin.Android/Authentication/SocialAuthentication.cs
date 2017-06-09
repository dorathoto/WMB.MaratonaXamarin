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
using Microsoft.WindowsAzure.MobileServices;
using wmbXamarin.Authentication;
using Xamarin.Forms;
using wmbXamarin.Droid.Authentication;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(SocialAuthentication))]
namespace wmbXamarin.Droid.Authentication
{
    public class SocialAuthentication : IAuthentication
    {
        public async Task<MobileServiceUser> Authenticate(MobileServiceClient client, MobileServiceAuthenticationProvider provider, IDictionary<string, string> parameters = null)
        {
            try
            {
                var user = await client.LoginAsync(Forms.Context, provider);

                wmbXamarin.Helpers.Settings.AuthToken = user?.MobileServiceAuthenticationToken ?? string.Empty;
                wmbXamarin.Helpers.Settings.UserId = user?.UserId;

                return user;
            }
            catch (Exception)
            {
                //TODO: LogError
                return null;
            }
        }
    }
}