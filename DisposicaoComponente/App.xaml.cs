namespace DisposicaoComponente;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }

    protected override Window
        CreateWindow(
        IActivationState activationState)
    {
        var window =
            base.CreateWindow(activationState);

        window.Height = 700; //Altura
        window.Width = 400; //Largura

        return window;
    }
}
