using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace organ
{

    partial class frmLogin
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pcbSair = new System.Windows.Forms.PictureBox();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pcbOlho = new System.Windows.Forms.PictureBox();
            this.pcbSenha = new System.Windows.Forms.PictureBox();
            this.pcbUsuario = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnlRetaLogin = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pnlRetaSenha = new System.Windows.Forms.Panel();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOlho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBackground.BackgroundImage")));
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackground.Controls.Add(this.pcbSair);
            this.pnlBackground.Controls.Add(this.lblBemVindo);
            this.pnlBackground.Controls.Add(this.pnlLogin);
            this.pnlBackground.Location = new System.Drawing.Point(-26, -19);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(677, 426);
            this.pnlBackground.TabIndex = 1;
            // 
            // pcbSair
            // 
            this.pcbSair.BackColor = System.Drawing.Color.Transparent;
            this.pcbSair.Image = global::organ.Properties.Resources.Shutdown_64px;
            this.pcbSair.Location = new System.Drawing.Point(607, 28);
            this.pcbSair.Margin = new System.Windows.Forms.Padding(2);
            this.pcbSair.Name = "pcbSair";
            this.pcbSair.Size = new System.Drawing.Size(29, 28);
            this.pcbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSair.TabIndex = 2;
            this.pcbSair.TabStop = false;
            this.pcbSair.Click += new System.EventHandler(this.pcbSair_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.lblBemVindo.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.Color.White;
            this.lblBemVindo.Location = new System.Drawing.Point(76, 108);
            this.lblBemVindo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(205, 27);
            this.lblBemVindo.TabIndex = 1;
            this.lblBemVindo.Text = "Bem vindo ao Organ!";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLogin.Controls.Add(this.pcbOlho);
            this.pnlLogin.Controls.Add(this.pcbSenha);
            this.pnlLogin.Controls.Add(this.pcbUsuario);
            this.pnlLogin.Controls.Add(this.btnEntrar);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.pnlRetaLogin);
            this.pnlLogin.Controls.Add(this.txtSenha);
            this.pnlLogin.Controls.Add(this.txtUsuario);
            this.pnlLogin.Controls.Add(this.pnlRetaSenha);
            this.pnlLogin.ForeColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Location = new System.Drawing.Point(343, 81);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(265, 268);
            this.pnlLogin.TabIndex = 0;
            this.pnlLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLogin_KeyPress);
            this.pnlLogin.Click += new System.EventHandler(this.pnlLogin_Click);
            // 
            // pcbOlho
            // 
            this.pcbOlho.Image = global::organ.Properties.Resources.Invisible_64px;
            this.pcbOlho.Location = new System.Drawing.Point(214, 144);
            this.pcbOlho.Margin = new System.Windows.Forms.Padding(2);
            this.pcbOlho.Name = "pcbOlho";
            this.pcbOlho.Size = new System.Drawing.Size(22, 21);
            this.pcbOlho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbOlho.TabIndex = 7;
            this.pcbOlho.TabStop = false;
            this.pcbOlho.Click += new System.EventHandler(this.pcbOlho_Click);
            // 
            // pcbSenha
            // 
            this.pcbSenha.Image = global::organ.Properties.Resources.Lock_50px1;
            this.pcbSenha.Location = new System.Drawing.Point(20, 144);
            this.pcbSenha.Margin = new System.Windows.Forms.Padding(2);
            this.pcbSenha.Name = "pcbSenha";
            this.pcbSenha.Size = new System.Drawing.Size(20, 21);
            this.pcbSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSenha.TabIndex = 6;
            this.pcbSenha.TabStop = false;
            // 
            // pcbUsuario
            // 
            this.pcbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pcbUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbUsuario.Image = global::organ.Properties.Resources.profile;
            this.pcbUsuario.Location = new System.Drawing.Point(20, 82);
            this.pcbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.pcbUsuario.Name = "pcbUsuario";
            this.pcbUsuario.Size = new System.Drawing.Size(20, 20);
            this.pcbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUsuario.TabIndex = 5;
            this.pcbUsuario.TabStop = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnEntrar.FlatAppearance.BorderSize = 2;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(250)))), ((int)(((byte)(188)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnEntrar.Location = new System.Drawing.Point(167, 202);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(70, 30);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(28, 32);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(51, 23);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login";
            // 
            // pnlRetaLogin
            // 
            this.pnlRetaLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlRetaLogin.Location = new System.Drawing.Point(20, 107);
            this.pnlRetaLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRetaLogin.Name = "pnlRetaLogin";
            this.pnlRetaLogin.Size = new System.Drawing.Size(217, 2);
            this.pnlRetaLogin.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSenha.Location = new System.Drawing.Point(44, 145);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(166, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "Senha";
            this.txtSenha.GotFocus += new System.EventHandler(this.txtSenha_GotFocus);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLogin_KeyPress);
            this.txtSenha.LostFocus += new System.EventHandler(this.txtSenha_LostFocus);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtUsuario.Location = new System.Drawing.Point(44, 82);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(193, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuário";
            this.txtUsuario.GotFocus += new System.EventHandler(this.txtUsuario_GotFocus);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLogin_KeyPress);
            this.txtUsuario.LostFocus += new System.EventHandler(this.txtUsuario_LostFocus);
            // 
            // pnlRetaSenha
            // 
            this.pnlRetaSenha.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlRetaSenha.Location = new System.Drawing.Point(20, 171);
            this.pnlRetaSenha.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRetaSenha.Name = "pnlRetaSenha";
            this.pnlRetaSenha.Size = new System.Drawing.Size(217, 2);
            this.pnlRetaSenha.TabIndex = 2;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 383);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organ";
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOlho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel pnlRetaLogin;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel pnlRetaSenha;
        private System.Windows.Forms.Button btnEntrar;
        private Panel pnlBackground;
        private Label lblBemVindo;
        private PictureBox pcbUsuario;
        private PictureBox pcbSenha;
        private PictureBox pcbOlho;
        private PictureBox pcbSair;
    }
}

