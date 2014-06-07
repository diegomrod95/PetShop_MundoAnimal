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

using SistemaMundoAnimal.Source.Entidades;
using SistemaMundoAnimal.Source.Pesquisa.Entidade;

namespace SistemaMundoAnimal.Forms {
    public partial class FormCadastroProduto : UserControl {

        private Produto produto;

        public FormCadastroProduto() {
            InitializeComponent();
            produto = new Produto();
            PesquisaFornecedor.Todos(SetFornecedorTodos);
            PesquisaFabricante.Todos(SetFabricanteTodos);
        }

        private void BtnCadastrarProduto_Click(object sender, EventArgs e) {
            try {
                var categorias = (ComboCategoria.Tag as string).Split(',');
                int cat = Convert.ToInt32(categorias[ComboCategoria.SelectedIndex]);

                produto.SetNome(TxtNome.Text);
                produto.SetCodigo();
                produto.SetPrecoVenda((double)numPrecoVenda.Value);
                produto.SetTamanho((double)numTamanho.Value);
                produto.SetPeso((double)numPeso.Value);
                produto.SetMedida(ComboMedida.Text.Substring(0, 2));
                produto.AddCategoria(FabricaCategoria.GetCategoria((TipoCategoria)cat));
                produto.SetDescricao(TxtDescricao.Text);

                AddFornecedoresAoProduto();
                AddFabricantesAoProduto();
                
                Produto.InserirNoBancoDeDados(produto);

                produto.InserirFabricantesNoBancoDeDados();
                produto.InserirFornecedoresNoBancoDeDados();
                produto.InserirCategoriasNoBancoDeDados();

                MessageBox.Show("Produto cadastrado com sucesso.");

            } catch (Exception ex) {
                MessageBox.Show(ex.StackTrace + "\n" + ex.Message + "\n" + ex.Source);
            }
        }

        private void AddFabricantesAoProduto() {
            foreach (var item in ListFabricantesProduto.Items) {
                var fabricante = new Fabricante();

                fabricante.SetId(Convert.ToInt32(item.ToString()[0].ToString()));
                
                produto.AddFabricante(fabricante);
            }
        }

        private void AddFornecedoresAoProduto() {
            foreach (var item in ListFornecedoresProduto.Items) {
                var fornecedor = new Fornecedor();

                fornecedor.SetId(Convert.ToInt32(item.ToString()[0].ToString()));

                produto.AddFornecedor(fornecedor);
            }
        }

        private void SetFornecedorTodos(SqlDataReader reader) {
            ListFornecedoresTodos.Items.Add(reader["Pessoa_Id"] + " - " + reader["Nome_Fantasia"]);
        }

        private void SetFabricanteTodos(SqlDataReader reader) {
            ListFabricantesTodos.Items.Add(reader["Pessoa_Id"] + " - " + reader["Nome_Fantasia"]);
        }

        private void ComboCategoria_Enter(object sender, EventArgs e) {
            ComboCategoria.Items.Clear();
            PesquisaCategoria.Todos((SqlDataReader reader) => {
                ComboCategoria.Items.Add(reader["Nome"]);
                ComboCategoria.Tag += reader["Categoria_Id"].ToString() + ",";
            });
        }

        private void SwapItemsListBox(ListBox from, ListBox to) {
            try {
                int index = from.SelectedIndex;

                to.Items.Add(from.Items[index]);
                from.Items.RemoveAt(index);
                from.Refresh();
            } catch (Exception) {
            }
        }

        private void BtnAddFabricante_Click(object sender, EventArgs e) {
            SwapItemsListBox(ListFabricantesTodos, ListFabricantesProduto);
        }

        private void BtnRemoveFabricante_Click(object sender, EventArgs e) {
            SwapItemsListBox(ListFabricantesProduto, ListFabricantesTodos);
        }

        private void BtnAddFornecedor_Click(object sender, EventArgs e) {
            SwapItemsListBox(ListFornecedoresTodos, ListFornecedoresProduto);
        }

        private void BtnRemoveFornecedor_Click(object sender, EventArgs e) {
            SwapItemsListBox(ListFornecedoresProduto, ListFornecedoresTodos);
        }
    }
}
