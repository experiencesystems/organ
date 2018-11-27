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
    public partial class relatorios : UserControl
    {
        public relatorios()
        {
            InitializeComponent();
            PreencherDataGridView();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (novo_relatorio _novo_relatorio = new novo_relatorio())
            {
                _novo_relatorio.ShowDialog(this);
            }
        }

        void PreencherDataGridView()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT R.cod_relatorio AS [Código], R.titulo_rel AS [Título], R.desc_rel AS [Descrição], R.data_rel AS [Data], " +
                                                              "F.nome_func AS [Funcionário] " +
                                                              "FROM tbRelatorio R " +
                                                              "INNER JOIN tbFuncionario F ON R.cod_funcionario = F.cod_funcionario " +
                                                              "ORDER BY R.cod_relatorio ASC;", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvRelatorios.DataSource = dtbl;
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

        private void tlpBarraSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvRelatorios_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SP_DELETE_RELATORIO", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@COD_RELATORIO", Convert.ToInt16(dgvRelatorios.CurrentRow.Cells["Código"].Value));
                sqlCmd.ExecuteNonQuery();
            }
        }
    }
    }
