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
    public partial class consulta_colheita : Form
    {
        public consulta_colheita()
        {
            InitializeComponent();
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            int h = Screen.PrimaryScreen.WorkingArea.Height - 83;
            int w = Screen.PrimaryScreen.WorkingArea.Width - 131;
            this.ClientSize = new Size(w, h);
            PreencherDataGridView();
        }

        void PreencherDataGridView()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SP_SELECT_COLHEITA", con);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvColheitas.DataSource = dtbl;
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvColheitas_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvColheitas.CurrentRow.Cells["Código"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Tem certeza que deseja deletar esse registro?", "Excluir dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Colheita c = new Colheita(Convert.ToInt16(dgvColheitas.CurrentRow.Cells["Código"].Value));

                    c.ExcluirColheita(c);
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }
    }
}
