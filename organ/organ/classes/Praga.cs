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
    public class Praga
    {
        private int codigo;
        private String nome_praga;
        private String descricao;

        public Praga()
        {

        }

        public Praga(int codigo)
        {
            this.Codigo_praga = codigo;
        }

        public Semente semente { get; set; }

        public Praga(String nome_praga, String descricao, int codigo_semente)
        {
            semente = new Semente();
            this.Nome_praga = nome_praga;
            this.Descricao = descricao;
            semente.Codigo_semente = codigo_semente;
        }

        public int Codigo_praga
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public String Nome_praga
        {
            get { return nome_praga; }
            set { nome_praga = value; }
        }
        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public void RegistrarPraga(Praga p)
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);

            SqlCommand cmd = new SqlCommand("SP_INSERT_PRAGA", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@NOME_PRAGA", SqlDbType.VarChar).Value = p.Nome_praga;
            cmd.Parameters.Add("@DESC_PRAGA", SqlDbType.VarChar).Value = p.Descricao;
            cmd.Parameters.Add("@COD_SEMENTE", SqlDbType.Int).Value = p.semente.Codigo_semente;

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Praga registrada com sucesso!", "Cadastro finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void ExcluirPraga(Praga p)
        {
            using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SP_DELETE_PRAGA", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@COD_PRAGA", p.Codigo_praga);
                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
