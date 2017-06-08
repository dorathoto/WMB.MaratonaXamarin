using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMB.MaratonaXamarin.Helpers;

namespace WMB.MaratonaXamarin.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        public string UserId { get; private set; }
        public string Token { get; private set; }

        public MainViewModel()
        {
            UserId = Settings.UserId;
            Token = Settings.AuthToken;
        }
    }
}
