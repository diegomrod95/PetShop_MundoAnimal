﻿using System;
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
                string consulta = TxtConsulta.Text.Replace(",", ".");
                if (consulta != "") {
                    switch (ComboFiltroPesquisa.SelectedIndex + 1) {
                        case (int)PesquisaFuncionario.Filtros.Id:
                            PesquisaFuncionario.PorId(Convert.ToInt32(consulta), AddResultadosDePesquisaAoGrid);
                            break;
                        case (int)PesquisaFuncionario.Filtros.Cargo:
                            PesquisaFuncionario.PorCargo(consulta, AddResultadosDePesquisaAoGrid);
                            break;
                        case (int)PesquisaFuncionario.Filtros.Sobrenome:
                            PesquisaFuncionario.PorSobrenome(consulta, AddResultadosDePesquisaAoGrid);
                            break;
                        case (int)PesquisaFuncionario.Filtros.RG:
                            PesquisaFuncionario.PorRG(consulta, AddResultadosDePesquisaAoGrid);
                            break;
                        case (int)PesquisaFuncionario.Filtros.CPF:
                            PesquisaFuncionario.PorCPF(consulta, AddResultadosDePesquisaAoGrid);
                            break;
                        case (int)PesquisaFuncionario.Filtros.Idade:
                            PesquisaFuncionario.PorIdade(consulta, ">=", AddResultadosDePesquisaAoGrid);
                            break;
                        case (int)PesquisaFuncionario.Filtros.IdadeMaiorQue:
                            PesquisaFuncionario.PorIdade(consulta, ">=", AddResultadosDePesquisaAoGrid);
                            break;
                        case (int)PesquisaFuncionario.Filtros.IdadeMenorQue:
                            PesquisaFuncionario.PorIdade(consulta, "<=", AddResultadosDePesquisaAoGrid);
                            break;
                        case (int)PesquisaFuncionario.Filtros.Salario:
                            PesquisaFuncionario.PorSalario(consulta, "=", AddResultadosDePesquisaAoGrid);
                            break;
                        case (int)PesquisaFuncionario.Filtros.SalarioMaiorQue:
                            PesquisaFuncionario.PorSalario(consulta, ">=", AddResultadosDePesquisaAoGrid);
                            break;
                        case (int)PesquisaFuncionario.Filtros.SalarioMenorQue:
                            PesquisaFuncionario.PorSalario(consulta, "<=", AddResultadosDePesquisaAoGrid);
                            break;
                        case (int)PesquisaFuncionario.Filtros.DiaDePagamento:
                            PesquisaFuncionario.PorDiaDePagamento(consulta, AddResultadosDePesquisaAoGrid);
                            break;
                        default:
                            PesquisaFuncionario.PorNome(consulta, AddResultadosDePesquisaAoGrid);
                            break;
                    }
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
            try {
                int codigo = Convert.ToInt32(GridResultado.Rows[e.RowIndex].Cells[0].Value);
                if (codigo >= 0) {
                    Program.Form.ShowVisualizarFuncionario(codigo);
                }
            } catch (Exception) {
            }
        }

        private void ComboFiltroPesquisa_SelectedIndexChanged(object sender, EventArgs e) {
            TxtConsulta.Text = "";
        }

    }
}
