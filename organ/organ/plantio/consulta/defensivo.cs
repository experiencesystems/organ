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
    public partial class defensivo : UserControl
    {
        public defensivo()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (novo_defensivo _novo_defensivo = new novo_defensivo())
            {
                _novo_defensivo.ShowDialog(this);
            }
        }

        private void tbDefensivoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbDefensivoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbOrganDataSet);

        }
    }
}
