namespace AppLogin;

public partial class pgPrincipal : ContentPage
{
	public pgPrincipal()
	{
		InitializeComponent();

		//Acessar a classe singleton
		//para recuperar o usuario logado
		//Criei um variavel que recebe
		//a posição em memoria da classe singleton
		var usuarioLogado = 
			UsuarioLogado.Instancia;

		//Agora podemos carregar a informação
		//da classe
		txtUsuario.Text =
			"Bem Vindo! " + usuarioLogado.Login;
	}
}