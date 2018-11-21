using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organ
{
    public class Fornecedor
    {
        private int cod_fornecedor;
        private String nome_fantasia;
        private String razao_social;
        private int cnpj;
        private int tel_fornecedor;
        private String email_forn;
        private String site;
        
        public int Cod_fornecedor
        {
            get { return cod_fornecedor; }
            set { cod_fornecedor = value; }
        }
        public String Nome_fantasia
        {
            get { return nome_fantasia; }
            set { nome_fantasia = value; }
        }
        public int CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public String Razao_social
        {
            get { return razao_social; }
            set { razao_social = value; }
        }
        public int Tel_fornecedor
        {
            get { return tel_fornecedor; }
            set { tel_fornecedor = value; }
        }
        public String Email_forn
        {
            get { return email_forn; }
            set { email_forn = value; }
        }
        public String Site
        {
            get { return site; }
            set { site = value; }
        }

        public Endereco endereco { get; set; }

        public static int CEP { get { return CEP; } }

        public static int Numero { get { return Numero; } }

        public static String Rua { get { return Rua; } }

        public static String Bairro { get { return Bairro; } }

        public static String Complemento { get { return Complemento; } }

        public static String Cidade { get { return Cidade; } }

        public static String UF { get { return UF; } }

        public Fornecedor(String nome_fantasia, String razao_social, int cnpj, int tel_fornecedor, String email_forn, String site, int CEP, int Numero, String Rua, String Bairro, String Complemento, String Cidade, String UF)
        {
            this.nome_fantasia = nome_fantasia;
            this.razao_social = razao_social;
            this.cnpj = cnpj;
            this.tel_fornecedor = tel_fornecedor;
            this.email_forn = email_forn;
            this.site = site;
            Endereco.CEP = Endereco.CEP;
            Endereco.Numero = Endereco.Numero;
            Endereco.Rua = Endereco.Rua;
            Endereco.Bairro = Endereco.Bairro;
            Endereco.Complemento = Endereco.Complemento;
            Endereco.Cidade = Endereco.Cidade;
            Endereco.UF = Endereco.UF;
        }
    }

    public class FornecedorCBO
    {
        private String display;
        public String Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        private Fornecedor value;
        public Fornecedor Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
    }
}