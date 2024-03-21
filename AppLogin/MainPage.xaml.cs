namespace AppLogin;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void ckbMostrarSenha_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		txtSenha.IsPassword =
			!ckbMostrarSenha.IsChecked;
    }

    private void lblMostrarSenha_Tapped(object sender, TappedEventArgs e)
    {
        ckbMostrarSenha.IsChecked =
            !ckbMostrarSenha.IsChecked;
    }

    private void btnEntrar_Clicked(object sender, EventArgs e)
    {
        if (txtUsuario.Text == "admin" &&
            txtSenha.Text == "admin")
        {
            //Vamos abrir a tela principal
        }
        else
            DisplayAlert("Atenção!!", 
                "Usuário ou Senha inválidos.",
                "OK");
    }
}

