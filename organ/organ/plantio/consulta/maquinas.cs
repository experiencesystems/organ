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
                                                              "E.qtd_estoque AS [Quantidade], F.nome_fantasia AS [Fornecedor] " +
                                                              "FROM tbMaquina M " +
                                                              "INNER JOIN tbEstoque E ON M.cod_estoque = E.cod_estoque " +
                                                              "INNER JOIN tbFornecedor F ON M.cod_fornecedor = F.cod_fornecedor " +
                                                              "ORDER BY cod_maquina ASC;", con);
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
            if (dgvMaquinas.CurrentRow.Cells["txtEmployeeID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Tem certeza que quer deletar essa linha?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("EmployeeDeleteByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(dgvMaquinas.CurrentRow.Cells["txtEmployeeID"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }
    }
}
