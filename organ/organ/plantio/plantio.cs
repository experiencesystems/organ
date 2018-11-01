using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organ
{
    public partial class plantio : UserControl
    {
        public plantio()
        {
            InitializeComponent();
        }

        private void plantio_Load(object sender, EventArgs e)
        {
            novo_plantio1.Visible = false;
            sementes1.Visible = false;
            fertilizantes1.Visible = false;
            solo1.Visible = false;
            maquinas1.Visible = false;
            ferramentas1.Visible = false;
            defensivo1.Visible = false;
        }

        private void btnNovoPlantio_Click(object sender, EventArgs e)
        {
            novo_plantio1.Visible = true;
            novo_plantio1.Dock = DockStyle.Fill;
        }

        private void btnFertilizantes_Click(object sender, EventArgs e)
        {
            fertilizantes1.Visible = true;
            fertilizantes1.Dock = DockStyle.Fill;
        }

        private void btnSementes_Click(object sender, EventArgs e)
        {
            sementes1.Visible = true;
            sementes1.Dock = DockStyle.Fill;
        }

        private void btnSolo_Click(object sender, EventArgs e)
        {
            solo1.Visible = true;
            solo1.Dock = DockStyle.Fill;
        }

        private void btnMaquinas_Click(object sender, EventArgs e)
        {
            maquinas1.Visible = true;
            maquinas1.Dock = DockStyle.Fill;
        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {
            ferramentas1.Visible = true;
            ferramentas1.Dock = DockStyle.Fill;
        }

        private void btnDefensivo_Click(object sender, EventArgs e)
        {
            defensivo1.Visible = true;
            defensivo1.Dock = DockStyle.Fill;
        }
    }
}
