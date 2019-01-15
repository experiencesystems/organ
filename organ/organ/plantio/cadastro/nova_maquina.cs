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
    public partial class nova_maquina : Form
    {
        public nova_maquina()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            PreencherComboBox();
            CarregaUnidadeMedida();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text != "" || rtxtDescricao.Text != "" || txtMarca.Text != "" || cboFornecedor.SelectedIndex != -1 || mskQuantidade.Text != "")
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
            txtModelo.Text = "";
            rtxtDescricao.Text = "";
            cboFornecedor.SelectedIndex = -1;
            txtMarca.Text = "";
            mskQuantidade.Text = "";
        }

        public void CarregaUnidadeMedida()
        {
            string[] unidade_medida = { "un" };

            for (int i = 0; i != unidade_medida.Length; i++)
            {
                cboUnidadeMedida.Items.Add(unidade_medida[i]);
            }
            cboUnidadeMedida.SelectedIndex = 0;

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

        /*private void cboFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = Convert.ToInt16(cboFornecedor.SelectedIndex);
        }*/

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text == "" || mskQuantidade.Text == "" || cboUnidadeMedida.Text == "" || cboFornecedor.Text == "")
            {
                MessageBox.Show("Preencha todos os campos requeridos.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Maquina m = new Maquina(txtModelo.Text, rtxtDescricao.Text, txtMarca.Text, Convert.ToInt16(mskQuantidade.Text), Convert.ToInt16(cboFornecedor.SelectedValue), cboUnidadeMedida.Text);
                m.RegistrarMaquina(m);
            }
        }
    }
}
