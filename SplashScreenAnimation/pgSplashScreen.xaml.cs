namespace SplashScreenAnimation;

public partial class pgSplashScreen : ContentPage
{
	public pgSplashScreen()
	{
		InitializeComponent();

		AnimatedImage();
	}

	//Metodo asyncrono para animar a imagem
	async void AnimatedImage()
	{
		//Aplicar um delay antes da animação
		await Task.Delay(2000); //1 segundo
		imgWorld.Rotation = 0; //reseto a imagem
		//Girar totalmente(360) sentido horario
		//Primeiro parametro é a
		//quantidade de grau a ser girada
		//Segundo parametro é o tempo
		//em milisegundo que ira demorar
		imgWorld.RotateTo(360, 3000);

		await Task.Delay(1000);

		//Aplicar uma animação de zoom na imagem
		//Utilizando o metodo scale
		//Onde iremos aumentar a escala da imagem

		//Primeiro paremtro, valor da escala
		//Ou seja sera multiplica a escala atual
		//pelo valor configurado
		//Tamanho de 200px
		//200 x 1.5 = 300px
		//Portanto o tamanho final da imagem
		//sera de 300px
		//Segundo parametro é o tempo da animação
		//terceiro parametro, é para deixar a
		//animação mais suave
		await imgWorld.
			ScaleTo(1.5, 2000, Easing.Linear);

		//Resetar a escala da imagem
		await imgWorld.
			ScaleTo(1, 1000, Easing.Linear);

		//Diminuir a imagem
		await imgWorld.
			ScaleTo(0.5, 1500, Easing.Linear);

		//Aplicar o efeito de zoom infinito
		await imgWorld.
			ScaleTo(150, 1500, Easing.Linear);

		Application.Current.MainPage =
			new NavigationPage(new MainPage());
;	}
}