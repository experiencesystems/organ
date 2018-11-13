namespace organ
{
    partial class colheita
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(colheita));
            System.Windows.Forms.Label cod_plantioLabel;
            this.dbOrganDataSet = new organ.dbOrganDataSet();
            this.tbColheitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbColheitaTableAdapter = new organ.dbOrganDataSetTableAdapters.tbColheitaTableAdapter();
            this.tableAdapterManager = new organ.dbOrganDataSetTableAdapters.TableAdapterManager();
            this.tbColheitaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tbColheitaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cod_plantioLabel1 = new System.Windows.Forms.Label();
            cod_plantioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrganDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColheitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColheitaBindingNavigator)).BeginInit();
            this.tbColheitaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbOrganDataSet
            // 
            this.dbOrganDataSet.DataSetName = "dbOrganDataSet";
            this.dbOrganDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbColheitaBindingSource
            // 
            this.tbColheitaBindingSource.DataMember = "tbColheita";
            this.tbColheitaBindingSource.DataSource = this.dbOrganDataSet;
            // 
            // tbColheitaTableAdapter
            // 
            this.tbColheitaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbColheitaTableAdapter = this.tbColheitaTableAdapter;
            this.tableAdapterManager.tbDefensivoTableAdapter = null;
            this.tableAdapterManager.tbDoencaTableAdapter = null;
            this.tableAdapterManager.tbEnderecoTableAdapter = null;
            this.tableAdapterManager.tbEstoqueTableAdapter = null;
            this.tableAdapterManager.tbFerramentaTableAdapter = null;
            this.tableAdapterManager.tbFertilizanteTableAdapter = null;
            this.tableAdapterManager.tbFornecedorTableAdapter = null;
            this.tableAdapterManager.tbFuncionarioTableAdapter = null;
            this.tableAdapterManager.tbHistorico_EstoqueTableAdapter = null;
            this.tableAdapterManager.tbLoginTableAdapter = null;
            this.tableAdapterManager.tbMaquinaTableAdapter = null;
            this.tableAdapterManager.tbPerfilTableAdapter = null;
            this.tableAdapterManager.tbPlantioTableAdapter = null;
            this.tableAdapterManager.tbPragaTableAdapter = null;
            this.tableAdapterManager.tbRelatorioTableAdapter = null;
            this.tableAdapterManager.tbSementeTableAdapter = null;
            this.tableAdapterManager.tbTalhaoTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = organ.dbOrganDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbColheitaBindingNavigator
            // 
            this.tbColheitaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbColheitaBindingNavigator.BindingSource = this.tbColheitaBindingSource;
            this.tbColheitaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbColheitaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbColheitaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbColheitaBindingNavigatorSaveItem});
            this.tbColheitaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbColheitaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbColheitaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbColheitaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbColheitaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbColheitaBindingNavigator.Name = "tbColheitaBindingNavigator";
            this.tbColheitaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbColheitaBindingNavigator.Size = new System.Drawing.Size(1406, 25);
            this.tbColheitaBindingNavigator.TabIndex = 0;
            this.tbColheitaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // tbColheitaBindingNavigatorSaveItem
            // 
            this.tbColheitaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbColheitaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbColheitaBindingNavigatorSaveItem.Image")));
            this.tbColheitaBindingNavigatorSaveItem.Name = "tbColheitaBindingNavigatorSaveItem";
            this.tbColheitaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tbColheitaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tbColheitaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbColheitaBindingNavigatorSaveItem_Click_1);
            // 
            // cod_plantioLabel
            // 
            cod_plantioLabel.AutoSize = true;
            cod_plantioLabel.Location = new System.Drawing.Point(121, 90);
            cod_plantioLabel.Name = "cod_plantioLabel";
            cod_plantioLabel.Size = new System.Drawing.Size(62, 13);
            cod_plantioLabel.TabIndex = 1;
            cod_plantioLabel.Text = "cod plantio:";
            // 
            // cod_plantioLabel1
            // 
            this.cod_plantioLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbColheitaBindingSource, "cod_plantio", true));
            this.cod_plantioLabel1.Location = new System.Drawing.Point(189, 90);
            this.cod_plantioLabel1.Name = "cod_plantioLabel1";
            this.cod_plantioLabel1.Size = new System.Drawing.Size(100, 23);
            this.cod_plantioLabel1.TabIndex = 2;
            this.cod_plantioLabel1.Text = "label1";
            // 
            // colheita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(cod_plantioLabel);
            this.Controls.Add(this.cod_plantioLabel1);
            this.Controls.Add(this.tbColheitaBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "colheita";
            this.Size = new System.Drawing.Size(1406, 788);
            ((System.ComponentModel.ISupportInitialize)(this.dbOrganDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColheitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColheitaBindingNavigator)).EndInit();
            this.tbColheitaBindingNavigator.ResumeLayout(false);
            this.tbColheitaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbOrganDataSet dbOrganDataSet;
        private System.Windows.Forms.BindingSource tbColheitaBindingSource;
        private dbOrganDataSetTableAdapters.tbColheitaTableAdapter tbColheitaTableAdapter;
        private dbOrganDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbColheitaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbColheitaBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cod_plantioLabel1;
    }
}
