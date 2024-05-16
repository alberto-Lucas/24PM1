using System.Collections.ObjectModel;
using SQLite;
using PCLExt.FileStorage.Folders;

namespace AppListView;

public partial class MainPage : ContentPage
{
    //Instalar as bibliotecas Nuget
    //sqlite-net-pcl (icone pena)
    //pclext.filestorage (icone de sushi)

    //Variavel responsavel pela conexão com o BD
    private SQLiteConnection conexao;


    //Cireamos um chasse Pessoa
    //para ser o nosso objeto
    //e definimos os seus atributos(propriedades)
    public class Pessoa
	{
        //Adionar a propriedade ID
        //para identificação do registro
        //Configurar a proprieade nova como 
        //Chave Primaria, e auto incremento
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }       
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

    //Devido a conexão com o BD não iremos mais 
    //utilizar a nossa coleção de objetos
    /*ObservableCollection<Pessoa> listaPessoas =
        new ObservableCollection<Pessoa>();*/

    //Função para retornar a conexão com o BD
    public SQLiteConnection GetConnection()
    {
        //Variavel para a pasta onde
        //estara o arquivo do BD
        var folder = new LocalRootFolder();

        //Definir as configurações do BD
        //Nome do BD
        //Configurar para caso o arquivo não exista
        //seja criado
        //Caso ja exista, seja atualizado

        //Criar vareiavel para o arquivo do BD
        var file =
            folder.CreateFile(
                "oraculo.db3", //Nome BD
                PCLExt.FileStorage.
                    CreationCollisionOption.OpenIfExists);

        //Retornar a conexão com o banco de dados
        return new SQLiteConnection(file.Path);
    }

    public MainPage()
	{
		InitializeComponent();

        //Vincular a coleção de objetos ao listView
        //Removemos devido o BD
        //lsvItens.ItemsSource = listaPessoas;

        //Adicionar um registro Default
        //apenas para teste
        //Removecos devido o BD
        /*
        listaPessoas.Add(
            new Pessoa
            {
                Nome = "Lucas",
                Idade = "00"
            });
        */

        //Abriamos a conexão com o BD
        conexao = GetConnection();
        //Mapeanos a classe para pessoa
        //para criação da tabela Pessoa
        conexao.CreateTable<Pessoa>();

        AtualizarListView();
    }

    //Função para atualizar os dados da ListView
    private void AtualizarListView()
    {
        //Realizar uma consulta na tabela do BD
        //e atribuir o retorno da consulta
        //na listView
        lsvItens.ItemsSource = 
            conexao.Table<Pessoa>().ToList();
        //Basicamente o comando:
        //SELECT * FROM Pessoa
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
            /*
            listaPessoas.Add(
                new Pessoa
                {
                    Nome = nome,
                    Idade = idade
                });
            */

            conexao.Insert(new Pessoa
            {
                Nome = nome,
                Idade = idade
            }) ;

            txtNome.Text = "";
            txtIdade.Text = "";

            AtualizarListView();
        }
        else
            DisplayAlert("Atenção",
                "Por favor, preencha o nome e a idade.",
                "Ok");
    }

    private async void btnDeletar_Clicked(object sender, EventArgs e)
    {
        //Premirei precisamos validar o click do botão
        //Se realmente foi clicar atibuimos o Button
        //a varial botao, a variavel botao, passar a ter
        //todos os dados do Button clicado
        //precisamos deste processo
        //para recupear o parametro
        //Depois, verifica se o obejto selecionado
        //é do tipo Pessoa.
        //se for atribuimos o obeto selecionado a 
        //varaivel pessoa
        //portanto pessoa passa ter
        //todos os dados do objeto
        if(sender is Button botao &&
            botao.CommandParameter is Pessoa pessoa)
        {
            //Realizar confirmação da ação
            bool validacao =
                await DisplayAlert(
                    "Confirmação",
                    "Deseja realmente excluiro o item?",
                    "Sim",
                    "Não");
            if(validacao)
            {
                //se confirmado a exclusão
                //Realizamo o delete no BD
                conexao.Delete(pessoa);
                AtualizarListView();
            }
        }
    }
}

