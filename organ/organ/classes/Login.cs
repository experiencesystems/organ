using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organ
{
    public class Login
    {
        private int cod_login;
        private String nome_login;
        private String senha;
        private String data_cadastro = "default";

        public int Cod_login
        {
            get { return cod_login; }
            set { cod_login = value; }
        }

        public String Nome_login
        {
            get { return nome_login; }
            set { nome_login = value; }
        }

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public String Data_cadastro
        {
            get { return data_cadastro; }
            set { data_cadastro = value; }
        }
    }
}
