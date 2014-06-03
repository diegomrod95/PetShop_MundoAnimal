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

        public FormVisualizarFuncionario(int funcionario) {
            InitializeComponent();
            TxtCodigo.Text = funcionario.ToString();
            Pesquisar();
        }

        private void LimpaDataGrid() {
            DataGridContato.Rows.Clear();
            DataGridEnderecos.Rows.Clear();

            foreach (Control controle in GroupInformacoesPessoais.Controls) {
                if (controle is TextBox || controle is MaskedTextBox || controle is ComboBox) {
                    controle.Text = "";
                }
            }
        }

        private void SetFuncionario(SqlDataReader reader) {
            TxtNome.Text = reader["Nome"].ToString();
            TxtSobrenome.Text = reader["Sobrenome"].ToString();
            ComboGeneros.Text = reader["Genero"].ToString();
            TxtRG.Text = reader["RG"].ToString();
            TxtCPF.Text = reader["CPF"].ToString();
            TxtSalarioFuncionario.Text = reader["Salario"].ToString();
            TxtNascimento.Text = reader["Nascimento"].ToString();
            ComboCargoFuncionario.Text = reader["Cargo"].ToString();
            TxtValeAlimentacao.Text = reader["Vale Alimentacao"].ToString();
            TxtValeTransporte.Text = reader["Vale Transporte"].ToString();
            TxtAuxilioCreche.Text = reader["Auxilio Creche"].ToString();
            TxtAssitenciaMedica.Text = reader["Assitencia Medica"].ToString();
            TxtDiaPagamento.Text = reader["Dia de Pagamento"].ToString();
            TxtDataCadastro.Text = reader["Admissao"].ToString();
        }

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

        private void SetContato(SqlDataReader reader) {

            if (reader["Ativo"].ToString() == "S") {
                DataGridContato.RowsDefaultCellStyle.BackColor = Color.LightGreen;
            } else {
                DataGridContato.RowsDefaultCellStyle.BackColor = Color.Red;
            }
            
            DataGridContato.Rows.Add(
                reader["Nome"],
                reader["Contato"],
                reader["Data_Cadastro"],
                reader["Ativo"]);
        }

        private void SetEndereco(SqlDataReader reader) {

            if (reader["Ativo"].ToString() == "S") {
                DataGridEnderecos.RowsDefaultCellStyle.BackColor = Color.LightGreen;
            } else {
                DataGridEnderecos.RowsDefaultCellStyle.BackColor = Color.Red;
            }

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

        private void BtnSalvar_Click(object sender, EventArgs e) {
            try {
                Funcionario funcionario = NovoFuncionario();

                Pessoa.UpdateNoBancoDeDados(funcionario);
                Funcionario.UpdateNoBancoDeDados(funcionario);

                MessageBox.Show("Alterações realizadas com sucesso!");
            } catch (Exception ex) {
                MessageBox.Show(ex.StackTrace + "\n" + ex.Message + "\n" + ex.Source);
            }
        }

        private void ComboCargoFuncionario_Enter(object sender, EventArgs e) {
            ComboCargoFuncionario.Items.Clear();
            PesquisaCargos.Todos((SqlDataReader reader) => {
                ComboCargoFuncionario.Items.Add(reader["Cargo_Id"] + " " + reader["Nome"]);
            });
        }
    }
}
