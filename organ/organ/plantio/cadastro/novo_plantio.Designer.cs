namespace organ
{
    partial class novo_plantio
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
            this.lblNovoPlantio = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tlpNovoPlantio = new System.Windows.Forms.TableLayoutPanel();
            this.mskQntDefensivo = new System.Windows.Forms.MaskedTextBox();
            this.lblDefensivo = new System.Windows.Forms.Label();
            this.lblDataColheita = new System.Windows.Forms.Label();
            this.lblTalhao = new System.Windows.Forms.Label();
            this.lblQntDefensivo = new System.Windows.Forms.Label();
            this.lblQntFertilizante = new System.Windows.Forms.Label();
            this.lblQntSemente = new System.Windows.Forms.Label();
            this.cboSemente = new System.Windows.Forms.ComboBox();
            this.cboTalhao1 = new System.Windows.Forms.ComboBox();
            this.cboFertilizante = new System.Windows.Forms.ComboBox();
            this.cboDefensivo = new System.Windows.Forms.ComboBox();
            this.dtDataColheita = new System.Windows.Forms.DateTimePicker();
            this.cboTalhao2 = new System.Windows.Forms.ComboBox();
            this.cboTalhao3 = new System.Windows.Forms.ComboBox();
            this.lblFertilizante = new System.Windows.Forms.Label();
            this.lblSemente = new System.Windows.Forms.Label();
            this.mskQntSemente = new System.Windows.Forms.MaskedTextBox();
            this.mskQntFertilizante = new System.Windows.Forms.MaskedTextBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.cboFuncionario1 = new System.Windows.Forms.ComboBox();
            this.cboFuncionario2 = new System.Windows.Forms.ComboBox();
            this.cboFuncionario3 = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tlpBarraSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.tlpNovoPlantio.SuspendLayout();
            this.tlpBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNovoPlantio
            // 
            this.lblNovoPlantio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNovoPlantio.AutoSize = true;
            this.lblNovoPlantio.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblNovoPlantio.Location = new System.Drawing.Point(135, 20);
            this.lblNovoPlantio.Name = "lblNovoPlantio";
            this.lblNovoPlantio.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblNovoPlantio.Size = new System.Drawing.Size(1084, 34);
            this.lblNovoPlantio.TabIndex = 1;
            this.lblNovoPlantio.Text = "Novo plantio";
            this.lblNovoPlantio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(934, 473);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(169, 50);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tlpNovoPlantio
            // 
            this.tlpNovoPlantio.AutoSize = true;
            this.tlpNovoPlantio.ColumnCount = 4;
            this.tlpNovoPlantio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.77244F));
            this.tlpNovoPlantio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.46106F));
            this.tlpNovoPlantio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.4081F));
            this.tlpNovoPlantio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.28205F));
            this.tlpNovoPlantio.Controls.Add(this.mskQntDefensivo, 3, 2);
            this.tlpNovoPlantio.Controls.Add(this.lblDefensivo, 0, 2);
            this.tlpNovoPlantio.Controls.Add(this.lblDataColheita, 0, 3);
            this.tlpNovoPlantio.Controls.Add(this.lblTalhao, 0, 4);
            this.tlpNovoPlantio.Controls.Add(this.lblQntDefensivo, 2, 2);
            this.tlpNovoPlantio.Controls.Add(this.lblQntFertilizante, 2, 1);
            this.tlpNovoPlantio.Controls.Add(this.lblQntSemente, 2, 0);
            this.tlpNovoPlantio.Controls.Add(this.cboSemente, 1, 0);
            this.tlpNovoPlantio.Controls.Add(this.cboTalhao1, 1, 4);
            this.tlpNovoPlantio.Controls.Add(this.cboFertilizante, 1, 1);
            this.tlpNovoPlantio.Controls.Add(this.cboDefensivo, 1, 2);
            this.tlpNovoPlantio.Controls.Add(this.dtDataColheita, 1, 3);
            this.tlpNovoPlantio.Controls.Add(this.cboTalhao2, 1, 5);
            this.tlpNovoPlantio.Controls.Add(this.cboTalhao3, 1, 6);
            this.tlpNovoPlantio.Controls.Add(this.lblFertilizante, 0, 1);
            this.tlpNovoPlantio.Controls.Add(this.lblSemente, 0, 0);
            this.tlpNovoPlantio.Controls.Add(this.mskQntSemente, 3, 0);
            this.tlpNovoPlantio.Controls.Add(this.mskQntFertilizante, 3, 1);
            this.tlpNovoPlantio.Controls.Add(this.lblFuncionario, 2, 4);
            this.tlpNovoPlantio.Controls.Add(this.cboFuncionario1, 3, 4);
            this.tlpNovoPlantio.Controls.Add(this.cboFuncionario2, 3, 5);
            this.tlpNovoPlantio.Controls.Add(this.cboFuncionario3, 3, 6);
            this.tlpNovoPlantio.Controls.Add(this.btnRegistrar, 3, 8);
            this.tlpNovoPlantio.Controls.Add(this.btnLimpar, 2, 8);
            this.tlpNovoPlantio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNovoPlantio.Location = new System.Drawing.Point(0, 66);
            this.tlpNovoPlantio.Name = "tlpNovoPlantio";
            this.tlpNovoPlantio.Padding = new System.Windows.Forms.Padding(50);
            this.tlpNovoPlantio.RowCount = 9;
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpNovoPlantio.Size = new System.Drawing.Size(1384, 708);
            this.tlpNovoPlantio.TabIndex = 23;
            // 
            // mskQntDefensivo
            // 
            this.mskQntDefensivo.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.mskQntDefensivo.Location = new System.Drawing.Point(934, 163);
            this.mskQntDefensivo.Mask = "000000000";
            this.mskQntDefensivo.Name = "mskQntDefensivo";
            this.mskQntDefensivo.Size = new System.Drawing.Size(244, 33);
            this.mskQntDefensivo.TabIndex = 7;
            // 
            // lblDefensivo
            // 
            this.lblDefensivo.AutoSize = true;
            this.lblDefensivo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefensivo.Location = new System.Drawing.Point(53, 160);
            this.lblDefensivo.Name = "lblDefensivo";
            this.lblDefensivo.Size = new System.Drawing.Size(94, 26);
            this.lblDefensivo.TabIndex = 9;
            this.lblDefensivo.Text = "Defensivo";
            // 
            // lblDataColheita
            // 
            this.lblDataColheita.AutoSize = true;
            this.lblDataColheita.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataColheita.Location = new System.Drawing.Point(53, 215);
            this.lblDataColheita.Name = "lblDataColheita";
            this.lblDataColheita.Size = new System.Drawing.Size(135, 26);
            this.lblDataColheita.TabIndex = 8;
            this.lblDataColheita.Text = "Data colheita*";
            // 
            // lblTalhao
            // 
            this.lblTalhao.AutoSize = true;
            this.lblTalhao.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTalhao.Location = new System.Drawing.Point(53, 270);
            this.lblTalhao.Name = "lblTalhao";
            this.lblTalhao.Size = new System.Drawing.Size(77, 26);
            this.lblTalhao.TabIndex = 6;
            this.lblTalhao.Text = "Talhão*";
            // 
            // lblQntDefensivo
            // 
            this.lblQntDefensivo.AutoSize = true;
            this.lblQntDefensivo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntDefensivo.Location = new System.Drawing.Point(749, 160);
            this.lblQntDefensivo.Name = "lblQntDefensivo";
            this.lblQntDefensivo.Size = new System.Drawing.Size(112, 26);
            this.lblQntDefensivo.TabIndex = 7;
            this.lblQntDefensivo.Text = "Quantidade";
            // 
            // lblQntFertilizante
            // 
            this.lblQntFertilizante.AutoSize = true;
            this.lblQntFertilizante.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntFertilizante.Location = new System.Drawing.Point(749, 105);
            this.lblQntFertilizante.Name = "lblQntFertilizante";
            this.lblQntFertilizante.Size = new System.Drawing.Size(112, 26);
            this.lblQntFertilizante.TabIndex = 11;
            this.lblQntFertilizante.Text = "Quantidade";
            // 
            // lblQntSemente
            // 
            this.lblQntSemente.AutoSize = true;
            this.lblQntSemente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntSemente.Location = new System.Drawing.Point(749, 50);
            this.lblQntSemente.Name = "lblQntSemente";
            this.lblQntSemente.Size = new System.Drawing.Size(122, 26);
            this.lblQntSemente.TabIndex = 10;
            this.lblQntSemente.Text = "Quantidade*";
            // 
            // cboSemente
            // 
            this.cboSemente.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboSemente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSemente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSemente.FormattingEnabled = true;
            this.cboSemente.Location = new System.Drawing.Point(268, 53);
            this.cboSemente.Name = "cboSemente";
            this.cboSemente.Size = new System.Drawing.Size(401, 34);
            this.cboSemente.TabIndex = 2;
            // 
            // cboTalhao1
            // 
            this.cboTalhao1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTalhao1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTalhao1.FormattingEnabled = true;
            this.cboTalhao1.Location = new System.Drawing.Point(268, 273);
            this.cboTalhao1.Name = "cboTalhao1";
            this.cboTalhao1.Size = new System.Drawing.Size(401, 34);
            this.cboTalhao1.TabIndex = 9;
            // 
            // cboFertilizante
            // 
            this.cboFertilizante.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboFertilizante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFertilizante.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFertilizante.FormattingEnabled = true;
            this.cboFertilizante.Location = new System.Drawing.Point(268, 108);
            this.cboFertilizante.Name = "cboFertilizante";
            this.cboFertilizante.Size = new System.Drawing.Size(401, 34);
            this.cboFertilizante.TabIndex = 4;
            // 
            // cboDefensivo
            // 
            this.cboDefensivo.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboDefensivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDefensivo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDefensivo.FormattingEnabled = true;
            this.cboDefensivo.Location = new System.Drawing.Point(268, 163);
            this.cboDefensivo.Name = "cboDefensivo";
            this.cboDefensivo.Size = new System.Drawing.Size(401, 34);
            this.cboDefensivo.TabIndex = 6;
            // 
            // dtDataColheita
            // 
            this.dtDataColheita.CustomFormat = "dd/MM/yyyy";
            this.dtDataColheita.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtDataColheita.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataColheita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataColheita.Location = new System.Drawing.Point(268, 218);
            this.dtDataColheita.Name = "dtDataColheita";
            this.dtDataColheita.Size = new System.Drawing.Size(401, 33);
            this.dtDataColheita.TabIndex = 8;
            this.dtDataColheita.Value = new System.DateTime(2018, 11, 25, 0, 0, 0, 0);
            // 
            // cboTalhao2
            // 
            this.cboTalhao2.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboTalhao2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTalhao2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTalhao2.FormattingEnabled = true;
            this.cboTalhao2.Location = new System.Drawing.Point(268, 328);
            this.cboTalhao2.Name = "cboTalhao2";
            this.cboTalhao2.Size = new System.Drawing.Size(401, 34);
            this.cboTalhao2.TabIndex = 11;
            // 
            // cboTalhao3
            // 
            this.cboTalhao3.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboTalhao3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTalhao3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTalhao3.FormattingEnabled = true;
            this.cboTalhao3.Location = new System.Drawing.Point(268, 383);
            this.cboTalhao3.Name = "cboTalhao3";
            this.cboTalhao3.Size = new System.Drawing.Size(401, 34);
            this.cboTalhao3.TabIndex = 13;
            // 
            // lblFertilizante
            // 
            this.lblFertilizante.AutoSize = true;
            this.lblFertilizante.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFertilizante.Location = new System.Drawing.Point(53, 105);
            this.lblFertilizante.Name = "lblFertilizante";
            this.lblFertilizante.Size = new System.Drawing.Size(107, 26);
            this.lblFertilizante.TabIndex = 4;
            this.lblFertilizante.Text = "Fertilizante";
            // 
            // lblSemente
            // 
            this.lblSemente.AutoSize = true;
            this.lblSemente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemente.Location = new System.Drawing.Point(53, 50);
            this.lblSemente.Name = "lblSemente";
            this.lblSemente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSemente.Size = new System.Drawing.Size(97, 26);
            this.lblSemente.TabIndex = 3;
            this.lblSemente.Text = "Semente*";
            // 
            // mskQntSemente
            // 
            this.mskQntSemente.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.mskQntSemente.Location = new System.Drawing.Point(934, 53);
            this.mskQntSemente.Mask = "000000000";
            this.mskQntSemente.Name = "mskQntSemente";
            this.mskQntSemente.Size = new System.Drawing.Size(244, 33);
            this.mskQntSemente.TabIndex = 3;
            // 
            // mskQntFertilizante
            // 
            this.mskQntFertilizante.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.mskQntFertilizante.Location = new System.Drawing.Point(934, 108);
            this.mskQntFertilizante.Mask = "000000000";
            this.mskQntFertilizante.Name = "mskQntFertilizante";
            this.mskQntFertilizante.Size = new System.Drawing.Size(244, 33);
            this.mskQntFertilizante.TabIndex = 5;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.Location = new System.Drawing.Point(749, 270);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(123, 26);
            this.lblFuncionario.TabIndex = 5;
            this.lblFuncionario.Text = "Funcionário*";
            // 
            // cboFuncionario1
            // 
            this.cboFuncionario1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncionario1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFuncionario1.FormattingEnabled = true;
            this.cboFuncionario1.Location = new System.Drawing.Point(934, 273);
            this.cboFuncionario1.Name = "cboFuncionario1";
            this.cboFuncionario1.Size = new System.Drawing.Size(377, 34);
            this.cboFuncionario1.TabIndex = 10;
            // 
            // cboFuncionario2
            // 
            this.cboFuncionario2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncionario2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFuncionario2.FormattingEnabled = true;
            this.cboFuncionario2.Location = new System.Drawing.Point(934, 328);
            this.cboFuncionario2.Name = "cboFuncionario2";
            this.cboFuncionario2.Size = new System.Drawing.Size(377, 34);
            this.cboFuncionario2.TabIndex = 12;
            // 
            // cboFuncionario3
            // 
            this.cboFuncionario3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncionario3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFuncionario3.FormattingEnabled = true;
            this.cboFuncionario3.Location = new System.Drawing.Point(934, 383);
            this.cboFuncionario3.Name = "cboFuncionario3";
            this.cboFuncionario3.Size = new System.Drawing.Size(377, 34);
            this.cboFuncionario3.TabIndex = 14;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(749, 473);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(166, 50);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
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
            // tlpBarraSuperior
            // 
            this.tlpBarraSuperior.ColumnCount = 3;
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.31085F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.68915F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tlpBarraSuperior.Controls.Add(this.btnVoltar, 0, 0);
            this.tlpBarraSuperior.Controls.Add(this.lblNovoPlantio, 1, 0);
            this.tlpBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tlpBarraSuperior.Name = "tlpBarraSuperior";
            this.tlpBarraSuperior.Padding = new System.Windows.Forms.Padding(20, 20, 0, 10);
            this.tlpBarraSuperior.RowCount = 1;
            this.tlpBarraSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBarraSuperior.Size = new System.Drawing.Size(1384, 66);
            this.tlpBarraSuperior.TabIndex = 24;
            // 
            // novo_plantio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tlpNovoPlantio);
            this.Controls.Add(this.tlpBarraSuperior);
            this.Name = "novo_plantio";
            this.Size = new System.Drawing.Size(1384, 774);
            this.tlpNovoPlantio.ResumeLayout(false);
            this.tlpNovoPlantio.PerformLayout();
            this.tlpBarraSuperior.ResumeLayout(false);
            this.tlpBarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblNovoPlantio;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TableLayoutPanel tlpNovoPlantio;
        private System.Windows.Forms.Label lblDefensivo;
        private System.Windows.Forms.Label lblDataColheita;
        private System.Windows.Forms.Label lblTalhao;
        private System.Windows.Forms.Label lblQntDefensivo;
        private System.Windows.Forms.Label lblQntFertilizante;
        private System.Windows.Forms.Label lblQntSemente;
        private System.Windows.Forms.ComboBox cboSemente;
        private System.Windows.Forms.ComboBox cboTalhao1;
        private System.Windows.Forms.ComboBox cboFertilizante;
        private System.Windows.Forms.ComboBox cboDefensivo;
        private System.Windows.Forms.DateTimePicker dtDataColheita;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.ComboBox cboFuncionario1;
        private System.Windows.Forms.ComboBox cboTalhao2;
        private System.Windows.Forms.ComboBox cboTalhao3;
        private System.Windows.Forms.ComboBox cboFuncionario2;
        private System.Windows.Forms.ComboBox cboFuncionario3;
        private System.Windows.Forms.Label lblFertilizante;
        private System.Windows.Forms.Label lblSemente;
        private System.Windows.Forms.TableLayoutPanel tlpBarraSuperior;
        private System.Windows.Forms.MaskedTextBox mskQntDefensivo;
        private System.Windows.Forms.MaskedTextBox mskQntSemente;
        private System.Windows.Forms.MaskedTextBox mskQntFertilizante;
        private System.Windows.Forms.Button btnLimpar;
    }
}
