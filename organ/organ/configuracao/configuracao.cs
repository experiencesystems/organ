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
    public partial class configuracao : UserControl
    {
        public configuracao()
        {
            InitializeComponent();
        }

        private void llblGerenciamentoContas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gerenciamento_contas1.Visible = true;
            gerenciamento_contas1.Dock = DockStyle.Fill;
        }

        public void VerificarUserLogado()
        {
            string cmdUser;
            try
            {
                SqlConnection con = new SqlConnection(StringConexao.connectionString);
                con.Open();
                cmdUser = "select nome_usuario from tbUsuario where ativacao_usuario = 1";
                SqlCommand comUser = new SqlCommand(cmdUser, con);
                SqlDataReader reader = comUser.ExecuteReader();

                if (reader.Read()) //Se não colocasse aqui dava erro (se o reader ler algo, executa isso)
                {
                    lblLogadoComo.Text = reader["nome_usuario"].ToString();
                    reader.Close(); //Tem que fechar um reader para abrir outro
                }
                else
                {
                    lblLogadoComo.Text = "Erro";
                    reader.Close();
                } //Fechar um reader para abrir outro
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
