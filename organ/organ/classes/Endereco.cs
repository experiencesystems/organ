using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organ
{
    public class Endereco
    {
        private static int cep;
        private static int numero;
        private static String rua;
        private static String bairro;
        private static String complemento;
        private static String cidade;
        private static String uf;

        public static int CEP
        {
            get { return cep; }
            set { cep = value; }
        }
        public static int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public static String Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public static String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public static String Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public static String Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public static String UF
        {
            get { return uf; }
            set { uf = value; }
        }
    }
}
