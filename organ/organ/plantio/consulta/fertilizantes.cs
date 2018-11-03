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
    public partial class fertilizantes : UserControl
    {
        public fertilizantes()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (novo_fertilizante _novo_fertilizante = new novo_fertilizante())
            {
                _novo_fertilizante.ShowDialog(this);
            }
        }
    }
}
