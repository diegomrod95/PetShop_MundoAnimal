namespace SistemaMundoAnimal.Forms {
    partial class FormPrincipal {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.PageRecursosHumanos = new System.Windows.Forms.TabPage();
            this.BtnVisualizarFuncionario = new System.Windows.Forms.Button();
            this.BtnPesquisaFuncionario = new System.Windows.Forms.Button();
            this.BtnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnEstoque = new System.Windows.Forms.Button();
            this.BtnVisualizarProduto = new System.Windows.Forms.Button();
            this.BtnPesquisarProduto = new System.Windows.Forms.Button();
            this.BtnCadastrarProduto = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnVendedores = new System.Windows.Forms.Button();
            this.BtnEstatisticas = new System.Windows.Forms.Button();
            this.BtnRelatório = new System.Windows.Forms.Button();
            this.BtnVisualizarVenda = new System.Windows.Forms.Button();
            this.BtnPesquisarVenda = new System.Windows.Forms.Button();
            this.PainelPrincipal = new System.Windows.Forms.Panel();
            this.TabControl.SuspendLayout();
            this.PageRecursosHumanos.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.PageRecursosHumanos);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1008, 100);
            this.TabControl.TabIndex = 0;
            // 
            // PageRecursosHumanos
            // 
            this.PageRecursosHumanos.Controls.Add(this.BtnVisualizarFuncionario);
            this.PageRecursosHumanos.Controls.Add(this.BtnPesquisaFuncionario);
            this.PageRecursosHumanos.Controls.Add(this.BtnCadastrarFuncionario);
            this.PageRecursosHumanos.Location = new System.Drawing.Point(4, 22);
            this.PageRecursosHumanos.Name = "PageRecursosHumanos";
            this.PageRecursosHumanos.Padding = new System.Windows.Forms.Padding(3);
            this.PageRecursosHumanos.Size = new System.Drawing.Size(1000, 74);
            this.PageRecursosHumanos.TabIndex = 0;
            this.PageRecursosHumanos.Text = "Resursos Humanos";
            this.PageRecursosHumanos.UseVisualStyleBackColor = true;
            // 
            // BtnVisualizarFuncionario
            // 
            this.BtnVisualizarFuncionario.Location = new System.Drawing.Point(328, 5);
            this.BtnVisualizarFuncionario.Name = "BtnVisualizarFuncionario";
            this.BtnVisualizarFuncionario.Size = new System.Drawing.Size(141, 27);
            this.BtnVisualizarFuncionario.TabIndex = 2;
            this.BtnVisualizarFuncionario.Text = "Visualizar Funcionário";
            this.BtnVisualizarFuncionario.UseVisualStyleBackColor = true;
            this.BtnVisualizarFuncionario.Click += new System.EventHandler(this.BtnVisualizarFuncionario_Click);
            // 
            // BtnPesquisaFuncionario
            // 
            this.BtnPesquisaFuncionario.Location = new System.Drawing.Point(163, 5);
            this.BtnPesquisaFuncionario.Name = "BtnPesquisaFuncionario";
            this.BtnPesquisaFuncionario.Size = new System.Drawing.Size(158, 27);
            this.BtnPesquisaFuncionario.TabIndex = 1;
            this.BtnPesquisaFuncionario.Text = "Pesquisar Funcionários";
            this.BtnPesquisaFuncionario.UseVisualStyleBackColor = true;
            this.BtnPesquisaFuncionario.Click += new System.EventHandler(this.BtnPesquisaFuncionario_Click);
            // 
            // BtnCadastrarFuncionario
            // 
            this.BtnCadastrarFuncionario.Location = new System.Drawing.Point(8, 6);
            this.BtnCadastrarFuncionario.Name = "BtnCadastrarFuncionario";
            this.BtnCadastrarFuncionario.Size = new System.Drawing.Size(148, 26);
            this.BtnCadastrarFuncionario.TabIndex = 0;
            this.BtnCadastrarFuncionario.Text = "Cadastrar Funcionário";
            this.BtnCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.BtnCadastrarFuncionario.Click += new System.EventHandler(this.BtnCadastrarFuncionario_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnEstoque);
            this.tabPage2.Controls.Add(this.BtnVisualizarProduto);
            this.tabPage2.Controls.Add(this.BtnPesquisarProduto);
            this.tabPage2.Controls.Add(this.BtnCadastrarProduto);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Suprimentos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnEstoque
            // 
            this.BtnEstoque.Location = new System.Drawing.Point(459, 7);
            this.BtnEstoque.Name = "BtnEstoque";
            this.BtnEstoque.Size = new System.Drawing.Size(144, 24);
            this.BtnEstoque.TabIndex = 3;
            this.BtnEstoque.Text = "Estoque";
            this.BtnEstoque.UseVisualStyleBackColor = true;
            this.BtnEstoque.Click += new System.EventHandler(this.BtnEstoque_Click);
            // 
            // BtnVisualizarProduto
            // 
            this.BtnVisualizarProduto.Location = new System.Drawing.Point(309, 7);
            this.BtnVisualizarProduto.Name = "BtnVisualizarProduto";
            this.BtnVisualizarProduto.Size = new System.Drawing.Size(144, 24);
            this.BtnVisualizarProduto.TabIndex = 2;
            this.BtnVisualizarProduto.Text = "Visualizar Produto";
            this.BtnVisualizarProduto.UseVisualStyleBackColor = true;
            this.BtnVisualizarProduto.Click += new System.EventHandler(this.BtnVisualizarProduto_Click);
            // 
            // BtnPesquisarProduto
            // 
            this.BtnPesquisarProduto.Location = new System.Drawing.Point(159, 7);
            this.BtnPesquisarProduto.Name = "BtnPesquisarProduto";
            this.BtnPesquisarProduto.Size = new System.Drawing.Size(144, 24);
            this.BtnPesquisarProduto.TabIndex = 1;
            this.BtnPesquisarProduto.Text = "Pesquisar Produto";
            this.BtnPesquisarProduto.UseVisualStyleBackColor = true;
            this.BtnPesquisarProduto.Click += new System.EventHandler(this.BtnPesquisarProduto_Click);
            // 
            // BtnCadastrarProduto
            // 
            this.BtnCadastrarProduto.Location = new System.Drawing.Point(9, 7);
            this.BtnCadastrarProduto.Name = "BtnCadastrarProduto";
            this.BtnCadastrarProduto.Size = new System.Drawing.Size(144, 24);
            this.BtnCadastrarProduto.TabIndex = 0;
            this.BtnCadastrarProduto.Text = "Cadastrar Produto";
            this.BtnCadastrarProduto.UseVisualStyleBackColor = true;
            this.BtnCadastrarProduto.Click += new System.EventHandler(this.BtnCadastrarProduto_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnVendedores);
            this.tabPage1.Controls.Add(this.BtnEstatisticas);
            this.tabPage1.Controls.Add(this.BtnRelatório);
            this.tabPage1.Controls.Add(this.BtnVisualizarVenda);
            this.tabPage1.Controls.Add(this.BtnPesquisarVenda);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 74);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Vendas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnVendedores
            // 
            this.BtnVendedores.Location = new System.Drawing.Point(517, 7);
            this.BtnVendedores.Name = "BtnVendedores";
            this.BtnVendedores.Size = new System.Drawing.Size(133, 24);
            this.BtnVendedores.TabIndex = 4;
            this.BtnVendedores.Text = "Vendedores";
            this.BtnVendedores.UseVisualStyleBackColor = true;
            // 
            // BtnEstatisticas
            // 
            this.BtnEstatisticas.Location = new System.Drawing.Point(386, 7);
            this.BtnEstatisticas.Name = "BtnEstatisticas";
            this.BtnEstatisticas.Size = new System.Drawing.Size(124, 24);
            this.BtnEstatisticas.TabIndex = 3;
            this.BtnEstatisticas.Text = "Estatisticas";
            this.BtnEstatisticas.UseVisualStyleBackColor = true;
            // 
            // BtnRelatório
            // 
            this.BtnRelatório.Location = new System.Drawing.Point(263, 7);
            this.BtnRelatório.Name = "BtnRelatório";
            this.BtnRelatório.Size = new System.Drawing.Size(116, 24);
            this.BtnRelatório.TabIndex = 2;
            this.BtnRelatório.Text = "Relatório";
            this.BtnRelatório.UseVisualStyleBackColor = true;
            // 
            // BtnVisualizarVenda
            // 
            this.BtnVisualizarVenda.Location = new System.Drawing.Point(136, 7);
            this.BtnVisualizarVenda.Name = "BtnVisualizarVenda";
            this.BtnVisualizarVenda.Size = new System.Drawing.Size(121, 24);
            this.BtnVisualizarVenda.TabIndex = 1;
            this.BtnVisualizarVenda.Text = "Visualizar Venda";
            this.BtnVisualizarVenda.UseVisualStyleBackColor = true;
            // 
            // BtnPesquisarVenda
            // 
            this.BtnPesquisarVenda.Location = new System.Drawing.Point(9, 7);
            this.BtnPesquisarVenda.Name = "BtnPesquisarVenda";
            this.BtnPesquisarVenda.Size = new System.Drawing.Size(121, 24);
            this.BtnPesquisarVenda.TabIndex = 0;
            this.BtnPesquisarVenda.Text = "Pesquisar Venda";
            this.BtnPesquisarVenda.UseVisualStyleBackColor = true;
            this.BtnPesquisarVenda.Click += new System.EventHandler(this.BtnPesquisarVenda_Click);
            // 
            // PainelPrincipal
            // 
            this.PainelPrincipal.AutoSize = true;
            this.PainelPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PainelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelPrincipal.Location = new System.Drawing.Point(0, 100);
            this.PainelPrincipal.Name = "PainelPrincipal";
            this.PainelPrincipal.Size = new System.Drawing.Size(1008, 590);
            this.PainelPrincipal.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 690);
            this.Controls.Add(this.PainelPrincipal);
            this.Controls.Add(this.TabControl);
            this.MaximumSize = new System.Drawing.Size(1024, 728);
            this.MinimumSize = new System.Drawing.Size(1024, 728);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Mundo Animal";
            this.TabControl.ResumeLayout(false);
            this.PageRecursosHumanos.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage PageRecursosHumanos;
        private System.Windows.Forms.Button BtnCadastrarFuncionario;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel PainelPrincipal;
        private System.Windows.Forms.Button BtnPesquisaFuncionario;
        private System.Windows.Forms.Button BtnVisualizarFuncionario;
        private System.Windows.Forms.Button BtnEstoque;
        private System.Windows.Forms.Button BtnVisualizarProduto;
        private System.Windows.Forms.Button BtnPesquisarProduto;
        private System.Windows.Forms.Button BtnCadastrarProduto;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnVendedores;
        private System.Windows.Forms.Button BtnEstatisticas;
        private System.Windows.Forms.Button BtnRelatório;
        private System.Windows.Forms.Button BtnVisualizarVenda;
        private System.Windows.Forms.Button BtnPesquisarVenda;

    }
}