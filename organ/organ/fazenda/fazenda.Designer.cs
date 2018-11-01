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
            this.pnlLateralFazenda = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.pboEmpresa = new System.Windows.Forms.PictureBox();
            this.lblNomeFazenda = new System.Windows.Forms.Label();
            this.pboFazenda = new System.Windows.Forms.PictureBox();
            this.btnDoenças = new System.Windows.Forms.Button();
            this.btnControleGastos = new System.Windows.Forms.Button();
            this.btnPragas = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.pragas1 = new organ.pragas();
            this.doencas1 = new organ.doencas();
            this.fornecedores1 = new organ.fornecedores();
            this.controle_gastos1 = new organ.controle_gastos();
            this.funcionarios1 = new organ.funcionarios();
            this.pnlLateralFazenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFazenda)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLateralFazenda
            // 
            this.pnlLateralFazenda.BackColor = System.Drawing.Color.White;
            this.pnlLateralFazenda.Controls.Add(this.lblEmail);
            this.pnlLateralFazenda.Controls.Add(this.lblTelefone);
            this.pnlLateralFazenda.Controls.Add(this.pboEmpresa);
            this.pnlLateralFazenda.Controls.Add(this.lblNomeFazenda);
            this.pnlLateralFazenda.Controls.Add(this.pboFazenda);
            this.pnlLateralFazenda.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLateralFazenda.Location = new System.Drawing.Point(1066, 0);
            this.pnlLateralFazenda.Name = "pnlLateralFazenda";
            this.pnlLateralFazenda.Size = new System.Drawing.Size(340, 788);
            this.pnlLateralFazenda.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(55, 706);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(237, 23);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "moreexpsystems@gmail.com";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(55, 683);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(142, 23);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "(11) 99324-2306";
            // 
            // pboEmpresa
            // 
            this.pboEmpresa.Image = global::organ.Properties.Resources.exp_systems;
            this.pboEmpresa.Location = new System.Drawing.Point(121, 616);
            this.pboEmpresa.Name = "pboEmpresa";
            this.pboEmpresa.Size = new System.Drawing.Size(103, 44);
            this.pboEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboEmpresa.TabIndex = 2;
            this.pboEmpresa.TabStop = false;
            // 
            // lblNomeFazenda
            // 
            this.lblNomeFazenda.AutoSize = true;
            this.lblNomeFazenda.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFazenda.Location = new System.Drawing.Point(70, 233);
            this.lblNomeFazenda.Name = "lblNomeFazenda";
            this.lblNomeFazenda.Size = new System.Drawing.Size(213, 26);
            this.lblNomeFazenda.TabIndex = 1;
            this.lblNomeFazenda.Text = "Fazenda Pedra Dourada";
            // 
            // pboFazenda
            // 
            this.pboFazenda.Image = global::organ.Properties.Resources.fazenda;
            this.pboFazenda.Location = new System.Drawing.Point(102, 65);
            this.pboFazenda.Name = "pboFazenda";
            this.pboFazenda.Size = new System.Drawing.Size(144, 137);
            this.pboFazenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboFazenda.TabIndex = 0;
            this.pboFazenda.TabStop = false;
            // 
            // btnDoenças
            // 
            this.btnDoenças.BackColor = System.Drawing.Color.White;
            this.btnDoenças.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDoenças.FlatAppearance.BorderSize = 2;
            this.btnDoenças.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoenças.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoenças.Image = global::organ.Properties.Resources.semente_6;
            this.btnDoenças.Location = new System.Drawing.Point(377, 336);
            this.btnDoenças.Name = "btnDoenças";
            this.btnDoenças.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnDoenças.Size = new System.Drawing.Size(309, 272);
            this.btnDoenças.TabIndex = 11;
            this.btnDoenças.Text = "Doenças";
            this.btnDoenças.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoenças.UseVisualStyleBackColor = false;
            this.btnDoenças.Click += new System.EventHandler(this.btnDoenças_Click);
            // 
            // btnControleGastos
            // 
            this.btnControleGastos.BackColor = System.Drawing.Color.White;
            this.btnControleGastos.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnControleGastos.FlatAppearance.BorderSize = 2;
            this.btnControleGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControleGastos.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControleGastos.Image = global::organ.Properties.Resources.semente_6;
            this.btnControleGastos.Location = new System.Drawing.Point(41, 336);
            this.btnControleGastos.Name = "btnControleGastos";
            this.btnControleGastos.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnControleGastos.Size = new System.Drawing.Size(309, 272);
            this.btnControleGastos.TabIndex = 10;
            this.btnControleGastos.Text = "Controle de gastos";
            this.btnControleGastos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnControleGastos.UseVisualStyleBackColor = false;
            this.btnControleGastos.Click += new System.EventHandler(this.btnControleGastos_Click);
            // 
            // btnPragas
            // 
            this.btnPragas.BackColor = System.Drawing.Color.White;
            this.btnPragas.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPragas.FlatAppearance.BorderSize = 2;
            this.btnPragas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPragas.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPragas.Image = global::organ.Properties.Resources.semente_6;
            this.btnPragas.Location = new System.Drawing.Point(713, 33);
            this.btnPragas.Name = "btnPragas";
            this.btnPragas.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnPragas.Size = new System.Drawing.Size(309, 272);
            this.btnPragas.TabIndex = 9;
            this.btnPragas.Text = "Pragas";
            this.btnPragas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPragas.UseVisualStyleBackColor = false;
            this.btnPragas.Click += new System.EventHandler(this.btnPragas_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.BackColor = System.Drawing.Color.White;
            this.btnFornecedores.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFornecedores.FlatAppearance.BorderSize = 2;
            this.btnFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedores.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedores.Image = global::organ.Properties.Resources.box_3;
            this.btnFornecedores.Location = new System.Drawing.Point(377, 33);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnFornecedores.Size = new System.Drawing.Size(309, 272);
            this.btnFornecedores.TabIndex = 8;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFornecedores.UseVisualStyleBackColor = false;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.White;
            this.btnFuncionarios.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFuncionarios.FlatAppearance.BorderSize = 2;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.Image = global::organ.Properties.Resources.semente_6;
            this.btnFuncionarios.Location = new System.Drawing.Point(41, 33);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnFuncionarios.Size = new System.Drawing.Size(309, 272);
            this.btnFuncionarios.TabIndex = 7;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // pragas1
            // 
            this.pragas1.Location = new System.Drawing.Point(729, 49);
            this.pragas1.Name = "pragas1";
            this.pragas1.Size = new System.Drawing.Size(147, 77);
            this.pragas1.TabIndex = 16;
            this.pragas1.Visible = false;
            // 
            // doencas1
            // 
            this.doencas1.Location = new System.Drawing.Point(396, 353);
            this.doencas1.Name = "doencas1";
            this.doencas1.Size = new System.Drawing.Size(133, 65);
            this.doencas1.TabIndex = 15;
            this.doencas1.Visible = false;
            // 
            // fornecedores1
            // 
            this.fornecedores1.Location = new System.Drawing.Point(390, 49);
            this.fornecedores1.Name = "fornecedores1";
            this.fornecedores1.Size = new System.Drawing.Size(139, 51);
            this.fornecedores1.TabIndex = 14;
            this.fornecedores1.Visible = false;
            // 
            // controle_gastos1
            // 
            this.controle_gastos1.Location = new System.Drawing.Point(53, 350);
            this.controle_gastos1.Name = "controle_gastos1";
            this.controle_gastos1.Size = new System.Drawing.Size(154, 68);
            this.controle_gastos1.TabIndex = 13;
            this.controle_gastos1.Visible = false;
            // 
            // funcionarios1
            // 
            this.funcionarios1.Location = new System.Drawing.Point(53, 49);
            this.funcionarios1.Name = "funcionarios1";
            this.funcionarios1.Size = new System.Drawing.Size(115, 70);
            this.funcionarios1.TabIndex = 12;
            this.funcionarios1.Visible = false;
            // 
            // fazenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pragas1);
            this.Controls.Add(this.doencas1);
            this.Controls.Add(this.fornecedores1);
            this.Controls.Add(this.controle_gastos1);
            this.Controls.Add(this.funcionarios1);
            this.Controls.Add(this.btnDoenças);
            this.Controls.Add(this.btnControleGastos);
            this.Controls.Add(this.btnPragas);
            this.Controls.Add(this.btnFornecedores);
            this.Controls.Add(this.btnFuncionarios);
            this.Controls.Add(this.pnlLateralFazenda);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fazenda";
            this.Size = new System.Drawing.Size(1406, 788);
            this.pnlLateralFazenda.ResumeLayout(false);
            this.pnlLateralFazenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFazenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLateralFazenda;
        private System.Windows.Forms.PictureBox pboFazenda;
        private System.Windows.Forms.PictureBox pboEmpresa;
        private System.Windows.Forms.Label lblNomeFazenda;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnPragas;
        private System.Windows.Forms.Button btnControleGastos;
        private System.Windows.Forms.Button btnDoenças;
        private funcionarios funcionarios1;
        private controle_gastos controle_gastos1;
        private fornecedores fornecedores1;
        private doencas doencas1;
        private pragas pragas1;
        public System.Windows.Forms.Label lblTelefone;
        public System.Windows.Forms.Label lblEmail;
    }
}
