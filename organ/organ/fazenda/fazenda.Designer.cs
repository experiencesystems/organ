namespace organ
{
    partial class fazenda
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
            this.btnDoenças = new System.Windows.Forms.Button();
            this.btnPragas = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.estoque1 = new organ.estoque();
            this.pragas1 = new organ.pragas();
            this.doencas1 = new organ.doencas();
            this.fornecedores1 = new organ.fornecedores();
            this.funcionarios1 = new organ.funcionarios();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDoenças
            // 
            this.btnDoenças.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoenças.BackColor = System.Drawing.Color.White;
            this.btnDoenças.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDoenças.FlatAppearance.BorderSize = 2;
            this.btnDoenças.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoenças.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoenças.Image = global::organ.Properties.Resources.doencas1;
            this.btnDoenças.Location = new System.Drawing.Point(10, 383);
            this.btnDoenças.Margin = new System.Windows.Forms.Padding(10, 20, 20, 20);
            this.btnDoenças.Name = "btnDoenças";
            this.btnDoenças.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnDoenças.Size = new System.Drawing.Size(413, 324);
            this.btnDoenças.TabIndex = 11;
            this.btnDoenças.Text = "Doenças";
            this.btnDoenças.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoenças.UseVisualStyleBackColor = false;
            this.btnDoenças.Click += new System.EventHandler(this.btnDoenças_Click);
            // 
            // btnPragas
            // 
            this.btnPragas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPragas.BackColor = System.Drawing.Color.White;
            this.btnPragas.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPragas.FlatAppearance.BorderSize = 2;
            this.btnPragas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPragas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPragas.Image = global::organ.Properties.Resources.pragas;
            this.btnPragas.Location = new System.Drawing.Point(906, 20);
            this.btnPragas.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.btnPragas.Name = "btnPragas";
            this.btnPragas.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnPragas.Size = new System.Drawing.Size(423, 323);
            this.btnPragas.TabIndex = 9;
            this.btnPragas.Text = "Pragas";
            this.btnPragas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPragas.UseVisualStyleBackColor = false;
            this.btnPragas.Click += new System.EventHandler(this.btnPragas_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFornecedores.BackColor = System.Drawing.Color.White;
            this.btnFornecedores.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFornecedores.FlatAppearance.BorderSize = 2;
            this.btnFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedores.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedores.Image = global::organ.Properties.Resources.box_4;
            this.btnFornecedores.Location = new System.Drawing.Point(463, 20);
            this.btnFornecedores.Margin = new System.Windows.Forms.Padding(20);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnFornecedores.Size = new System.Drawing.Size(403, 323);
            this.btnFornecedores.TabIndex = 8;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFornecedores.UseVisualStyleBackColor = false;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFuncionarios.BackColor = System.Drawing.Color.White;
            this.btnFuncionarios.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFuncionarios.FlatAppearance.BorderSize = 2;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.Image = global::organ.Properties.Resources.funcionarios;
            this.btnFuncionarios.Location = new System.Drawing.Point(10, 20);
            this.btnFuncionarios.Margin = new System.Windows.Forms.Padding(10, 20, 20, 20);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnFuncionarios.Size = new System.Drawing.Size(413, 323);
            this.btnFuncionarios.TabIndex = 7;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstoque.BackColor = System.Drawing.Color.White;
            this.btnEstoque.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEstoque.FlatAppearance.BorderSize = 2;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Image = global::organ.Properties.Resources.estoque_2;
            this.btnEstoque.Location = new System.Drawing.Point(463, 383);
            this.btnEstoque.Margin = new System.Windows.Forms.Padding(20);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnEstoque.Size = new System.Drawing.Size(403, 324);
            this.btnEstoque.TabIndex = 17;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnFuncionarios, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFornecedores, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPragas, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDoenças, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEstoque, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1329, 727);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // estoque1
            // 
            this.estoque1.Location = new System.Drawing.Point(620, 405);
            this.estoque1.Name = "estoque1";
            this.estoque1.Size = new System.Drawing.Size(261, 81);
            this.estoque1.TabIndex = 18;
            this.estoque1.Visible = false;
            // 
            // pragas1
            // 
            this.pragas1.Location = new System.Drawing.Point(1171, 61);
            this.pragas1.Name = "pragas1";
            this.pragas1.Size = new System.Drawing.Size(147, 77);
            this.pragas1.TabIndex = 16;
            this.pragas1.Visible = false;
            // 
            // doencas1
            // 
            this.doencas1.Location = new System.Drawing.Point(290, 405);
            this.doencas1.Name = "doencas1";
            this.doencas1.Size = new System.Drawing.Size(133, 65);
            this.doencas1.TabIndex = 15;
            this.doencas1.Visible = false;
            // 
            // fornecedores1
            // 
            this.fornecedores1.Location = new System.Drawing.Point(730, 61);
            this.fornecedores1.Name = "fornecedores1";
            this.fornecedores1.Size = new System.Drawing.Size(139, 51);
            this.fornecedores1.TabIndex = 14;
            this.fornecedores1.Visible = false;
            // 
            // funcionarios1
            // 
            this.funcionarios1.Location = new System.Drawing.Point(308, 61);
            this.funcionarios1.Name = "funcionarios1";
            this.funcionarios1.Size = new System.Drawing.Size(115, 70);
            this.funcionarios1.TabIndex = 12;
            this.funcionarios1.Visible = false;
            // 
            // fazenda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.estoque1);
            this.Controls.Add(this.pragas1);
            this.Controls.Add(this.doencas1);
            this.Controls.Add(this.fornecedores1);
            this.Controls.Add(this.funcionarios1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fazenda";
            this.Size = new System.Drawing.Size(1384, 774);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnPragas;
        private System.Windows.Forms.Button btnDoenças;
        private funcionarios funcionarios1;
        private fornecedores fornecedores1;
        private doencas doencas1;
        private pragas pragas1;
        private System.Windows.Forms.Button btnEstoque;
        private estoque estoque1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
