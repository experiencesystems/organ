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
    public class Doenca
    {
        private int codigo;
        private String nome_doenca;
        private String descricao;

        public int Codigo_doenca
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public String Nome_doenca
        {
            get { return nome_doenca; }
            set { nome_doenca = value; }
        }
        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public Doenca()
        {

        }

        public Doenca(int codigo)
        {
            this.Codigo_doenca = codigo;
        }

        public Semente semente { get; set; }

        public Doenca(String nome_doenca, String descricao, int codigo_semente)
        {
            semente = new Semente();
            this.Nome_doenca = nome_doenca;
            this.Descricao = descricao;
            semente.Codigo_semente = codigo_semente;
        }

        public void RegistrarDoenca(Doenca d)
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);

            SqlCommand cmd = new SqlCommand("SP_INSERT_DOENCA", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@NOME_DOENCA", SqlDbType.VarChar).Value = d.Nome_doenca;
            cmd.Parameters.Add("@DESC_DOENCA", SqlDbType.VarChar).Value = d.Descricao;
            cmd.Parameters.Add("@COD_SEMENTE", SqlDbType.Int).Value = d.semente.Codigo_semente;

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Doença registrada com sucesso!", "Cadastro finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public void ExcluirDoenca(Doenca d)
        {
            using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SP_DELETE_DOENCA", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@COD_DOENCA", d.Codigo_doenca);
                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}