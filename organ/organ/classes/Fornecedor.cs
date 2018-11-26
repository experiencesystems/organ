using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        private long telefone;
        private String email;
        private String site;
        private String status;
        
        public int Codigo_fornecedor
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
        public long Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public String Site
        {
            get { return site; }
            set { site = value; }
        }
        public String Status
        {
            get { return status; }
            set { status = value; }
        }

        public Endereco endereco { get; set; }
       
        public Fornecedor(int codigo)
        {
            this.Codigo_fornecedor = codigo;
        }
        
        public Fornecedor()
        {

        }

        //sem cod fornecedor
        public Fornecedor(String nome_fantasia, String razao_social, long cnpj, long telefone, String email, String site, String CEP, int Numero, String Rua, String Bairro, String Complemento, String Cidade, String UF)
        {
            endereco = new Endereco();
            this.Nome_fantasia = nome_fantasia;
            this.Razao_social = razao_social;
            this.CNPJ = cnpj;
            this.Telefone = telefone;
            this.Email = email;
            this.Site = site;
            endereco.CEP = CEP;
            endereco.Numero = Numero;
            endereco.Rua = Rua;
            endereco.Bairro = Bairro;
            endereco.Complemento = Complemento;
            endereco.Cidade = Cidade;
            endereco.UF = UF;
        }

        public void RegistrarFornecedor(Fornecedor f)
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);

            SqlCommand cmd = new SqlCommand("SP_INSERT_FORNECEDOR", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@CEP", SqlDbType.Char).Value = f.endereco.CEP;
            cmd.Parameters.Add("@NUMERO", SqlDbType.Int).Value = f.endereco.Numero;
            cmd.Parameters.Add("@RUA", SqlDbType.VarChar).Value = f.endereco.Rua;
            cmd.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = f.endereco.Bairro;
            cmd.Parameters.Add("@COMPLEMENTO", SqlDbType.VarChar).Value = f.endereco.Complemento;
            cmd.Parameters.Add("@CIDADE", SqlDbType.VarChar).Value = f.endereco.Cidade;
            cmd.Parameters.Add("@UF", SqlDbType.Char).Value = f.endereco.UF;
            cmd.Parameters.Add("@NOME_FANTASIA", SqlDbType.VarChar).Value = f.Nome_fantasia;
            cmd.Parameters.Add("@CNPJ_FORN", SqlDbType.Char).Value = f.CNPJ;
            cmd.Parameters.Add("@RAZAO_SOCIAL", SqlDbType.VarChar).Value = f.Razao_social;
            cmd.Parameters.Add("@TEL_FORN", SqlDbType.NVarChar).Value = f.Telefone;
            cmd.Parameters.Add("@EMAIL_FORN", SqlDbType.VarChar).Value = f.Email;
            cmd.Parameters.Add("@SITE_FORN", SqlDbType.VarChar).Value = f.Site;

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Fornecedor registrado com sucesso!", "Cadastro finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro: " + e.ToString());
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public void ExcluirFornecedor(Fornecedor f)
        {
            using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SP_DELETE_FORNECEDOR", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@COD_FORNECEDOR", f.Codigo_fornecedor);
                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}    