using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SistemaMundoAnimal.Source.Entidades;

namespace SistemaMundoAnimal.Forms {
    public partial class FormCadastroFuncionario : UserControl {

        private Funcionario funcionario;

        public FormCadastroFuncionario() {
            InitializeComponent();
            funcionario = new Funcionario();
        }

        /// <summary>
        /// Limpa os controles do formulario inteiro.
        /// </summary>
        private void LimpaControlesFormularioCadastroFuncionario() {
            foreach (Control grupo in this.Controls) { 
                if (grupo is GroupBox) {
                    foreach (Control controle in grupo.Controls) {
                        if (controle is TextBox || controle is ComboBox || controle is RichTextBox) {
                            controle.Text = "";
                        }
                    }
                }

                if (grupo is TextBox || grupo is ComboBox || grupo is RichTextBox || grupo is MaskedTextBox) {
                    grupo.Text = "";
                }
            }
        }

        /// <summary>
        /// Limpa os controles do formulario de endereço.
        /// </summary>
        private void LimpaControlesEndereco() {
            foreach(Control controle in GroupEndereco.Controls) {
                if (controle is TextBox || controle is ComboBox || controle is RichTextBox) {
                    controle.Text = "";
                }
            }
        }

        /// <summary>
        /// Limpa os controles do formulario de 
        /// </summary>
        private void LimpaControlesContato() {
            TxtContato.Text = "";
            ComboTipoContato.Text = "";
        }

        /// <summary>
        /// Adiciona um endereço ao funcionário.
        /// </summary>
        private void BtnAddEndereco_Click(object sender, EventArgs e) {
            var endereco = new Endereco();

            try {
                
                endereco.SetPais(ComboEnderecoPais.Text);
                endereco.SetEstado(ComboEstado.Text);
                endereco.SetCidade(TxtEnderecoCidade.Text);
                endereco.SetEndereco(TxtEndereco.Text);

                if (TxtNumeroEndereco.Text != "") {
                    endereco.SetNumeroEndereco(Convert.ToInt32(TxtNumeroEndereco.Text));
                }

                endereco.SetBairro(TxtBairroEndereco.Text);
                endereco.SetCEP(TxtCEPEndereco.Text);
                endereco.SetComplemento(TxtComplemento.Text);

                funcionario.AddEndereco(endereco);

                LimpaControlesEndereco();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRegistrarFuncionario_Click(object sender, EventArgs e) {
            try {

                int dia = Convert.ToInt32(TxtNascimento.Text.Substring(0, 2));
                int mes = Convert.ToInt32(TxtNascimento.Text.Substring(2, 2));
                int ano = Convert.ToInt32(TxtNascimento.Text.Substring(4, 4));

                funcionario.SetNome(TxtNome.Text);
                funcionario.SetSobrenome(TxtSobrenome.Text);
                funcionario.SetTipoPessoa('F');
                funcionario.SetGenero(ComboGeneros.Text.ToCharArray()[0]);
                funcionario.SetRG(TxtRG.Text);
                funcionario.SetCPF(TxtCPF.Text);
                funcionario.SetNascimento(dia, mes, ano);
                funcionario.SetCargo((TipoCargo) ComboCargoFuncionario.Items.IndexOf(ComboCargoFuncionario.Text) + 1);
                funcionario.SetSalario(Convert.ToDouble(TxtSalarioFuncionario.Text));
                funcionario.SetValeAlimentacao(Convert.ToDouble(TxtValeAlimentacao.Text));
                funcionario.SetValeTransporte(Convert.ToDouble(TxtValeTransporte.Text));
                funcionario.SetAuxilioCreche(Convert.ToDouble(TxtAuxilioCreche.Text));
                funcionario.SetAssitenciaMedica(Convert.ToDouble(TxtAssitenciaMedica.Text));
                funcionario.SetDiaPagamento(Convert.ToInt32(TxtDiaPagamento.Text));

                Pessoa.InserirNoBancoDeDados(funcionario);
                Funcionario.InserirNoBancoDeDados(funcionario);

                funcionario.InserirContatosNoBancoDeDados();
                funcionario.InserirEnderecosNoBancoDeDados();

                LimpaControlesFormularioCadastroFuncionario();

                funcionario = new Funcionario();

            } catch (Exception ex) {
                MessageBox.Show(ex.StackTrace + "\n\n" + ex.Message);
            }
        }

        /// <summary>
        /// Adiciona um contato ao funcionário.
        /// </summary>
        private void BtnAddContato_Click(object sender, EventArgs e) {
            try {
                int index = ComboTipoContato.Items.IndexOf(ComboTipoContato.Text) + 1;
                var contato = FabricaContato.GetContato(TxtContato.Text, (TipoContato)index);

                funcionario.AddContato(contato);

                LimpaControlesContato();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLimpaEndereco_Click(object sender, EventArgs e) {
            LimpaControlesEndereco();
        }

        private void BtnLimpaContato_Click(object sender, EventArgs e) {
            LimpaControlesContato();
        }

        private void button1_Click(object sender, EventArgs e) {
            LimpaControlesFormularioCadastroFuncionario();
        }

    }
}
