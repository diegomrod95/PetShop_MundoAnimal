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
    public partial class FormVisualizarFuncionario : UserControl {
        public FormVisualizarFuncionario() {
            InitializeComponent();
        }

        /// <summary>
        /// Contructor que recebe o codigo do funcionario para ser visualizado
        /// e aletarado.
        /// </summary>
        /// <param name="funcionario">O codigo do funcionario.</param>
        public FormVisualizarFuncionario(int funcionario) {
            InitializeComponent();
            TxtCodigo.Text = funcionario.ToString();
            Pesquisar();
        }

        /// <summary>
        /// Limpa os DataGrids.
        /// </summary>
        private void LimpaDataGrid() {
            DataGridContato.Rows.Clear();
            DataGridEnderecos.Rows.Clear();

            foreach (Control controle in GroupInformacoesPessoais.Controls) {
                if (controle is TextBox || controle is MaskedTextBox || controle is ComboBox) {
                    controle.Text = "";
                }
            }
        }

        /// <summary>
        /// Insere as infomações do funcionarios nos controles. 
        /// </summary>
        /// <param name="reader">Um SqlDataReader</param>
        private void SetFuncionario(SqlDataReader reader) {
            TxtNome.Text = reader["Nome"].ToString();
            TxtSobrenome.Text = reader["Sobrenome"].ToString();
            ComboGeneros.Text = reader["Genero"].ToString();
            TxtRG.Text = reader["RG"].ToString();
            TxtCPF.Text = reader["CPF"].ToString();
            TxtSalarioFuncionario.Text = reader["Salario"].ToString();
            TxtNascimento.Text = reader["Nascimento"].ToString();
            ComboCargoFuncionario.Text = reader["Codigo do Cargo"].ToString() + " " + reader["Cargo"].ToString();
            TxtValeAlimentacao.Text = reader["Vale Alimentacao"].ToString();
            TxtValeTransporte.Text = reader["Vale Transporte"].ToString();
            TxtAuxilioCreche.Text = reader["Auxilio Creche"].ToString();
            TxtAssitenciaMedica.Text = reader["Assitencia Medica"].ToString();
            TxtDiaPagamento.Text = reader["Dia de Pagamento"].ToString();
            TxtDataCadastro.Text = reader["Admissao"].ToString();
        }

        /// <summary>
        /// Retorna uma instancia da entidade funcionário.
        /// </summary>
        /// <returns>Um funcionario com os dados dos controles.</returns>
        private Funcionario NovoFuncionario() {
            var funcionario = new Funcionario();

            try {

                int dia = Convert.ToInt32(TxtNascimento.Text.Substring(0, 2));
                int mes = Convert.ToInt32(TxtNascimento.Text.Substring(2, 2));
                int ano = Convert.ToInt32(TxtNascimento.Text.Substring(4, 4));

                funcionario.SetId(Convert.ToInt32(TxtCodigo.Text));
                funcionario.SetNome(TxtNome.Text);
                funcionario.SetSobrenome(TxtSobrenome.Text);
                funcionario.SetTipoPessoa('F');
                funcionario.SetGenero(ComboGeneros.Text[0]);
                funcionario.SetRG(TxtRG.Text);
                funcionario.SetCPF(TxtCPF.Text);
                funcionario.SetNascimento(dia, mes, ano);
                funcionario.SetCargo((TipoCargo)Convert.ToInt32(ComboCargoFuncionario.Text[0].ToString()));
                funcionario.SetSalario(Convert.ToDouble(TxtSalarioFuncionario.Text));
                funcionario.SetValeAlimentacao(Convert.ToDouble(TxtValeAlimentacao.Text));
                funcionario.SetValeTransporte(Convert.ToDouble(TxtValeTransporte.Text));
                funcionario.SetAuxilioCreche(Convert.ToDouble(TxtAuxilioCreche.Text));
                funcionario.SetAssitenciaMedica(Convert.ToDouble(TxtAssitenciaMedica.Text));
                funcionario.SetDiaPagamento(Convert.ToInt32(TxtDiaPagamento.Text));

                return funcionario;
            } catch (Exception e) {
                throw e;
            }
        }

        /// <summary>
        /// Adiciona os contatos de um funcionário no DataGrid.
        /// </summary>
        /// <param name="reader">Um SqlDataReader</param>
        private void SetContato(SqlDataReader reader) {
            int index;
            
            DataGridContato.Rows.Add(
                reader["Nome"],
                reader["Contato"],
                reader["Data_Cadastro"],
                reader["Ativo"]);

            index = DataGridContato.Rows.Count - 1;

            DataGridContato.Rows[index].Tag = reader["Tipo_Id"];
            DataGridContato.Rows[index].Cells[1].Tag = reader["Contato"];
        }

        /// <summary>
        /// Adiciona os endereços de um funcionario no DataGrid.
        /// </summary>
        /// <param name="reader">Um SqlDataReader</param>
        private void SetEndereco(SqlDataReader reader) {
            DataGridEnderecos.Rows.Add(
                reader["Pais"],
                reader["Estado"],
                reader["Cidade"],
                reader["Endereco"],
                reader["NumeroEndereco"],
                reader["Bairro"],
                reader["Complemento"],
                reader["CEP"],
                reader["Data_Cadastro"],
                reader["Ativo"]);
        }

        /// <summary>
        /// Pesquisa na view funcionários de acordo com o codigo do controle TxtCodigo.
        /// </summary>
        private void Pesquisar() {
            try {
                LimpaDataGrid();
                int id = Convert.ToInt32(TxtCodigo.Text);
                PesquisaContatos.PorFuncionarioId(id, SetContato);
                PesquisaEnderecos.PorFuncionarioId(id, SetEndereco);
                PesquisaFuncionario.PorId(id, SetFuncionario);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateContatos() {
            try {
                foreach (DataGridViewRow row in DataGridContato.Rows) {
                    string antigo = row.Cells[1].Tag.ToString();
                    var contato = FabricaContato.GetContato(row.Cells[1].Value.ToString(), 
                                                                        (TipoContato)Convert.ToInt32(row.Tag));
                    contato.SetAtivo(row.Cells[3].Value.ToString()[0]);
                    Contato.UpdateNoBancoDeDados(contato, Convert.ToInt32(TxtCodigo.Text), antigo);
                }
            } catch (Exception e) {
                throw e;
            }
        }

        private void TxtCodigo_KeyUp(object sender, KeyEventArgs e) {
            if (TxtCodigo.Text != "") {
                Pesquisar();
            } else {
                LimpaDataGrid();    
            }
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e) {
            if (TxtCodigo.Text != "") {
                Pesquisar();
            } else {
                LimpaDataGrid();
            }
        }

        /// <summary>
        /// Cria um funcionario com os dados do controle e o salva no banco de dados.
        /// </summary>
        private void BtnSalvar_Click(object sender, EventArgs e) {
            try {
                Funcionario funcionario = NovoFuncionario();

                Pessoa.UpdateNoBancoDeDados(funcionario);
                Funcionario.UpdateNoBancoDeDados(funcionario);

                UpdateContatos();

                MessageBox.Show("Alterações realizadas com sucesso!");
                Pesquisar();
            } catch (Exception ex) {
                MessageBox.Show(ex.StackTrace + "\n" + ex.Message + "\n" + ex.Source);
            }
        }

        /// <summary>
        /// Prenche a ComboBox com os cargos cadastrados no banco.
        /// </summary>
        private void ComboCargoFuncionario_Enter(object sender, EventArgs e) {
            ComboCargoFuncionario.Items.Clear();
            PesquisaCargos.Todos((SqlDataReader reader) => {
                ComboCargoFuncionario.Items.Add(reader["Cargo_Id"] + " " + reader["Nome"]);
            });
        }

        /// <summary>
        /// Pinta de verde os contatos e endereços ativos e de vermelho os não ativos.
        /// </summary>
        private void DataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            var o = (DataGridView)sender;

            if (o.Rows[e.RowIndex].Cells[Convert.ToInt32(o.Tag)].Value.ToString() == "S") {
                o.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
            } else {
                o.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }
    }
}
