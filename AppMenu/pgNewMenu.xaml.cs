namespace AppMenu;

public partial class pgNewMenu : ContentPage
{
	public pgNewMenu()
	{
		InitializeComponent();
	}

    private void btnClientes_Clicked(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new pgClientes());
    }

    private void btnVoltar_Clicked(object sender, EventArgs e)
    {

    }
}