using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace organ
{
    public partial class inicio : UserControl
    {
        public inicio()
        {
            InitializeComponent();
            /*StreamReader reader = new StreamReader("Resources\\cotacao.html");
            wbCotacoes.DocumentText = reader.ReadToEnd();
            StreamReader reader2 = new StreamReader("Resources\\clima.html");
            wbClima.DocumentText = reader2.ReadToEnd();*/
        }

        private void btnProgresso_Click(object sender, EventArgs e)
        {

        }
    }
}
