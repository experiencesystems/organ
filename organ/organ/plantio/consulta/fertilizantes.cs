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
                                                              "E.qtd_estoque AS [Quantidade], FO.nome_fantasia AS [Fornecedor] " +
                                                              "FROM tbFertilizante F " +
                                                              "INNER JOIN tbEstoque E ON F.cod_estoque = E.cod_estoque " +
                                                              "INNER JOIN tbFornecedor FO ON F.cod_fornecedor = FO.cod_fornecedor " +
                                                              "ORDER BY cod_fertilizante ASC; ", con);
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
    }
}
