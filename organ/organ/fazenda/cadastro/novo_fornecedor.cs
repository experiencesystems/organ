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
    public partial class novo_fornecedor : Form
    {
        List<Fornecedor> lista = new List<Fornecedor>();

        public novo_fornecedor()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            carregaEstado();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" || txtRazaoSocial.Text != "" || mskCNPJ.Text != "" || mskTel.Text != "" || txtEmail.Text != "" ||
                txtSite.Text != "" || mskCEP.Text != "" || txtEndereco.Text != "" || txtNumero.Text != "" || txtBairro.Text != "" ||
                txtCidade.Text != "" || txtComplemento.Text != "")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja voltar? Você irá perder todas as informações preenchidas.",
                                                      "Voltar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        public void carregaEstado()
        {
            string[] estados = {"AC","AL","AP","AM","BA","CE","DF","ES","GO","MA","MT","MS","MG","PA","PB","PR","PE","PI","RJ","RN",
                 "RS","RO","RR","SC","SP","SE","TO"};

            for (int i = 0; i != estados.Length; i++)
            {
                cboUF.Items.Add(estados[i]);
            }
            cboUF.SelectedIndex = 0;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string CNPJ = mskCNPJ.Text;

            if (txtNome.Text == "" || mskCNPJ.Text == "" || mskCEP.Text == "" || txtEndereco.Text == "" || txtNumero.Text == "" || txtBairro.Text == "" ||
                   txtCidade.Text == "" || cboUF.Text == "")
            {
                MessageBox.Show("Preencha todos os campos requeridos.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (CPF_CNPJ.IsValid(CNPJ))
            {
                RegistrarFornecedor();
            }
            else
            {
                MessageBox.Show("Digite um CNPJ válido.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void RegistrarFornecedor()
        {
            /*"EXEC SP_INSERT_FORNECEDOR " + mskCEP.Text + ", " + txtNumero.Text + ", '" + txtEndereco.Text + "', '" + txtBairro.Text + "', '" +
                                                    txtComplemento.Text + "', '" + txtCidade.Text + "', '" + cboUF.Text + "', '" + txtNome.Text + "', " +
                                                    mskCNPJ.Text + ", '" + txtRazaoSocial.Text + "', " + mskTel.Text + ", '" + txtEmail.Text + "', '" +
                                                    txtSite.Text + "'; ";*/

            SqlConnection con = new SqlConnection(StringConexao.connectionString);

            SqlCommand cmd = new SqlCommand("SP_INSERT_FORNECEDOR", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@CEP", SqlDbType.Int).Value = Convert.ToInt32(mskCEP.Text);
            cmd.Parameters.Add("@NUMERO", SqlDbType.Int).Value = Convert.ToInt16(txtNumero.Text);
            cmd.Parameters.Add("@RUA", SqlDbType.VarChar).Value = txtEndereco.Text;
            cmd.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = txtBairro.Text;
            cmd.Parameters.Add("@COMPLEMENTO", SqlDbType.VarChar).Value = txtComplemento.Text;
            cmd.Parameters.Add("@CIDADE", SqlDbType.VarChar).Value = txtCidade.Text;
            cmd.Parameters.Add("@UF", SqlDbType.Char).Value = cboUF.Text;
            cmd.Parameters.Add("@NOME_FANTASIA", SqlDbType.VarChar).Value = txtNome.Text;
            cmd.Parameters.Add("@CNPJ_FORN", SqlDbType.NVarChar).Value = Convert.ToInt64(mskCNPJ.Text);
            cmd.Parameters.Add("@RAZAO_SOCIAL", SqlDbType.VarChar).Value = txtRazaoSocial.Text;
            cmd.Parameters.Add("@TEL_FORN", SqlDbType.NVarChar).Value = Convert.ToInt64(mskTel.Text);
            cmd.Parameters.Add("@EMAIL_FORN", SqlDbType.VarChar).Value = txtEmail.Text;
            cmd.Parameters.Add("@SITE_FORN", SqlDbType.VarChar).Value = txtSite.Text;

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Fornecedor registrado com sucesso!", "Cadastro finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro: " + e.ToString());
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
