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
    public class Colheita
    {
        private int qtd_colheita;
        private int codigo_colheita;

        public Plantio plantio { get; set; }

        public Colheita(int codigo_colheita)
        {
            this.Cod_colheita = codigo_colheita;
        }

        public Colheita(int qtd_colheita, int cod_plantio)
        {
            plantio = new Plantio();
            this.Qtd_colheita = qtd_colheita;
            plantio.Cod_plantio = cod_plantio;
        }

        public int Qtd_colheita
        {
            get { return qtd_colheita; }
            set { qtd_colheita = value; }
        }

        public int Cod_colheita
        {
            get { return codigo_colheita; }
            set { codigo_colheita = value; }
        }

        string unidade_medida = "sac";

        public void RealizarColheita(Colheita c)
        {
            using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SP_FINALIZAR_COLHEITA", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@COD_PLANTIO", SqlDbType.Int).Value = plantio.Cod_plantio;
                sqlCmd.Parameters.AddWithValue("@QTD_COLHEITA", SqlDbType.Int).Value = c.Qtd_colheita;
                sqlCmd.Parameters.AddWithValue("@UNIDADE_MEDIDA", SqlDbType.Char).Value = unidade_medida;
                try
                {
                    int i = sqlCmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Plantio foi colhido com sucesso!", "Colheita realizada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Erro");
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }

        public void RepetirColheita(Colheita c)
        {
            using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SP_INSERT_COLHEITA", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@COD_PLANTIO", SqlDbType.Int).Value = plantio.Cod_plantio;
                sqlCmd.Parameters.AddWithValue("@QTD_COLHEITA", SqlDbType.Int).Value = c.Qtd_colheita;
                sqlCmd.Parameters.AddWithValue("@UNIDADE_MEDIDA", SqlDbType.Char).Value = unidade_medida;
                try
                {
                    int i = sqlCmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Plantio foi colhido com sucesso!", "Colheita realizada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Erro");
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }

        public void ExcluirColheita(Colheita c)
        {
            using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SP_DELETE_COLHEITA", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@COD_COLHEITA", c.Cod_colheita);
                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
