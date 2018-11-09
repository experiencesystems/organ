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
        string connectionString = @"Data Source=LAB2PC12\SA;Initial Catalog=dbOrgan;Persist Security Info=True;User ID=sa;Password=1234567";

        public novo_defensivo()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

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
    }
}
