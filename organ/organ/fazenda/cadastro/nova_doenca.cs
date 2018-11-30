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
    public partial class nova_doenca : Form
    {
        public nova_doenca()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            PreencherComboBox();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" || rtxtDescricao.Text != "" || cboSemente.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja voltar? Você irá perder todas as informações preenchidas.",
                                                      "Voltar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    LimparCampos();
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        void LimparCampos()
        {
            txtNome.Text = "";
            rtxtDescricao.Text = "";
            cboSemente.SelectedIndex = -1;
        }

        void PreencherComboBox()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT cod_semente AS [CODIGO], nome_sem AS [SEMENTE] from tbSemente", con);

            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CODIGO", typeof(int));
                dt.Columns.Add("SEMENTE", typeof(string));
                dt.Load(reader);

                cboSemente.ValueMember = "CODIGO";
                cboSemente.DisplayMember = "SEMENTE";
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "";
                dt.Rows.InsertAt(topItem, 0);
                cboSemente.DataSource = dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || cboSemente.Text == "")
            {
                MessageBox.Show("Preencha todos os campos requeridos.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string semente = cboSemente.SelectedValue.ToString();
                Doenca d = new Doenca(txtNome.Text, rtxtDescricao.Text, Convert.ToInt16(semente));
                d.RegistrarDoenca(d);
            }
        }
    }
}
