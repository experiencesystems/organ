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
    public partial class pragas : UserControl
    {
        public pragas()
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
            using (nova_praga _nova_praga = new nova_praga())
            {
                _nova_praga.ShowDialog(this);
            }
        }

        void PreencherDataGridView()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT P.cod_praga AS [Código], P.nome_praga AS [Nome], P.desc_praga AS [Descrição], S.nome_sem AS [Semente relacionada] FROM tbPraga P " +
                                                              "INNER JOIN tbSemente S ON P.cod_semente = S.cod_semente "+
                                                              "ORDER BY P.cod_praga ASC", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvPragas.DataSource = dtbl;
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

        private void dgvPragas_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvPragas.CurrentRow.Cells["Código"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Tem certeza que deseja deletar esse registro?", "Excluir dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Praga p = new Praga(Convert.ToInt16(dgvPragas.CurrentRow.Cells["Código"].Value));

                    p.ExcluirPraga(p);
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }
    }
}
