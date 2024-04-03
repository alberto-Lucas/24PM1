using System.Collections.Generic;
using System;

namespace App_Prova;

public partial class CaraOuCoroa : ContentPage
{
	public CaraOuCoroa()
	{
		InitializeComponent();
	}

    static Random rnd = new Random();

    private void jogar(object sender, EventArgs e)
    {
        int Escolha = 3;

        List<int> numeros = new List<int>() { 0, 1 };
        Random rnd = new Random();
        int indice = rnd.Next(numeros.Count);
        int numeroAleatorio = numeros[indice];

        if(opcaoCara.IsChecked == false && opcaoCoroa.IsChecked== false )
        {
            DisplayAlert("ERRO", "MARQUE ALGUMA OPÇÃO PARA JOGAR", "TENTAR NOVAMENTE");
        }


        if (opcaoCara.IsChecked == true)
		{
			Escolha = 0;

            if(Escolha == numeroAleatorio)
            {
                lblresult.Text = "VITÓRIA C: \n VOCÊ ESCOLHEU : CARA \n CAIU EM : CARA";
                lblresult.TextColor = Color.FromRgb(0,128,0);
            }
            else
            {
                lblresult.Text = "DERROTA C: \n VOCÊ ESCOLHEU : CARA \n CAIU EM : COROA";
                lblresult.TextColor = Color.FromRgb(255,0,0);
            }
		}
        if(opcaoCoroa.IsChecked== true)
        {
            Escolha = 1;

            if (Escolha == numeroAleatorio)
            {
                lblresult.Text = "VITÓRIA C: \n VOCÊ ESCOLHEU : COROA \n CAIU EM : COROA";
                lblresult.TextColor = Color.FromRgb(0, 128, 0);
            }
            else
            {
                lblresult.Text = "DERROTA C: \n VOCÊ ESCOLHEU : COROA \n CAIU EM : CARA";
                lblresult.TextColor = Color.FromRgb(255, 0, 0);
            }
        }
    }

    private void validacao(object sender, CheckedChangedEventArgs e)
    {
        if (opcaoCara.IsChecked)
        {
            opcaoCoroa.IsChecked = false;
        }
        if (opcaoCoroa.IsChecked)
        {
            opcaoCara.IsChecked = false;
        }
    }
}