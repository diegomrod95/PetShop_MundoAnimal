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
    public partial class FormPesquisarProduto : UserControl {
        public FormPesquisarProduto() {
            InitializeComponent();
            PesquisaProduto.Todos(AddResultadoDePesquisaAoGrid);
        }

        private void AddResultadoDePesquisaAoGrid(SqlDataReader reader) {
            GridResultado.Rows.Add(
                reader["Produto_Id"],
                reader["Codigo"],
                reader["Nome"],
                reader["Categoria"],
                reader["Tamanho"],
                reader["Preco_Venda"],
                reader["Peso"],
                reader["Tipo_Medida"],
                reader["Data_Cadastro"],
                reader["Ativo"]);
        }

        private void Pesquisar() {
            GridResultado.Rows.Clear();
            try {
                string consulta = TxtConsulta.Text.Replace(",", ".");
                if (consulta != "") {
                    switch (ComboFiltroPesquisa.SelectedIndex + 1) {
                        case (int)PesquisaProduto.Filtros.Id:
                            PesquisaProduto.PorId(consulta, AddResultadoDePesquisaAoGrid);
                            break;
                        case (int)PesquisaProduto.Filtros.Nome:
                            PesquisaProduto.PorNome(consulta, AddResultadoDePesquisaAoGrid);
                            break;
                        case (int)PesquisaProduto.Filtros.Codigo:
                            PesquisaProduto.PorCodigo(consulta, AddResultadoDePesquisaAoGrid);
                            break;
                        default:
                            PesquisaProduto.PorNome(consulta, AddResultadoDePesquisaAoGrid);
                            break;
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                TxtConsulta.Text = "";
            }
        }

        private void TxtConsulta_KeyPress(object sender, KeyPressEventArgs e) {
            Pesquisar();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e) {
            Pesquisar();
        }

        private void TxtConsulta_KeyUp(object sender, KeyEventArgs e) {
            Pesquisar();
        }

        private void ComboFiltroPesquisa_SelectedIndexChanged(object sender, EventArgs e) {
            TxtConsulta.Text = "";
        }

        private void BtnLimpar_Click(object sender, EventArgs e) {
            PesquisaProduto.Todos(AddResultadoDePesquisaAoGrid);
        }


    }
}
