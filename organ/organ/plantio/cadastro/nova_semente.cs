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
    public partial class nova_semente : Form
    {
        public nova_semente()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            PreencherComboBox();
            CarregaUnidadeMedida();
            CarregaTipoSolo();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" || nupIncSolar.Text != "0,00" || cboFornecedor.SelectedIndex != -1 || mskQuantidade.Text != "" ||
            nupIncVento.Text != "0,00" || nupAcidez.Text != "0,00")
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
            cboTipoSolo.Text = "";
            nupIncSolar.Text = "0,00";
            cboFornecedor.SelectedIndex = -1;
            mskQuantidade.Text = "";
            nupIncVento.Text = "0,00";
            nupAcidez.Text = "0,00";
        }

        public void CarregaUnidadeMedida()
        {
            string[] unidade_medida = { "un", "Kg", "g", "mL", "L" };

            for (int i = 0; i != unidade_medida.Length; i++)
            {
                cboUnidadeMedida.Items.Add(unidade_medida[i]);
            }
            cboUnidadeMedida.SelectedIndex = 0;

        }

        public void CarregaTipoSolo()
        {
            string[] solo = {"Argiloso","Arenoso", "Humoso", "Calcário", "Terra roxa"};

            for (int i = 0; i != solo.Length; i++)
            {
                cboTipoSolo.Items.Add(solo[i]);
            }
            cboTipoSolo.SelectedIndex = 0;

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
                cboFornecedor.SelectedIndex = -1;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || mskQuantidade.Text == "" || cboUnidadeMedida.Text == "")
            {
                MessageBox.Show("Preencha todos os campos requeridos.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Semente s = new Semente(txtNome.Text, cboTipoSolo.Text, Convert.ToDouble(nupAcidez.Text), Convert.ToDouble(nupIncVento.Text), Convert.ToDouble(nupIncSolar.Text), Convert.ToInt16(mskQuantidade.Text), Convert.ToInt16(cboFornecedor.SelectedValue), cboUnidadeMedida.Text);
                s.RegistrarSemente(s);
            }
        }
    }
}
