﻿namespace organ
{
    partial class plantio
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
            this.sementes1 = new organ.sementes();
            this.novo_plantio1 = new organ.novo_plantio();
            this.fertilizantes1 = new organ.fertilizantes();
            this.solo1 = new organ.solo();
            this.maquinas1 = new organ.maquinas();
            this.ferramentas1 = new organ.ferramentas();
            this.defensivo1 = new organ.defensivo();
            this.btnDefensivo = new System.Windows.Forms.Button();
            this.btnFerramentas = new System.Windows.Forms.Button();
            this.btnMaquinas = new System.Windows.Forms.Button();
            this.btnSementes = new System.Windows.Forms.Button();
            this.btnFertilizantes = new System.Windows.Forms.Button();
            this.btnSolo = new System.Windows.Forms.Button();
            this.btnNovoPlantio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sementes1
            // 
            this.sementes1.Location = new System.Drawing.Point(77, 175);
            this.sementes1.Name = "sementes1";
            this.sementes1.Size = new System.Drawing.Size(163, 107);
            this.sementes1.TabIndex = 11;
            // 
            // novo_plantio1
            // 
            this.novo_plantio1.Location = new System.Drawing.Point(136, 40);
            this.novo_plantio1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.novo_plantio1.Name = "novo_plantio1";
            this.novo_plantio1.Size = new System.Drawing.Size(200, 59);
            this.novo_plantio1.TabIndex = 10;
            this.novo_plantio1.Visible = false;
            // 
            // fertilizantes1
            // 
            this.fertilizantes1.Location = new System.Drawing.Point(591, 165);
            this.fertilizantes1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.fertilizantes1.Name = "fertilizantes1";
            this.fertilizantes1.Size = new System.Drawing.Size(150, 43);
            this.fertilizantes1.TabIndex = 12;
            // 
            // solo1
            // 
            this.solo1.Location = new System.Drawing.Point(1086, 175);
            this.solo1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.solo1.Name = "solo1";
            this.solo1.Size = new System.Drawing.Size(150, 84);
            this.solo1.TabIndex = 13;
            // 
            // maquinas1
            // 
            this.maquinas1.Location = new System.Drawing.Point(88, 521);
            this.maquinas1.Name = "maquinas1";
            this.maquinas1.Size = new System.Drawing.Size(119, 53);
            this.maquinas1.TabIndex = 14;
            // 
            // ferramentas1
            // 
            this.ferramentas1.Location = new System.Drawing.Point(591, 521);
            this.ferramentas1.Name = "ferramentas1";
            this.ferramentas1.Size = new System.Drawing.Size(158, 85);
            this.ferramentas1.TabIndex = 15;
            // 
            // defensivo1
            // 
            this.defensivo1.Location = new System.Drawing.Point(1083, 521);
            this.defensivo1.Name = "defensivo1";
            this.defensivo1.Size = new System.Drawing.Size(153, 76);
            this.defensivo1.TabIndex = 16;
            // 
            // btnDefensivo
            // 
            this.btnDefensivo.BackColor = System.Drawing.Color.White;
            this.btnDefensivo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDefensivo.FlatAppearance.BorderSize = 2;
            this.btnDefensivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefensivo.Font = new System.Drawing.Font("Calibri", 20F);
            this.btnDefensivo.Image = global::organ.Properties.Resources.defensivo_2;
            this.btnDefensivo.Location = new System.Drawing.Point(1063, 501);
            this.btnDefensivo.Name = "btnDefensivo";
            this.btnDefensivo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnDefensivo.Size = new System.Drawing.Size(459, 308);
            this.btnDefensivo.TabIndex = 9;
            this.btnDefensivo.Text = " Defensivo";
            this.btnDefensivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDefensivo.UseVisualStyleBackColor = false;
            this.btnDefensivo.Click += new System.EventHandler(this.btnDefensivo_Click);
            // 
            // btnFerramentas
            // 
            this.btnFerramentas.BackColor = System.Drawing.Color.White;
            this.btnFerramentas.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFerramentas.FlatAppearance.BorderSize = 2;
            this.btnFerramentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFerramentas.Font = new System.Drawing.Font("Calibri", 20F);
            this.btnFerramentas.Image = global::organ.Properties.Resources.ferramentas_2;
            this.btnFerramentas.Location = new System.Drawing.Point(569, 501);
            this.btnFerramentas.Name = "btnFerramentas";
            this.btnFerramentas.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnFerramentas.Size = new System.Drawing.Size(459, 308);
            this.btnFerramentas.TabIndex = 8;
            this.btnFerramentas.Text = "Ferramentas";
            this.btnFerramentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFerramentas.UseVisualStyleBackColor = false;
            this.btnFerramentas.Click += new System.EventHandler(this.btnFerramentas_Click);
            // 
            // btnMaquinas
            // 
            this.btnMaquinas.BackColor = System.Drawing.Color.White;
            this.btnMaquinas.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnMaquinas.FlatAppearance.BorderSize = 2;
            this.btnMaquinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaquinas.Font = new System.Drawing.Font("Calibri", 20F);
            this.btnMaquinas.Image = global::organ.Properties.Resources.trator_9;
            this.btnMaquinas.Location = new System.Drawing.Point(68, 501);
            this.btnMaquinas.Name = "btnMaquinas";
            this.btnMaquinas.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnMaquinas.Size = new System.Drawing.Size(459, 308);
            this.btnMaquinas.TabIndex = 7;
            this.btnMaquinas.Text = "Máquinas";
            this.btnMaquinas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaquinas.UseVisualStyleBackColor = false;
            this.btnMaquinas.Click += new System.EventHandler(this.btnMaquinas_Click);
            // 
            // btnSementes
            // 
            this.btnSementes.BackColor = System.Drawing.Color.White;
            this.btnSementes.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSementes.FlatAppearance.BorderSize = 2;
            this.btnSementes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSementes.Font = new System.Drawing.Font("Calibri", 20F);
            this.btnSementes.Image = global::organ.Properties.Resources.semente_7;
            this.btnSementes.Location = new System.Drawing.Point(68, 154);
            this.btnSementes.Name = "btnSementes";
            this.btnSementes.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnSementes.Size = new System.Drawing.Size(459, 308);
            this.btnSementes.TabIndex = 6;
            this.btnSementes.Text = "Sementes";
            this.btnSementes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSementes.UseVisualStyleBackColor = false;
            this.btnSementes.Click += new System.EventHandler(this.btnSementes_Click);
            // 
            // btnFertilizantes
            // 
            this.btnFertilizantes.BackColor = System.Drawing.Color.White;
            this.btnFertilizantes.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFertilizantes.FlatAppearance.BorderSize = 2;
            this.btnFertilizantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFertilizantes.Font = new System.Drawing.Font("Calibri", 20F);
            this.btnFertilizantes.Image = global::organ.Properties.Resources.fertilizante;
            this.btnFertilizantes.Location = new System.Drawing.Point(569, 154);
            this.btnFertilizantes.Name = "btnFertilizantes";
            this.btnFertilizantes.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnFertilizantes.Size = new System.Drawing.Size(459, 308);
            this.btnFertilizantes.TabIndex = 5;
            this.btnFertilizantes.Text = "Fertilizantes";
            this.btnFertilizantes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFertilizantes.UseVisualStyleBackColor = false;
            this.btnFertilizantes.Click += new System.EventHandler(this.btnFertilizantes_Click);
            // 
            // btnSolo
            // 
            this.btnSolo.BackColor = System.Drawing.Color.White;
            this.btnSolo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSolo.FlatAppearance.BorderSize = 2;
            this.btnSolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolo.Font = new System.Drawing.Font("Calibri", 20F);
            this.btnSolo.Image = global::organ.Properties.Resources.solo_3;
            this.btnSolo.Location = new System.Drawing.Point(1063, 154);
            this.btnSolo.Name = "btnSolo";
            this.btnSolo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnSolo.Size = new System.Drawing.Size(459, 308);
            this.btnSolo.TabIndex = 4;
            this.btnSolo.Text = "Solo";
            this.btnSolo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSolo.UseVisualStyleBackColor = false;
            this.btnSolo.Click += new System.EventHandler(this.btnSolo_Click);
            // 
            // btnNovoPlantio
            // 
            this.btnNovoPlantio.BackgroundImage = global::organ.Properties.Resources.btnNovoPlantio;
            this.btnNovoPlantio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoPlantio.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoPlantio.ForeColor = System.Drawing.Color.White;
            this.btnNovoPlantio.Image = global::organ.Properties.Resources.icone_novo_plantio_4;
            this.btnNovoPlantio.Location = new System.Drawing.Point(68, 28);
            this.btnNovoPlantio.Name = "btnNovoPlantio";
            this.btnNovoPlantio.Size = new System.Drawing.Size(1454, 92);
            this.btnNovoPlantio.TabIndex = 0;
            this.btnNovoPlantio.Text = " NOVO PLANTIO";
            this.btnNovoPlantio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoPlantio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovoPlantio.UseVisualStyleBackColor = true;
            this.btnNovoPlantio.Click += new System.EventHandler(this.btnNovoPlantio_Click);
            // 
            // plantio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.defensivo1);
            this.Controls.Add(this.ferramentas1);
            this.Controls.Add(this.maquinas1);
            this.Controls.Add(this.solo1);
            this.Controls.Add(this.fertilizantes1);
            this.Controls.Add(this.sementes1);
            this.Controls.Add(this.novo_plantio1);
            this.Controls.Add(this.btnDefensivo);
            this.Controls.Add(this.btnFerramentas);
            this.Controls.Add(this.btnMaquinas);
            this.Controls.Add(this.btnSementes);
            this.Controls.Add(this.btnFertilizantes);
            this.Controls.Add(this.btnSolo);
            this.Controls.Add(this.btnNovoPlantio);
            this.Font = new System.Drawing.Font("Calibri", 15F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "plantio";
            this.Size = new System.Drawing.Size(1583, 874);
            this.Load += new System.EventHandler(this.plantio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoPlantio;
        private System.Windows.Forms.Button btnSolo;
        private System.Windows.Forms.Button btnFertilizantes;
        private System.Windows.Forms.Button btnSementes;
        private System.Windows.Forms.Button btnMaquinas;
        private System.Windows.Forms.Button btnFerramentas;
        private System.Windows.Forms.Button btnDefensivo;
        private novo_plantio novo_plantio1;
        private sementes sementes1;
        private fertilizantes fertilizantes1;
        private solo solo1;
        private maquinas maquinas1;
        private ferramentas ferramentas1;
        private defensivo defensivo1;
    }
}
