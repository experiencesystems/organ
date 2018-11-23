using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organ
{
    public  class Endereco
    {
        private String cep;
        private int numero;
        private String rua;
        private String bairro;
        private String complemento;
        private String cidade;
        private String uf;

        public String CEP
        {
            get { return cep; }
            set { cep = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public String Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public String Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public String Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public String UF
        {
            get { return uf; }
            set { uf = value; }
        }
    }
}
