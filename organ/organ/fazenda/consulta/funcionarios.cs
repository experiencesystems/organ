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
    public partial class funcionarios : UserControl
    {
        public funcionarios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (novo_funcionario _novo_funcionario = new novo_funcionario())
            {
                _novo_funcionario.ShowDialog(this);
            }
        }

        void PreencherDataGridView()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT F.cod_funcionario AS [Código], F.nome_func AS [Nome], F.cpf_func AS [CPF], F.rg_func AS [RG], " +
                                                              "F.tel_func AS [Telefone], F.cel_func AS [Celular], F.email_func AS [Email], F.cargo_func AS [Cargo], " +
                                                              "E.rua AS [Rua], E.numero AS [Número], E.complemento AS [Complemento], E.bairro AS [Bairro], " +
                                                              "E.cep AS [CEP], E.cidade AS [Cidade], E.uf AS [UF] FROM tbFuncionario F INNER JOIN tbEndereco E ON F.cep_func = E.cep " +
                                                              "ORDER BY cod_funcionario ASC; ", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvFuncionarios.DataSource = dtbl;
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
