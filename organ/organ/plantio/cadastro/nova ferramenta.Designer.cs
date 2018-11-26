namespace organ
{
    partial class nova_ferramenta
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
            this.lblNovaFerramenta = new System.Windows.Forms.Label();
            this.tlpNovoFuncionario = new System.Windows.Forms.TableLayoutPanel();
            this.lblFertilizante = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFornecedor = new System.Windows.Forms.ComboBox();
            this.rtxtDescricao = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mskQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.cboUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.tlpBarraSuperior.SuspendLayout();
            this.tlpNovoFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBarraSuperior
            // 
            this.tlpBarraSuperior.ColumnCount = 3;
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.31085F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.68915F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tlpBarraSuperior.Controls.Add(this.btnVoltar, 0, 0);
            this.tlpBarraSuperior.Controls.Add(this.lblNovaFerramenta, 1, 0);
            this.tlpBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tlpBarraSuperior.Name = "tlpBarraSuperior";
            this.tlpBarraSuperior.Padding = new System.Windows.Forms.Padding(20, 20, 0, 10);
            this.tlpBarraSuperior.RowCount = 1;
            this.tlpBarraSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBarraSuperior.Size = new System.Drawing.Size(1425, 66);
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
            this.btnVoltar.Size = new System.Drawing.Size(105, 30);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "   Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblNovaFerramenta
            // 
            this.lblNovaFerramenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNovaFerramenta.AutoSize = true;
            this.lblNovaFerramenta.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblNovaFerramenta.Location = new System.Drawing.Point(138, 20);
            this.lblNovaFerramenta.Name = "lblNovaFerramenta";
            this.lblNovaFerramenta.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblNovaFerramenta.Size = new System.Drawing.Size(1116, 34);
            this.lblNovaFerramenta.TabIndex = 30;
            this.lblNovaFerramenta.Text = "Adicionar ferramenta";
            this.lblNovaFerramenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.tlpNovoFuncionario.Controls.Add(this.txtMarca, 1, 1);
            this.tlpNovoFuncionario.Controls.Add(this.label2, 0, 3);
            this.tlpNovoFuncionario.Controls.Add(this.label1, 0, 2);
            this.tlpNovoFuncionario.Controls.Add(this.cboFornecedor, 1, 2);
            this.tlpNovoFuncionario.Controls.Add(this.rtxtDescricao, 1, 3);
            this.tlpNovoFuncionario.Controls.Add(this.label3, 0, 4);
            this.tlpNovoFuncionario.Controls.Add(this.btnRegistrar, 1, 6);
            this.tlpNovoFuncionario.Controls.Add(this.label4, 0, 5);
            this.tlpNovoFuncionario.Controls.Add(this.mskQuantidade, 1, 4);
            this.tlpNovoFuncionario.Controls.Add(this.cboUnidadeMedida, 1, 5);
            this.tlpNovoFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNovoFuncionario.Location = new System.Drawing.Point(0, 66);
            this.tlpNovoFuncionario.Name = "tlpNovoFuncionario";
            this.tlpNovoFuncionario.Padding = new System.Windows.Forms.Padding(100, 30, 400, 0);
            this.tlpNovoFuncionario.RowCount = 7;
            this.tlpNovoFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpNovoFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpNovoFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpNovoFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpNovoFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpNovoFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpNovoFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpNovoFuncionario.Size = new System.Drawing.Size(1425, 735);
            this.tlpNovoFuncionario.TabIndex = 47;
            // 
            // lblFertilizante
            // 
            this.lblFertilizante.AutoSize = true;
            this.lblFertilizante.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFertilizante.Location = new System.Drawing.Point(103, 90);
            this.lblFertilizante.Name = "lblFertilizante";
            this.lblFertilizante.Size = new System.Drawing.Size(66, 26);
            this.lblFertilizante.TabIndex = 4;
            this.lblFertilizante.Text = "Marca";
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
            this.txtNome.Location = new System.Drawing.Point(380, 33);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(642, 33);
            this.txtNome.TabIndex = 2;
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Calibri", 14F);
            this.txtMarca.Location = new System.Drawing.Point(380, 93);
            this.txtMarca.MaxLength = 50;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(642, 30);
            this.txtMarca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 52;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 51;
            this.label1.Text = "Fornecedor";
            // 
            // cboFornecedor
            // 
            this.cboFornecedor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFornecedor.FormattingEnabled = true;
            this.cboFornecedor.Location = new System.Drawing.Point(380, 153);
            this.cboFornecedor.Name = "cboFornecedor";
            this.cboFornecedor.Size = new System.Drawing.Size(642, 31);
            this.cboFornecedor.TabIndex = 4;
            // 
            // rtxtDescricao
            // 
            this.rtxtDescricao.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescricao.Location = new System.Drawing.Point(380, 213);
            this.rtxtDescricao.MaxLength = 200;
            this.rtxtDescricao.Name = "rtxtDescricao";
            this.rtxtDescricao.Size = new System.Drawing.Size(642, 67);
            this.rtxtDescricao.TabIndex = 5;
            this.rtxtDescricao.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 55;
            this.label3.Text = "Quantidade*";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(767, 414);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(255, 50);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 26);
            this.label4.TabIndex = 56;
            this.label4.Text = "Unidade de medida*";
            // 
            // mskQuantidade
            // 
            this.mskQuantidade.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.mskQuantidade.Location = new System.Drawing.Point(380, 294);
            this.mskQuantidade.Mask = "000000000";
            this.mskQuantidade.Name = "mskQuantidade";
            this.mskQuantidade.Size = new System.Drawing.Size(121, 31);
            this.mskQuantidade.TabIndex = 6;
            // 
            // cboUnidadeMedida
            // 
            this.cboUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadeMedida.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.cboUnidadeMedida.FormattingEnabled = true;
            this.cboUnidadeMedida.Location = new System.Drawing.Point(380, 354);
            this.cboUnidadeMedida.Name = "cboUnidadeMedida";
            this.cboUnidadeMedida.Size = new System.Drawing.Size(121, 31);
            this.cboUnidadeMedida.TabIndex = 7;
            // 
            // nova_ferramenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1425, 801);
            this.Controls.Add(this.tlpNovoFuncionario);
            this.Controls.Add(this.tlpBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(131, 83);
            this.Name = "nova_ferramenta";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "nova_ferramenta";
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
        private System.Windows.Forms.Label lblNovaFerramenta;
        private System.Windows.Forms.TableLayoutPanel tlpNovoFuncionario;
        private System.Windows.Forms.Label lblFertilizante;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFornecedor;
        private System.Windows.Forms.RichTextBox rtxtDescricao;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskQuantidade;
        private System.Windows.Forms.ComboBox cboUnidadeMedida;
    }
}