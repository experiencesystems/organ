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
using Microsoft.Win32;
using System.Diagnostics;

namespace organ
{
    public partial class inicio : UserControl
    {
        public inicio()
        {
            InitializeComponent();
            WebBrowserHelper.FixBrowserVersion();

            StreamReader reader = new StreamReader("C:\\Program Files\\More Experience Systems\\Organ\\Resources\\cotacao.html");
            wbCotacoes.DocumentText = reader.ReadToEnd();
            string curDir = Directory.GetCurrentDirectory();
            this.wbClima.Url = new Uri(String.Format("C:\\Program Files\\More Experience Systems\\Organ\\Resources\\clima.html", curDir));
        }
    }
}
