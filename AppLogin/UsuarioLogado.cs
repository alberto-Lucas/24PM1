using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogin
{
    public sealed class UsuarioLogado
    {
        //Variavel que aponta a posição em memoria
        static UsuarioLogado _instancia;

        public static UsuarioLogado Instancia
        {
            get
            {
                //retonar o apontamento da
                //instancia em memoria
                //se não exisitir o apontamento
                //sera criado um novo
                return _instancia ??
                    (_instancia = new UsuarioLogado());
            }
        }

        //Construtor da Classe
        public UsuarioLogado() { }

        //Neste é definido as propriedades da classe
        //Login = propriedade que ira
        //armazenar o nome do usuario logado
        public string Login { get; set; }

    }
}
