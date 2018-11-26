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
using System.Reflection;

namespace organ
{
    public partial class maquinas : UserControl
    {
        public maquinas()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (nova_maquina _nova_maquina = new nova_maquina())
            {
                _nova_maquina.ShowDialog(this);
            }
        }

        private void maquinas_Load(object sender, EventArgs ex)
        {
            PreencherDataGridView();
        }

        void PreencherDataGridView()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT M.cod_maquina AS [Código], M.nome_maq AS [Nome], M.marca_maq AS [Marca], M.desc_maq AS [Descrição], " +
                                                              "E.qtd_estoque AS [Quantidade], F.nome_fantasia AS [Fornecedor], F.cod_fornecedor AS [Código do fornecedor] " +
                                                              "FROM tbMaquina M " +
                                                              "INNER JOIN tbEstoque E ON M.cod_estoque = E.cod_estoque " +
                                                              "LEFT JOIN tbFornecedor F ON M.cod_fornecedor = F.cod_fornecedor " +
                                                              "ORDER BY M.cod_maquina ASC;", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvMaquinas.DataSource = dtbl;
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

        private void dgvMaquinas_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvMaquinas.CurrentRow.Cells["Código"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Tem certeza que deseja deletar esse registro?", "Excluir dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Maquina m = new Maquina(Convert.ToInt16(dgvMaquinas.CurrentRow.Cells["Código"].Value));

                    m.ExcluirMaquina(m);
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }
    }
}
