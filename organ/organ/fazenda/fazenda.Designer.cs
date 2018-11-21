namespace organ
{
    partial class fazenda
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
            this.estoque1 = new organ.estoque();
            this.pragas1 = new organ.pragas();
            this.doencas1 = new organ.doencas();
            this.fornecedores1 = new organ.fornecedores();
            this.funcionarios1 = new organ.funcionarios();
            this.btnDoenças = new System.Windows.Forms.Button();
            this.btnControleGastos = new System.Windows.Forms.Button();
            this.btnPragas = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // estoque1
            // 
            this.estoque1.Location = new System.Drawing.Point(620, 405);
            this.estoque1.Name = "estoque1";
            this.estoque1.Size = new System.Drawing.Size(261, 81);
            this.estoque1.TabIndex = 18;
            this.estoque1.Visible = false;
            // 
            // pragas1
            // 
            this.pragas1.Location = new System.Drawing.Point(1171, 61);
            this.pragas1.Name = "pragas1";
            this.pragas1.Size = new System.Drawing.Size(147, 77);
            this.pragas1.TabIndex = 16;
            this.pragas1.Visible = false;
            // 
            // doencas1
            // 
            this.doencas1.Location = new System.Drawing.Point(290, 405);
            this.doencas1.Name = "doencas1";
            this.doencas1.Size = new System.Drawing.Size(133, 65);
            this.doencas1.TabIndex = 15;
            this.doencas1.Visible = false;
            // 
            // fornecedores1
            // 
            this.fornecedores1.Location = new System.Drawing.Point(730, 61);
            this.fornecedores1.Name = "fornecedores1";
            this.fornecedores1.Size = new System.Drawing.Size(139, 51);
            this.fornecedores1.TabIndex = 14;
            this.fornecedores1.Visible = false;
            // 
            // funcionarios1
            // 
            this.funcionarios1.Location = new System.Drawing.Point(308, 61);
            this.funcionarios1.Name = "funcionarios1";
            this.funcionarios1.Size = new System.Drawing.Size(115, 70);
            this.funcionarios1.TabIndex = 12;
            this.funcionarios1.Visible = false;
            // 
            // btnDoenças
            // 
            this.btnDoenças.BackColor = System.Drawing.Color.White;
            this.btnDoenças.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDoenças.FlatAppearance.BorderSize = 2;
            this.btnDoenças.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoenças.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoenças.Image = global::organ.Properties.Resources.doencas1;
            this.btnDoenças.Location = new System.Drawing.Point(42, 393);
            this.btnDoenças.Name = "btnDoenças";
            this.btnDoenças.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnDoenças.Size = new System.Drawing.Size(405, 310);
            this.btnDoenças.TabIndex = 11;
            this.btnDoenças.Text = "Doenças";
            this.btnDoenças.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoenças.UseVisualStyleBackColor = false;
            this.btnDoenças.Click += new System.EventHandler(this.btnDoenças_Click);
            // 
            // btnControleGastos
            // 
            this.btnControleGastos.Location = new System.Drawing.Point(0, 0);
            this.btnControleGastos.Name = "btnControleGastos";
            this.btnControleGastos.Size = new System.Drawing.Size(75, 23);
            this.btnControleGastos.TabIndex = 19;
            // 
            // btnPragas
            // 
            this.btnPragas.BackColor = System.Drawing.Color.White;
            this.btnPragas.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPragas.FlatAppearance.BorderSize = 2;
            this.btnPragas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPragas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPragas.Image = global::organ.Properties.Resources.pragas;
            this.btnPragas.Location = new System.Drawing.Point(939, 40);
            this.btnPragas.Name = "btnPragas";
            this.btnPragas.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnPragas.Size = new System.Drawing.Size(405, 310);
            this.btnPragas.TabIndex = 9;
            this.btnPragas.Text = "Pragas";
            this.btnPragas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPragas.UseVisualStyleBackColor = false;
            this.btnPragas.Click += new System.EventHandler(this.btnPragas_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.BackColor = System.Drawing.Color.White;
            this.btnFornecedores.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFornecedores.FlatAppearance.BorderSize = 2;
            this.btnFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedores.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedores.Image = global::organ.Properties.Resources.box_4;
            this.btnFornecedores.Location = new System.Drawing.Point(489, 40);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnFornecedores.Size = new System.Drawing.Size(405, 310);
            this.btnFornecedores.TabIndex = 8;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFornecedores.UseVisualStyleBackColor = false;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.White;
            this.btnFuncionarios.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFuncionarios.FlatAppearance.BorderSize = 2;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.Image = global::organ.Properties.Resources.funcionarios;
            this.btnFuncionarios.Location = new System.Drawing.Point(42, 40);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnFuncionarios.Size = new System.Drawing.Size(405, 310);
            this.btnFuncionarios.TabIndex = 7;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.White;
            this.btnEstoque.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEstoque.FlatAppearance.BorderSize = 2;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Image = global::organ.Properties.Resources.estoque_2;
            this.btnEstoque.Location = new System.Drawing.Point(489, 393);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.btnEstoque.Size = new System.Drawing.Size(405, 310);
            this.btnEstoque.TabIndex = 17;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // fazenda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.estoque1);
            this.Controls.Add(this.pragas1);
            this.Controls.Add(this.doencas1);
            this.Controls.Add(this.fornecedores1);
            this.Controls.Add(this.funcionarios1);
            this.Controls.Add(this.btnDoenças);
            this.Controls.Add(this.btnControleGastos);
            this.Controls.Add(this.btnPragas);
            this.Controls.Add(this.btnFornecedores);
            this.Controls.Add(this.btnFuncionarios);
            this.Controls.Add(this.btnEstoque);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fazenda";
            this.Size = new System.Drawing.Size(1384, 774);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnPragas;
        private System.Windows.Forms.Button btnControleGastos;
        private System.Windows.Forms.Button btnDoenças;
        private funcionarios funcionarios1;
        private fornecedores fornecedores1;
        private doencas doencas1;
        private pragas pragas1;
        private System.Windows.Forms.Button btnEstoque;
        private estoque estoque1;
    }
}
