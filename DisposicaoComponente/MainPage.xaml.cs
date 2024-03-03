namespace DisposicaoComponente;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void btnCliqueAqui_Clicked(object sender, EventArgs e)
    {
        DisplayAlert(
            "Titulo",
            "O conteudo: " +
                txtCampo.Text,
            "Ok");
    }

    private void btnAbrir_Clicked(object sender, EventArgs e)
    {
        Application.Current.
            MainPage.
            Navigation.
            PushAsync(new pgPrincipal());
    }
}

