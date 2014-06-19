namespace SistemaMundoAnimal.Forms {
    partial class FormPesquisarVenda {
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
            this.LinkExportarHTML = new System.Windows.Forms.LinkLabel();
            this.LinkExportarCsv = new System.Windows.Forms.LinkLabel();
            this.LinkExportarExcel = new System.Windows.Forms.LinkLabel();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.GridResultado = new System.Windows.Forms.DataGridView();
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.ComboFiltroPesquisa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkExportarHTML
            // 
            this.LinkExportarHTML.AutoSize = true;
            this.LinkExportarHTML.Location = new System.Drawing.Point(243, 560);
            this.LinkExportarHTML.Name = "LinkExportarHTML";
            this.LinkExportarHTML.Size = new System.Drawing.Size(103, 13);
            this.LinkExportarHTML.TabIndex = 17;
            this.LinkExportarHTML.TabStop = true;
            this.LinkExportarHTML.Text = "Exportar para HTML";
            // 
            // LinkExportarCsv
            // 
            this.LinkExportarCsv.AutoSize = true;
            this.LinkExportarCsv.Location = new System.Drawing.Point(144, 560);
            this.LinkExportarCsv.Name = "LinkExportarCsv";
            this.LinkExportarCsv.Size = new System.Drawing.Size(93, 13);
            this.LinkExportarCsv.TabIndex = 16;
            this.LinkExportarCsv.TabStop = true;
            this.LinkExportarCsv.Text = "Exportar para .csv";
            // 
            // LinkExportarExcel
            // 
            this.LinkExportarExcel.AutoSize = true;
            this.LinkExportarExcel.Location = new System.Drawing.Point(30, 560);
            this.LinkExportarExcel.Name = "LinkExportarExcel";
            this.LinkExportarExcel.Size = new System.Drawing.Size(108, 13);
            this.LinkExportarExcel.TabIndex = 15;
            this.LinkExportarExcel.TabStop = true;
            this.LinkExportarExcel.Text = "Exportar para o Excel";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(860, 18);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(121, 23);
            this.BtnLimpar.TabIndex = 14;
            this.BtnLimpar.Text = "Limpar Resultado";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(779, 18);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 13;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // GridResultado
            // 
            this.GridResultado.AllowUserToAddRows = false;
            this.GridResultado.AllowUserToDeleteRows = false;
            this.GridResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column9,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.GridResultado.Location = new System.Drawing.Point(30, 57);
            this.GridResultado.Name = "GridResultado";
            this.GridResultado.ReadOnly = true;
            this.GridResultado.Size = new System.Drawing.Size(951, 496);
            this.GridResultado.TabIndex = 12;
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Location = new System.Drawing.Point(239, 20);
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(534, 20);
            this.TxtConsulta.TabIndex = 11;
            // 
            // ComboFiltroPesquisa
            // 
            this.ComboFiltroPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFiltroPesquisa.FormattingEnabled = true;
            this.ComboFiltroPesquisa.Items.AddRange(new object[] {
            "Id",
            "Tipo Pedido",
            "Vendedor Id",
            "Valor Total",
            "Maior que Valor",
            "Menor que Valor",
            "Status",
            "Data Entrega",
            "Antes Data",
            "Depois Data",
            "Entregues"});
            this.ComboFiltroPesquisa.Location = new System.Drawing.Point(78, 20);
            this.ComboFiltroPesquisa.Name = "ComboFiltroPesquisa";
            this.ComboFiltroPesquisa.Size = new System.Drawing.Size(154, 21);
            this.ComboFiltroPesquisa.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filtro:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tipo Pedido";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Vendedor Id";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Vendedor Nome";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Valor Total";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Desconto";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Status";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Data Entrega";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Data Cadastro";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // FormPesquisarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LinkExportarHTML);
            this.Controls.Add(this.LinkExportarCsv);
            this.Controls.Add(this.LinkExportarExcel);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.GridResultado);
            this.Controls.Add(this.TxtConsulta);
            this.Controls.Add(this.ComboFiltroPesquisa);
            this.Controls.Add(this.label1);
            this.Name = "FormPesquisarVenda";
            this.Size = new System.Drawing.Size(1008, 590);
            ((System.ComponentModel.ISupportInitialize)(this.GridResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkExportarHTML;
        private System.Windows.Forms.LinkLabel LinkExportarCsv;
        private System.Windows.Forms.LinkLabel LinkExportarExcel;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.DataGridView GridResultado;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.ComboBox ComboFiltroPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
