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
    public partial class FormPesquisarFuncionarios : UserControl {

        private void PrencherTodosFuncionarios() {
            GridResultado.Rows.Clear();
            PesquisaFuncionario.Todos(AddResultadosDePesquisaAoGrid);
        }

        private void AddResultadosDePesquisaAoGrid(SqlDataReader reader) {
            GridResultado.Rows.Add(
                    reader["Código da Pessoa"],
                    reader["Nome"],
                    reader["Sobrenome"],
                    reader["Genero"],
                    reader["Cargo"],
                    reader["RG"],
                    reader["CPF"],
                    reader["Idade"],
                    reader["Salario"],
                    reader["Assitencia Medica"],
                    reader["Auxilio Creche"],
                    reader["Vale Alimentacao"],
                    reader["Vale Transporte"],
                    reader["Dia de Pagamento"]);
        }

        private void Pesquisar() {
            GridResultado.Rows.Clear();
            try {
                switch (ComboFiltroPesquisa.SelectedIndex + 1) {
                    case (int)PesquisaFuncionario.Filtros.Id:
                        if (TxtConsulta.Text != "") {
                            PesquisaFuncionario.PorId(Convert.ToInt32(TxtConsulta.Text), AddResultadosDePesquisaAoGrid);
                        }
                        break;
                    case (int)PesquisaFuncionario.Filtros.Cargo:
                        PesquisaFuncionario.PorCargo(TxtConsulta.Text, AddResultadosDePesquisaAoGrid);
                        break;
                    default:
                        PesquisaFuncionario.PorNome(TxtConsulta.Text, AddResultadosDePesquisaAoGrid);
                        break;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                TxtConsulta.Text = "";
            }
        }

        public FormPesquisarFuncionarios() {
            InitializeComponent();
            PrencherTodosFuncionarios();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e) {
            Pesquisar();
        }

        private void TxtConsulta_KeyUp(object sender, KeyEventArgs e) {
            Pesquisar();
        }

        private void TxtConsulta_KeyPress(object sender, KeyPressEventArgs e) {
            Pesquisar();
        }

        private void BtnLimpar_Click(object sender, EventArgs e) {
            PrencherTodosFuncionarios();
            TxtConsulta.Text = "";
        }
        
        private void GridResultado_CellClick(object sender, DataGridViewCellEventArgs e) {
            // TODO: Criar um formulario onde o usuario possa alterar os dados do 
            // funcionário clicado, com base no código dele.
            try {
                int index = Convert.ToInt32(GridResultado.Rows[e.RowIndex].Cells[0].Value);
                if (index >= 0) {
                    MessageBox.Show(index.ToString());
                }
            } catch (Exception) {
            }
        }

    }
}
