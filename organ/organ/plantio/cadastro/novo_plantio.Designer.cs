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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tlpNovoPlantio = new System.Windows.Forms.TableLayoutPanel();
            this.lblDefensivo = new System.Windows.Forms.Label();
            this.lblDataColheita = new System.Windows.Forms.Label();
            this.txtQntDefensivo = new System.Windows.Forms.TextBox();
            this.txtQntFertilizante = new System.Windows.Forms.TextBox();
            this.lblTalhao = new System.Windows.Forms.Label();
            this.txtQntSemente = new System.Windows.Forms.TextBox();
            this.lblQntDefensivo = new System.Windows.Forms.Label();
            this.lblQntFertilizante = new System.Windows.Forms.Label();
            this.lblQntSemente = new System.Windows.Forms.Label();
            this.cboSemente = new System.Windows.Forms.ComboBox();
            this.cboTalhao1 = new System.Windows.Forms.ComboBox();
            this.cboFertilizante = new System.Windows.Forms.ComboBox();
            this.cboDefensivo = new System.Windows.Forms.ComboBox();
            this.dtDataColheita = new System.Windows.Forms.DateTimePicker();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.cboFuncionario1 = new System.Windows.Forms.ComboBox();
            this.cboTalhao2 = new System.Windows.Forms.ComboBox();
            this.cboTalhao3 = new System.Windows.Forms.ComboBox();
            this.cboTalhao4 = new System.Windows.Forms.ComboBox();
            this.cboFuncionario2 = new System.Windows.Forms.ComboBox();
            this.cboFuncionario3 = new System.Windows.Forms.ComboBox();
            this.lblFertilizante = new System.Windows.Forms.Label();
            this.lblSemente = new System.Windows.Forms.Label();
            this.lblMaquinas = new System.Windows.Forms.Label();
            this.cboMaquina1 = new System.Windows.Forms.ComboBox();
            this.cboMaquina2 = new System.Windows.Forms.ComboBox();
            this.cboMaquina3 = new System.Windows.Forms.ComboBox();
            this.cboMaquina4 = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tlpBarraSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.tlpNovoPlantio.SuspendLayout();
            this.tlpBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNovoPlantio
            // 
            this.lblNovoPlantio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNovoPlantio.AutoSize = true;
            this.lblNovoPlantio.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblNovoPlantio.Location = new System.Drawing.Point(591, 20);
            this.lblNovoPlantio.Name = "lblNovoPlantio";
            this.lblNovoPlantio.Padding = new System.Windows.Forms.Padding(30, 5, 0, 0);
            this.lblNovoPlantio.Size = new System.Drawing.Size(171, 34);
            this.lblNovoPlantio.TabIndex = 1;
            this.lblNovoPlantio.Text = "Novo plantio";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(1084, 684);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(143, 50);
            this.btnEnviar.TabIndex = 21;
            this.btnEnviar.Text = "Registrar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(911, 684);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(143, 50);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tlpNovoPlantio
            // 
            this.tlpNovoPlantio.AutoSize = true;
            this.tlpNovoPlantio.ColumnCount = 4;
            this.tlpNovoPlantio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.77244F));
            this.tlpNovoPlantio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.05983F));
            this.tlpNovoPlantio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.99145F));
            this.tlpNovoPlantio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.28205F));
            this.tlpNovoPlantio.Controls.Add(this.lblDefensivo, 0, 2);
            this.tlpNovoPlantio.Controls.Add(this.lblDataColheita, 0, 3);
            this.tlpNovoPlantio.Controls.Add(this.txtQntDefensivo, 3, 2);
            this.tlpNovoPlantio.Controls.Add(this.txtQntFertilizante, 3, 1);
            this.tlpNovoPlantio.Controls.Add(this.lblTalhao, 0, 4);
            this.tlpNovoPlantio.Controls.Add(this.txtQntSemente, 3, 0);
            this.tlpNovoPlantio.Controls.Add(this.lblQntDefensivo, 2, 2);
            this.tlpNovoPlantio.Controls.Add(this.lblQntFertilizante, 2, 1);
            this.tlpNovoPlantio.Controls.Add(this.lblQntSemente, 2, 0);
            this.tlpNovoPlantio.Controls.Add(this.cboSemente, 1, 0);
            this.tlpNovoPlantio.Controls.Add(this.cboTalhao1, 1, 4);
            this.tlpNovoPlantio.Controls.Add(this.cboFertilizante, 1, 1);
            this.tlpNovoPlantio.Controls.Add(this.cboDefensivo, 1, 2);
            this.tlpNovoPlantio.Controls.Add(this.dtDataColheita, 1, 3);
            this.tlpNovoPlantio.Controls.Add(this.lblFuncionario, 0, 8);
            this.tlpNovoPlantio.Controls.Add(this.cboFuncionario1, 1, 8);
            this.tlpNovoPlantio.Controls.Add(this.cboTalhao2, 1, 5);
            this.tlpNovoPlantio.Controls.Add(this.cboTalhao3, 1, 6);
            this.tlpNovoPlantio.Controls.Add(this.cboTalhao4, 1, 7);
            this.tlpNovoPlantio.Controls.Add(this.cboFuncionario2, 1, 9);
            this.tlpNovoPlantio.Controls.Add(this.cboFuncionario3, 1, 10);
            this.tlpNovoPlantio.Controls.Add(this.lblFertilizante, 0, 1);
            this.tlpNovoPlantio.Controls.Add(this.lblSemente, 0, 0);
            this.tlpNovoPlantio.Controls.Add(this.lblMaquinas, 2, 4);
            this.tlpNovoPlantio.Controls.Add(this.cboMaquina1, 3, 4);
            this.tlpNovoPlantio.Controls.Add(this.cboMaquina2, 3, 5);
            this.tlpNovoPlantio.Controls.Add(this.cboMaquina3, 3, 6);
            this.tlpNovoPlantio.Controls.Add(this.cboMaquina4, 3, 7);
            this.tlpNovoPlantio.Location = new System.Drawing.Point(92, 90);
            this.tlpNovoPlantio.Name = "tlpNovoPlantio";
            this.tlpNovoPlantio.RowCount = 11;
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoPlantio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoPlantio.Size = new System.Drawing.Size(1174, 605);
            this.tlpNovoPlantio.TabIndex = 23;
            // 
            // lblDefensivo
            // 
            this.lblDefensivo.AutoSize = true;
            this.lblDefensivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDefensivo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefensivo.Location = new System.Drawing.Point(3, 110);
            this.lblDefensivo.Name = "lblDefensivo";
            this.lblDefensivo.Size = new System.Drawing.Size(190, 55);
            this.lblDefensivo.TabIndex = 9;
            this.lblDefensivo.Text = "Defensivo";
            // 
            // lblDataColheita
            // 
            this.lblDataColheita.AutoSize = true;
            this.lblDataColheita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataColheita.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataColheita.Location = new System.Drawing.Point(3, 165);
            this.lblDataColheita.Name = "lblDataColheita";
            this.lblDataColheita.Size = new System.Drawing.Size(190, 55);
            this.lblDataColheita.TabIndex = 8;
            this.lblDataColheita.Text = "Data colheita";
            // 
            // txtQntDefensivo
            // 
            this.txtQntDefensivo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQntDefensivo.Location = new System.Drawing.Point(809, 113);
            this.txtQntDefensivo.Name = "txtQntDefensivo";
            this.txtQntDefensivo.Size = new System.Drawing.Size(209, 33);
            this.txtQntDefensivo.TabIndex = 19;
            // 
            // txtQntFertilizante
            // 
            this.txtQntFertilizante.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQntFertilizante.Location = new System.Drawing.Point(809, 58);
            this.txtQntFertilizante.Name = "txtQntFertilizante";
            this.txtQntFertilizante.Size = new System.Drawing.Size(209, 33);
            this.txtQntFertilizante.TabIndex = 20;
            // 
            // lblTalhao
            // 
            this.lblTalhao.AutoSize = true;
            this.lblTalhao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTalhao.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTalhao.Location = new System.Drawing.Point(3, 220);
            this.lblTalhao.Name = "lblTalhao";
            this.lblTalhao.Size = new System.Drawing.Size(190, 55);
            this.lblTalhao.TabIndex = 6;
            this.lblTalhao.Text = "Talhão";
            // 
            // txtQntSemente
            // 
            this.txtQntSemente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQntSemente.Location = new System.Drawing.Point(809, 3);
            this.txtQntSemente.Name = "txtQntSemente";
            this.txtQntSemente.Size = new System.Drawing.Size(209, 33);
            this.txtQntSemente.TabIndex = 18;
            // 
            // lblQntDefensivo
            // 
            this.lblQntDefensivo.AutoSize = true;
            this.lblQntDefensivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQntDefensivo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntDefensivo.Location = new System.Drawing.Point(657, 110);
            this.lblQntDefensivo.Name = "lblQntDefensivo";
            this.lblQntDefensivo.Size = new System.Drawing.Size(146, 55);
            this.lblQntDefensivo.TabIndex = 7;
            this.lblQntDefensivo.Text = "Quantidade";
            // 
            // lblQntFertilizante
            // 
            this.lblQntFertilizante.AutoSize = true;
            this.lblQntFertilizante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQntFertilizante.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntFertilizante.Location = new System.Drawing.Point(657, 55);
            this.lblQntFertilizante.Name = "lblQntFertilizante";
            this.lblQntFertilizante.Size = new System.Drawing.Size(146, 55);
            this.lblQntFertilizante.TabIndex = 11;
            this.lblQntFertilizante.Text = "Quantidade";
            // 
            // lblQntSemente
            // 
            this.lblQntSemente.AutoSize = true;
            this.lblQntSemente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQntSemente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntSemente.Location = new System.Drawing.Point(657, 0);
            this.lblQntSemente.Name = "lblQntSemente";
            this.lblQntSemente.Size = new System.Drawing.Size(146, 55);
            this.lblQntSemente.TabIndex = 10;
            this.lblQntSemente.Text = "Quantidade";
            // 
            // cboSemente
            // 
            this.cboSemente.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboSemente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSemente.FormattingEnabled = true;
            this.cboSemente.Location = new System.Drawing.Point(199, 3);
            this.cboSemente.Name = "cboSemente";
            this.cboSemente.Size = new System.Drawing.Size(401, 34);
            this.cboSemente.TabIndex = 12;
            // 
            // cboTalhao1
            // 
            this.cboTalhao1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTalhao1.FormattingEnabled = true;
            this.cboTalhao1.Location = new System.Drawing.Point(199, 223);
            this.cboTalhao1.Name = "cboTalhao1";
            this.cboTalhao1.Size = new System.Drawing.Size(401, 34);
            this.cboTalhao1.TabIndex = 16;
            // 
            // cboFertilizante
            // 
            this.cboFertilizante.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboFertilizante.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFertilizante.FormattingEnabled = true;
            this.cboFertilizante.Location = new System.Drawing.Point(199, 58);
            this.cboFertilizante.Name = "cboFertilizante";
            this.cboFertilizante.Size = new System.Drawing.Size(401, 34);
            this.cboFertilizante.TabIndex = 15;
            // 
            // cboDefensivo
            // 
            this.cboDefensivo.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboDefensivo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDefensivo.FormattingEnabled = true;
            this.cboDefensivo.Location = new System.Drawing.Point(199, 113);
            this.cboDefensivo.Name = "cboDefensivo";
            this.cboDefensivo.Size = new System.Drawing.Size(401, 34);
            this.cboDefensivo.TabIndex = 14;
            // 
            // dtDataColheita
            // 
            this.dtDataColheita.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtDataColheita.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataColheita.Location = new System.Drawing.Point(199, 168);
            this.dtDataColheita.Name = "dtDataColheita";
            this.dtDataColheita.Size = new System.Drawing.Size(401, 33);
            this.dtDataColheita.TabIndex = 17;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFuncionario.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.Location = new System.Drawing.Point(3, 440);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(190, 55);
            this.lblFuncionario.TabIndex = 5;
            this.lblFuncionario.Text = "Funcionário";
            // 
            // cboFuncionario1
            // 
            this.cboFuncionario1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFuncionario1.FormattingEnabled = true;
            this.cboFuncionario1.Location = new System.Drawing.Point(199, 443);
            this.cboFuncionario1.Name = "cboFuncionario1";
            this.cboFuncionario1.Size = new System.Drawing.Size(401, 34);
            this.cboFuncionario1.TabIndex = 13;
            // 
            // cboTalhao2
            // 
            this.cboTalhao2.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboTalhao2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTalhao2.FormattingEnabled = true;
            this.cboTalhao2.Location = new System.Drawing.Point(199, 278);
            this.cboTalhao2.Name = "cboTalhao2";
            this.cboTalhao2.Size = new System.Drawing.Size(401, 34);
            this.cboTalhao2.TabIndex = 21;
            // 
            // cboTalhao3
            // 
            this.cboTalhao3.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboTalhao3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTalhao3.FormattingEnabled = true;
            this.cboTalhao3.Location = new System.Drawing.Point(199, 333);
            this.cboTalhao3.Name = "cboTalhao3";
            this.cboTalhao3.Size = new System.Drawing.Size(401, 34);
            this.cboTalhao3.TabIndex = 22;
            // 
            // cboTalhao4
            // 
            this.cboTalhao4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTalhao4.FormattingEnabled = true;
            this.cboTalhao4.Location = new System.Drawing.Point(199, 388);
            this.cboTalhao4.Name = "cboTalhao4";
            this.cboTalhao4.Size = new System.Drawing.Size(401, 34);
            this.cboTalhao4.TabIndex = 23;
            // 
            // cboFuncionario2
            // 
            this.cboFuncionario2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFuncionario2.FormattingEnabled = true;
            this.cboFuncionario2.Location = new System.Drawing.Point(199, 498);
            this.cboFuncionario2.Name = "cboFuncionario2";
            this.cboFuncionario2.Size = new System.Drawing.Size(401, 34);
            this.cboFuncionario2.TabIndex = 24;
            // 
            // cboFuncionario3
            // 
            this.cboFuncionario3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFuncionario3.FormattingEnabled = true;
            this.cboFuncionario3.Location = new System.Drawing.Point(199, 553);
            this.cboFuncionario3.Name = "cboFuncionario3";
            this.cboFuncionario3.Size = new System.Drawing.Size(401, 34);
            this.cboFuncionario3.TabIndex = 25;
            // 
            // lblFertilizante
            // 
            this.lblFertilizante.AutoSize = true;
            this.lblFertilizante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFertilizante.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFertilizante.Location = new System.Drawing.Point(3, 55);
            this.lblFertilizante.Name = "lblFertilizante";
            this.lblFertilizante.Size = new System.Drawing.Size(190, 55);
            this.lblFertilizante.TabIndex = 4;
            this.lblFertilizante.Text = "Fertilizante";
            // 
            // lblSemente
            // 
            this.lblSemente.AutoSize = true;
            this.lblSemente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSemente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemente.Location = new System.Drawing.Point(3, 0);
            this.lblSemente.Name = "lblSemente";
            this.lblSemente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSemente.Size = new System.Drawing.Size(190, 55);
            this.lblSemente.TabIndex = 3;
            this.lblSemente.Text = "Semente";
            // 
            // lblMaquinas
            // 
            this.lblMaquinas.AutoSize = true;
            this.lblMaquinas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaquinas.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaquinas.Location = new System.Drawing.Point(657, 220);
            this.lblMaquinas.Name = "lblMaquinas";
            this.lblMaquinas.Size = new System.Drawing.Size(146, 55);
            this.lblMaquinas.TabIndex = 26;
            this.lblMaquinas.Text = "Máquinas";
            // 
            // cboMaquina1
            // 
            this.cboMaquina1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cboMaquina1.FormattingEnabled = true;
            this.cboMaquina1.Location = new System.Drawing.Point(809, 223);
            this.cboMaquina1.Name = "cboMaquina1";
            this.cboMaquina1.Size = new System.Drawing.Size(361, 34);
            this.cboMaquina1.TabIndex = 27;
            // 
            // cboMaquina2
            // 
            this.cboMaquina2.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cboMaquina2.FormattingEnabled = true;
            this.cboMaquina2.Location = new System.Drawing.Point(809, 278);
            this.cboMaquina2.Name = "cboMaquina2";
            this.cboMaquina2.Size = new System.Drawing.Size(361, 34);
            this.cboMaquina2.TabIndex = 28;
            // 
            // cboMaquina3
            // 
            this.cboMaquina3.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cboMaquina3.FormattingEnabled = true;
            this.cboMaquina3.Location = new System.Drawing.Point(809, 333);
            this.cboMaquina3.Name = "cboMaquina3";
            this.cboMaquina3.Size = new System.Drawing.Size(361, 34);
            this.cboMaquina3.TabIndex = 29;
            // 
            // cboMaquina4
            // 
            this.cboMaquina4.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cboMaquina4.FormattingEnabled = true;
            this.cboMaquina4.Location = new System.Drawing.Point(809, 388);
            this.cboMaquina4.Name = "cboMaquina4";
            this.cboMaquina4.Size = new System.Drawing.Size(361, 34);
            this.cboMaquina4.TabIndex = 30;
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
            this.Controls.Add(this.tlpBarraSuperior);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.tlpNovoPlantio);
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
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TableLayoutPanel tlpNovoPlantio;
        private System.Windows.Forms.Label lblDefensivo;
        private System.Windows.Forms.Label lblDataColheita;
        private System.Windows.Forms.TextBox txtQntDefensivo;
        private System.Windows.Forms.TextBox txtQntFertilizante;
        private System.Windows.Forms.Label lblTalhao;
        private System.Windows.Forms.TextBox txtQntSemente;
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
        private System.Windows.Forms.ComboBox cboTalhao4;
        private System.Windows.Forms.ComboBox cboFuncionario2;
        private System.Windows.Forms.ComboBox cboFuncionario3;
        private System.Windows.Forms.Label lblFertilizante;
        private System.Windows.Forms.Label lblSemente;
        private System.Windows.Forms.Label lblMaquinas;
        private System.Windows.Forms.ComboBox cboMaquina1;
        private System.Windows.Forms.ComboBox cboMaquina2;
        private System.Windows.Forms.ComboBox cboMaquina3;
        private System.Windows.Forms.ComboBox cboMaquina4;
        private System.Windows.Forms.TableLayoutPanel tlpBarraSuperior;
    }
}
