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
    public partial class ferramentas : UserControl
    {
        public ferramentas()
        {
            InitializeComponent();
            PreencherDataGridView();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (nova_ferramenta _nova_ferramenta = new nova_ferramenta())
            {
                _nova_ferramenta.ShowDialog(this);
            }
        }

        void PreencherDataGridView()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT F.cod_ferramenta AS [Código], F.nome_ferra AS [Nome], F.marca_ferra AS [Marca], F.desc_ferra AS [Descrição], " +
                                                              "E.qtd_estoque AS [Quantidade], FO.nome_fantasia AS [Fornecedor], FO.cod_fornecedor AS [Código do fornecedor] " +
                                                              "FROM tbFerramenta F " +
                                                              "INNER JOIN tbEstoque E ON F.cod_estoque = E.cod_estoque " +
                                                              "LEFT JOIN tbFornecedor FO ON F.cod_fornecedor = FO.cod_fornecedor " +
                                                              "ORDER BY F.cod_ferramenta ASC;", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvFerramentas.DataSource = dtbl;
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

        private void dgvFerramentas_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvFerramentas.CurrentRow.Cells["Código"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Tem certeza que deseja deletar esse registro?", "Excluir dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Ferramenta f = new Ferramenta(Convert.ToInt16(dgvFerramentas.CurrentRow.Cells["Código"].Value));

                    f.ExcluirFerramenta(f);
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }
    }
}
