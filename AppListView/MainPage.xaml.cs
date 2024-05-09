using System.Collections.ObjectModel;

namespace AppListView;

public partial class MainPage : ContentPage
{
	//Cireamos um chasse Pessoa
	//para ser o nosso objeto
	//e definimos os seus atributos(propriedades)
	public class Pessoa
	{
        public string Nome { get; set; }
        public string Idade { get; set; }
    }

    //Criamos uma coleção de objetos
    //Casicamente cada registro é um objeto
    //Reunimos todos os objetos em uma coleção
    //Iremos utilizar um tipo de coleção automatico
    //Ou seja ao ser alterar, ira atualizara a lista
    //automaticamente

    //para isso precisamos imporar a biblioteca
    //using System.Collections.ObjectModel;
    ObservableCollection<Pessoa> listaPessoas =
        new ObservableCollection<Pessoa>();

    public MainPage()
	{
		InitializeComponent();

        //Vincular a coleção de objetos ao listView
        lsvItens.ItemsSource = listaPessoas;

        //Adicionar um registro Default
        //apenas para teste

        listaPessoas.Add(
            new Pessoa
            {
                Nome = "Lucas",
                Idade = "00"
            });
	}

    private void btnAdicionar_Clicked(object sender, EventArgs e)
    {
        string nome = txtNome.Text;
        string idade = txtIdade.Text;

        //Validando se os campos estão vazios
        if(!string.IsNullOrEmpty(txtNome.Text) &&
           !string.IsNullOrEmpty(txtIdade.Text))
        {
            //Criamos um novo objeto
            //E o adcionamos a lista
            listaPessoas.Add(
                new Pessoa
                {
                    Nome = nome,
                    Idade = idade
                });

            txtNome.Text = "";
            txtIdade.Text = "";
        }
        else
            DisplayAlert("Atenção",
                "Por favor, preencha o nome e a idade.",
                "Ok");
    }
}

