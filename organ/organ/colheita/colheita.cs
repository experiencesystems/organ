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

        private void tbSementeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbSementeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbOrganDataSet);

        }
    }
}
