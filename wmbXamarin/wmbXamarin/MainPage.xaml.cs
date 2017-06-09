using wmbXamarin.ViewModels;
using Xamarin.Forms;

namespace wmbXamarin
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
