using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organ
{
    public partial class frmLogin : Form
    {
        Bitmap olho_visivel = Properties.Resources.Eye_64px;
        Bitmap olho_invisivel = Properties.Resources.Invisible_64px;

        public frmLogin()
        {
            InitializeComponent();
            this.ActiveControl = pnlLogin;
            pcbOlho.Image = olho_invisivel;
        }

        private void txtUsuario_GotFocus(object sender, EventArgs e)
        {
            /*Quando ele for digitar, muda a cor do texto pra preto*/
            if (txtUsuario.Text == "Usuário")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_LostFocus(object sender, EventArgs e)
        {
            /*Tava com um erro de quando o campo Usuário tava vazio e o de Senha tava escrito senha, a cor do Usuário ficava preta*/
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuário";
                txtSenha.ForeColor = Color.Gray;
            }

            /*Se estiver escrito usuário, deixa como cinza, que é o padrão (contei que o usuário não poderia deixar o login dele como "Usuário"
             *nem como "Senha", então poderia ficar assim)*/
            if (txtUsuario.Text == "Usuário")
            {
                txtUsuario.ForeColor = Color.Gray;
            }

            /*Se ele clicar fora do campo usuário e estiver escrito alguma coisa, fica na cor preta*/
            else
            {
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtSenha_GotFocus(object sender, EventArgs e)
        {
            /*Quando não tá nada digitado, fica escrito "Senha" com a cor de fonte cinza*/
            if (txtSenha.Text == "Senha")
            {
                txtSenha.PasswordChar = '*';
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
            }

            /*Quando o usuário digita, a cor da fonte fica preta*/
            else
            {
                txtSenha.ForeColor = Color.Black;
            }

            /*Esse if embaixo é porque tava com o olho visível mas mesmo assim o texto ficava com asterisco*/
            if (pcbOlho.Image == olho_visivel)
            {
                txtSenha.PasswordChar = '\0';
            }
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }

        private void txtSenha_LostFocus(object sender, EventArgs e)
        {
            /*Se ele sair do campo e estiver vazio, muda pra "Senha" e deixa na cor cinza*/
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.Gray;

                /*Se estiver escrito "Senha" e tiver com o olho invisivel, muda pra aparecer "Senha" de novo*/
                if (txtSenha.Text == "Senha" && txtSenha.PasswordChar == '*')
                {
                    txtSenha.PasswordChar = '\0';
                    txtSenha.Text = "Senha";
                }
            }

            /*Padrão de deixar cinza quando estiver escrito "Senha"*/
            if (txtSenha.Text == "Senha")
            {
                txtSenha.ForeColor = Color.Gray;
            }
            else
            {
                txtSenha.ForeColor = Color.Black;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    if ((txtUsuario.Text == "") || (txtUsuario.Text == "Usuário") || (txtSenha.Text == "Senha") || (txtSenha.Text == ""))
                    {
                        MessageBox.Show("Digite valores válidos nos campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "SELECT COUNT (*) AS CNT FROM tbLogin WHERE nome_login = @NOME_LOGIN AND senha = @SENHA";

                        SqlCommand scmd = new SqlCommand(sql, con);

                        scmd.Parameters.Add("@NOME_LOGIN", SqlDbType.NVarChar).Value = txtUsuario.Text;
                        scmd.Parameters.Add("@SENHA", SqlDbType.NVarChar).Value = txtSenha.Text;

                        con.Open();

                        if (scmd.ExecuteScalar().ToString() == "1")
                        {
                            string logar = "UPDATE tbUsuario SET ativacao_usuario = 1 FROM tbUsuario U INNER JOIN tbLogin L ON L.cod_login = U.cod_login WHERE L.nome_login = @NOME_LOGIN AND L.senha = @SENHA";
                            SqlCommand login_usuario = new SqlCommand(logar, con);
                                
                            login_usuario.Parameters.Add("@NOME_LOGIN", SqlDbType.NVarChar).Value = txtUsuario.Text;
                            login_usuario.Parameters.Add("@SENHA", SqlDbType.NVarChar).Value = txtSenha.Text;

                            login_usuario.ExecuteScalar();

                            frmOrgan Interface_Organ = new frmOrgan();
                            Interface_Organ.Show();
                            this.Hide();
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos. Tente novamente.", "Não foi dessa vez. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Primeiro cadastre um usuário no banco ou confirme se a string de conexão está correta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void pcbOlho_Click(object sender, EventArgs e)
        {
            /*Se o usuário clicar e estiver no invisível, vira o visível e tira o PasswordChar*/
            if (pcbOlho.Image == olho_invisivel)
            {
                pcbOlho.Image = olho_visivel;
                txtSenha.PasswordChar = '\0';
            }

            /*Se estiver no visível, vira invisível e deixa o PasswordChar como '*'*/
            else
            {
                pcbOlho.Image = olho_invisivel;
                txtSenha.PasswordChar = '*';

                /*Esse aqui é pra não dar o erro de clicar pra deixar invisível e o placeholder "Senha" não ficar com asterisco*/
                if (txtSenha.Text == "Senha" && txtSenha.PasswordChar == '*')
                {
                    txtSenha.PasswordChar = '\0';
                    txtSenha.Text = "Senha";
                }
            }
        }

        private void pnlLogin_Click(object sender, EventArgs e)
        {
            /*Quando o usuário clica fora dos campos Usuário e Senha, o pnlLogin fica ativo (ao invés dos dois campos)*/
            this.ActiveControl = pnlLogin;
            //tava dando um erro de quando tinha a senha preenchida e depois clicava em usuário, ficava cinza
            if (txtSenha.Text != "" && txtSenha.Text != "Senha")
            {
                txtSenha.ForeColor = Color.Black;
            }
        }

        private void pcbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
