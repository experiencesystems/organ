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
    public partial class sementes : UserControl
    {
        public sementes()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (nova_semente _nova_semente = new nova_semente())
            {
                _nova_semente.ShowDialog(this);
            }
        }

        void PreencherDataGridView()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT S.cod_semente AS [Código], S.nome_sem AS [Nome], S.tipo_solo_sem AS [Tipo de solo], S.tempo_plantio AS [Tempo de plantio], " +
                                                              "S.irrigacao_sem AS [Frequência de irrigação], S.acidez_sem AS [Acidez], S.inc_vento_sem AS [Incidência do vento], "+
                                                              "S.inc_solar_sem AS [Incidência solar], E.qtd_estoque AS [Quantidade], F.nome_fantasia AS [Fornecedor] " +
                                                              "FROM tbSemente S " +
                                                              "INNER JOIN tbEstoque E ON S.cod_estoque = E.cod_estoque " +
                                                              "INNER JOIN tbFornecedor F ON S.cod_fornecedor = F.cod_fornecedor " +
                                                              "ORDER BY cod_semente ASC; ", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvSementes.DataSource = dtbl;
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
