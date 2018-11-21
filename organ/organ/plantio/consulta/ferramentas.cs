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
                                                              "E.qtd_estoque AS [Quantidade], FO.nome_fantasia AS [Fornecedor] " +
                                                              "FROM tbFerramenta F " +
                                                              "INNER JOIN tbEstoque E ON F.cod_estoque = E.cod_estoque " +
                                                              "INNER JOIN tbFornecedor FO ON F.cod_fornecedor = FO.cod_fornecedor " +
                                                              "ORDER BY cod_ferramenta ASC;", con);
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
    }
}
