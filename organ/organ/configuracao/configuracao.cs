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
using Microsoft.Win32;

namespace organ
{
    public partial class configuracao : UserControl
    {
        public configuracao()
        {
            InitializeComponent();
            VerificarUserLogado();
        }

        protected override void OnCreateControl()
        {

            try
            {
                //Exibe Campo caso esteja como administrador
                RegistryKey startupKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                ckbAbrirIniciar.Visible = true;
            }
            catch { }

            base.OnCreateControl();
        }

        private void llblGerenciamentoContas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string cmdCodUser;
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    con.Open();
                    cmdCodUser = "select * from tbUsuario where cod_usuario = 1 and ativacao_usuario = 1;";//adm
                    SqlCommand comUser = new SqlCommand(cmdCodUser, con);
                    SqlDataReader reader = comUser.ExecuteReader();
                    if (reader.Read()) //Se não colocasse aqui dava erro (se o reader ler algo, executa isso)
                    {
                        using (gerenciamento_contas _gerenciamento_contas = new gerenciamento_contas())
                        {
                            _gerenciamento_contas.ShowDialog(this);
                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Você não tem permissão para acessar.", "Sem permissão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        reader.Close();
                    }
                }
                catch (Exception c)
                {
                    throw new Exception(c.Message);
                }
                finally
                {
                    con.Close();
                }
            }

            //gerenciamento_contas1.Visible = true;
            //gerenciamento_contas1.Dock = DockStyle.Fill;
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

        public static void AbrirIniciar(bool OnOff)
        {
            try
            {
                //Nome a ser exibido no registro ou quando Der MSCONFIG - Pode Alterar
                string appName = "organ";
                string runKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

                //Diretorio da chave do Registro NAO ALTERAR


                //Abre o registro
                RegistryKey startupKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                //Valida se vai incluir o iniciar com o Windows ou remover
                if (OnOff)//Iniciar
                {
                    if (startupKey.GetValue(appName) == null)
                    {
                        // Add startup reg key
                        startupKey.SetValue(appName, @"""" + Application.ExecutablePath.ToString() + @"""");
                        startupKey.Close();
                    }
                }
                else//Nao iniciar mais
                {
                    // remove startup
                    startupKey = Registry.LocalMachine.OpenSubKey(runKey, true);
                    startupKey.DeleteValue(appName, false);
                    startupKey.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ckbAbrirIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string appName = "Organ";
                string runKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
                RegistryKey startupKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                if (startupKey.GetValue(appName) == startupKey.GetValue(appName))
                {
                    ckbAbrirIniciar.Checked = true;
                }
                else
                {
                    switch (ckbAbrirIniciar.CheckState)
                    {
                        case CheckState.Checked:
                            if (startupKey.GetValue(appName) == null)
                            {
                                // Add startup reg key
                                startupKey.SetValue(appName, @"""" + Application.ExecutablePath.ToString() + @"""");
                                startupKey.Close();
                            }
                            break;
                        case CheckState.Unchecked:
                            startupKey = Registry.LocalMachine.OpenSubKey(runKey, true);
                            startupKey.DeleteValue(appName, false);
                            startupKey.Close();
                            break;

                        case CheckState.Indeterminate:
                            startupKey = Registry.LocalMachine.OpenSubKey(runKey, true);
                            startupKey.DeleteValue(appName, false);
                            startupKey.Close();
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Você deve executar o programa como administrador para definir essa opção.", "Não foi possível completar a operação requisitada.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFaleConosco_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acesse o site moreexpsystems.cs!", "Só que esse site não existe...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void llblSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja sair dessa aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Deslogar();
                Application.Restart();
            }
        }

        void Deslogar()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    con.Open();
                    string deslogar = "UPDATE tbUsuario SET ativacao_usuario = 0 WHERE ativacao_usuario = 1;";//só teria um usuário logado
                    SqlCommand sair = new SqlCommand(deslogar, con);
                    sair.ExecuteScalar();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
