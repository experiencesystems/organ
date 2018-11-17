namespace organ
{
    partial class maquinas
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
            this.lblMaquinas = new System.Windows.Forms.Label();
            this.tlpBarraSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvMaquinas = new System.Windows.Forms.DataGridView();
            this.tlpCentral = new System.Windows.Forms.TableLayoutPanel();
            this.dbOrgan = new organ.dbOrgan();
            this.dbOrganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbMaquinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbMaquinaTableAdapter = new organ.dbOrganTableAdapters.tbMaquinaTableAdapter();
            this.txtcod_maquinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnome_maq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdesc_maq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmarca_maq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcod_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbocod_fornecedor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tlpBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas)).BeginInit();
            this.tlpCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrgan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaquinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaquinas
            // 
            this.lblMaquinas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaquinas.AutoSize = true;
            this.lblMaquinas.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblMaquinas.Location = new System.Drawing.Point(567, 20);
            this.lblMaquinas.Name = "lblMaquinas";
            this.lblMaquinas.Padding = new System.Windows.Forms.Padding(60, 5, 0, 0);
            this.lblMaquinas.Size = new System.Drawing.Size(172, 34);
            this.lblMaquinas.TabIndex = 10;
            this.lblMaquinas.Text = "Máquinas";
            // 
            // tlpBarraSuperior
            // 
            this.tlpBarraSuperior.ColumnCount = 3;
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.705373F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.29462F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tlpBarraSuperior.Controls.Add(this.btnVoltar, 0, 0);
            this.tlpBarraSuperior.Controls.Add(this.btnAdd, 2, 0);
            this.tlpBarraSuperior.Controls.Add(this.lblMaquinas, 1, 0);
            this.tlpBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tlpBarraSuperior.Name = "tlpBarraSuperior";
            this.tlpBarraSuperior.Padding = new System.Windows.Forms.Padding(20, 20, 0, 10);
            this.tlpBarraSuperior.RowCount = 1;
            this.tlpBarraSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBarraSuperior.Size = new System.Drawing.Size(1384, 66);
            this.tlpBarraSuperior.TabIndex = 38;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 16F);
            this.btnVoltar.Image = global::organ.Properties.Resources.voltar;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(23, 23);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVoltar.Size = new System.Drawing.Size(106, 30);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "   Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 16F);
            this.btnAdd.Image = global::organ.Properties.Resources.soma;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(1177, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(204, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "  Adicionar novo";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvMaquinas
            // 
            this.dgvMaquinas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaquinas.AutoGenerateColumns = false;
            this.dgvMaquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtcod_maquinas,
            this.txtnome_maq,
            this.txtdesc_maq,
            this.txtmarca_maq,
            this.txtcod_estoque,
            this.cbocod_fornecedor});
            this.dgvMaquinas.DataSource = this.tbMaquinaBindingSource;
            this.dgvMaquinas.Location = new System.Drawing.Point(20, 20);
            this.dgvMaquinas.Margin = new System.Windows.Forms.Padding(20);
            this.dgvMaquinas.Name = "dgvMaquinas";
            this.dgvMaquinas.Size = new System.Drawing.Size(1344, 768);
            this.dgvMaquinas.TabIndex = 39;
            this.dgvMaquinas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaquinas_CellValueChanged);
            this.dgvMaquinas.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvMaquinas_EditingControlShowing);
            this.dgvMaquinas.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvMaquinas_UserDeletingRow);
            // 
            // tlpCentral
            // 
            this.tlpCentral.ColumnCount = 1;
            this.tlpCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCentral.Controls.Add(this.dgvMaquinas, 0, 0);
            this.tlpCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCentral.Location = new System.Drawing.Point(0, 66);
            this.tlpCentral.Name = "tlpCentral";
            this.tlpCentral.RowCount = 1;
            this.tlpCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCentral.Size = new System.Drawing.Size(1384, 808);
            this.tlpCentral.TabIndex = 40;
            // 
            // dbOrgan
            // 
            this.dbOrgan.DataSetName = "dbOrgan";
            this.dbOrgan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbOrganBindingSource
            // 
            this.dbOrganBindingSource.DataSource = this.dbOrgan;
            this.dbOrganBindingSource.Position = 0;
            // 
            // tbMaquinaBindingSource
            // 
            this.tbMaquinaBindingSource.DataMember = "tbMaquina";
            this.tbMaquinaBindingSource.DataSource = this.dbOrganBindingSource;
            // 
            // tbMaquinaTableAdapter
            // 
            this.tbMaquinaTableAdapter.ClearBeforeFill = true;
            // 
            // txtcod_maquinas
            // 
            this.txtcod_maquinas.DataPropertyName = "txtcod_maquinas";
            this.txtcod_maquinas.HeaderText = "Código";
            this.txtcod_maquinas.Name = "txtcod_maquinas";
            this.txtcod_maquinas.ReadOnly = true;
            // 
            // txtnome_maq
            // 
            this.txtnome_maq.DataPropertyName = "txtnome_maq";
            this.txtnome_maq.HeaderText = "Nome";
            this.txtnome_maq.Name = "txtnome_maq";
            // 
            // txtdesc_maq
            // 
            this.txtdesc_maq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtdesc_maq.DataPropertyName = "txtdesc_maq";
            this.txtdesc_maq.HeaderText = "Descrição";
            this.txtdesc_maq.Name = "txtdesc_maq";
            // 
            // txtmarca_maq
            // 
            this.txtmarca_maq.DataPropertyName = "txtmarca_maq";
            this.txtmarca_maq.HeaderText = "Marca";
            this.txtmarca_maq.Name = "txtmarca_maq";
            // 
            // txtcod_estoque
            // 
            this.txtcod_estoque.DataPropertyName = "txtcod_estoque";
            this.txtcod_estoque.HeaderText = "Código do estoque";
            this.txtcod_estoque.Name = "txtcod_estoque";
            this.txtcod_estoque.Visible = false;
            // 
            // cbocod_fornecedor
            // 
            this.cbocod_fornecedor.DataPropertyName = "cbocod_fornecedor";
            this.cbocod_fornecedor.HeaderText = "Fornecedor";
            this.cbocod_fornecedor.Name = "cbocod_fornecedor";
            this.cbocod_fornecedor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbocod_fornecedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // maquinas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tlpCentral);
            this.Controls.Add(this.tlpBarraSuperior);
            this.Name = "maquinas";
            this.Size = new System.Drawing.Size(1384, 874);
            this.Load += new System.EventHandler(this.maquinas_Load);
            this.tlpBarraSuperior.ResumeLayout(false);
            this.tlpBarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas)).EndInit();
            this.tlpCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbOrgan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaquinaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMaquinas;
        private System.Windows.Forms.TableLayoutPanel tlpBarraSuperior;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvMaquinas;
        private System.Windows.Forms.TableLayoutPanel tlpCentral;
        private System.Windows.Forms.BindingSource tbMaquinaBindingSource;
        private System.Windows.Forms.BindingSource dbOrganBindingSource;
        private dbOrgan dbOrgan;
        private dbOrganTableAdapters.tbMaquinaTableAdapter tbMaquinaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcod_maquinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtnome_maq;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtdesc_maq;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtmarca_maq;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcod_estoque;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbocod_fornecedor;
    }
}
