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
    public partial class inicio : UserControl
    {
        public inicio()
        {
            InitializeComponent();
            wbCotacoes.Navigate("www.google.com");
            //webBrowser1.Navigate(@".\Documentation\index.html");
        }

        private void btnProgresso_Click(object sender, EventArgs e)
        {

        }
    }
}
