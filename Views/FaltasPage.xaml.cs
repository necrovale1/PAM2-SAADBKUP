using SAAD2.Services;

namespace SAAD2.Views
{
    public partial class FaltasPage : ContentPage
    {
        public FaltasPage()
        {
            InitializeComponent();
            // Define o contexto de dados para a inst�ncia do servi�o de faltas
            BindingContext = FaltaService.Instance;
        }

        // Garante que a lista seja atualizada sempre que a p�gina aparecer
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await FaltaService.Instance.LoadFaltasAsync(); // Carrega os dados de forma ass�ncrona
                                                           // A linha abaixo n�o � mais necess�ria, pois o BindingContext j� cuida disso
                                                           // (BindingContext as FaltaService).Faltas.CollectionChanged += (s, e) => { };
        }
        private async void OnRegistrarFaltaClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(RegistroFaltasPage));
        }
    }
}