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
    public partial class doencas : UserControl
    {

        public doencas()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //fazenda.Metodo.MostrarPainelLateral();
            lblTelefone.LblEmail.Visible = true;
        }
    }
}
