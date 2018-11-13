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
    public partial class colheita : UserControl
    {
        public colheita()
        {
            InitializeComponent();
        }

        private void tbColheitaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbColheitaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbOrganDataSet);

        }

        private void tbColheitaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbColheitaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbOrganDataSet);

        }
    }
}
