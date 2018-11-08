namespace organ
{
    partial class novo_funcionario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cod_funcionarioLabel;
            this.tlpBarraSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblAddFuncionario = new System.Windows.Forms.Label();
            this.tlpNovoFuncionario = new System.Windows.Forms.TableLayoutPanel();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtNumCasa = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblDefensivo = new System.Windows.Forms.Label();
            this.lblDataColheita = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblTalhao = new System.Windows.Forms.Label();
            this.lblQntDefensivo = new System.Windows.Forms.Label();
            this.lblQntFertilizante = new System.Windows.Forms.Label();
            this.lblFertilizante = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dbOrganDataSet = new organ.dbOrganDataSet();
            this.tbFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFuncionarioTableAdapter = new organ.dbOrganDataSetTableAdapters.tbFuncionarioTableAdapter();
            this.tableAdapterManager = new organ.dbOrganDataSetTableAdapters.TableAdapterManager();
            this.cod_funcionarioLabel1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            cod_funcionarioLabel = new System.Windows.Forms.Label();
            this.tlpBarraSuperior.SuspendLayout();
            this.tlpNovoFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrganDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_funcionarioLabel
            // 
            cod_funcionarioLabel.AutoSize = true;
            cod_funcionarioLabel.Location = new System.Drawing.Point(222, 575);
            cod_funcionarioLabel.Name = "cod_funcionarioLabel";
            cod_funcionarioLabel.Size = new System.Drawing.Size(83, 13);
            cod_funcionarioLabel.TabIndex = 50;
            cod_funcionarioLabel.Text = "cod funcionario:";
            // 
            // tlpBarraSuperior
            // 
            this.tlpBarraSuperior.ColumnCount = 3;
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.705373F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.29462F));
            this.tlpBarraSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tlpBarraSuperior.Controls.Add(this.btnVoltar, 0, 0);
            this.tlpBarraSuperior.Controls.Add(this.lblAddFuncionario, 1, 0);
            this.tlpBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tlpBarraSuperior.Name = "tlpBarraSuperior";
            this.tlpBarraSuperior.Padding = new System.Windows.Forms.Padding(20, 20, 0, 10);
            this.tlpBarraSuperior.RowCount = 1;
            this.tlpBarraSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBarraSuperior.Size = new System.Drawing.Size(1445, 66);
            this.tlpBarraSuperior.TabIndex = 41;
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
            // lblAddFuncionario
            // 
            this.lblAddFuncionario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddFuncionario.AutoSize = true;
            this.lblAddFuncionario.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblAddFuncionario.Location = new System.Drawing.Point(537, 20);
            this.lblAddFuncionario.Name = "lblAddFuncionario";
            this.lblAddFuncionario.Padding = new System.Windows.Forms.Padding(60, 5, 0, 0);
            this.lblAddFuncionario.Size = new System.Drawing.Size(287, 34);
            this.lblAddFuncionario.TabIndex = 6;
            this.lblAddFuncionario.Text = "Adicionar funcionário";
            // 
            // tlpNovoFuncionario
            // 
            this.tlpNovoFuncionario.AutoSize = true;
            this.tlpNovoFuncionario.ColumnCount = 4;
            this.tlpNovoFuncionario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.77244F));
            this.tlpNovoFuncionario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.05281F));
            this.tlpNovoFuncionario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.56218F));
            this.tlpNovoFuncionario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.77513F));
            this.tlpNovoFuncionario.Controls.Add(this.txtIdade, 3, 0);
            this.tlpNovoFuncionario.Controls.Add(this.txtSalario, 3, 6);
            this.tlpNovoFuncionario.Controls.Add(this.txtCEP, 3, 5);
            this.tlpNovoFuncionario.Controls.Add(this.txtCargo, 1, 6);
            this.tlpNovoFuncionario.Controls.Add(this.txtNumCasa, 3, 4);
            this.tlpNovoFuncionario.Controls.Add(this.txtComplemento, 1, 5);
            this.tlpNovoFuncionario.Controls.Add(this.label2, 0, 5);
            this.tlpNovoFuncionario.Controls.Add(this.txtEndereco, 1, 4);
            this.tlpNovoFuncionario.Controls.Add(this.txtEmail, 1, 3);
            this.tlpNovoFuncionario.Controls.Add(this.txtTelefone, 1, 2);
            this.tlpNovoFuncionario.Controls.Add(this.lblDefensivo, 0, 2);
            this.tlpNovoFuncionario.Controls.Add(this.lblDataColheita, 0, 3);
            this.tlpNovoFuncionario.Controls.Add(this.txtRG, 3, 1);
            this.tlpNovoFuncionario.Controls.Add(this.lblTalhao, 0, 4);
            this.tlpNovoFuncionario.Controls.Add(this.lblQntDefensivo, 2, 2);
            this.tlpNovoFuncionario.Controls.Add(this.lblQntFertilizante, 2, 1);
            this.tlpNovoFuncionario.Controls.Add(this.lblFertilizante, 0, 1);
            this.tlpNovoFuncionario.Controls.Add(this.lblNome, 0, 0);
            this.tlpNovoFuncionario.Controls.Add(this.txtNome, 1, 0);
            this.tlpNovoFuncionario.Controls.Add(this.txtCPF, 1, 1);
            this.tlpNovoFuncionario.Controls.Add(this.txtCelular, 3, 2);
            this.tlpNovoFuncionario.Controls.Add(this.label1, 2, 4);
            this.tlpNovoFuncionario.Controls.Add(this.label3, 2, 5);
            this.tlpNovoFuncionario.Controls.Add(this.label4, 0, 6);
            this.tlpNovoFuncionario.Controls.Add(this.label5, 2, 6);
            this.tlpNovoFuncionario.Location = new System.Drawing.Point(0, 66);
            this.tlpNovoFuncionario.Name = "tlpNovoFuncionario";
            this.tlpNovoFuncionario.Padding = new System.Windows.Forms.Padding(80, 20, 0, 0);
            this.tlpNovoFuncionario.RowCount = 7;
            this.tlpNovoFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpNovoFuncionario.Size = new System.Drawing.Size(1425, 438);
            this.tlpNovoFuncionario.TabIndex = 43;
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(946, 23);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(361, 33);
            this.txtIdade.TabIndex = 50;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtSalario.Location = new System.Drawing.Point(946, 353);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(360, 33);
            this.txtSalario.TabIndex = 50;
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtCEP.Location = new System.Drawing.Point(946, 298);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(360, 33);
            this.txtCEP.TabIndex = 45;
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtCargo.Location = new System.Drawing.Point(308, 353);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(401, 33);
            this.txtCargo.TabIndex = 45;
            // 
            // txtNumCasa
            // 
            this.txtNumCasa.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtNumCasa.Location = new System.Drawing.Point(946, 243);
            this.txtNumCasa.Name = "txtNumCasa";
            this.txtNumCasa.Size = new System.Drawing.Size(361, 33);
            this.txtNumCasa.TabIndex = 45;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtComplemento.Location = new System.Drawing.Point(308, 298);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(401, 33);
            this.txtComplemento.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label2.Location = new System.Drawing.Point(83, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 45;
            this.label2.Text = "Complemento";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtEndereco.Location = new System.Drawing.Point(308, 243);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(401, 33);
            this.txtEndereco.TabIndex = 43;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtEmail.Location = new System.Drawing.Point(308, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(401, 33);
            this.txtEmail.TabIndex = 42;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtTelefone.Location = new System.Drawing.Point(308, 133);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(401, 33);
            this.txtTelefone.TabIndex = 41;
            // 
            // lblDefensivo
            // 
            this.lblDefensivo.AutoSize = true;
            this.lblDefensivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDefensivo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefensivo.Location = new System.Drawing.Point(83, 130);
            this.lblDefensivo.Name = "lblDefensivo";
            this.lblDefensivo.Size = new System.Drawing.Size(219, 55);
            this.lblDefensivo.TabIndex = 9;
            this.lblDefensivo.Text = "Telefone";
            // 
            // lblDataColheita
            // 
            this.lblDataColheita.AutoSize = true;
            this.lblDataColheita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataColheita.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataColheita.Location = new System.Drawing.Point(83, 185);
            this.lblDataColheita.Name = "lblDataColheita";
            this.lblDataColheita.Size = new System.Drawing.Size(219, 55);
            this.lblDataColheita.TabIndex = 8;
            this.lblDataColheita.Text = "Email";
            // 
            // txtRG
            // 
            this.txtRG.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(946, 78);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(361, 33);
            this.txtRG.TabIndex = 20;
            // 
            // lblTalhao
            // 
            this.lblTalhao.AutoSize = true;
            this.lblTalhao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTalhao.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTalhao.Location = new System.Drawing.Point(83, 240);
            this.lblTalhao.Name = "lblTalhao";
            this.lblTalhao.Size = new System.Drawing.Size(219, 55);
            this.lblTalhao.TabIndex = 6;
            this.lblTalhao.Text = "Endereço";
            // 
            // lblQntDefensivo
            // 
            this.lblQntDefensivo.AutoSize = true;
            this.lblQntDefensivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQntDefensivo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntDefensivo.Location = new System.Drawing.Point(805, 130);
            this.lblQntDefensivo.Name = "lblQntDefensivo";
            this.lblQntDefensivo.Size = new System.Drawing.Size(135, 55);
            this.lblQntDefensivo.TabIndex = 7;
            this.lblQntDefensivo.Text = "Celular";
            // 
            // lblQntFertilizante
            // 
            this.lblQntFertilizante.AutoSize = true;
            this.lblQntFertilizante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQntFertilizante.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntFertilizante.Location = new System.Drawing.Point(805, 75);
            this.lblQntFertilizante.Name = "lblQntFertilizante";
            this.lblQntFertilizante.Size = new System.Drawing.Size(135, 55);
            this.lblQntFertilizante.TabIndex = 11;
            this.lblQntFertilizante.Text = "RG";
            // 
            // lblFertilizante
            // 
            this.lblFertilizante.AutoSize = true;
            this.lblFertilizante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFertilizante.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFertilizante.Location = new System.Drawing.Point(83, 75);
            this.lblFertilizante.Name = "lblFertilizante";
            this.lblFertilizante.Size = new System.Drawing.Size(219, 55);
            this.lblFertilizante.TabIndex = 4;
            this.lblFertilizante.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(83, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNome.Size = new System.Drawing.Size(219, 55);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(308, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(401, 33);
            this.txtNome.TabIndex = 18;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtCPF.Location = new System.Drawing.Point(308, 78);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(401, 33);
            this.txtCPF.TabIndex = 31;
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(946, 133);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(361, 33);
            this.txtCelular.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label1.Location = new System.Drawing.Point(805, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 26);
            this.label1.TabIndex = 44;
            this.label1.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label3.Location = new System.Drawing.Point(805, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 26);
            this.label3.TabIndex = 46;
            this.label3.Text = "CEP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label4.Location = new System.Drawing.Point(83, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 26);
            this.label4.TabIndex = 47;
            this.label4.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label5.Location = new System.Drawing.Point(805, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 26);
            this.label5.TabIndex = 48;
            this.label5.Text = "Salário";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(907, 600);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(193, 92);
            this.btnRegistrar.TabIndex = 49;
            this.btnRegistrar.Text = "button1";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dbOrganDataSet
            // 
            this.dbOrganDataSet.DataSetName = "dbOrganDataSet";
            this.dbOrganDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFuncionarioBindingSource
            // 
            this.tbFuncionarioBindingSource.DataMember = "tbFuncionario";
            this.tbFuncionarioBindingSource.DataSource = this.dbOrganDataSet;
            // 
            // tbFuncionarioTableAdapter
            // 
            this.tbFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbColheitaTableAdapter = null;
            this.tableAdapterManager.tbDefensivoTableAdapter = null;
            this.tableAdapterManager.tbDoencaTableAdapter = null;
            this.tableAdapterManager.tbEnderecoTableAdapter = null;
            this.tableAdapterManager.tbEstoqueTableAdapter = null;
            this.tableAdapterManager.tbFerramentaTableAdapter = null;
            this.tableAdapterManager.tbFertilizanteTableAdapter = null;
            this.tableAdapterManager.tbFornecedorTableAdapter = null;
            this.tableAdapterManager.tbFuncionarioTableAdapter = this.tbFuncionarioTableAdapter;
            this.tableAdapterManager.tbHistorico_EstoqueTableAdapter = null;
            this.tableAdapterManager.tbLoginTableAdapter = null;
            this.tableAdapterManager.tbMaquinaTableAdapter = null;
            this.tableAdapterManager.tbPerfilTableAdapter = null;
            this.tableAdapterManager.tbPlantioTableAdapter = null;
            this.tableAdapterManager.tbPragaTableAdapter = null;
            this.tableAdapterManager.tbRelatorioTableAdapter = null;
            this.tableAdapterManager.tbSementeTableAdapter = null;
            this.tableAdapterManager.tbTalhaoTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = organ.dbOrganDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cod_funcionarioLabel1
            // 
            this.cod_funcionarioLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFuncionarioBindingSource, "cod_funcionario", true));
            this.cod_funcionarioLabel1.Location = new System.Drawing.Point(311, 575);
            this.cod_funcionarioLabel1.Name = "cod_funcionarioLabel1";
            this.cod_funcionarioLabel1.Size = new System.Drawing.Size(100, 23);
            this.cod_funcionarioLabel1.TabIndex = 51;
            this.cod_funcionarioLabel1.Text = "label6";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(494, 614);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 52;
            // 
            // novo_funcionario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1445, 801);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(cod_funcionarioLabel);
            this.Controls.Add(this.cod_funcionarioLabel1);
            this.Controls.Add(this.tlpNovoFuncionario);
            this.Controls.Add(this.tlpBarraSuperior);
            this.Controls.Add(this.btnRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(131, 83);
            this.Name = "novo_funcionario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "novo_funcionario";
            this.tlpBarraSuperior.ResumeLayout(false);
            this.tlpBarraSuperior.PerformLayout();
            this.tlpNovoFuncionario.ResumeLayout(false);
            this.tlpNovoFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrganDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpBarraSuperior;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblAddFuncionario;
        private System.Windows.Forms.TableLayoutPanel tlpNovoFuncionario;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtNumCasa;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblDefensivo;
        private System.Windows.Forms.Label lblDataColheita;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lblTalhao;
        private System.Windows.Forms.Label lblQntDefensivo;
        private System.Windows.Forms.Label lblQntFertilizante;
        private System.Windows.Forms.Label lblFertilizante;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtIdade;
        private dbOrganDataSet dbOrganDataSet;
        private System.Windows.Forms.BindingSource tbFuncionarioBindingSource;
        private dbOrganDataSetTableAdapters.tbFuncionarioTableAdapter tbFuncionarioTableAdapter;
        private dbOrganDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label cod_funcionarioLabel1;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}