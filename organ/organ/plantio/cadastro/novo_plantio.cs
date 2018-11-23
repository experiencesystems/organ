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
    public partial class novo_plantio : UserControl
    {
        public novo_plantio()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        /*private void btnAddFunc_Click(object sender, EventArgs e)
        {
            Addtextbox();
        }

        private void Addtextbox()
        {
            int rowIndex = AddTableRow();
            this.tablelayoutNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent));

            Label lbl = new Label();
            TextBox Text1 = new TextBox();
            lbl.Text = rowIndex.ToString();
            tablelayoutNovoPlantio.Controls.Add(lbl, 0, rowIndex);
            tablelayoutNovoPlantio.Controls.Add(Text1, 1, rowIndex);
        }
        private int AddTableRow()
        {
            int index = this.tablelayoutNovoPlantio.RowCount++;
            tablelayoutNovoPlantio.RowStyles.Clear();
            tablelayoutNovoPlantio.RowStyles.Add(new RowStyle(SizeType.Percent));
            return index;
        }
        */
    }
}
