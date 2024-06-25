using Xamarin.Forms;

namespace appGenerateCV
{
    public partial class CVDetailPage : ContentPage
    {
        public CVDetailPage(string name, string email, string phone, string address, string languages, string experience, string education)
        {
            InitializeComponent();

            nameLabel.Text = $"Nombre: {name}";
            nameLabel.FontSize = 22;
            nameLabel.TextColor = Color.White;

            emailLabel.Text = $"Email: {email}";
            emailLabel.FontSize = 20;
            emailLabel.TextColor = Color.White;

            phoneLabel.Text = $"Teléfono: {phone}";
            phoneLabel.FontSize = 20;
            phoneLabel.TextColor = Color.White;

            addressLabel.Text = $"Dirección: {address}";
            addressLabel.FontSize = 20;
            addressLabel.TextColor = Color.White;

            languagesLabel.Text = $"Idiomas: {languages}";
            languagesLabel.FontSize = 20;
            languagesLabel.TextColor = Color.White;

            experienceLabel.Text = $"Experiencia: {experience}";
            experienceLabel.FontSize = 18;
            experienceLabel.TextColor = Color.White;

            educationLabel.Text = $"Formación: {education}";
            educationLabel.FontSize = 18;
            educationLabel.TextColor = Color.White;
        }
    }
}
