using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using SistemaMundoAnimal.Source.Pesquisa.Entidade;

namespace SistemaMundoAnimal.Forms {
    public partial class FormVisualizarProduto : UserControl {
        public FormVisualizarProduto() {
            InitializeComponent();
        }

        public FormVisualizarProduto(int produto) {
            InitializeComponent();
            TxtCodigo.Text = produto.ToString();
            PesquisaCategoria.Todos(SetCategoria);
            Pesquisar();
        }

        private void SetFornecedor(SqlDataReader reader) {
            DataGridFornecedores.Rows.Add(
                reader["Fornecedor_Id"],
                reader["Nome_Fantasia"],
                reader["CNPJ"],
                reader["Data_Cadastro"],
                reader["Ativo"]);
        }

        private void SetFabricante(SqlDataReader reader) {
            DataGridFabricantes.Rows.Add(
                reader["Fabricante_Id"],
                reader["Nome_Fantasia"],
                reader["CNPJ"],
                reader["Data_Cadastro"],
                reader["Ativo"]);
        }

        private void SetCategoria(SqlDataReader reader) {
            ComboCategoria.Items.Add(reader["Nome"]);
        }

        private void SetProduto(SqlDataReader reader) {
            TxtNome.Text = reader["Nome"].ToString();
            TxtCodigoProduto.Text = reader["Codigo"].ToString();
            numPrecoVenda.Value = Convert.ToDecimal(reader["Preco_Venda"]);
            numTamanho.Value = Convert.ToDecimal(reader["Tamanho"]);
            numPeso.Value = Convert.ToDecimal(reader["Peso"]);
            TxtDescricao.Text = reader["Descricao"].ToString();
            
            // Utiliza o linq para descobrir a medida correspondente
            var medida = from string e in ComboMedida.Items
                         where e.Substring(0, 2) == reader["Tipo_Medida"].ToString()
                         select ComboMedida.Items.IndexOf(e);

            foreach (int i in medida) {
                ComboMedida.SelectedIndex = i;
            }

            var categoria = from string e in ComboCategoria.Items
                            where e == reader["Categoria"].ToString()
                            select ComboCategoria.Items.IndexOf(e);

            foreach (int i in categoria) {
                ComboCategoria.SelectedIndex = i;
            }

        }

        private void LimpaResultado() {
            DataGridFornecedores.Rows.Clear();
            DataGridFabricantes.Rows.Clear();
        }

        private void Pesquisar() {
            try {
                LimpaResultado();
                int id = Convert.ToInt32(TxtCodigo.Text);
                PesquisaFornecedor.PorProdutoId(id, SetFornecedor);
                PesquisaFabricante.ProProdutoId(id, SetFabricante);
                PesquisaProduto.PorId(id.ToString(), SetProduto);
            } catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e) {
            if (TxtCodigo.Text != "") Pesquisar();
            else LimpaResultado();
        }

        private void TxtCodigo_KeyUp(object sender, KeyEventArgs e) {
            if (TxtCodigo.Text != "") Pesquisar();
            else LimpaResultado();
        }
    }
}
