namespace organ
{
    partial class detalhes_solo
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
            this.tlpCentro = new System.Windows.Forms.TableLayoutPanel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dgvDetalhesSolo = new System.Windows.Forms.DataGridView();
            this.tlpBarraSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblDetalhesSolo = new System.Windows.Forms.Label();
            this.tlpCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalhesSolo)).BeginInit();
            this.tlpBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCentro
            // 
            this.tlpCentro.ColumnCount = 2;
            this.tlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tlpCentro.Controls.Add(this.btnAtualizar, 0, 0);
            this.tlpCentro.Controls.Add(this.dgvDetalhesSolo, 0, 0);
            this.tlpCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCentro.Location = new System.Drawing.Point(0, 66);
            this.tlpCentro.Name = "tlpCentro";
            this.tlpCentro.RowCount = 1;
            this.tlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCentro.Size = new System.Drawing.Size(1384, 808);
            this.tlpCentro.TabIndex = 43;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(1184, 30);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(15, 30, 15, 3);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(184, 62);
            this.btnAtualizar.TabIndex = 42;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // dgvDetalhesSolo
            // 
            this.dgvDetalhesSolo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalhesSolo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalhesSolo.Location = new System.Drawing.Point(30, 30);
            this.dgvDetalhesSolo.Margin = new System.Windows.Forms.Padding(30);
            this.dgvDetalhesSolo.Name = "dgvDetalhesSolo";
            this.dgvDetalhesSolo.Size = new System.Drawing.Size(1109, 748);
            this.dgvDetalhesSolo.TabIndex = 39;
            // 
            // tlpBarraSuperior
            // 
            this.tlpBarraSuperior.ColumnCount = 3;
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.705373F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.29462F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tlpBarraSuperior.Controls.Add(this.btnVoltar, 0, 0);
            this.tlpBarraSuperior.Controls.Add(this.lblDetalhesSolo, 1, 0);
            this.tlpBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tlpBarraSuperior.Name = "tlpBarraSuperior";
            this.tlpBarraSuperior.Padding = new System.Windows.Forms.Padding(20, 20, 0, 10);
            this.tlpBarraSuperior.RowCount = 1;
            this.tlpBarraSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBarraSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBarraSuperior.Size = new System.Drawing.Size(1384, 66);
            this.tlpBarraSuperior.TabIndex = 42;
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
            this.btnVoltar.Size = new System.Drawing.Size(106, 30);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "   Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblDetalhesSolo
            // 
            this.lblDetalhesSolo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDetalhesSolo.AutoSize = true;
            this.lblDetalhesSolo.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblDetalhesSolo.Location = new System.Drawing.Point(515, 20);
            this.lblDetalhesSolo.Name = "lblDetalhesSolo";
            this.lblDetalhesSolo.Padding = new System.Windows.Forms.Padding(60, 5, 0, 0);
            this.lblDetalhesSolo.Size = new System.Drawing.Size(276, 36);
            this.lblDetalhesSolo.TabIndex = 10;
            this.lblDetalhesSolo.Text = "Detalhes solo";
            // 
            // detalhes_solo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1384, 874);
            this.Controls.Add(this.tlpCentro);
            this.Controls.Add(this.tlpBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "detalhes_solo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "detalhes_solo";
            this.tlpCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalhesSolo)).EndInit();
            this.tlpBarraSuperior.ResumeLayout(false);
            this.tlpBarraSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCentro;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dgvDetalhesSolo;
        private System.Windows.Forms.TableLayoutPanel tlpBarraSuperior;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblDetalhesSolo;
    }
}