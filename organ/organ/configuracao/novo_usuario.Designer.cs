namespace organ
{
    partial class novo_usuario
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
            this.lblNovoUsuario = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCriarNovoUser = new System.Windows.Forms.Button();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.tlpBarraSuperior.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBarraSuperior
            // 
            this.tlpBarraSuperior.ColumnCount = 3;
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.705373F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.29462F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 343F));
            this.tlpBarraSuperior.Controls.Add(this.btnVoltar, 0, 0);
            this.tlpBarraSuperior.Controls.Add(this.lblNovoUsuario, 1, 0);
            this.tlpBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tlpBarraSuperior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpBarraSuperior.Name = "tlpBarraSuperior";
            this.tlpBarraSuperior.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.tlpBarraSuperior.RowCount = 1;
            this.tlpBarraSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBarraSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpBarraSuperior.Size = new System.Drawing.Size(2076, 86);
            this.tlpBarraSuperior.TabIndex = 39;
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
            // lblNovoUsuario
            // 
            this.lblNovoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNovoUsuario.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblNovoUsuario.Location = new System.Drawing.Point(670, 31);
            this.lblNovoUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.lblNovoUsuario.Name = "lblNovoUsuario";
            this.lblNovoUsuario.Size = new System.Drawing.Size(560, 50);
            this.lblNovoUsuario.TabIndex = 6;
            this.lblNovoUsuario.Text = "Novo usuário";
            this.lblNovoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.txtNomeUsuario, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSenha, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCriarNovoUser, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2076, 1018);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // btnCriarNovoUser
            // 
            this.btnCriarNovoUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCriarNovoUser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarNovoUser.Location = new System.Drawing.Point(851, 225);
            this.btnCriarNovoUser.Margin = new System.Windows.Forms.Padding(200, 0, 200, 0);
            this.btnCriarNovoUser.Name = "btnCriarNovoUser";
            this.btnCriarNovoUser.Size = new System.Drawing.Size(373, 49);
            this.btnCriarNovoUser.TabIndex = 51;
            this.btnCriarNovoUser.Text = "Criar novo usuário";
            this.btnCriarNovoUser.UseVisualStyleBackColor = true;
            this.btnCriarNovoUser.Click += new System.EventHandler(this.btnCriarNovoUser_Click);
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeUsuario.BackColor = System.Drawing.Color.White;
            this.txtNomeUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNomeUsuario.Location = new System.Drawing.Point(831, 31);
            this.txtNomeUsuario.Margin = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(414, 37);
            this.txtNomeUsuario.TabIndex = 43;
            this.txtNomeUsuario.Text = "Nome usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSenha.Location = new System.Drawing.Point(831, 131);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(414, 37);
            this.txtSenha.TabIndex = 44;
            this.txtSenha.Text = "Senha ";
            // 
            // novo_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2076, 1191);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tlpBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "novo_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "novo_usuario";
            this.tlpBarraSuperior.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBarraSuperior;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblNovoUsuario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnCriarNovoUser;
    }
}