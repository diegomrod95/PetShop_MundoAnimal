namespace SistemaMundoAnimal.Forms {
    partial class FormEstoque {
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
            this.DataGridEstoque = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.ComboFiltroPesquisa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridEstoque
            // 
            this.DataGridEstoque.AllowUserToAddRows = false;
            this.DataGridEstoque.AllowUserToDeleteRows = false;
            this.DataGridEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column9,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DataGridEstoque.Location = new System.Drawing.Point(17, 53);
            this.DataGridEstoque.Name = "DataGridEstoque";
            this.DataGridEstoque.ReadOnly = true;
            this.DataGridEstoque.Size = new System.Drawing.Size(976, 493);
            this.DataGridEstoque.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código Produto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Categoria";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nome";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Preço Venda";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Medida";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quantidade Estoque";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Quantidade Minima";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Sub Total";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(858, 17);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(121, 23);
            this.BtnLimpar.TabIndex = 16;
            this.BtnLimpar.Text = "Limpar Resultado";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(777, 17);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 15;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Location = new System.Drawing.Point(237, 19);
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(534, 20);
            this.TxtConsulta.TabIndex = 14;
            // 
            // ComboFiltroPesquisa
            // 
            this.ComboFiltroPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFiltroPesquisa.FormattingEnabled = true;
            this.ComboFiltroPesquisa.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "Codigo"});
            this.ComboFiltroPesquisa.Location = new System.Drawing.Point(76, 19);
            this.ComboFiltroPesquisa.Name = "ComboFiltroPesquisa";
            this.ComboFiltroPesquisa.Size = new System.Drawing.Size(154, 21);
            this.ComboFiltroPesquisa.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filtro:";
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.TxtConsulta);
            this.Controls.Add(this.ComboFiltroPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridEstoque);
            this.Name = "FormEstoque";
            this.Size = new System.Drawing.Size(1008, 590);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridEstoque;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.ComboBox ComboFiltroPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
