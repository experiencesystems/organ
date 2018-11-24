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
    public class Funcionario
    {
        private String nome_funcionario;
        private long cpf;
        private long rg;
        private long telefone;
        private long celular;
        private String email;
        private String cargo;
        private double salario;

        public String Nome_funcionario
        {
            get { return nome_funcionario; }
            set { nome_funcionario = value; }
        }
        public long CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public long RG
        {
            get { return rg; }
            set { rg = value; }
        }
        public long Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public long Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public String Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public Endereco endereco { get; set; }

        public Funcionario(String nome_funcionario, long cpf, long rg, long telefone, long celular, String email, String cargo, double salario, String CEP, int Numero, String Rua, String Bairro, String Complemento, String Cidade, String UF)
        {
            endereco = new Endereco();
            this.Nome_funcionario = nome_funcionario;
            this.CPF = cpf;
            this.RG = rg;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Email = email;
            this.Cargo = cargo;
            this.Salario = salario;
            endereco.CEP = CEP;
            endereco.Numero = Numero;
            endereco.Rua = Rua;
            endereco.Bairro = Bairro;
            endereco.Complemento = Complemento;
            endereco.Cidade = Cidade;
            endereco.UF = UF;
        }

        public void RegistrarFuncionario(Funcionario f)
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);

            SqlCommand cmd = new SqlCommand("SP_INSERT_FUNCIONARIO", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@CEP", SqlDbType.Int).Value = f.endereco.CEP;
            cmd.Parameters.Add("@NUMERO", SqlDbType.Int).Value = f.endereco.Numero;
            cmd.Parameters.Add("@RUA", SqlDbType.VarChar).Value = f.endereco.Rua;
            cmd.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = f.endereco.Bairro;
            cmd.Parameters.Add("@COMPLEMENTO", SqlDbType.VarChar).Value = f.endereco.Complemento;
            cmd.Parameters.Add("@CIDADE", SqlDbType.VarChar).Value = f.endereco.Cidade;
            cmd.Parameters.Add("@UF", SqlDbType.Char).Value = f.endereco.UF;
            cmd.Parameters.Add("@NOME_FUNC", SqlDbType.VarChar).Value = f.Nome_funcionario;
            cmd.Parameters.Add("@CPF_FUNC", SqlDbType.NVarChar).Value = f.CPF;
            cmd.Parameters.Add("@RG", SqlDbType.NVarChar).Value = f.RG;
            cmd.Parameters.Add("@TEL_FORN", SqlDbType.NVarChar).Value = f.Telefone;
            cmd.Parameters.Add("@CEL_FORN", SqlDbType.NVarChar).Value = f.Celular;
            cmd.Parameters.Add("@EMAIL_FORN", SqlDbType.VarChar).Value = f.Email;
            cmd.Parameters.Add("@CARGO", SqlDbType.VarChar).Value = f.Cargo;
            cmd.Parameters.Add("@SALARIO", SqlDbType.Money).Value = f.Salario;

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
    }
}
