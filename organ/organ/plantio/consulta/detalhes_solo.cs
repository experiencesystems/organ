using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organ
{
    public partial class detalhes_solo : Form
    {
        public detalhes_solo()
        {
            InitializeComponent();
            int h = Screen.PrimaryScreen.WorkingArea.Height - 83;
            int w = Screen.PrimaryScreen.WorkingArea.Width - 131;
            this.ClientSize = new Size(w, h);
            PreencherDataGridView();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void PreencherDataGridView()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT cod_talhao AS [Código], nome_tal AS [Nome], tam_tal AS [Tamanho], tipo_solo_tal AS [Tipo de solo], inc_solar_tal AS [Incidência solar], inc_vento_tal AS [Incidência do vento], acidez_tal AS [Acidez], disponivel_tal AS [Disponível] FROM tbTalhao ORDER BY cod_talhao ASC;", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvDetalhesSolo.DataSource = dtbl;
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }



        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }

        private void dgvDetalhesSolo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalhesSolo.CurrentRow != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dgvDetalhesSolo.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("SP_UPDATE_TALHAO", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@COD_TALHAO", Convert.ToInt32(dgvRow.Cells["Código"].Value));
                    sqlCmd.Parameters.AddWithValue("NOME_TAL", dgvRow.Cells["Nome"].Value);
                    sqlCmd.Parameters.AddWithValue("@TAM_TAL", Convert.ToInt32(dgvRow.Cells["Tamanho"].Value));
                    sqlCmd.Parameters.AddWithValue("@TIPO_SOLO_TAL", dgvRow.Cells["Tipo de solo"].Value);
                    sqlCmd.Parameters.Add("@INC_SOLAR_TAL", SqlDbType.Decimal).Value = Convert.ToDouble(dgvRow.Cells["Incidência solar"].Value == DBNull.Value ? "0" : dgvRow.Cells["Incidência solar"].Value.ToString());
                    sqlCmd.Parameters["@INC_SOLAR_TAL"].Precision = 5;
                    sqlCmd.Parameters["@INC_SOLAR_TAL"].Scale = 2;
                    sqlCmd.Parameters.AddWithValue("@INC_VENTO_TAL", SqlDbType.Decimal).Value = Convert.ToDouble(dgvRow.Cells["Incidência do vento"].Value == DBNull.Value ? "0" : dgvRow.Cells["Incidência do vento"].Value.ToString());
                    sqlCmd.Parameters["@INC_VENTO_TAL"].Precision = 5;
                    sqlCmd.Parameters["@INC_VENTO_TAL"].Scale = 2;
                    sqlCmd.Parameters.AddWithValue("@ACIDEZ_TAL", SqlDbType.Decimal).Value = Convert.ToDouble(dgvRow.Cells["Acidez"].Value == DBNull.Value ? "0" : dgvRow.Cells["Acidez"].Value.ToString());
                    sqlCmd.Parameters["@ACIDEZ_TAL"].Precision = 5;
                    sqlCmd.Parameters["@ACIDEZ_TAL"].Scale = 2;
                    try
                    {
                        int i = sqlCmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Detalhes do talhão alterados com sucesso!", "Alteração finalizada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PreencherDataGridView();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível alterar esse valor na tabela.", "Erro ao alterar tabela.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        sqlCon.Close();
                    }
                }
            }
        }
    }
}

