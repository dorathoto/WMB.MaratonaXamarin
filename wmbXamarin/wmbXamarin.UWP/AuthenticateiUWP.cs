using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wmbXamarin.Authentication;
using Xamarin.Forms;

namespace wmbXamarin.UWP
{
    public class AuthenticateiUWP : IAuthentication
    {
        public async Task<MobileServiceUser> Authenticate(MobileServiceClient client, MobileServiceAuthenticationProvider provider, IDictionary<string, string> parameters = null)
        {
            try
            {
                var user = await client.LoginAsync(provider);

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