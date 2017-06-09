using WMB.MaratonaXamarin.ViewModels;
using Xamarin.Forms;

namespace WMB.MaratonaXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
