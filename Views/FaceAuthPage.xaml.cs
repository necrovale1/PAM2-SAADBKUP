using Camera.MAUI;

namespace SAAD2.Views;

// A palavra "partial" � essencial para conectar este c�digo ao XAML
public partial class FaceAuthPage : ContentPage
{
    public FaceAuthPage()
    {
        // Este comando conecta os controles do XAML (como o cameraView) a este arquivo
        InitializeComponent();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        // Garante que a c�mera seja desligada ao sair da p�gina
        if (cameraView.IsCameraStarted)
        {
            cameraView.StopCameraAsync();
        }
    }

    private void CameraView_CamerasLoaded(object sender, EventArgs e)
    {
        // Verifica se existem c�meras no dispositivo
        if (cameraView.Cameras.Count > 0)
        {
            // Seleciona a c�mera frontal como padr�o
            cameraView.Camera = cameraView.Cameras.FirstOrDefault(c => c.Position == CameraPosition.Front);

            // Inicia a visualiza��o da c�mera na thread principal
            MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await cameraView.StartCameraAsync();
            });
        }
    }
}