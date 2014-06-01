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
    public partial class FormVisualizarFuncionario : UserControl {
        public FormVisualizarFuncionario() {
            InitializeComponent();
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

        private void SetContato(SqlDataReader reader) {
            DataGridContato.Rows.Add(
                reader["Nome"],
                reader["Contato"],
                reader["Data_Cadastro"],
                reader["Ativo"]);
        }

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
    }
}
