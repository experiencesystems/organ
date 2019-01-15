using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace organ
{
    public partial class estoque : UserControl
    {
        public estoque()
        {
            InitializeComponent();
            PreencherDataGridView();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        void PreencherDataGridView()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SP_SELECT_ESTOQUE", con);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvEstoque.DataSource = dtbl;
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

        private void dgvEstoque_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEstoque.CurrentRow != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dgvEstoque.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("SP_UPDATE_ESTOQUE", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@COD_ESTOQUE", Convert.ToInt32(dgvRow.Cells["Codigo"].Value));
                    sqlCmd.Parameters.AddWithValue("@QTD_ESTOQUE", Convert.ToInt32(dgvRow.Cells["Quantidade"].Value));
                    sqlCmd.Parameters.AddWithValue("@UNIDADE_MEDIDA", dgvRow.Cells["Unidade de medida"].Value);
                    try
                    {
                        int i = sqlCmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Quantidade no estoque alterada com sucesso!", "Alteração finalizada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PreencherDataGridView();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Você não pode ter uma quantidade menor que zero registrada no estoque.", "Erro ao mudar quantidade.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        sqlCon.Close();
                    }
                }
            }
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            using (historico _historico = new historico())
            {
                _historico.ShowDialog(this);
            }
        }
    }
}
