namespace AppMenu
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new pgMenu();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Height = 800; //Altura
            window.Width = 400;  //Largura

            return window;
        }
    }
}
