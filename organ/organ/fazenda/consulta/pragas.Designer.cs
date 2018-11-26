namespace organ
{
    partial class pragas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpBarraSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPragas = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dgvPragas = new System.Windows.Forms.DataGridView();
            this.tlpBarraSuperior.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPragas)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBarraSuperior
            // 
            this.tlpBarraSuperior.ColumnCount = 3;
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.705373F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.29462F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tlpBarraSuperior.Controls.Add(this.btnVoltar, 0, 0);
            this.tlpBarraSuperior.Controls.Add(this.btnAdd, 2, 0);
            this.tlpBarraSuperior.Controls.Add(this.lblPragas, 1, 0);
            this.tlpBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tlpBarraSuperior.Name = "tlpBarraSuperior";
            this.tlpBarraSuperior.Padding = new System.Windows.Forms.Padding(20, 20, 0, 10);
            this.tlpBarraSuperior.RowCount = 1;
            this.tlpBarraSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBarraSuperior.Size = new System.Drawing.Size(1384, 66);
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
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 16F);
            this.btnAdd.Image = global::organ.Properties.Resources.soma;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(1168, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(204, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "  Adicionar novo";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPragas
            // 
            this.lblPragas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPragas.AutoSize = true;
            this.lblPragas.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblPragas.Location = new System.Drawing.Point(579, 20);
            this.lblPragas.Name = "lblPragas";
            this.lblPragas.Padding = new System.Windows.Forms.Padding(60, 5, 0, 0);
            this.lblPragas.Size = new System.Drawing.Size(137, 34);
            this.lblPragas.TabIndex = 6;
            this.lblPragas.Text = "Pragas";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel1.Controls.Add(this.btnAtualizar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvPragas, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1384, 708);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(1184, 30);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(15, 30, 15, 3);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(184, 62);
            this.btnAtualizar.TabIndex = 41;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dgvPragas
            // 
            this.dgvPragas.AllowUserToAddRows = false;
            this.dgvPragas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPragas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPragas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPragas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPragas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPragas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPragas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPragas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPragas.Location = new System.Drawing.Point(30, 30);
            this.dgvPragas.Margin = new System.Windows.Forms.Padding(30);
            this.dgvPragas.Name = "dgvPragas";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPragas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPragas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPragas.Size = new System.Drawing.Size(1109, 648);
            this.dgvPragas.TabIndex = 39;
            this.dgvPragas.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvPragas_UserDeletingRow);
            // 
            // pragas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tlpBarraSuperior);
            this.Name = "pragas";
            this.Size = new System.Drawing.Size(1384, 774);
            this.tlpBarraSuperior.ResumeLayout(false);
            this.tlpBarraSuperior.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPragas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBarraSuperior;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPragas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvPragas;
        private System.Windows.Forms.Button btnAtualizar;
    }
}
