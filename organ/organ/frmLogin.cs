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
        static int attempt = 3;
        string connectionString = @"Data Source=LAB2PC16\SA;Initial Catalog=dbOrgan;Persist Security Info=True;User ID=sa;Password=1234567";
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
            string sql = "select count (*) as cnt from tbLogin where nome_login = '" + txtUsuario.Text + "' and senha = '" + txtSenha.Text + "';";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand scmd = new SqlCommand(sql, con);
            con.Open();

            if (scmd.ExecuteScalar().ToString() == "1")
            {
                MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
            }

            else
            {
                MessageBox.Show("YOU ARE NOT GRANTED WITH ACCESS");
                //lbl_Msg.Text = ("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");
                //--attempt;
                txtUsuario.Text = "";
                txtSenha.Text = "";
            }

            con.Close();

            if ((txtUsuario.Text == "") || (txtUsuario.Text == "Usuário") || (txtSenha.Text == "Senha") || (txtSenha.Text == ""))
            {
                MessageBox.Show("Digite valores válidos nos campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmOrgan Interface_Organ = new frmOrgan();
                Interface_Organ.Show();
                this.Hide();
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
