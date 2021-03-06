﻿namespace SistemaMundoAnimal.Forms {
    partial class FormPesquisarProduto {
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
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.GridResultado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.ComboFiltroPesquisa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LinkExportarCsv = new System.Windows.Forms.LinkLabel();
            this.LinkExportarHTML = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GridResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(860, 28);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(121, 23);
            this.BtnLimpar.TabIndex = 11;
            this.BtnLimpar.Text = "Limpar Resultado";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(779, 28);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 10;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // GridResultado
            // 
            this.GridResultado.AllowUserToAddRows = false;
            this.GridResultado.AllowUserToDeleteRows = false;
            this.GridResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column10,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.GridResultado.Location = new System.Drawing.Point(30, 67);
            this.GridResultado.Name = "GridResultado";
            this.GridResultado.ReadOnly = true;
            this.GridResultado.Size = new System.Drawing.Size(951, 496);
            this.GridResultado.TabIndex = 9;
            this.GridResultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridResultado_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 41;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Codigo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 65;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nome";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Categoria";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 77;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tamanho";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 77;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Preço Venda";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 94;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Peso";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 56;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Medida";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 67;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Data Cadastro";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Ativo";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 56;
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Location = new System.Drawing.Point(239, 30);
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(534, 20);
            this.TxtConsulta.TabIndex = 8;
            this.TxtConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConsulta_KeyPress);
            this.TxtConsulta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtConsulta_KeyUp);
            // 
            // ComboFiltroPesquisa
            // 
            this.ComboFiltroPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFiltroPesquisa.FormattingEnabled = true;
            this.ComboFiltroPesquisa.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "Codigo"});
            this.ComboFiltroPesquisa.Location = new System.Drawing.Point(78, 30);
            this.ComboFiltroPesquisa.Name = "ComboFiltroPesquisa";
            this.ComboFiltroPesquisa.Size = new System.Drawing.Size(154, 21);
            this.ComboFiltroPesquisa.TabIndex = 7;
            this.ComboFiltroPesquisa.SelectedIndexChanged += new System.EventHandler(this.ComboFiltroPesquisa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtro:";
            // 
            // LinkExportarCsv
            // 
            this.LinkExportarCsv.AutoSize = true;
            this.LinkExportarCsv.Location = new System.Drawing.Point(30, 570);
            this.LinkExportarCsv.Name = "LinkExportarCsv";
            this.LinkExportarCsv.Size = new System.Drawing.Size(93, 13);
            this.LinkExportarCsv.TabIndex = 12;
            this.LinkExportarCsv.TabStop = true;
            this.LinkExportarCsv.Text = "Exportar para .csv";
            this.LinkExportarCsv.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkExportarCsv_LinkClicked);
            // 
            // LinkExportarHTML
            // 
            this.LinkExportarHTML.AutoSize = true;
            this.LinkExportarHTML.Location = new System.Drawing.Point(129, 570);
            this.LinkExportarHTML.Name = "LinkExportarHTML";
            this.LinkExportarHTML.Size = new System.Drawing.Size(103, 13);
            this.LinkExportarHTML.TabIndex = 13;
            this.LinkExportarHTML.TabStop = true;
            this.LinkExportarHTML.Text = "Exportar para HTML";
            this.LinkExportarHTML.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkExportarHTML_LinkClicked);
            // 
            // FormPesquisarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LinkExportarHTML);
            this.Controls.Add(this.LinkExportarCsv);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.GridResultado);
            this.Controls.Add(this.TxtConsulta);
            this.Controls.Add(this.ComboFiltroPesquisa);
            this.Controls.Add(this.label1);
            this.Name = "FormPesquisarProduto";
            this.Size = new System.Drawing.Size(1008, 590);
            ((System.ComponentModel.ISupportInitialize)(this.GridResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.DataGridView GridResultado;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.ComboBox ComboFiltroPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.LinkLabel LinkExportarCsv;
        private System.Windows.Forms.LinkLabel LinkExportarHTML;
    }
}
