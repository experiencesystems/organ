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
    public partial class fertilizantes : UserControl
    {
        public fertilizantes()
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
            using (novo_fertilizante _novo_fertilizante = new novo_fertilizante())
            {
                _novo_fertilizante.ShowDialog(this);
            }
        }

        void PreencherDataGridView()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT F.cod_fertilizante AS [Código], F.nome_fert AS [Nome], F.marca_fert AS [Marca], F.desc_fert AS [Descrição], " +
                                                              "E.qtd_estoque AS [Quantidade], FO.nome_fantasia AS [Fornecedor], FO.cod_fornecedor AS [Código do fornecedor] " +
                                                              "FROM tbFertilizante F " +
                                                              "INNER JOIN tbEstoque E ON F.cod_estoque = E.cod_estoque " +
                                                              "LEFT JOIN tbFornecedor FO ON F.cod_fornecedor = FO.cod_fornecedor " +
                                                              "ORDER BY F.cod_fertilizante ASC; ", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvFertilizante.DataSource = dtbl;
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

        private void dgvFertilizante_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvFertilizante.CurrentRow.Cells["Código"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Tem certeza que deseja deletar esse registro?", "Excluir dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Fertilizante f = new Fertilizante(Convert.ToInt16(dgvFertilizante.CurrentRow.Cells["Código"].Value));

                    f.ExcluirFertilizante(f);
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }
    }
}
