namespace organ
{
    partial class funcionarios
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFuncionarios = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.dbOrgan = new organ.dbOrgan();
            this.tbFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFuncionarioTableAdapter = new organ.dbOrganTableAdapters.tbFuncionarioTableAdapter();
            this.codfuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpffuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgfuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telfuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celfuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailfuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargofuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariofuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepfuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcasafuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrgan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.705373F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.29462F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel2.Controls.Add(this.btnVoltar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblFuncionarios, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(20, 20, 0, 10);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1384, 66);
            this.tableLayoutPanel2.TabIndex = 38;
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
            this.btnVoltar.Size = new System.Drawing.Size(105, 30);
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
            this.btnAdd.Location = new System.Drawing.Point(1172, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(204, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "  Adicionar novo";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFuncionarios
            // 
            this.lblFuncionarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFuncionarios.AutoSize = true;
            this.lblFuncionarios.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblFuncionarios.Location = new System.Drawing.Point(550, 20);
            this.lblFuncionarios.Name = "lblFuncionarios";
            this.lblFuncionarios.Padding = new System.Windows.Forms.Padding(60, 5, 0, 0);
            this.lblFuncionarios.Size = new System.Drawing.Size(200, 34);
            this.lblFuncionarios.TabIndex = 6;
            this.lblFuncionarios.Text = "Funcionários";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.Controls.Add(this.dgvFuncionarios, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.40678F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1384, 708);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AutoGenerateColumns = false;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codfuncionarioDataGridViewTextBoxColumn,
            this.nomefuncDataGridViewTextBoxColumn,
            this.cpffuncDataGridViewTextBoxColumn,
            this.rgfuncDataGridViewTextBoxColumn,
            this.telfuncDataGridViewTextBoxColumn,
            this.celfuncDataGridViewTextBoxColumn,
            this.emailfuncDataGridViewTextBoxColumn,
            this.cargofuncDataGridViewTextBoxColumn,
            this.salariofuncDataGridViewTextBoxColumn,
            this.cepfuncDataGridViewTextBoxColumn,
            this.numcasafuncDataGridViewTextBoxColumn,
            this.codusuarioDataGridViewTextBoxColumn});
            this.dgvFuncionarios.DataSource = this.tbFuncionarioBindingSource;
            this.dgvFuncionarios.Location = new System.Drawing.Point(30, 30);
            this.dgvFuncionarios.Margin = new System.Windows.Forms.Padding(30);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(1139, 648);
            this.dgvFuncionarios.TabIndex = 39;
            // 
            // dbOrgan
            // 
            this.dbOrgan.DataSetName = "dbOrgan";
            this.dbOrgan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFuncionarioBindingSource
            // 
            this.tbFuncionarioBindingSource.DataMember = "tbFuncionario";
            this.tbFuncionarioBindingSource.DataSource = this.dbOrgan;
            // 
            // tbFuncionarioTableAdapter
            // 
            this.tbFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // codfuncionarioDataGridViewTextBoxColumn
            // 
            this.codfuncionarioDataGridViewTextBoxColumn.DataPropertyName = "cod_funcionario";
            this.codfuncionarioDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codfuncionarioDataGridViewTextBoxColumn.Name = "codfuncionarioDataGridViewTextBoxColumn";
            this.codfuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomefuncDataGridViewTextBoxColumn
            // 
            this.nomefuncDataGridViewTextBoxColumn.DataPropertyName = "nome_func";
            this.nomefuncDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomefuncDataGridViewTextBoxColumn.Name = "nomefuncDataGridViewTextBoxColumn";
            // 
            // cpffuncDataGridViewTextBoxColumn
            // 
            this.cpffuncDataGridViewTextBoxColumn.DataPropertyName = "cpf_func";
            this.cpffuncDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cpffuncDataGridViewTextBoxColumn.Name = "cpffuncDataGridViewTextBoxColumn";
            // 
            // rgfuncDataGridViewTextBoxColumn
            // 
            this.rgfuncDataGridViewTextBoxColumn.DataPropertyName = "rg_func";
            this.rgfuncDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rgfuncDataGridViewTextBoxColumn.Name = "rgfuncDataGridViewTextBoxColumn";
            // 
            // telfuncDataGridViewTextBoxColumn
            // 
            this.telfuncDataGridViewTextBoxColumn.DataPropertyName = "tel_func";
            this.telfuncDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telfuncDataGridViewTextBoxColumn.Name = "telfuncDataGridViewTextBoxColumn";
            // 
            // celfuncDataGridViewTextBoxColumn
            // 
            this.celfuncDataGridViewTextBoxColumn.DataPropertyName = "cel_func";
            this.celfuncDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celfuncDataGridViewTextBoxColumn.Name = "celfuncDataGridViewTextBoxColumn";
            // 
            // emailfuncDataGridViewTextBoxColumn
            // 
            this.emailfuncDataGridViewTextBoxColumn.DataPropertyName = "email_func";
            this.emailfuncDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailfuncDataGridViewTextBoxColumn.Name = "emailfuncDataGridViewTextBoxColumn";
            // 
            // cargofuncDataGridViewTextBoxColumn
            // 
            this.cargofuncDataGridViewTextBoxColumn.DataPropertyName = "cargo_func";
            this.cargofuncDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargofuncDataGridViewTextBoxColumn.Name = "cargofuncDataGridViewTextBoxColumn";
            // 
            // salariofuncDataGridViewTextBoxColumn
            // 
            this.salariofuncDataGridViewTextBoxColumn.DataPropertyName = "salario_func";
            this.salariofuncDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.salariofuncDataGridViewTextBoxColumn.Name = "salariofuncDataGridViewTextBoxColumn";
            // 
            // cepfuncDataGridViewTextBoxColumn
            // 
            this.cepfuncDataGridViewTextBoxColumn.DataPropertyName = "cep_func";
            this.cepfuncDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cepfuncDataGridViewTextBoxColumn.Name = "cepfuncDataGridViewTextBoxColumn";
            // 
            // numcasafuncDataGridViewTextBoxColumn
            // 
            this.numcasafuncDataGridViewTextBoxColumn.DataPropertyName = "numcasa_func";
            this.numcasafuncDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numcasafuncDataGridViewTextBoxColumn.Name = "numcasafuncDataGridViewTextBoxColumn";
            // 
            // codusuarioDataGridViewTextBoxColumn
            // 
            this.codusuarioDataGridViewTextBoxColumn.DataPropertyName = "cod_usuario";
            this.codusuarioDataGridViewTextBoxColumn.HeaderText = "Cód. Usuário";
            this.codusuarioDataGridViewTextBoxColumn.Name = "codusuarioDataGridViewTextBoxColumn";
            // 
            // funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "funcionarios";
            this.Size = new System.Drawing.Size(1384, 774);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrgan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFuncionarios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn codfuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpffuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgfuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telfuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celfuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailfuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargofuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariofuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepfuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcasafuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbFuncionarioBindingSource;
        private dbOrgan dbOrgan;
        private dbOrganTableAdapters.tbFuncionarioTableAdapter tbFuncionarioTableAdapter;
    }
}
