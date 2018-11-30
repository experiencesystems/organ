namespace organ
{
    partial class nova_praga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpBarraSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblAddPraga = new System.Windows.Forms.Label();
            this.tlpNovoFuncionario = new System.Windows.Forms.TableLayoutPanel();
            this.lblFertilizante = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rtxtDescricao = new System.Windows.Forms.RichTextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSemente = new System.Windows.Forms.ComboBox();
            this.tlpBarraSuperior.SuspendLayout();
            this.tlpNovoFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBarraSuperior
            // 
            this.tlpBarraSuperior.ColumnCount = 3;
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.705373F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.29462F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tlpBarraSuperior.Controls.Add(this.btnVoltar, 0, 0);
            this.tlpBarraSuperior.Controls.Add(this.lblAddPraga, 1, 0);
            this.tlpBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tlpBarraSuperior.Name = "tlpBarraSuperior";
            this.tlpBarraSuperior.Padding = new System.Windows.Forms.Padding(20, 20, 0, 10);
            this.tlpBarraSuperior.RowCount = 1;
            this.tlpBarraSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBarraSuperior.Size = new System.Drawing.Size(1480, 66);
            this.tlpBarraSuperior.TabIndex = 41;
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
            // lblAddPraga
            // 
            this.lblAddPraga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddPraga.AutoSize = true;
            this.lblAddPraga.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblAddPraga.Location = new System.Drawing.Point(143, 20);
            this.lblAddPraga.Name = "lblAddPraga";
            this.lblAddPraga.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblAddPraga.Size = new System.Drawing.Size(1115, 34);
            this.lblAddPraga.TabIndex = 6;
            this.lblAddPraga.Text = "Adicionar praga";
            this.lblAddPraga.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tlpNovoFuncionario
            // 
            this.tlpNovoFuncionario.AutoSize = true;
            this.tlpNovoFuncionario.ColumnCount = 2;
            this.tlpNovoFuncionario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpNovoFuncionario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpNovoFuncionario.Controls.Add(this.lblFertilizante, 0, 1);
            this.tlpNovoFuncionario.Controls.Add(this.lblNome, 0, 0);
            this.tlpNovoFuncionario.Controls.Add(this.txtNome, 1, 0);
            this.tlpNovoFuncionario.Controls.Add(this.rtxtDescricao, 1, 1);
            this.tlpNovoFuncionario.Controls.Add(this.btnRegistrar, 1, 3);
            this.tlpNovoFuncionario.Controls.Add(this.label1, 0, 2);
            this.tlpNovoFuncionario.Controls.Add(this.cboSemente, 1, 2);
            this.tlpNovoFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNovoFuncionario.Location = new System.Drawing.Point(0, 66);
            this.tlpNovoFuncionario.Name = "tlpNovoFuncionario";
            this.tlpNovoFuncionario.Padding = new System.Windows.Forms.Padding(100, 30, 400, 0);
            this.tlpNovoFuncionario.RowCount = 4;
            this.tlpNovoFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpNovoFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpNovoFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpNovoFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpNovoFuncionario.Size = new System.Drawing.Size(1480, 734);
            this.tlpNovoFuncionario.TabIndex = 45;
            // 
            // lblFertilizante
            // 
            this.lblFertilizante.AutoSize = true;
            this.lblFertilizante.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFertilizante.Location = new System.Drawing.Point(103, 90);
            this.lblFertilizante.Name = "lblFertilizante";
            this.lblFertilizante.Size = new System.Drawing.Size(94, 26);
            this.lblFertilizante.TabIndex = 4;
            this.lblFertilizante.Text = "Descrição";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(103, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNome.Size = new System.Drawing.Size(74, 26);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome*";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(397, 33);
            this.txtNome.MaxLength = 70;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(680, 33);
            this.txtNome.TabIndex = 1;
            // 
            // rtxtDescricao
            // 
            this.rtxtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDescricao.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.rtxtDescricao.Location = new System.Drawing.Point(397, 93);
            this.rtxtDescricao.MaxLength = 200;
            this.rtxtDescricao.Name = "rtxtDescricao";
            this.rtxtDescricao.Size = new System.Drawing.Size(680, 109);
            this.rtxtDescricao.TabIndex = 2;
            this.rtxtDescricao.Text = "";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(822, 283);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(255, 50);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 220);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(201, 26);
            this.label1.TabIndex = 51;
            this.label1.Text = "Semente relacionada*";
            // 
            // cboSemente
            // 
            this.cboSemente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSemente.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cboSemente.FormattingEnabled = true;
            this.cboSemente.Location = new System.Drawing.Point(397, 223);
            this.cboSemente.Name = "cboSemente";
            this.cboSemente.Size = new System.Drawing.Size(680, 34);
            this.cboSemente.TabIndex = 3;
            // 
            // nova_praga
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1480, 800);
            this.Controls.Add(this.tlpNovoFuncionario);
            this.Controls.Add(this.tlpBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(131, 83);
            this.Name = "nova_praga";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "nova_praga";
            this.tlpBarraSuperior.ResumeLayout(false);
            this.tlpBarraSuperior.PerformLayout();
            this.tlpNovoFuncionario.ResumeLayout(false);
            this.tlpNovoFuncionario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBarraSuperior;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblAddPraga;
        private System.Windows.Forms.TableLayoutPanel tlpNovoFuncionario;
        private System.Windows.Forms.Label lblFertilizante;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RichTextBox rtxtDescricao;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSemente;
    }
}