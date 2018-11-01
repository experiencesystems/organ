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
    public partial class sementes : UserControl
    {
        public sementes()
        {
            InitializeComponent();
            nova_semente1.Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            nova_semente1.Visible = true;
            nova_semente1.Dock = DockStyle.Fill;
        }
    }
}
