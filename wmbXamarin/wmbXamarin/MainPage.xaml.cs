using wmbXamarin.Service;
using wmbXamarin.ViewModels;
using Xamarin.Forms;

namespace wmbXamarin
{
    public partial class MainPage : ContentPage
    {
        readonly AzureService azureService = new AzureService();

        public MainPage()
        {
            InitializeComponent();

            LoginButton.Clicked += async (sender, args) =>
            {
                var user = await azureService.LoginAsync();

                InfoLabel.Text = (user != null) ? $"Olá {user.UserId}" : "Falha";
            };
        }
    }
}
