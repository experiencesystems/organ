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
        }

        public static object Instance { get; internal set; }
    }
}
