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
    public partial class novo_defensivo : Form
    {
        public novo_defensivo()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            PreencherComboBox();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            /*string sql = "INSERT INTO tbDefensivo (cod_defensivo, nome_def, marca_def, desc_def, cod_praga, cod_doenca, cod_) ''  
            + "VALUES ('" + txtNome.Text + "', '" + txtEndereco.Text + "', '"
            + mskCep.Text + "', '" + txtBairro.Text
            + "', '" + txtCidade.Text + "', '" + txtUf.Text + "', '"
            + mskTelefone.Text + "')";*/

            /*SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();*/
        }

        void PreencherComboBox()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT cod_fornecedor AS [CODIGO], nome_fantasia AS [FORNECEDOR] FROM tbFornecedor", con);

            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CODIGO", typeof(int));
                dt.Columns.Add("FORNECEDOR", typeof(string));
                dt.Load(reader);

                cboFornecedor.ValueMember = "CODIGO";
                cboFornecedor.DisplayMember = "FORNECEDOR";
                cboFornecedor.DataSource = dt;
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

        private void cboFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
