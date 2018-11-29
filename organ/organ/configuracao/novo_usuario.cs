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
    public partial class novo_usuario : Form
    {
        public novo_usuario()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        //Focus Nome Usuário

        private void txtNomeUsuario_GotFocus(object sender, EventArgs e)
        {
            if (txtNomeUsuario.Text == "Nome usuário")
            {
                txtNomeUsuario.Text = "";
                txtNomeUsuario.ForeColor = Color.Black;
            }
        }

        private void txtNomeUsuario_LostFocus(object sender, EventArgs e)
        {
            if (txtNomeUsuario.Text == "")
            {
                txtNomeUsuario.Text = "Nome usuário";
                txtNomeUsuario.ForeColor = Color.Gray;
            }

            if (txtNomeUsuario.Text == "Nome usuário")
            {
                txtNomeUsuario.ForeColor = Color.Gray;
            }

            else
            {
                txtNomeUsuario.ForeColor = Color.Black;
            }
        }

        //Focus Senha

        private void txtSenha_GotFocus(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
            }
        }

        private void txtSenha_LostFocus(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.Gray;
            }

            if (txtSenha.Text == "Senha")
            {
                txtSenha.ForeColor = Color.Gray;
            }

            else
            {
                txtSenha.ForeColor = Color.Black;
            }
        }

        private void btnCriarNovoUser_Click(object sender, EventArgs e)
        {
            if (txtNomeUsuario.Text == "" || txtSenha.Text == "" || txtNomeUsuario.Text == "Nome usuário" || txtSenha.Text == "Senha")
            {
                MessageBox.Show("Não foi possível criar um novo usuário.", "Preencha todos os campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(StringConexao.connectionString);

                SqlCommand cmd = new SqlCommand("sp_insert_login", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nome_login", txtNomeUsuario.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Usuário registrado com sucesso!", "Cadastro finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException N)
                {
                    MessageBox.Show("Erro: " + N.ToString());
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }
            }
        }
    }
}