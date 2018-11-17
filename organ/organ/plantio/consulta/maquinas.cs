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

        void PreencherComboBox()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM tbFornecedor", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                cbocod_fornecedor.ValueMember = "cod_fornecedor";
                cbocod_fornecedor.DisplayMember = "nome_fantasia";
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "Selecione um item";
                dtbl.Rows.InsertAt(topItem, 0);
                cbocod_fornecedor.DataSource = dtbl;
            }
        }

        private void maquinas_Load(object sender, EventArgs e)
        {
            PreencherComboBox();
            PreencherDataGridView();
        }

        void PreencherDataGridView()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM tbMaquina", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvMaquinas.DataSource = dtbl;
            }
        }

        private void dgvMaquinas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaquinas.CurrentRow != null)
            {
                using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
                {
                    con.Open();
                    DataGridViewRow dgvRow = dgvMaquinas.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("MaquinasInsertUpdate", con);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    if (dgvRow.Cells["txtcod_maquinas"].Value == DBNull.Value)
                    {//insert
                        sqlCmd.Parameters.AddWithValue("@cod_maquinas", 0);
                    }
                    else//update
                    {
                        sqlCmd.Parameters.AddWithValue("@cod_maquinas", Convert.ToInt32(dgvRow.Cells["txtcod_maquinas"].Value));
                        sqlCmd.Parameters.AddWithValue("@nome_maq", dgvRow.Cells["txtnome_maq"].Value == DBNull.Value ? "" : dgvRow.Cells["txtnome_maq"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@desc_maq", dgvRow.Cells["txtdesc_maq"].Value == DBNull.Value ? "" : dgvRow.Cells["txtdesc_maq"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@marca_maq", dgvRow.Cells["txtmarca_maq"].Value == DBNull.Value ? "" : dgvRow.Cells["txtmarca_maq"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@cod_fornecedor", Convert.ToInt32(dgvRow.Cells["cbocod_fornecedor"].Value == DBNull.Value ? "0" : dgvRow.Cells["cbocod_fornecedor"].Value.ToString()));
                        sqlCmd.ExecuteNonQuery();
                        PreencherDataGridView();
                    }
                }
            }
        }

        private void dgvMaquinas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= AllowNumbersOnly;
            if (dgvMaquinas.CurrentCell.ColumnIndex == 4)
            {

                e.Control.KeyPress += AllowNumbersOnly;
            }
        }

        private void AllowNumbersOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
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
