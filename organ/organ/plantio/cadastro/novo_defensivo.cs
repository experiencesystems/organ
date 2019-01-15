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
            PreencherComboBoxFornecedor();
            PreencherComboBoxDoenca();
            PreencherComboBoxPraga();
            CarregaUnidadeMedida();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" || txtDescricao.Text != "" || txtMarca.Text != "" || cboFornecedor.SelectedIndex != -1 || mskQuantidade.Text != ""||
                cboDoenca.SelectedIndex != -1 || cboPraga.SelectedIndex != -1)
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
            txtDescricao.Text = "";
            cboFornecedor.SelectedIndex = -1;
            cboPraga.SelectedIndex = -1;
            cboDoenca.SelectedIndex = -1;
            txtMarca.Text = "";
            mskQuantidade.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || mskQuantidade.Text == "" || cboUnidadeMedida.Text == "")
            {
                MessageBox.Show("Preencha todos os campos requeridos.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string fornecedor, doenca, praga;
                if (cboDoenca.Text == "")
                {
                    doenca = "-1";
                }
                else
                {
                    doenca = cboDoenca.SelectedValue.ToString();
                }

                if (cboPraga.Text == "")
                {
                    praga = "-1";
                }
                else
                {
                    praga = cboPraga.SelectedValue.ToString();
                }

                if (cboFornecedor.Text == "")
                {
                    fornecedor = "-1";
                }
                else
                {
                    fornecedor = cboFornecedor.SelectedValue.ToString();
                }

                Defensivo d = new Defensivo(txtNome.Text, txtDescricao.Text, txtMarca.Text, Convert.ToInt16(doenca), Convert.ToInt16(praga), Convert.ToInt16(fornecedor), Convert.ToInt32(mskQuantidade.Text), cboUnidadeMedida.Text);
                d.RegistrarDefensivo(d);
            }
        }
        

        void PreencherComboBoxFornecedor()
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
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "";
                dt.Rows.InsertAt(topItem, 0);
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

        void PreencherComboBoxDoenca()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT cod_doenca AS [CODIGO], nome_doenca AS [DOENCA] FROM tbDoenca", con);

            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CODIGO", typeof(int));
                dt.Columns.Add("DOENCA", typeof(string));
                dt.Load(reader);

                cboDoenca.ValueMember = "CODIGO";
                cboDoenca.DisplayMember = "DOENCA";
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "";
                dt.Rows.InsertAt(topItem, 0);
                cboDoenca.DataSource = dt;
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

        void PreencherComboBoxPraga()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT cod_praga AS [CODIGO], nome_praga AS [PRAGA] FROM tbPraga", con);

            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CODIGO", typeof(int));
                dt.Columns.Add("PRAGA", typeof(string));
                dt.Load(reader);

                cboPraga.ValueMember = "CODIGO";
                cboPraga.DisplayMember = "PRAGA";
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "";
                dt.Rows.InsertAt(topItem, 0);
                cboPraga.DataSource = dt;
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
    }
}
