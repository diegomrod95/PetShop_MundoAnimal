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
                var categoriaIds = (List<string>)ComboCategoria.Tag;
                int index = Convert.ToInt32(categoriaIds[ComboCategoria.SelectedIndex]);

                produto.SetNome(TxtNome.Text);
                produto.SetPrecoVenda((double)numPrecoVenda.Value);
                produto.SetTamanho((double)numTamanho.Value);
                produto.SetPeso((double)numPeso.Value);
                produto.SetMedida(ComboMedida.Text.Substring(0, 2));
                produto.AddCategoria(FabricaCategoria.GetCategoria((TipoCategoria)index));
                produto.SetDescricao(TxtDescricao.Text);

                //TODO: Inserir fabricantes e fornecedore no banco
            } catch (Exception ex) {
                MessageBox.Show(ex.StackTrace + "\n" + ex.Message + "\n" + ex.Source);
            }
        }

        private void SetFornecedorTodos(SqlDataReader reader) {
            ListFornecedoresTodos.Items.Add(reader["Pessoa_Id"] + " - " + reader["Nome_Fantasia"]);
        }

        private void SetFabricanteTodos(SqlDataReader reader) {
            ListFabricantesTodos.Items.Add(reader["Pessoa_Id"] + " - " + reader["Nome_Fantasia"]);
        }

        private void ComboCategoria_Enter(object sender, EventArgs e) {
            var ids = new List<string>();
            PesquisaCategoria.Todos((SqlDataReader reader) => {
                ComboCategoria.Items.Add(reader["Nome"]);
                ids.Add(reader["Categoria_Id"].ToString());
            });
            ComboCategoria.Tag = ids;
        }

        private void ComboCategoria_Leave(object sender, EventArgs e) {
            ComboCategoria.Items.Clear();
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
