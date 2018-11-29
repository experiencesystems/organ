using System;
using System.Windows.Forms;

namespace organ
{
    partial class gerenciamento_contas
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
            this.tlpBarraSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblGerenciamentoContas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenhaAntiga = new System.Windows.Forms.TextBox();
            this.btnConfirmarSenha = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnNovoUser = new System.Windows.Forms.Button();
            this.txtSenhaNew = new System.Windows.Forms.TextBox();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.cboUsuario2 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLogadoComo = new System.Windows.Forms.Label();
            this.tlpBarraSuperior.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBarraSuperior
            // 
            this.tlpBarraSuperior.ColumnCount = 3;
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.705373F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.29462F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 341F));
            this.tlpBarraSuperior.Controls.Add(this.btnVoltar, 0, 0);
            this.tlpBarraSuperior.Controls.Add(this.lblGerenciamentoContas, 1, 0);
            this.tlpBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tlpBarraSuperior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpBarraSuperior.Name = "tlpBarraSuperior";
            this.tlpBarraSuperior.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.tlpBarraSuperior.RowCount = 1;
            this.tlpBarraSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBarraSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpBarraSuperior.Size = new System.Drawing.Size(2076, 86);
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
            this.btnVoltar.Location = new System.Drawing.Point(4, 36);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnVoltar.Size = new System.Drawing.Size(156, 45);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "   Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblGerenciamentoContas
            // 
            this.lblGerenciamentoContas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGerenciamentoContas.AutoSize = true;
            this.lblGerenciamentoContas.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblGerenciamentoContas.Location = new System.Drawing.Point(707, 31);
            this.lblGerenciamentoContas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGerenciamentoContas.Name = "lblGerenciamentoContas";
            this.lblGerenciamentoContas.Padding = new System.Windows.Forms.Padding(90, 8, 0, 0);
            this.lblGerenciamentoContas.Size = new System.Drawing.Size(487, 52);
            this.lblGerenciamentoContas.TabIndex = 6;
            this.lblGerenciamentoContas.Text = "Gerenciamento de contas";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 36);
            this.label1.TabIndex = 39;
            this.label1.Text = "Mudar senha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSenhaAntiga
            // 
            this.txtSenhaAntiga.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSenhaAntiga.BackColor = System.Drawing.Color.White;
            this.txtSenhaAntiga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAntiga.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSenhaAntiga.Location = new System.Drawing.Point(57, 189);
            this.txtSenhaAntiga.Margin = new System.Windows.Forms.Padding(22, 5, 22, 5);
            this.txtSenhaAntiga.Name = "txtSenhaAntiga";
            this.txtSenhaAntiga.Size = new System.Drawing.Size(450, 37);
            this.txtSenhaAntiga.TabIndex = 42;
            this.txtSenhaAntiga.Text = "Senha atual";
            this.txtSenhaAntiga.GotFocus += new System.EventHandler(this.txtSenhaAntiga_GotFocus);
            this.txtSenhaAntiga.LostFocus += new System.EventHandler(this.txtSenhaAntiga_LostFocus);
            // 
            // btnConfirmarSenha
            // 
            this.btnConfirmarSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmarSenha.AutoSize = true;
            this.btnConfirmarSenha.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarSenha.Location = new System.Drawing.Point(20, 388);
            this.btnConfirmarSenha.Margin = new System.Windows.Forms.Padding(20);
            this.btnConfirmarSenha.Name = "btnConfirmarSenha";
            this.btnConfirmarSenha.Size = new System.Drawing.Size(525, 46);
            this.btnConfirmarSenha.TabIndex = 49;
            this.btnConfirmarSenha.Text = "Confirmar";
            this.btnConfirmarSenha.UseVisualStyleBackColor = true;
            this.btnConfirmarSenha.Click += new System.EventHandler(this.btnConfirmarSenha_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(557, 36);
            this.label3.TabIndex = 47;
            this.label3.Text = "Remover usuário";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnRemover, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnConfirmarSenha, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSenhaAntiga, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNovoUser, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSenhaNew, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboUsuario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboUsuario2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(466, 243);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1130, 574);
            this.tableLayoutPanel1.TabIndex = 52;
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(585, 204);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(20);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(525, 42);
            this.btnRemover.TabIndex = 51;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnNovoUser
            // 
            this.btnNovoUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoUser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoUser.Location = new System.Drawing.Point(585, 296);
            this.btnNovoUser.Margin = new System.Windows.Forms.Padding(20);
            this.btnNovoUser.Name = "btnNovoUser";
            this.btnNovoUser.Size = new System.Drawing.Size(525, 42);
            this.btnNovoUser.TabIndex = 50;
            this.btnNovoUser.Text = "Novo usuário";
            this.btnNovoUser.UseVisualStyleBackColor = true;
            this.btnNovoUser.Click += new System.EventHandler(this.btnNovoUser_Click);
            // 
            // txtSenhaNew
            // 
            this.txtSenhaNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSenhaNew.BackColor = System.Drawing.Color.White;
            this.txtSenhaNew.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaNew.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSenhaNew.Location = new System.Drawing.Point(57, 281);
            this.txtSenhaNew.Margin = new System.Windows.Forms.Padding(22, 5, 22, 5);
            this.txtSenhaNew.Name = "txtSenhaNew";
            this.txtSenhaNew.Size = new System.Drawing.Size(450, 37);
            this.txtSenhaNew.TabIndex = 42;
            this.txtSenhaNew.Text = "Senha nova";
            this.txtSenhaNew.GotFocus += new System.EventHandler(this.txtSenhaNew_GotFocus);
            this.txtSenhaNew.LostFocus += new System.EventHandler(this.txtSenhaNew_LostFocus);
            // 
            // cboUsuario
            // 
            this.cboUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(57, 97);
            this.cboUsuario.Margin = new System.Windows.Forms.Padding(22, 5, 22, 5);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(450, 37);
            this.cboUsuario.TabIndex = 52;
            this.cboUsuario.Text = "Selecione o usuário";
            // 
            // cboUsuario2
            // 
            this.cboUsuario2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboUsuario2.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboUsuario2.FormattingEnabled = true;
            this.cboUsuario2.Location = new System.Drawing.Point(622, 97);
            this.cboUsuario2.Margin = new System.Windows.Forms.Padding(22, 5, 22, 5);
            this.cboUsuario2.Name = "cboUsuario2";
            this.cboUsuario2.Size = new System.Drawing.Size(450, 37);
            this.cboUsuario2.TabIndex = 52;
            this.cboUsuario2.Text = "Selecione o usuário";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblLogadoComo, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(718, 143);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(587, 64);
            this.tableLayoutPanel2.TabIndex = 53;
            // 
            // lblLogadoComo
            // 
            this.lblLogadoComo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogadoComo.AutoSize = true;
            this.lblLogadoComo.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogadoComo.Location = new System.Drawing.Point(4, 0);
            this.lblLogadoComo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogadoComo.Name = "lblLogadoComo";
            this.lblLogadoComo.Size = new System.Drawing.Size(285, 37);
            this.lblLogadoComo.TabIndex = 2;
            this.lblLogadoComo.Text = "Logado como: ";
            // 
            // gerenciamento_contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2076, 1191);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tlpBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(131, 83);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "gerenciamento_contas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.tlpBarraSuperior.ResumeLayout(false);
            this.tlpBarraSuperior.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBarraSuperior;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblGerenciamentoContas;
        private Label label1;
        private TextBox txtSenhaAntiga;
        private Button btnConfirmarSenha;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblLogadoComo;
        private Button btnRemover;
        private Button btnNovoUser;
        private TextBox txtSenhaNew;
        private ComboBox cboUsuario;
        private ComboBox cboUsuario2;
    }
}