namespace SistemaMundoAnimal.Forms {
    partial class FormCadastroProduto {
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
            this.TxtDescricao = new System.Windows.Forms.RichTextBox();
            this.ComboMedida = new System.Windows.Forms.ComboBox();
            this.numPeso = new System.Windows.Forms.NumericUpDown();
            this.numTamanho = new System.Windows.Forms.NumericUpDown();
            this.numPrecoVenda = new System.Windows.Forms.NumericUpDown();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListFabricante = new System.Windows.Forms.ListBox();
            this.BtnNovoFabricante = new System.Windows.Forms.Button();
            this.TxtFabricanteConsulta = new System.Windows.Forms.TextBox();
            this.ComboFabricanteCampo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListFornecedoresTodos = new System.Windows.Forms.ListBox();
            this.ListFornecedoresProduto = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnNovoFornecedor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoVenda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProduto
            // 
            this.gbProduto.Controls.Add(this.TxtDescricao);
            this.gbProduto.Controls.Add(this.ComboMedida);
            this.gbProduto.Controls.Add(this.numPeso);
            this.gbProduto.Controls.Add(this.numTamanho);
            this.gbProduto.Controls.Add(this.numPrecoVenda);
            this.gbProduto.Controls.Add(this.TxtNome);
            this.gbProduto.Controls.Add(this.label7);
            this.gbProduto.Controls.Add(this.label6);
            this.gbProduto.Controls.Add(this.label5);
            this.gbProduto.Controls.Add(this.label4);
            this.gbProduto.Controls.Add(this.label3);
            this.gbProduto.Controls.Add(this.label2);
            this.gbProduto.Controls.Add(this.label1);
            this.gbProduto.Location = new System.Drawing.Point(13, 12);
            this.gbProduto.Name = "gbProduto";
            this.gbProduto.Size = new System.Drawing.Size(394, 430);
            this.gbProduto.TabIndex = 0;
            this.gbProduto.TabStop = false;
            this.gbProduto.Text = "Informações do Produto";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(19, 246);
            this.TxtDescricao.MaxLength = 1000;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(357, 163);
            this.TxtDescricao.TabIndex = 12;
            this.TxtDescricao.Text = "";
            // 
            // ComboMedida
            // 
            this.ComboMedida.FormattingEnabled = true;
            this.ComboMedida.Location = new System.Drawing.Point(140, 150);
            this.ComboMedida.Name = "ComboMedida";
            this.ComboMedida.Size = new System.Drawing.Size(236, 21);
            this.ComboMedida.TabIndex = 11;
            // 
            // numPeso
            // 
            this.numPeso.Location = new System.Drawing.Point(140, 122);
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
            this.numTamanho.Location = new System.Drawing.Point(140, 90);
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
            this.numPrecoVenda.Location = new System.Drawing.Point(140, 58);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Especificações:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Medida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tamanho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 58);
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
            this.groupBox1.Controls.Add(this.ComboFabricanteCampo);
            this.groupBox1.Controls.Add(this.TxtFabricanteConsulta);
            this.groupBox1.Controls.Add(this.BtnNovoFabricante);
            this.groupBox1.Controls.Add(this.ListFabricante);
            this.groupBox1.Location = new System.Drawing.Point(426, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 242);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fabricante";
            // 
            // ListFabricante
            // 
            this.ListFabricante.FormattingEnabled = true;
            this.ListFabricante.Location = new System.Drawing.Point(6, 56);
            this.ListFabricante.Name = "ListFabricante";
            this.ListFabricante.Size = new System.Drawing.Size(551, 147);
            this.ListFabricante.TabIndex = 0;
            // 
            // BtnNovoFabricante
            // 
            this.BtnNovoFabricante.Location = new System.Drawing.Point(400, 209);
            this.BtnNovoFabricante.Name = "BtnNovoFabricante";
            this.BtnNovoFabricante.Size = new System.Drawing.Size(157, 27);
            this.BtnNovoFabricante.TabIndex = 2;
            this.BtnNovoFabricante.Text = "Adicionar novo fabricante";
            this.BtnNovoFabricante.UseVisualStyleBackColor = true;
            // 
            // TxtFabricanteConsulta
            // 
            this.TxtFabricanteConsulta.Location = new System.Drawing.Point(173, 20);
            this.TxtFabricanteConsulta.Name = "TxtFabricanteConsulta";
            this.TxtFabricanteConsulta.Size = new System.Drawing.Size(384, 20);
            this.TxtFabricanteConsulta.TabIndex = 3;
            // 
            // ComboFabricanteCampo
            // 
            this.ComboFabricanteCampo.FormattingEnabled = true;
            this.ComboFabricanteCampo.Location = new System.Drawing.Point(6, 20);
            this.ComboFabricanteCampo.Name = "ComboFabricanteCampo";
            this.ComboFabricanteCampo.Size = new System.Drawing.Size(161, 21);
            this.ComboFabricanteCampo.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.BtnNovoFornecedor);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.ListFornecedoresProduto);
            this.groupBox2.Controls.Add(this.ListFornecedoresTodos);
            this.groupBox2.Location = new System.Drawing.Point(426, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 310);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fornecedores";
            // 
            // ListFornecedoresTodos
            // 
            this.ListFornecedoresTodos.FormattingEnabled = true;
            this.ListFornecedoresTodos.Location = new System.Drawing.Point(6, 45);
            this.ListFornecedoresTodos.Name = "ListFornecedoresTodos";
            this.ListFornecedoresTodos.Size = new System.Drawing.Size(242, 225);
            this.ListFornecedoresTodos.TabIndex = 0;
            // 
            // ListFornecedoresProduto
            // 
            this.ListFornecedoresProduto.FormattingEnabled = true;
            this.ListFornecedoresProduto.Location = new System.Drawing.Point(298, 45);
            this.ListFornecedoresProduto.Name = "ListFornecedoresProduto";
            this.ListFornecedoresProduto.Size = new System.Drawing.Size(259, 225);
            this.ListFornecedoresProduto.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnNovoFornecedor
            // 
            this.BtnNovoFornecedor.Location = new System.Drawing.Point(6, 276);
            this.BtnNovoFornecedor.Name = "BtnNovoFornecedor";
            this.BtnNovoFornecedor.Size = new System.Drawing.Size(147, 28);
            this.BtnNovoFornecedor.TabIndex = 4;
            this.BtnNovoFornecedor.Text = "Adiconar novo fornecedor";
            this.BtnNovoFornecedor.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cadastrados:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Fornecem este produto:";
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbProduto);
            this.Name = "FormCadastroProduto";
            this.Size = new System.Drawing.Size(1008, 590);
            this.gbProduto.ResumeLayout(false);
            this.gbProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoVenda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.NumericUpDown numPrecoVenda;
        private System.Windows.Forms.RichTextBox TxtDescricao;
        private System.Windows.Forms.ComboBox ComboMedida;
        private System.Windows.Forms.NumericUpDown numPeso;
        private System.Windows.Forms.NumericUpDown numTamanho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ListFabricante;
        private System.Windows.Forms.Button BtnNovoFabricante;
        private System.Windows.Forms.ComboBox ComboFabricanteCampo;
        private System.Windows.Forms.TextBox TxtFabricanteConsulta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnNovoFornecedor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ListFornecedoresProduto;
        private System.Windows.Forms.ListBox ListFornecedoresTodos;
    }
}
