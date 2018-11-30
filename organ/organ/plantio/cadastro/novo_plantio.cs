using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace organ
{
    public partial class novo_plantio : UserControl
    {

        public novo_plantio()
        {
            InitializeComponent();
            PreencherComboBoxSemente();
            PreencherComboBoxFuncionario();
            PreencherComboBoxFuncionario2();
            PreencherComboBoxFuncionario3();
            PreencherComboBoxFertilizante();
            PreencherComboBoxDefensivo();
            PreencherComboBoxTalhoes();
            PreencherComboBoxTalhoes2();
            PreencherComboBoxTalhoes3();
            btnLimpar.PerformClick();
        }

        DateTime hoje = DateTime.Now;

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" || cboSemente.SelectedIndex != -1 || mskQntSemente.Text != "" || mskQntDefensivo.Text != "" ||
                mskQntFertilizante.Text != "" || cboFertilizante.SelectedIndex != -1 || cboDefensivo.SelectedIndex != -1 ||
                cboTalhao1.SelectedIndex != -1 || cboTalhao2.SelectedIndex != -1 || cboTalhao3.SelectedIndex != -1 ||
                cboFuncionario1.SelectedIndex != -1|| cboFuncionario2.SelectedIndex != -1 || cboFuncionario3.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja voltar? Você irá perder todas as informações preenchidas.",
                                                      "Voltar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    btnLimpar.PerformClick();
                    this.Hide();
                }
            }
            else
            {
                this.Hide();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cboSemente.SelectedIndex = -1;
            mskQntSemente.Text = "";
            cboFertilizante.SelectedIndex = -1;
            mskQntFertilizante.Text = "";
            cboDefensivo.SelectedIndex = -1;
            mskQntDefensivo.Text = "";
            cboTalhao1.SelectedIndex = -1;
            cboTalhao2.SelectedIndex = -1;
            cboTalhao3.SelectedIndex = -1;
            cboFuncionario1.SelectedIndex = -1;
            cboFuncionario2.SelectedIndex = -1;
            cboFuncionario3.SelectedIndex = -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboSemente.Text == "" || mskQntSemente.Text == "" || dtDataColheita.Text == "" || cboTalhao1.Text == "" || cboFuncionario1.Text == "")
            {
                MessageBox.Show("Preencha todos os campos requeridos.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cboFertilizante.Text != "" && mskQntFertilizante.Text == "")
            {
                MessageBox.Show("Insira a quantidade utilizada do fertilizante selecionado.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cboDefensivo.Text != "" && mskQntDefensivo.Text == "")
            {
                MessageBox.Show("Insira a quantidade utilizada do defensivo selecionado.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((cboFuncionario1.SelectedIndex == cboFuncionario2.SelectedIndex && cboFuncionario2.Text != "") || (cboFuncionario1.SelectedIndex == cboFuncionario3.SelectedIndex && cboFuncionario3.Text != "") || (cboFuncionario2.SelectedIndex == cboFuncionario3.SelectedIndex && cboFuncionario2.Text != "" && cboFuncionario3.Text != ""))
            {
                MessageBox.Show("Selecione funcionários diferentes para a colheita.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((cboTalhao1.SelectedIndex == cboTalhao2.SelectedIndex && cboTalhao2.Text != "") || (cboTalhao1.SelectedIndex == cboTalhao3.SelectedIndex && cboTalhao3.Text != "") || (cboTalhao2.SelectedIndex == cboTalhao3.SelectedIndex && cboTalhao2.Text != "" && cboTalhao3.Text != ""))
            {
                MessageBox.Show("Selecione talhões diferentes para a colheita.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtDataColheita.Value <= hoje)
            {
                MessageBox.Show("Selecione uma data válida na data da colheita.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ConverteValoresCBO();
                Plantio p = new Plantio(txtNome.Text, dtDataColheita.Text, Convert.ToInt16(func1), Convert.ToInt16(func2), Convert.ToInt16(func3), Convert.ToInt16(semente), Convert.ToInt32(mskQntSemente.Text), Convert.ToInt16(fertilizante), mskQntFertilizante.Text, Convert.ToInt16(defensivo), mskQntDefensivo.Text, Convert.ToInt16(talhao1), Convert.ToInt16(talhao2), Convert.ToInt16(talhao3));
                p.NovoPlantio(p);
            }
        }

        string semente, fertilizante, defensivo, talhao1, talhao2, talhao3, func1, func2, func3;

        void ConverteValoresCBO()
        {
            semente = cboSemente.SelectedValue.ToString();
            talhao1 = cboTalhao1.SelectedValue.ToString();
            func1 = cboFuncionario1.SelectedValue.ToString();

            if (cboFertilizante.SelectedIndex == -1)//selected index é oq deixa o campo vazio
            {
                fertilizante = cboFertilizante.SelectedIndex.ToString();//ai deixaria como -1 para mudar pra nulo lá na classe plantio
            }
            else
            {//se nao for converte o object selectedvalue (que pega o valuemember) para string para depois converter para numero quando chama o método
                fertilizante = cboFertilizante.SelectedValue.ToString();
            }

            if (cboDefensivo.SelectedIndex == -1)
            {
                defensivo = cboDefensivo.SelectedIndex.ToString();
            }
            else
            {
                defensivo = cboDefensivo.SelectedValue.ToString();
            }

            if (cboFuncionario2.SelectedIndex == -1)
            {
                func2 = cboFuncionario2.SelectedIndex.ToString();
            }
            else
            {
                func2 = cboFuncionario2.SelectedValue.ToString();
            }

            if (cboFuncionario3.SelectedIndex == -1)
            {
                func3 = cboFuncionario3.SelectedIndex.ToString();
            }
            else
            {
                func3 = cboFuncionario3.SelectedValue.ToString();
            }

            if (cboTalhao2.SelectedIndex == -1)
            {
                talhao2 = cboTalhao2.SelectedIndex.ToString();
            }
            else
            {
                talhao2 = cboTalhao2.SelectedValue.ToString();
            }

            if (cboTalhao3.SelectedIndex == -1)
            {
                talhao3 = cboTalhao3.SelectedIndex.ToString();
            }
            else
            {
                talhao3 = cboTalhao3.SelectedValue.ToString();
            }
        }

        void PreencherComboBoxFuncionario()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT cod_funcionario AS [CODIGO], nome_func AS [FUNCIONARIO] " +
                                            "FROM tbFuncionario " +
                                            "WHERE status_func = 'Ativo'", con);
            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CODIGO", typeof(int));
                dt.Columns.Add("FUNCIONARIO", typeof(string));
                dt.Load(reader);

                cboFuncionario1.ValueMember = "CODIGO";
                cboFuncionario1.DisplayMember = "FUNCIONARIO";
                cboFuncionario1.SelectedIndex = -1;
                cboFuncionario1.DataSource = dt;
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

        void PreencherComboBoxFuncionario2()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT cod_funcionario AS [CODIGO], nome_func AS [FUNCIONARIO] " +
                                            "FROM tbFuncionario " +
                                            "WHERE status_func = 'Ativo'", con);
            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CODIGO", typeof(int));
                dt.Columns.Add("FUNCIONARIO", typeof(string));
                dt.Load(reader);

                cboFuncionario2.ValueMember = "CODIGO";
                cboFuncionario2.DisplayMember = "FUNCIONARIO";
                cboFuncionario2.SelectedIndex = -1;
                cboFuncionario2.DataSource = dt;
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

        void PreencherComboBoxFuncionario3()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT cod_funcionario AS [CODIGO], nome_func AS [FUNCIONARIO] " +
                                            "FROM tbFuncionario " +
                                            "WHERE status_func = 'Ativo'", con);
            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CODIGO", typeof(int));
                dt.Columns.Add("FUNCIONARIO", typeof(string));
                dt.Load(reader);

                cboFuncionario3.ValueMember = "CODIGO";
                cboFuncionario3.DisplayMember = "FUNCIONARIO";
                cboFuncionario3.SelectedIndex = -1;
                cboFuncionario3.DataSource = dt;
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

        void PreencherComboBoxSemente()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT S.cod_semente AS [CODIGO], S.nome_sem AS [SEMENTE] "+
                                            "FROM tbSemente S "+
                                            "INNER JOIN tbEstoque E ON S.cod_estoque = E.cod_estoque "+
                                            "WHERE E.qtd_estoque > 0", con);
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
                cboSemente.SelectedIndex = -1;
                cboSemente.DataSource = dt;
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

        void PreencherComboBoxFertilizante()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT F.cod_fertilizante AS [CODIGO], F.nome_fert AS [FERTILIZANTE] " +
                                            "FROM tbFertilizante F "+
                                            "INNER JOIN tbEstoque E ON F.cod_estoque = E.cod_estoque " +
                                            "WHERE E.qtd_estoque > 0", con);
            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CODIGO", typeof(int));
                dt.Columns.Add("FERTILIZANTE", typeof(string));
                dt.Load(reader);

                cboFertilizante.ValueMember = "CODIGO";
                cboFertilizante.DisplayMember = "FERTILIZANTE";
                cboFertilizante.SelectedIndex = -1;
                cboFertilizante.DataSource = dt;
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

        void PreencherComboBoxDefensivo()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT D.cod_defensivo AS [CODIGO], D.nome_def AS [DEFENSIVO] " +
                                            "FROM tbDefensivo D "+
                                            "INNER JOIN tbEstoque E ON D.cod_estoque = E.cod_estoque " +
                                            "WHERE E.qtd_estoque > 0", con);
            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CODIGO", typeof(int));
                dt.Columns.Add("DEFENSIVO", typeof(string));
                dt.Load(reader);

                cboDefensivo.ValueMember = "CODIGO";
                cboDefensivo.DisplayMember = "DEFENSIVO";
                cboDefensivo.SelectedIndex = -1;
                cboDefensivo.DataSource = dt;
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

        void PreencherComboBoxTalhoes()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT cod_talhao AS [CODIGO], nome_tal AS [TALHAO] " +
                                            "FROM tbTalhao " +
                                            "WHERE disponivel_tal = 'Disponivel'", con);
            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add("CODIGO", typeof(int));
                dt.Columns.Add("TALHAO", typeof(string));
                dt.Load(reader);

                cboTalhao1.ValueMember = "CODIGO";
                cboTalhao1.DisplayMember = "TALHAO";
                cboTalhao1.SelectedIndex = -1;
                cboTalhao1.DataSource = dt;
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

        void PreencherComboBoxTalhoes2()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT cod_talhao AS [CODIGO], nome_tal AS [TALHAO] " +
                                            "FROM tbTalhao " +
                                            "WHERE disponivel_tal = 'Disponivel'", con);
            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add("CODIGO", typeof(int));
                dt.Columns.Add("TALHAO", typeof(string));
                dt.Load(reader);

                cboTalhao2.ValueMember = "CODIGO";
                cboTalhao2.DisplayMember = "TALHAO";
                cboTalhao2.SelectedIndex = -1;
                cboTalhao2.DataSource = dt;
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

        void PreencherComboBoxTalhoes3()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT cod_talhao AS [CODIGO], nome_tal AS [TALHAO] " +
                                            "FROM tbTalhao " +
                                            "WHERE disponivel_tal = 'Disponivel'", con);
            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add("CODIGO", typeof(int));
                dt.Columns.Add("TALHAO", typeof(string));
                dt.Load(reader);

                cboTalhao3.ValueMember = "CODIGO";
                cboTalhao3.DisplayMember = "TALHAO";
                cboTalhao3.SelectedIndex = -1;
                cboTalhao3.DataSource = dt;
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            PreencherComboBoxDefensivo();
            PreencherComboBoxFertilizante();
            PreencherComboBoxFuncionario();
            PreencherComboBoxFuncionario2();
            PreencherComboBoxFuncionario3();
            PreencherComboBoxSemente();
            PreencherComboBoxTalhoes();
            PreencherComboBoxTalhoes2();
            PreencherComboBoxTalhoes3();
        }
    }
}
