﻿using System;
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
                string fornecedor, doenca, praga;
                if (cboDoenca.SelectedIndex == -1)
                {
                    doenca = cboDoenca.SelectedIndex.ToString();
                }
                else
                {
                    doenca = cboDoenca.SelectedValue.ToString();
                }

                if (cboPraga.SelectedIndex == -1)
                {
                    praga =  cboPraga.SelectedIndex.ToString();
                }
                else
                {
                    praga = cboPraga.SelectedValue.ToString();
                }

                if (cboFornecedor.SelectedIndex == -1)
                {
                    fornecedor = cboFornecedor.SelectedIndex.ToString();
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

                cboDoenca.DataSource = dt;
                cboDoenca.ValueMember = "CODIGO";
                cboDoenca.DisplayMember = "DOENCA";
                cboFornecedor.SelectedIndex = -1;
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

                cboPraga.DataSource = dt;
                cboPraga.ValueMember = "CODIGO";
                cboPraga.DisplayMember = "PRAGA";
                cboFornecedor.SelectedIndex = -1;
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
