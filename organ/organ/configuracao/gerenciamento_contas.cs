using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organ
{
    public partial class gerenciamento_contas : Form
    {
        public gerenciamento_contas()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            PreencherComboBoxUsuario();
            PreencherComboBoxUsuario2();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Focus Senha Antiga

        private void txtSenhaAntiga_GotFocus(object sender, EventArgs e)
        {
            if (txtSenhaAntiga.Text == "Senha atual")
            {
                txtSenhaAntiga.Text = "";
                txtSenhaAntiga.ForeColor = Color.Black;
            }
        }

        private void txtSenhaAntiga_LostFocus(object sender, EventArgs e)
        {
            if (txtSenhaAntiga.Text == "")
            {
                txtSenhaAntiga.Text = "Senha atual";
                txtSenhaAntiga.ForeColor = Color.Gray;
            }

            if (txtSenhaAntiga.Text == "Senha atual")
            {
                txtSenhaAntiga.ForeColor = Color.Gray;
            }

            else
            {
                txtSenhaAntiga.ForeColor = Color.Black;
            }
        }

        //Focus Senha Nova

        private void txtSenhaNew_GotFocus(object sender, EventArgs e)
        {
            if (txtSenhaNew.Text == "Senha nova")
            {
                txtSenhaNew.Text = "";
                txtSenhaNew.ForeColor = Color.Black;
            }
        }

        private void txtSenhaNew_LostFocus(object sender, EventArgs e)
        {
            if (txtSenhaNew.Text == "")
            {
                txtSenhaNew.Text = "Senha nova";
                txtSenhaNew.ForeColor = Color.Gray;
            }

            if (txtSenhaNew.Text == "Senha nova")
            {
                txtSenhaNew.ForeColor = Color.Gray;
            }

            else
            {
                txtSenhaNew.ForeColor = Color.Black;
            }
        }


        void PreencherComboBoxUsuario()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT cod_login AS [CODIGO], nome_login AS [NOME] FROM tbLogin", con);

            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CODIGO", typeof(int));
                dt.Columns.Add("NOME", typeof(string));
                dt.Load(reader);

                cboUsuario.ValueMember = "CODIGO";
                cboUsuario.DisplayMember = "NOME";
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "";
                dt.Rows.InsertAt(topItem, 0);
                cboUsuario.DataSource = dt;
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

        void PreencherComboBoxUsuario2()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlCommand cmd = new SqlCommand(@"SELECT tbLogin.cod_login AS [CODIGO], tbLogin.nome_login AS [NOME] FROM tbLogin 
                                              INNER JOIN tbUsuario ON tbLogin.cod_login =tbUsuario.cod_login 
                                              WHERE tbUsuario.ativacao_usuario = 0 ", con);

            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CODIGO", typeof(int));
                dt.Columns.Add("NOME", typeof(string));
                dt.Load(reader);

                cboUsuario2.ValueMember = "CODIGO";
                cboUsuario2.DisplayMember = "NOME";
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "";
                dt.Rows.InsertAt(topItem, 0);
                cboUsuario2.DataSource = dt;
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

        void PreencherComboBoxUsuario3()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT cod_login AS [CODIGO], nome_login AS [NOME] FROM tbLogin", con);
            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CODIGO", typeof(int));
                dt.Columns.Add("NOME", typeof(string));
                dt.Load(reader);

                cboUsuario2.ValueMember = "CODIGO";
                cboUsuario2.DisplayMember = "NOME";
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "";
                dt.Rows.InsertAt(topItem, 0);
                cboUsuario2.DataSource = dt;
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


        private void btnConfirmarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(StringConexao.connectionString);
                con.Open();
                string cmdNS;
                int codlogin = cboUsuario.SelectedIndex;
                
                cmdNS = "select senha from tbLogin where cod_login = " + codlogin + ";";
                SqlCommand passaword = new SqlCommand(cmdNS, con);
                SqlDataReader readerNS = passaword.ExecuteReader();
                if (readerNS.Read())
                {
                    string senha = Convert.ToString(readerNS["senha"]);
                    if (txtSenhaAntiga.Text == senha)
                    {
                        if (cboUsuario.Text == "" || txtSenhaAntiga.Text == "" || txtSenhaNew.Text == "" || txtSenhaAntiga.Text == "Senha atual" || txtSenhaNew.Text == "Senha nova")
                        {
                            MessageBox.Show("Não foi possível criar um novo registro.", "Preencha todos os campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {

                            using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
                            {
                                sqlCon.Open();
                                SqlCommand sqlCmd = new SqlCommand("sp_update_senha", sqlCon);
                                sqlCmd.CommandType = CommandType.StoredProcedure;
                                sqlCmd.Parameters.AddWithValue("@nome_login", codlogin);
                                sqlCmd.Parameters.AddWithValue("@senha", txtSenhaNew.Text);
                                sqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Senha alterada com sucesso!", "Senha alterada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                sqlCon.Close();
                            }
                        }
                    }
                    else MessageBox.Show("Não foi possível mudar a senha.", "Senha atual incorreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void ExcluirUsuario()
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse usuário?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("sp_delete_usuario", sqlCon)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        sqlCmd.Parameters.AddWithValue("@cod_login", cboUsuario2.SelectedIndex);
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Usuário excluido com sucesso!", "Usuário removido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (cboUsuario2.SelectedIndex != -1 && cboUsuario2.SelectedIndex != 0)
            {
                ExcluirUsuario();
            }
            else
            {
                MessageBox.Show("Selecione um usuário para ser excluído.", "Nenhum usuário selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void VerificarUserLogado()
        {
            string cmdUser;
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    con.Open();
                    cmdUser = "select * from tbUsuario where ativacao_usuario = 1";
                    SqlCommand comUser = new SqlCommand(cmdUser, con);
                    SqlDataReader reader = comUser.ExecuteReader();
                    if (reader.Read()) //Se não colocasse aqui dava erro (se o reader ler algo, executa isso)
                    {
                        lblLogadoComo.Text = reader["nome_usuario"].ToString();
                        reader.Close();
                    }
                    else
                    {
                        lblLogadoComo.Text = "Erro";
                        reader.Close();
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnNovoUser_Click(object sender, EventArgs e)
        {
            using (novo_usuario _novo_usuario = new novo_usuario())
            {
                _novo_usuario.ShowDialog(this);
            }
        }
    }
}
