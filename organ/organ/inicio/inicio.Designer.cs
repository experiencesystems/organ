namespace organ
{
    partial class inicio
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
            this.pnlCotacoes = new System.Windows.Forms.Panel();
            this.wbCotacoes = new System.Windows.Forms.WebBrowser();
            this.pnlLinha2 = new System.Windows.Forms.Panel();
            this.btnCotacoes = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCotacoes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCotacoes
            // 
            this.pnlCotacoes.AutoSize = true;
            this.pnlCotacoes.BackColor = System.Drawing.Color.White;
            this.pnlCotacoes.Controls.Add(this.wbCotacoes);
            this.pnlCotacoes.Controls.Add(this.pnlLinha2);
            this.pnlCotacoes.Controls.Add(this.btnCotacoes);
            this.pnlCotacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCotacoes.Location = new System.Drawing.Point(65, 65);
            this.pnlCotacoes.Margin = new System.Windows.Forms.Padding(15);
            this.pnlCotacoes.Name = "pnlCotacoes";
            this.pnlCotacoes.Size = new System.Drawing.Size(1276, 658);
            this.pnlCotacoes.TabIndex = 4;
            // 
            // wbCotacoes
            // 
            this.wbCotacoes.AllowNavigation = false;
            this.wbCotacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbCotacoes.Location = new System.Drawing.Point(14, 72);
            this.wbCotacoes.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbCotacoes.Name = "wbCotacoes";
            this.wbCotacoes.Size = new System.Drawing.Size(1251, 572);
            this.wbCotacoes.TabIndex = 5;
            this.wbCotacoes.WebBrowserShortcutsEnabled = false;
            // 
            // pnlLinha2
            // 
            this.pnlLinha2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLinha2.BackColor = System.Drawing.Color.Black;
            this.pnlLinha2.Location = new System.Drawing.Point(14, 58);
            this.pnlLinha2.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLinha2.Name = "pnlLinha2";
            this.pnlLinha2.Size = new System.Drawing.Size(1252, 1);
            this.pnlLinha2.TabIndex = 4;
            // 
            // btnCotacoes
            // 
            this.btnCotacoes.BackColor = System.Drawing.Color.Transparent;
            this.btnCotacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCotacoes.FlatAppearance.BorderSize = 0;
            this.btnCotacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotacoes.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotacoes.Location = new System.Drawing.Point(0, 0);
            this.btnCotacoes.Margin = new System.Windows.Forms.Padding(2);
            this.btnCotacoes.Name = "btnCotacoes";
            this.btnCotacoes.Size = new System.Drawing.Size(1276, 65);
            this.btnCotacoes.TabIndex = 3;
            this.btnCotacoes.Text = "  Cotações";
            this.btnCotacoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCotacoes.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pnlCotacoes, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(50);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1406, 788);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "inicio";
            this.Size = new System.Drawing.Size(1406, 788);
            this.pnlCotacoes.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCotacoes;
        private System.Windows.Forms.WebBrowser wbCotacoes;
        private System.Windows.Forms.Panel pnlLinha2;
        private System.Windows.Forms.Button btnCotacoes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
