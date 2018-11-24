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
                txtSite.Text != "" || mskCEP.Text != "" || txtEndereco.Text != "" || mskNumero.Text != "" || txtBairro.Text != "" ||
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

            if (txtNome.Text == "" || mskCNPJ.Text == "" || mskCEP.Text == "" || txtEndereco.Text == "" || mskNumero.Text == "" || txtBairro.Text == "" ||
                   txtCidade.Text == "" || cboUF.Text == "")
            {
                MessageBox.Show("Preencha todos os campos requeridos.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (CPF_CNPJ.IsValid(CNPJ))
            {
                Fornecedor fornecedor = new Fornecedor(txtNome.Text, txtRazaoSocial.Text, Convert.ToInt64(mskCNPJ.Text), Convert.ToInt32(mskTel.Text), txtEmail.Text, txtSite.Text, mskCEP.Text, Convert.ToInt16(mskNumero.Text), txtEndereco.Text, txtBairro.Text, txtComplemento.Text, txtCidade.Text, cboUF.Text);
                fornecedor.RegistrarFornecedor(fornecedor);
            }
            else
            {
                MessageBox.Show("Digite um CNPJ válido.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
