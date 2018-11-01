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
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProgresso = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1682, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 483);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(76, 227);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(367, 32);
            this.progressBar1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnProgresso);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Location = new System.Drawing.Point(53, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 585);
            this.panel1.TabIndex = 3;
            // 
            // btnProgresso
            // 
            this.btnProgresso.BackColor = System.Drawing.Color.Transparent;
            this.btnProgresso.FlatAppearance.BorderSize = 0;
            this.btnProgresso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgresso.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgresso.Location = new System.Drawing.Point(3, 3);
            this.btnProgresso.Name = "btnProgresso";
            this.btnProgresso.Size = new System.Drawing.Size(563, 80);
            this.btnProgresso.TabIndex = 3;
            this.btnProgresso.Text = "  Progresso dos plantios  >";
            this.btnProgresso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProgresso.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(18, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 1);
            this.panel2.TabIndex = 4;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Name = "inicio";
            this.Size = new System.Drawing.Size(1875, 970);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProgresso;
        private System.Windows.Forms.Panel panel2;
    }
}
