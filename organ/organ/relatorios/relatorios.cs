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
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT R.cod_relatorio AS [Código], R.desc_rel AS [Descrição], R.data_rel AS [Data], F.desc_rel AS [Descrição], " +
                                                              "P.nome_praga AS [Praga], D.nome_doenca AS [Doença], F.nome_func AS [Funcionário] " +
                                                              "FROM tbRelatorio R " +
                                                              "INNER JOIN tbPraga P ON R.cod_praga = P.cod_praga " +
                                                              "INNER JOIN tbDoenca D ON R.cod_doenca = D.cod_doenca " +
                                                              "INNER JOIN tbFuncionario F ON R.cod_funcionario = F.cod_funcionario " +
                                                              "ORDER BY cod_relatorio ASC;", con);
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
    }
}
