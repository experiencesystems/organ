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
    public partial class fazenda : UserControl
    {
        public fazenda()
        {
            InitializeComponent();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            funcionarios1.Visible = true;
            funcionarios1.Dock = DockStyle.Fill;
        }

        private void btnControleGastos_Click(object sender, EventArgs e)
        {
            controle_gastos1.Visible = true;
            controle_gastos1.Dock = DockStyle.Fill;
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            fornecedores1.Visible = true;
            fornecedores1.Dock = DockStyle.Fill;
        }

        private void btnPragas_Click(object sender, EventArgs e)
        {
            pragas1.Visible = true;
            pragas1.Dock = DockStyle.Fill;
        }

        private void btnDoenças_Click(object sender, EventArgs e)
        {
            doencas1.Visible = true;
            doencas1.Dock = DockStyle.Fill;
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            estoque1.Visible = true;
            estoque1.Dock = DockStyle.Fill;
        }
    }
}
