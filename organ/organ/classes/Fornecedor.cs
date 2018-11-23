using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organ
{
    public class Fornecedor
    {
        private int cod_fornecedor;
        private String nome_fantasia;
        private String razao_social;
        private long cnpj;
        private long tel_fornecedor;
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
        public long CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public String Razao_social
        {
            get { return razao_social; }
            set { razao_social = value; }
        }
        public long Tel_fornecedor
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
       
        public Fornecedor(String nome_fantasia, String razao_social, long cnpj, long tel_fornecedor, String email_forn, String site, String CEP, int Numero, String Rua, String Bairro, String Complemento, String Cidade, String UF)
        {
            endereco = new Endereco();
            this.nome_fantasia = nome_fantasia;
            this.razao_social = razao_social;
            this.cnpj = cnpj;
            this.tel_fornecedor = tel_fornecedor;
            this.email_forn = email_forn;
            this.site = site;
            endereco.CEP = CEP;
            endereco.Numero = Numero;
            endereco.Rua = Rua;
            endereco.Bairro = Bairro;
            endereco.Complemento = Complemento;
            endereco.Cidade = Cidade;
            endereco.UF = UF;
        }
    }
}    