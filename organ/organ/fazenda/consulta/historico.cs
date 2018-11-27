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
    public partial class historico : Form
    {
        public historico()
        {
            InitializeComponent();
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
                    SqlDataAdapter sqlDa = new SqlDataAdapter("select cod_estoque AS [Código], data_alteracao AS [Data de alteração], qtd_antiga AS "+
                        "[Quantidade anterior], qtd_alt AS [Quantidade alterada], unidade_medida AS [Unidade de medida], desc_hist AS [Descrição] from"+
                        " tbHistorico_Estoque", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvHistoricoEstoque.DataSource = dtbl;
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
    }
}
