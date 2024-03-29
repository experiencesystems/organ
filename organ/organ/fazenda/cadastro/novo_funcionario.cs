﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organ
{
    public partial class novo_funcionario : Form
    {
        public novo_funcionario()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            CarregaEstado();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" || mskCPF.Text != "" || mskRG.Text != "" || mskTelefone.Text != "" || mskCelular.Text != "" || 
                txtEmail.Text != "" || nupSalario.Text != "0,00" || txtCargo.Text != ""|| mskCEP.Text != "" || txtEndereco.Text != "" || 
                mskNumero.Text != "" || txtBairro.Text != "" || txtCidade.Text != "" || txtComplemento.Text != "")
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
            mskCPF.Text = "";
            mskRG.Text = "";
            mskTelefone.Text = "";
            mskCelular.Text = "";
            txtEmail.Text = "";
            nupSalario.Text = "0,00";
            txtCargo.Text = "";
            mskCEP.Text = "";
            txtEndereco.Text = "";
            mskNumero.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtComplemento.Text = "";
        }

        void CarregaEstado()
        {
            string[] estados = {"AC","AL","AP","AM","BA","CE","DF","ES","GO","MA","MT","MS","MG","PA","PB","PR","PE","PI","RJ","RN",
                 "RS","RO","RR","SC","SP","SE","TO"};

            for (int i = 0; i != estados.Length; i++)
            {
                cboUF.Items.Add(estados[i]);
            }
            cboUF.SelectedIndex = 0;

        }

        DateTime hoje = DateTime.Now;

        string salario;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            decimal x = nupSalario.Value;
            double y = decimal.ToDouble(x);
            salario = Convert.ToString(y);
            salario = salario.Replace(",", ".");

            //repeti o método pq sou insegura quanto aos meus códigos, é isso

            DateTime DataNascimento = dtDataNasc.Value;
            int anos = DateTime.Now.Year - DataNascimento.Year;
            
            if (DateTime.Now.Month < DataNascimento.Month || (DateTime.Now.Month == DataNascimento.Month && DateTime.Now.Day < DataNascimento.Day))
            {
                anos--;
            }
                Regex veremail = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (txtNome.Text == "" || mskCPF.Text == "" || mskRG.Text == "" || txtEndereco.Text == "" || mskNumero.Text == "" || mskCEP.Text == "" || 
                txtBairro.Text == "" || txtCidade.Text == "" || cboUF.Text == "" || txtCargo.Text == "" || nupSalario.Text == "0,00" || nupSalario.Text == "")
            {
                MessageBox.Show("Preencha todos os campos requeridos.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!CPF_CNPJ.IsValid(mskCPF.Text))
            {
                MessageBox.Show("Verifique se o CPF foi digitado corretamente.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtEmail.Text != "" && !veremail.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Verifique se o e-mail foi digitado corretamente.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (anos < 18)
            {
                MessageBox.Show("Digite uma data de nascimento válida.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {//registra, mas se telefones forem nulos nao le como int 64
                Funcionario f = new Funcionario(txtNome.Text, mskCPF.Text, mskRG.Text, mskTelefone.Text, mskCelular.Text, txtEmail.Text, txtCargo.Text, salario, dtDataNasc.Text, mskCEP.Text, Convert.ToInt16(mskNumero.Text), txtEndereco.Text, txtBairro.Text, txtComplemento.Text, txtCidade.Text, cboUF.Text);
                f.RegistrarFuncionario(f);
            }
        }

        private void nupSalario_ValueChanged(object sender, EventArgs e)
        {
            decimal x = nupSalario.Value;
            double y = decimal.ToDouble(x);
            salario = Convert.ToString(y);
            salario = salario.Replace(",", ".");
        }
    }
}
