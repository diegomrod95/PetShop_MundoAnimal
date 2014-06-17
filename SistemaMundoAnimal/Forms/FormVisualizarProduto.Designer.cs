namespace SistemaMundoAnimal.Forms {
    partial class FormVisualizarProduto {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gbProduto = new System.Windows.Forms.GroupBox();
            this.TxtCodigoProduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.ComboCategoria = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtDescricao = new System.Windows.Forms.RichTextBox();
            this.ComboMedida = new System.Windows.Forms.ComboBox();
            this.numPeso = new System.Windows.Forms.NumericUpDown();
            this.numTamanho = new System.Windows.Forms.NumericUpDown();
            this.numPrecoVenda = new System.Windows.Forms.NumericUpDown();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAddFornecedor = new System.Windows.Forms.Button();
            this.DataGridFornecedores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnAddFabricante = new System.Windows.Forms.Button();
            this.DataGridFabricantes = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.gbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoVenda)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFornecedores)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFabricantes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProduto
            // 
            this.gbProduto.Controls.Add(this.TxtCodigoProduto);
            this.gbProduto.Controls.Add(this.label8);
            this.gbProduto.Controls.Add(this.BtnSalvar);
            this.gbProduto.Controls.Add(this.ComboCategoria);
            this.gbProduto.Controls.Add(this.label10);
            this.gbProduto.Controls.Add(this.TxtDescricao);
            this.gbProduto.Controls.Add(this.ComboMedida);
            this.gbProduto.Controls.Add(this.numPeso);
            this.gbProduto.Controls.Add(this.numTamanho);
            this.gbProduto.Controls.Add(this.numPrecoVenda);
            this.gbProduto.Controls.Add(this.TxtNome);
            this.gbProduto.Controls.Add(this.label6);
            this.gbProduto.Controls.Add(this.label5);
            this.gbProduto.Controls.Add(this.label4);
            this.gbProduto.Controls.Add(this.label3);
            this.gbProduto.Controls.Add(this.label2);
            this.gbProduto.Controls.Add(this.label1);
            this.gbProduto.Location = new System.Drawing.Point(15, 18);
            this.gbProduto.Name = "gbProduto";
            this.gbProduto.Size = new System.Drawing.Size(394, 559);
            this.gbProduto.TabIndex = 1;
            this.gbProduto.TabStop = false;
            this.gbProduto.Text = "Informações do Produto";
            // 
            // TxtCodigoProduto
            // 
            this.TxtCodigoProduto.Location = new System.Drawing.Point(140, 53);
            this.TxtCodigoProduto.Name = "TxtCodigoProduto";
            this.TxtCodigoProduto.Size = new System.Drawing.Size(236, 20);
            this.TxtCodigoProduto.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "Código:";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(268, 525);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(120, 28);
            this.BtnSalvar.TabIndex = 61;
            this.BtnSalvar.Text = "Salvar Alterações";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // ComboCategoria
            // 
            this.ComboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCategoria.FormattingEnabled = true;
            this.ComboCategoria.Location = new System.Drawing.Point(140, 197);
            this.ComboCategoria.Name = "ComboCategoria";
            this.ComboCategoria.Size = new System.Drawing.Size(236, 21);
            this.ComboCategoria.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Categoria:";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(19, 247);
            this.TxtDescricao.MaxLength = 1000;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(357, 163);
            this.TxtDescricao.TabIndex = 12;
            this.TxtDescricao.Text = "";
            // 
            // ComboMedida
            // 
            this.ComboMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMedida.FormattingEnabled = true;
            this.ComboMedida.Items.AddRange(new object[] {
            "UN - Unidade",
            "KG - Kilograma",
            "GR - Gramas",
            "DU - Dúzias",
            "DZ - Dezenas",
            "LT - Litros"});
            this.ComboMedida.Location = new System.Drawing.Point(140, 169);
            this.ComboMedida.Name = "ComboMedida";
            this.ComboMedida.Size = new System.Drawing.Size(236, 21);
            this.ComboMedida.TabIndex = 11;
            // 
            // numPeso
            // 
            this.numPeso.DecimalPlaces = 3;
            this.numPeso.Location = new System.Drawing.Point(140, 141);
            this.numPeso.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPeso.Name = "numPeso";
            this.numPeso.Size = new System.Drawing.Size(142, 20);
            this.numPeso.TabIndex = 10;
            this.numPeso.ThousandsSeparator = true;
            // 
            // numTamanho
            // 
            this.numTamanho.DecimalPlaces = 2;
            this.numTamanho.Location = new System.Drawing.Point(140, 109);
            this.numTamanho.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numTamanho.Name = "numTamanho";
            this.numTamanho.Size = new System.Drawing.Size(142, 20);
            this.numTamanho.TabIndex = 9;
            this.numTamanho.ThousandsSeparator = true;
            // 
            // numPrecoVenda
            // 
            this.numPrecoVenda.DecimalPlaces = 2;
            this.numPrecoVenda.Location = new System.Drawing.Point(140, 77);
            this.numPrecoVenda.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPrecoVenda.Name = "numPrecoVenda";
            this.numPrecoVenda.Size = new System.Drawing.Size(142, 20);
            this.numPrecoVenda.TabIndex = 8;
            this.numPrecoVenda.ThousandsSeparator = true;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(140, 27);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(236, 20);
            this.TxtNome.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Medida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tamanho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço Venda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAddFornecedor);
            this.groupBox1.Controls.Add(this.DataGridFornecedores);
            this.groupBox1.Location = new System.Drawing.Point(419, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 199);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fornecedores";
            // 
            // BtnAddFornecedor
            // 
            this.BtnAddFornecedor.Location = new System.Drawing.Point(7, 167);
            this.BtnAddFornecedor.Name = "BtnAddFornecedor";
            this.BtnAddFornecedor.Size = new System.Drawing.Size(131, 26);
            this.BtnAddFornecedor.TabIndex = 1;
            this.BtnAddFornecedor.Text = "Adicionar Fornecedor";
            this.BtnAddFornecedor.UseVisualStyleBackColor = true;
            // 
            // DataGridFornecedores
            // 
            this.DataGridFornecedores.AllowUserToAddRows = false;
            this.DataGridFornecedores.AllowUserToDeleteRows = false;
            this.DataGridFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DataGridFornecedores.Location = new System.Drawing.Point(7, 19);
            this.DataGridFornecedores.Name = "DataGridFornecedores";
            this.DataGridFornecedores.ReadOnly = true;
            this.DataGridFornecedores.Size = new System.Drawing.Size(553, 141);
            this.DataGridFornecedores.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 102;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome Fantasia";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 102;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CNPJ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 102;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Data Cadastro";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 102;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ativo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 102;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnAddFabricante);
            this.groupBox2.Controls.Add(this.DataGridFabricantes);
            this.groupBox2.Location = new System.Drawing.Point(419, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 199);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fabricantes";
            // 
            // BtnAddFabricante
            // 
            this.BtnAddFabricante.Location = new System.Drawing.Point(7, 165);
            this.BtnAddFabricante.Name = "BtnAddFabricante";
            this.BtnAddFabricante.Size = new System.Drawing.Size(131, 26);
            this.BtnAddFabricante.TabIndex = 2;
            this.BtnAddFabricante.Text = "Adicionar Fabricante";
            this.BtnAddFabricante.UseVisualStyleBackColor = true;
            // 
            // DataGridFabricantes
            // 
            this.DataGridFabricantes.AllowUserToAddRows = false;
            this.DataGridFabricantes.AllowUserToDeleteRows = false;
            this.DataGridFabricantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridFabricantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.DataGridFabricantes.Location = new System.Drawing.Point(7, 19);
            this.DataGridFabricantes.Name = "DataGridFabricantes";
            this.DataGridFabricantes.ReadOnly = true;
            this.DataGridFabricantes.Size = new System.Drawing.Size(553, 140);
            this.DataGridFabricantes.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Codigo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 102;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nome Fantasia";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 102;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "CNPJ";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 102;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Data Cadastro";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 102;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Ativo";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 102;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(737, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Código do Produto:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(841, 15);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(144, 20);
            this.TxtCodigo.TabIndex = 17;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            this.TxtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo_KeyUp);
            // 
            // FormVisualizarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbProduto);
            this.Name = "FormVisualizarProduto";
            this.Size = new System.Drawing.Size(1008, 590);
            this.gbProduto.ResumeLayout(false);
            this.gbProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoVenda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFornecedores)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFabricantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProduto;
        private System.Windows.Forms.RichTextBox TxtDescricao;
        private System.Windows.Forms.ComboBox ComboMedida;
        private System.Windows.Forms.NumericUpDown numPeso;
        private System.Windows.Forms.NumericUpDown numTamanho;
        private System.Windows.Forms.NumericUpDown numPrecoVenda;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGridFornecedores;
        private System.Windows.Forms.Button BtnAddFornecedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnAddFabricante;
        private System.Windows.Forms.DataGridView DataGridFabricantes;
        private System.Windows.Forms.ComboBox ComboCategoria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox TxtCodigoProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}
