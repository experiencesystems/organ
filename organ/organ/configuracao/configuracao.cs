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
    public partial class configuracao : UserControl
    {
        public configuracao()
        {
            InitializeComponent();
        }

        private void llblGerenciamentoContas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gerenciamento_contas1.Visible = true;
            gerenciamento_contas1.Dock = DockStyle.Fill;
        }
    }
}
