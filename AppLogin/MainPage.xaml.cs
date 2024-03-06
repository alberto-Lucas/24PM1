﻿namespace AppLogin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void EntrarClicked(object sender, EventArgs e)
        {
            if (ValidarLogin(txtUsuario.Text, txtSenha.Text))
            {
                //Sem a menu voltar
                //Navigation.PushModalAsync(new Principal());

                //Com menu voltar
                Application.Current.MainPage.Navigation.PushAsync(new Principal());
            }
            else
                DisplayAlert("Atenção",
                            "Login ou Senha inválidos!",
                            "Ok");
        }

        bool ValidarLogin(string login, string senha)
        {
            return (login == "admin" && senha == "admin");
        }

        private void ValidarUsuario(string usuario, string senha)
        {
            if ((usuario == "admin") && (senha == "admin"))
            {
                DisplayAlert("Informação!!", "Acesso permitido", "Ok");
            }
            else
            {
                DisplayAlert("Atenção!!", "Usuário ou Senha inválido", "Ok");
            }
        }


        private void VoltarClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void MostrarSenha()
        {
            txtSenha.IsPassword =
                !ckbMostrarSenha.IsChecked;
        }

        private void ckbMostrarSenha_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            MostrarSenha();
        }

        private void tapMostrarSenha_Tapped(object sender, TappedEventArgs e)
        {
            //Pricisar atualizar visualmente o checkbox
            ckbMostrarSenha.IsChecked = !ckbMostrarSenha.IsChecked;
            MostrarSenha();
        }

        private void tapCadastrar_Tapped(object sender, TappedEventArgs e)
        {

        }
    }

}