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
    public partial class defensivo : UserControl
    {
        public defensivo()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (novo_defensivo _novo_defensivo = new novo_defensivo())
            {
                _novo_defensivo.ShowDialog(this);
            }
        }

        void PreencherDataGridView()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT D.cod_defensivo AS [Código], D.nome_def AS [Nome], D.marca_def AS [Marca], D.desc_def AS [Descrição], " +
                                                              "P.nome_praga AS [Praga relacionada], DO.nome_doenca AS [Doença relacionada], E.qtd_estoque AS [Quantidade] "+
                                                              "F.nome_fantasia AS [Fornecedor] "+
                                                              "FROM tbDefensivo D "+
                                                              "INNER JOIN tbPraga P ON D.cod_defensivo = P.cod_praga "+
                                                              "INNER JOIN tbDoenca DO ON D.cod_defensivo = DO.cod_doenca "+
                                                              "INNER JOIN tbEstoque E ON D.cod_estoque = E.cod_estoque "+
                                                              "INNER JOIN tbFornecedor F ON D.cod_fornecedor = F.cod_fornecedor "+
                                                              "ORDER BY cod_defensivo ASC; ", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvDefensivo.DataSource = dtbl;
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
    }
}
