using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;
using System.Windows.Forms.Design;
using System.ComponentModel.Design;

namespace organ
{
    partial class frmOrgan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrgan));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.tlpBarraSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.btnSair = new System.Windows.Forms.Button();
            this.pcbOrgan = new System.Windows.Forms.PictureBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.configuracao1 = new organ.configuracao();
            this.fazenda1 = new organ.fazenda();
            this.relatorios1 = new organ.relatorios();
            this.colheita1 = new organ.colheita();
            this.plantio1 = new organ.plantio();
            this.inicio1 = new organ.inicio();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnFazenda = new System.Windows.Forms.Button();
            this.pnlSelecionado = new System.Windows.Forms.Panel();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnColheita = new System.Windows.Forms.Button();
            this.btnPlantio = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            this.tlpBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOrgan)).BeginInit();
            this.pnlLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.White;
            this.pnlSuperior.Controls.Add(this.tlpBarraSuperior);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(131, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1425, 83);
            this.pnlSuperior.TabIndex = 1;
            // 
            // tlpBarraSuperior
            // 
            this.tlpBarraSuperior.AutoSize = true;
            this.tlpBarraSuperior.ColumnCount = 3;
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tlpBarraSuperior.Controls.Add(this.btnSair, 2, 0);
            this.tlpBarraSuperior.Controls.Add(this.pcbOrgan, 1, 0);
            this.tlpBarraSuperior.Controls.Add(this.btnConfig, 0, 0);
            this.tlpBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tlpBarraSuperior.Name = "tlpBarraSuperior";
            this.tlpBarraSuperior.Padding = new System.Windows.Forms.Padding(15, 15, 15, 0);
            this.tlpBarraSuperior.RowCount = 1;
            this.tlpBarraSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBarraSuperior.Size = new System.Drawing.Size(1425, 70);
            this.tlpBarraSuperior.TabIndex = 7;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSair.BackgroundImage = global::organ.Properties.Resources.Shutdown_64px;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(1373, 25);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(35, 35);
            this.btnSair.TabIndex = 5;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pcbOrgan
            // 
            this.pcbOrgan.Image = global::organ.Properties.Resources.organ_completo;
            this.pcbOrgan.Location = new System.Drawing.Point(638, 18);
            this.pcbOrgan.Name = "pcbOrgan";
            this.pcbOrgan.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.pcbOrgan.Size = new System.Drawing.Size(107, 49);
            this.pcbOrgan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbOrgan.TabIndex = 3;
            this.pcbOrgan.TabStop = false;
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnConfig.BackgroundImage = global::organ.Properties.Resources.settings;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Location = new System.Drawing.Point(17, 25);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(35, 35);
            this.btnConfig.TabIndex = 6;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // configuracao1
            // 
            this.configuracao1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configuracao1.Location = new System.Drawing.Point(131, 83);
            this.configuracao1.Name = "configuracao1";
            this.configuracao1.Size = new System.Drawing.Size(1425, 801);
            this.configuracao1.TabIndex = 7;
            // 
            // fazenda1
            // 
            this.fazenda1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fazenda1.Location = new System.Drawing.Point(131, 83);
            this.fazenda1.Margin = new System.Windows.Forms.Padding(2);
            this.fazenda1.Name = "fazenda1";
            this.fazenda1.Size = new System.Drawing.Size(1425, 801);
            this.fazenda1.TabIndex = 7;
            // 
            // relatorios1
            // 
            this.relatorios1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relatorios1.Location = new System.Drawing.Point(131, 83);
            this.relatorios1.Margin = new System.Windows.Forms.Padding(2);
            this.relatorios1.Name = "relatorios1";
            this.relatorios1.Size = new System.Drawing.Size(1425, 801);
            this.relatorios1.TabIndex = 6;
            // 
            // colheita1
            // 
            this.colheita1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colheita1.Location = new System.Drawing.Point(131, 83);
            this.colheita1.Margin = new System.Windows.Forms.Padding(2);
            this.colheita1.Name = "colheita1";
            this.colheita1.Size = new System.Drawing.Size(1425, 801);
            this.colheita1.TabIndex = 5;
            // 
            // plantio1
            // 
            this.plantio1.BackColor = System.Drawing.SystemColors.Control;
            this.plantio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plantio1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plantio1.Location = new System.Drawing.Point(131, 83);
            this.plantio1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plantio1.Name = "plantio1";
            this.plantio1.Size = new System.Drawing.Size(1425, 801);
            this.plantio1.TabIndex = 4;
            // 
            // inicio1
            // 
            this.inicio1.AutoSize = true;
            this.inicio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inicio1.Location = new System.Drawing.Point(131, 83);
            this.inicio1.Margin = new System.Windows.Forms.Padding(2);
            this.inicio1.Name = "inicio1";
            this.inicio1.Size = new System.Drawing.Size(1425, 801);
            this.inicio1.TabIndex = 2;
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackgroundImage = global::organ.Properties.Resources.Retângulo_7;
            this.pnlLateral.Controls.Add(this.btnFazenda);
            this.pnlLateral.Controls.Add(this.pnlSelecionado);
            this.pnlLateral.Controls.Add(this.btnRelatorios);
            this.pnlLateral.Controls.Add(this.btnColheita);
            this.pnlLateral.Controls.Add(this.btnPlantio);
            this.pnlLateral.Controls.Add(this.btnInicio);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(131, 884);
            this.pnlLateral.TabIndex = 0;
            // 
            // btnFazenda
            // 
            this.btnFazenda.AutoSize = true;
            this.btnFazenda.BackColor = System.Drawing.Color.Transparent;
            this.btnFazenda.FlatAppearance.BorderSize = 0;
            this.btnFazenda.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFazenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnFazenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnFazenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFazenda.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(137)))), ((int)(((byte)(131)))));
            this.btnFazenda.Image = global::organ.Properties.Resources.fazenda_45;
            this.btnFazenda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFazenda.Location = new System.Drawing.Point(-3, 411);
            this.btnFazenda.Margin = new System.Windows.Forms.Padding(2);
            this.btnFazenda.Name = "btnFazenda";
            this.btnFazenda.Size = new System.Drawing.Size(134, 100);
            this.btnFazenda.TabIndex = 4;
            this.btnFazenda.Text = " Fazenda";
            this.btnFazenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFazenda.UseVisualStyleBackColor = false;
            this.btnFazenda.Click += new System.EventHandler(this.btnFazenda_Click);
            // 
            // pnlSelecionado
            // 
            this.pnlSelecionado.BackColor = System.Drawing.Color.Green;
            this.pnlSelecionado.Location = new System.Drawing.Point(0, 0);
            this.pnlSelecionado.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSelecionado.Name = "pnlSelecionado";
            this.pnlSelecionado.Size = new System.Drawing.Size(9, 106);
            this.pnlSelecionado.TabIndex = 3;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.AutoSize = true;
            this.btnRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(137)))), ((int)(((byte)(131)))));
            this.btnRelatorios.Image = global::organ.Properties.Resources.relatorios_45_6;
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRelatorios.Location = new System.Drawing.Point(-3, 311);
            this.btnRelatorios.Margin = new System.Windows.Forms.Padding(2);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(134, 97);
            this.btnRelatorios.TabIndex = 3;
            this.btnRelatorios.Text = " Relatórios";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnColheita
            // 
            this.btnColheita.AutoSize = true;
            this.btnColheita.BackColor = System.Drawing.Color.Transparent;
            this.btnColheita.FlatAppearance.BorderSize = 0;
            this.btnColheita.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnColheita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnColheita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnColheita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColheita.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColheita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(137)))), ((int)(((byte)(131)))));
            this.btnColheita.Image = global::organ.Properties.Resources.colheita_45_4;
            this.btnColheita.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnColheita.Location = new System.Drawing.Point(0, 214);
            this.btnColheita.Margin = new System.Windows.Forms.Padding(2);
            this.btnColheita.Name = "btnColheita";
            this.btnColheita.Size = new System.Drawing.Size(131, 94);
            this.btnColheita.TabIndex = 2;
            this.btnColheita.Text = " Colheita";
            this.btnColheita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColheita.UseVisualStyleBackColor = false;
            this.btnColheita.Click += new System.EventHandler(this.btnColheita_Click);
            // 
            // btnPlantio
            // 
            this.btnPlantio.AutoSize = true;
            this.btnPlantio.BackColor = System.Drawing.Color.Transparent;
            this.btnPlantio.FlatAppearance.BorderSize = 0;
            this.btnPlantio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPlantio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnPlantio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnPlantio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlantio.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlantio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(137)))), ((int)(((byte)(131)))));
            this.btnPlantio.Image = ((System.Drawing.Image)(resources.GetObject("btnPlantio.Image")));
            this.btnPlantio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlantio.Location = new System.Drawing.Point(-3, 110);
            this.btnPlantio.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlantio.Name = "btnPlantio";
            this.btnPlantio.Size = new System.Drawing.Size(134, 101);
            this.btnPlantio.TabIndex = 1;
            this.btnPlantio.Text = " Plantio";
            this.btnPlantio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlantio.UseVisualStyleBackColor = false;
            this.btnPlantio.Click += new System.EventHandler(this.btnPlantio_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(131, 106);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = " Início";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // frmOrgan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.configuracao1);
            this.Controls.Add(this.fazenda1);
            this.Controls.Add(this.relatorios1);
            this.Controls.Add(this.colheita1);
            this.Controls.Add(this.plantio1);
            this.Controls.Add(this.inicio1);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOrgan";
            this.Text = "inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.tlpBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbOrgan)).EndInit();
            this.pnlLateral.ResumeLayout(false);
            this.pnlLateral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Button btnSair;
        private Button btnInicio;
        private Button btnFazenda;
        private Button btnColheita;
        private Button btnRelatorios;
        private Panel pnlSelecionado;
        private Panel pnlLateral;
        private inicio inicio1;
        private plantio plantio1;
        private colheita colheita1;
        private relatorios relatorios1;
        private fazenda fazenda1;
        private PictureBox pcbOrgan;
        public Button btnPlantio;
        private Button btnConfig;
        private configuracao configuracao1;
        private TableLayoutPanel tlpBarraSuperior;
    }
}