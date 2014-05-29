namespace SistemaMundoAnimal.Forms {
    partial class FormPesquisarFuncionarios {
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
            this.label1 = new System.Windows.Forms.Label();
            this.ComboFiltroPesquisa = new System.Windows.Forms.ComboBox();
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.GridResultado = new System.Windows.Forms.DataGridView();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssitenciaMedica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuxilioCreche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValeAlimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValeTransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro:";
            // 
            // ComboFiltroPesquisa
            // 
            this.ComboFiltroPesquisa.FormattingEnabled = true;
            this.ComboFiltroPesquisa.Items.AddRange(new object[] {
            "Código"});
            this.ComboFiltroPesquisa.Location = new System.Drawing.Point(78, 28);
            this.ComboFiltroPesquisa.Name = "ComboFiltroPesquisa";
            this.ComboFiltroPesquisa.Size = new System.Drawing.Size(154, 21);
            this.ComboFiltroPesquisa.TabIndex = 1;
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Location = new System.Drawing.Point(239, 28);
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(534, 20);
            this.TxtConsulta.TabIndex = 2;
            // 
            // GridResultado
            // 
            this.GridResultado.AllowUserToAddRows = false;
            this.GridResultado.AllowUserToDeleteRows = false;
            this.GridResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Sobrenome,
            this.Genero,
            this.Cargo,
            this.RG,
            this.CPF,
            this.Idade,
            this.Salario,
            this.AssitenciaMedica,
            this.AuxilioCreche,
            this.ValeAlimentacao,
            this.ValeTransporte,
            this.DiaPagamento});
            this.GridResultado.Location = new System.Drawing.Point(30, 65);
            this.GridResultado.Name = "GridResultado";
            this.GridResultado.ReadOnly = true;
            this.GridResultado.Size = new System.Drawing.Size(951, 496);
            this.GridResultado.TabIndex = 3;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(779, 26);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 4;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(860, 26);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(121, 23);
            this.BtnLimpar.TabIndex = 5;
            this.BtnLimpar.Text = "Limpar Resultado";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Sobrenome
            // 
            this.Sobrenome.HeaderText = "Sobrenome";
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // RG
            // 
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Idade
            // 
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            // 
            // AssitenciaMedica
            // 
            this.AssitenciaMedica.HeaderText = "Assitencia Medica";
            this.AssitenciaMedica.Name = "AssitenciaMedica";
            this.AssitenciaMedica.ReadOnly = true;
            // 
            // AuxilioCreche
            // 
            this.AuxilioCreche.HeaderText = "Auxilio Creche";
            this.AuxilioCreche.Name = "AuxilioCreche";
            this.AuxilioCreche.ReadOnly = true;
            // 
            // ValeAlimentacao
            // 
            this.ValeAlimentacao.HeaderText = "Vale Alimentacão";
            this.ValeAlimentacao.Name = "ValeAlimentacao";
            this.ValeAlimentacao.ReadOnly = true;
            // 
            // ValeTransporte
            // 
            this.ValeTransporte.HeaderText = "Vale Transporte";
            this.ValeTransporte.Name = "ValeTransporte";
            this.ValeTransporte.ReadOnly = true;
            // 
            // DiaPagamento
            // 
            this.DiaPagamento.HeaderText = "Dia de Pagamento";
            this.DiaPagamento.Name = "DiaPagamento";
            this.DiaPagamento.ReadOnly = true;
            // 
            // FormPesquisarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.GridResultado);
            this.Controls.Add(this.TxtConsulta);
            this.Controls.Add(this.ComboFiltroPesquisa);
            this.Controls.Add(this.label1);
            this.Name = "FormPesquisarFuncionarios";
            this.Size = new System.Drawing.Size(1008, 590);
            ((System.ComponentModel.ISupportInitialize)(this.GridResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboFiltroPesquisa;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.DataGridView GridResultado;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssitenciaMedica;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuxilioCreche;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValeAlimentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValeTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaPagamento;
    }
}
