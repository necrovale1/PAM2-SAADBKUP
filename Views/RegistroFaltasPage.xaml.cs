using SAAD2.Models;
using SAAD2.Services;

namespace SAAD2.Views
{
    public partial class RegistroFaltasPage : ContentPage
    {
        public RegistroFaltasPage()
        {
            InitializeComponent();
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            // Valida��o simples
            if (string.IsNullOrWhiteSpace(MateriaEntry.Text) ||
                string.IsNullOrWhiteSpace(FaltasEntry.Text) ||
                string.IsNullOrWhiteSpace(PresencasEntry.Text))
            {
                await DisplayAlert("Erro", "Todos os campos s�o obrigat�rios.", "OK");
                return;
            }

            if (!int.TryParse(FaltasEntry.Text, out int faltas) || !int.TryParse(PresencasEntry.Text, out int presencas))
            {
                await DisplayAlert("Erro", "Os campos de faltas e presen�as devem ser n�meros.", "OK");
                return;
            }

            var novaFalta = new Falta
            {
                Materia = MateriaEntry.Text,
                Faltas = faltas,
                Presencas = presencas
            };

            await FaltaService.Instance.AddFaltaAsync(novaFalta);
            await Shell.Current.GoToAsync("..");
        }
    }
}