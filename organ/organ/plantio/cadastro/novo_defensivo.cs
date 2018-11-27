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
            PreencherComboBoxPraga();
            PreencherComboBoxDoenca();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || mskQuantidade.Text == "" || cboUnidadeMedida.Text == "")
            {
                MessageBox.Show("Preencha todos os campos requeridos.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Defensivo d = new  Defensivo(txtNome.Text, txtDescricao.Text, txtMarca.Text, Convert.ToInt16(mskQuantidade.Text), Convert.ToInt16(cboFornecedor.ValueMember), Convert.ToInt16(cboPraga.ValueMember), Convert.ToInt16(cboDoenca.ValueMember), cboUnidadeMedida.Text);
                d.RegistrarDefensivo(d);
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

                cboPraga.ValueMember = "CODIGO";
                cboPraga.DisplayMember = "DOENCA";
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
    }
}
