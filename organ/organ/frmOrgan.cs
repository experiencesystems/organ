using organ.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organ
{
    public partial class frmOrgan : Form
    {
        public frmOrgan()
        {
            InitializeComponent();
            inicio1.BringToFront();
            inicio1.Dock = DockStyle.Fill;

            btnInicio.Image = Resources.home_100;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja sair dessa aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Deslogar();
                Application.Exit();
            }
        }

        void Deslogar()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    con.Open();
                    string deslogar = "UPDATE tbUsuario SET ativacao_usuario = 0 WHERE ativacao_usuario = 1;";//só teria um usuário logado
                    SqlCommand sair = new SqlCommand(deslogar, con);
                    sair.ExecuteScalar();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            pnlSelecionado.Visible = true;
            pnlSelecionado.Height = btnInicio.Height;
            pnlSelecionado.Top = btnInicio.Top;
            pnlSelecionado.BringToFront();
            inicio1.BringToFront();
            inicio1.Dock = DockStyle.Fill;

            //inicio
            btnInicio.Image = Resources.home_100;
            btnInicio.ForeColor = Color.White;
            //plantio
            btnPlantio.Image = Resources.plantio_45;
            btnPlantio.ForeColor = Color.FromArgb(121, 137, 131);
            //colheita
            btnColheita.Image = Resources.colheita_45_4;
            btnColheita.ForeColor = Color.FromArgb(121, 137, 131);
            //relatorios
            btnRelatorios.Image = Resources.relatorios_45_6;
            btnRelatorios.ForeColor = Color.FromArgb(121, 137, 131);
            //fazenda
            btnFazenda.Image = Resources.fazenda_45;
            btnFazenda.ForeColor = Color.FromArgb(121, 137, 131);
        }

        private void btnPlantio_Click(object sender, EventArgs e)
        {
            pnlSelecionado.Visible = true;
            pnlSelecionado.Height = btnPlantio.Height;
            pnlSelecionado.Top = btnPlantio.Top;
            pnlSelecionado.BringToFront();
            plantio1.BringToFront();
            plantio1.Dock = DockStyle.Fill;

            //inicio
            btnInicio.Image = Resources.house_45;
            btnInicio.ForeColor = Color.FromArgb(121, 137, 131);
            //plantio
            btnPlantio.Image = Resources.plantio_100_2;
            btnPlantio.ForeColor = Color.White;
            //colheita
            btnColheita.Image = Resources.colheita_45_4;
            btnColheita.ForeColor = Color.FromArgb(121, 137, 131);
            //relatorios
            btnRelatorios.Image = Resources.relatorios_45_6;
            btnRelatorios.ForeColor = Color.FromArgb(121, 137, 131);
            //fazenda
            btnFazenda.Image = Resources.fazenda_45;
            btnFazenda.ForeColor = Color.FromArgb(121, 137, 131);
        }

        private void btnColheita_Click(object sender, EventArgs e)
        {
            pnlSelecionado.Visible = true;
            pnlSelecionado.Height = btnColheita.Height;
            pnlSelecionado.Top = btnColheita.Top;
            pnlSelecionado.BringToFront();
            colheita1.BringToFront();
            colheita1.Dock = DockStyle.Fill;

            //inicio
            btnInicio.Image = Resources.house_45;
            btnInicio.ForeColor = Color.FromArgb(121, 137, 131);
            //plantio
            btnPlantio.Image = Resources.plantio_45;
            btnPlantio.ForeColor = Color.FromArgb(121, 137, 131);
            //colheita
            btnColheita.Image = Resources.colheita_100_4;
            btnColheita.ForeColor = Color.White;
            //relatorios
            btnRelatorios.Image = Resources.relatorios_45_6;
            btnRelatorios.ForeColor = Color.FromArgb(121, 137, 131);
            //fazenda
            btnFazenda.Image = Resources.fazenda_45;
            btnFazenda.ForeColor = Color.FromArgb(121, 137, 131);
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            pnlSelecionado.Visible = true;
            pnlSelecionado.Height = btnRelatorios.Height;
            pnlSelecionado.Top = btnRelatorios.Top;
            pnlSelecionado.BringToFront();
            relatorios1.BringToFront();
            relatorios1.Dock = DockStyle.Fill;

            //inicio
            btnInicio.Image = Resources.house_45;
            btnInicio.ForeColor = Color.FromArgb(121, 137, 131);
            //plantio
            btnPlantio.Image = Resources.plantio_45;
            btnPlantio.ForeColor = Color.FromArgb(121, 137, 131);
            //colheita
            btnColheita.Image = Resources.colheita_45_4;
            btnColheita.ForeColor = Color.FromArgb(121, 137, 131);
            //relatorios
            btnRelatorios.Image = Resources.relatorios_100_7;
            btnRelatorios.ForeColor = Color.White;
            //fazenda
            btnFazenda.Image = Resources.fazenda_45;
            btnFazenda.ForeColor = Color.FromArgb(121, 137, 131);
        }

        private void btnFazenda_Click(object sender, EventArgs e)
        {
            pnlSelecionado.Visible = true;
            pnlSelecionado.Height = btnFazenda.Height;
            pnlSelecionado.Top = btnFazenda.Top;
            pnlSelecionado.BringToFront();
            fazenda1.BringToFront();
            fazenda1.Dock = DockStyle.Fill;

            //inicio
            btnInicio.Image = Resources.house_45;
            btnInicio.ForeColor = Color.FromArgb(121, 137, 131);
            //plantio
            btnPlantio.Image = Resources.plantio_45;
            btnPlantio.ForeColor = Color.FromArgb(121, 137, 131);
            //colheita
            btnColheita.Image = Resources.colheita_45_4;
            btnColheita.ForeColor = Color.FromArgb(121, 137, 131);
            //relatorios
            btnRelatorios.Image = Resources.relatorios_45_6;
            btnRelatorios.ForeColor = Color.FromArgb(121, 137, 131);
            //fazenda
            btnFazenda.Image = Resources.fazenda_100;
            btnFazenda.ForeColor = Color.White;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            configuracao1.BringToFront();
            configuracao1.Dock = DockStyle.Fill;
            //deixando tudo como não selecionado
            pnlSelecionado.Visible = false;
            //inicio
            btnInicio.Image = Resources.house_45;
            btnInicio.ForeColor = Color.FromArgb(121, 137, 131);
            //plantio
            btnPlantio.Image = Resources.plantio_45;
            btnPlantio.ForeColor = Color.FromArgb(121, 137, 131);
            //colheita
            btnColheita.Image = Resources.colheita_45_4;
            btnColheita.ForeColor = Color.FromArgb(121, 137, 131);
            //relatorios
            btnRelatorios.Image = Resources.relatorios_45_6;
            btnRelatorios.ForeColor = Color.FromArgb(121, 137, 131);
            //fazenda
            btnFazenda.Image = Resources.fazenda_45;
            btnFazenda.ForeColor = Color.FromArgb(121, 137, 131);
        }
    }
}
