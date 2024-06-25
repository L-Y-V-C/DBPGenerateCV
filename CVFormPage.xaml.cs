using System;
using Xamarin.Forms;

namespace appGenerateCV
{
    public partial class CVFormPage : ContentPage
    {
        public CVFormPage()
        {
            InitializeComponent();
        }

        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            string sname = name.Text;
            string semail = email.Text;
            string sphone = phone.Text;
            string saddress = address.Text;
            string slanguages = languages.Text;
            string sexperience = experience.Text;
            string seducation = education.Text;

            await Navigation.PushAsync(new CVDetailPage(sname, semail, sphone, saddress, slanguages, sexperience, seducation));
        }
    }
}
