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
        }

        DateTime hoje = DateTime.Now;
        
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            else if ((cboFuncionario1.ValueMember == cboFuncionario2.ValueMember && cboFuncionario2.Text != "") || (cboFuncionario1.ValueMember == cboFuncionario3.ValueMember && cboFuncionario3.Text != "") || (cboFuncionario2.ValueMember == cboFuncionario3.ValueMember && cboFuncionario2.Text != "" && cboFuncionario3.Text != ""))
            {
                MessageBox.Show("Selecione funcionários diferentes para a colheita.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((cboTalhao1.ValueMember == cboTalhao2.ValueMember && cboTalhao2.Text != "") || (cboTalhao1.ValueMember == cboTalhao3.ValueMember && cboTalhao3.Text != "") || (cboTalhao2.ValueMember == cboTalhao3.ValueMember && cboTalhao2.Text != "" && cboTalhao3.Text != ""))
            {
                MessageBox.Show("Selecione talhões diferentes para a colheita.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtDataColheita.Value <= hoje)
            {
                MessageBox.Show("Selecione uma data válida na data da colheita.", "Não foi possível criar um novo registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Plantio p = new Plantio(txtNome.Text, Convert.ToString(dtDataColheita.Text), cboFuncionario1.SelectedIndex, cboFuncionario2.SelectedIndex, cboFuncionario3.SelectedIndex, cboSemente.SelectedIndex, Convert.ToInt16(mskQntSemente.Text), cboFertilizante.SelectedIndex, Convert.ToInt16(mskQntFertilizante.Text), cboDefensivo.SelectedIndex, Convert.ToInt16(mskQntDefensivo.Text), cboTalhao1.SelectedIndex, cboTalhao2.SelectedIndex, cboTalhao3.SelectedIndex);
                p.NovoPlantio(p);
            }
        }

        void PreencherComboBoxFuncionario()
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT cod_funcionario AS [CODIGO], nome_func AS [FUNCIONARIO] " +
                                            "FROM tbFuncionario " +
                                            "/*WHERE status_funcionario = 1*/", con);
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
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "";
                dt.Rows.InsertAt(topItem, 0);
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
                                            "/*WHERE status_funcionario = 1*/", con);
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
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "";
                dt.Rows.InsertAt(topItem, 0);
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
                                            "/*WHERE status_funcionario = 1*/", con);
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
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "";
                dt.Rows.InsertAt(topItem, 0);
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
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "";
                dt.Rows.InsertAt(topItem, 0);
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
                                            "FROM tbFertilizante F " +
                                            "INNER JOIN tbEstoque E ON F.cod_estoque = F.cod_estoque " +
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
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "";
                dt.Rows.InsertAt(topItem, 0);
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
                                            "FROM tbDefensivo D " +
                                            "INNER JOIN tbEstoque E ON D.cod_estoque = D.cod_estoque " +
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
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "";
                dt.Rows.InsertAt(topItem, 0);
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
                                            "WHERE disponivel_tal = 1", con);
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
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "";
                dt.Rows.InsertAt(topItem, 0);
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
                                            "WHERE disponivel_tal = 1", con);
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
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "";
                dt.Rows.InsertAt(topItem, 0);
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
                                            "WHERE disponivel_tal = 1", con);
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
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "";
                dt.Rows.InsertAt(topItem, 0);
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cboFertilizante.SelectedIndex = 0;
            mskQntFertilizante.Text = "";
            cboDefensivo.SelectedIndex = 0;
            mskQntDefensivo.Text = "";
            cboTalhao2.SelectedIndex = 0;
            cboTalhao3.SelectedIndex = 0;
            cboFuncionario2.SelectedIndex = 0;
            cboFuncionario3.SelectedIndex = 0;
        }
    }
}
