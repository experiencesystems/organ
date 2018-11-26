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
    public partial class doencas : UserControl
    {

        public doencas()
        {
            InitializeComponent();
            PreencherDataGridView();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (nova_doenca _nova_doenca = new nova_doenca())
            {
                _nova_doenca.ShowDialog(this);
            }
        }

        void PreencherDataGridView()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT cod_doenca AS [Código], nome_doenca AS [Doença], desc_doenca AS [Descrição] FROM tbDoenca " +
                                                              "ORDER BY cod_doenca ASC; ", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvDoencas.DataSource = dtbl;
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

        private void dgvDoencas_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvDoencas.CurrentRow.Cells["Código"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Tem certeza que deseja deletar esse registro?", "Excluir dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   Doenca d = new Doenca(Convert.ToInt16(dgvDoencas.CurrentRow.Cells["Código"].Value));

                    d.ExcluirDoenca(d);
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }
    }
}
