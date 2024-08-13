namespace SplashScreenAnimation;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void btnGirarEsquerdaClicked(object sender, EventArgs e)
    {
        imgLogo.Rotation = 0; //resetar a posição
        imgLogo.RotateTo(-360, 2000); //antihorario
    }

    private void btnGirarDireitaClicked(object sender, EventArgs e)
    {
        imgLogo.Rotation = 0; //resetar a posição
        imgLogo.RotateTo(360, 2000); //horario
    }

    private void btnGirarVerticalClicked(object sender, EventArgs e)
    {
        imgLogo.RotationY = 0;
        imgLogo.RotateYTo(360, 2000);
    }

    private void btnGirarHorizontalClicked(object sender, EventArgs e)
    {
        imgLogo.RotationX = 0;
        imgLogo.RotateXTo(360, 2000);
    }

    private void btnZoomMaisClicked(object sender, EventArgs e)
    {
        //Aplicar o zoom de acordo com o tamanho 
        //atual da imagem
        //ou seja imagem iniciando em 200px ao aplicar o zoom
        //sobre 200 após aplicado o valor é 300
        //então o proximo zoom sera sobre o valor 300
        imgLogo.ScaleTo(imgLogo.Scale + 0.5, 250);
    }

    private void btnZoomMenosClicked(object sender, EventArgs e)
    {
        imgLogo.ScaleTo(imgLogo.Scale - 0.5, 250);
    }

    private async void btnTremerClicked(object sender, EventArgs e)
    {
        uint tempo = 50;

        await imgLogo.TranslateTo(-15, 0, tempo);
        await imgLogo.TranslateTo(15, 0, tempo);
        await imgLogo.TranslateTo(-10, 0, tempo);
        await imgLogo.TranslateTo(10, 0, tempo);
        await imgLogo.TranslateTo(-5, 0, tempo);
        await imgLogo.TranslateTo(5, 0, tempo);
        imgLogo.TranslationX = 0;

    }

    private async void btnGirarZoomClicked(object sender, EventArgs e)
    {
        imgLogo.Rotation = 0;
        //criamos uma taks para
        //executar mais de uma animação
        await Task.WhenAny<bool>
            (imgLogo.RotateTo(360, 2000),
            imgLogo.ScaleTo(2, 1000)
            );
        await imgLogo.ScaleTo(1, 1000);
    }

    private async void btnFadeClicked(object sender, EventArgs e)
    {
        imgLogo.Opacity = 1;
        await imgLogo.FadeTo(0, 500);

        imgLogo.Opacity = 0;
        await imgLogo.FadeTo(1, 500);
    }
}

