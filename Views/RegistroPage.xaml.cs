namespace SAAD2.Views
{
    // A classe aqui deve ser 'RegistroPage'
    public partial class RegistroPage : ContentPage
    {
        public RegistroPage()
        {
            InitializeComponent();
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            // Este bot�o apenas volta para a p�gina anterior (Login)
            await Shell.Current.GoToAsync("..");
        }
    }
}