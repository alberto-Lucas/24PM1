namespace AppLogin;

public partial class pgPrincipal : ContentPage
{
	public pgPrincipal()
	{
		InitializeComponent();

		//Acessar a classe singleton
		//para recuperar o usuario logado
		//Criei um variavel que recebe
		//a posi��o em memoria da classe singleton
		var usuarioLogado = 
			UsuarioLogado.Instancia;

		//Agora podemos carregar a informa��o
		//da classe
		txtUsuario.Text =
			"Bem Vindo! " + usuarioLogado.Login;
	}
}