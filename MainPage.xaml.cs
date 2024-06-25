using System;
using Xamarin.Forms;

namespace appGenerateCV
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateToCVFormPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CVFormPage());
        }
    }
}
