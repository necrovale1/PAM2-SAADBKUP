namespace SAAD2.Views
{
    public partial class RecuperarSenhaPage : ContentPage
    {
        public RecuperarSenhaPage()
        {
            InitializeComponent();
        }

        private async void OnEnviarLinkClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Sucesso", "Se o e-mail estiver cadastrado, um link de recupera��o ser� enviado em breve.", "OK");
            await Shell.Current.GoToAsync("..");
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}