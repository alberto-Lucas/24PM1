using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogin
{
    public sealed class UsuarioLogado
    {
        //Variavel que vai apontar a memoria
        static UsuarioLogado _instancia;

        //Metodo para retorno da instancia
        public static UsuarioLogado Instancia
        {
            get
            {
                //retorna o apontamento da
                //instancia em memoria
                //se não existir
                //cria um novo apontamento
                return _instancia ??
                    (_instancia = new UsuarioLogado());
            }
        }

        //construtor da classe
        public UsuarioLogado() { }
        // prop tab tab
        //Atributos da classe
        public string Login { get; set; }
    }
}
