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
    public partial class novo_funcionario : Form
    {
        public novo_funcionario()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtCPF.Text == "" || txtRG.Text == "" || txtEndereco.Text == "" || txtNumCasa.Text == "" || txtCEP.Text == "" || txtBairro.Text == "" || txtCidade.Text == "" || txtUF.Text == "" || txtCargo.Text == "" || txtSalario.Text == "")
            {
                MessageBox.Show("Certifique-se de preencher todos os campos que têm asterisco.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string sql = "alter table tbFuncionario nocheck constraint FK_tbFuncionario_tbEndereco;" +
                             "alter table tbFuncionario nocheck constraint FK_tbFuncionario_tbUsuario;" +
                             "alter table tbFuncionario alter column cod_usuario int null;" +
                             "INSERT INTO tbFuncionario (nome_func, cpf_func, rg_func, tel_func, cel_func, email_func, cargo_func, salario_func, numcasa_func, cep_func) " +
                             "VALUES ('" + txtNome.Text + "', " + txtCPF.Text + ", " + txtRG.Text + ", " + txtTelefone.Text + ", " + txtCelular.Text + ", '"
                             + txtEmail.Text + "', '" + txtCargo.Text + "', " + txtSalario.Text + ", " + txtNumCasa.Text + ", " + txtCEP.Text + ")";

                SqlConnection con = new SqlConnection(StringConexao.connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
