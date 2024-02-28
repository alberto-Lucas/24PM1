namespace AppLogin;

public partial class Principal : ContentPage
{
	public Principal()
	{
		InitializeComponent();
	}

    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PopAsync();
    }
}