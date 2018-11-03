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
    public partial class ferramentas : UserControl
    {
        public ferramentas()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (nova_ferramenta _nova_ferramenta = new nova_ferramenta())
            {
                _nova_ferramenta.ShowDialog(this);
            }
        }
    }
}
