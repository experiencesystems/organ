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
    public partial class novo_relatorio : Form
    {
        public novo_relatorio()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string usuario;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            con.Open();
            string cmdUser = "select * from tbUsuario where ativacao_usuario = 1";
            SqlCommand comUser = new SqlCommand(cmdUser, con);
            SqlDataReader reader = comUser.ExecuteReader();
            if (reader.Read()) //Se não colocasse aqui dava erro (se o reader ler algo, executa isso)
            {
                usuario = reader["cod_funcionario"].ToString();
                reader.Close();
            }
            else
            {
                reader.Close();
            }

            SqlCommand cmd = new SqlCommand("SP_INSERT_RELATORIO", con);
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            cmd.Parameters.Add("@TITULO_REL", SqlDbType.VarChar).Value = txtTitulo.Text;
            cmd.Parameters.Add("@DESC_REL", SqlDbType.VarChar).Value = rtxtDescricao.Text;
            cmd.Parameters.Add("@COD_FUNCIONARIO", SqlDbType.Int).Value = Convert.ToInt16(usuario);
            

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Relatório registrado com sucesso!", "Cadastro finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
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
