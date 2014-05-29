using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Entidades;

namespace SistemaMundoAnimal.Testes.Entidades {
    public class PessoaTeste : Pessoa, ITestavel {

        public bool TesteOK = true;

        private void InserirPessoaFissicaNoBancoDeDados() {
            var pessoa = new PessoaTeste();

            try {

                pessoa.SetNome("José");
                pessoa.SetSobrenome("Arnaldo");
                pessoa.SetTipoPessoa('F');
                pessoa.SetGenero('M');
                pessoa.SetRG("311596215");
                pessoa.SetCPF("14455829993");
                pessoa.SetNascimento(18, 6, 1991);

                Pessoa.InserirNoBancoDeDados(pessoa);

            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                TesteOK = false;
            }
        }

        private void InserirPessoaJuridicaNoBancoDeDados() {
            var pessoa = new PessoaTeste();

            try {

                pessoa.SetNomeFantasia("Casa Bahia");
                pessoa.SetTipoPessoa('J');
                pessoa.SetGenero('O');
                pessoa.SetCNPJ("12345678954321");
                
                Pessoa.InserirNoBancoDeDados(pessoa);

            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                TesteOK = false;
            }
        }

        private void InserirContatosNoBancoDeDadosTeste() {
            var pessoa = new PessoaTeste();

            try {

                pessoa.SetId(3);

                var contato1 = FabricaContato.GetContato("1155555555", TipoContato.Telefone);
                var contato2 = FabricaContato.GetContato("meutwitter", TipoContato.Twitter);
                var contato3 = FabricaContato.GetContato("AAA", TipoContato.Outro);

                pessoa.AddContato(contato1);
                pessoa.AddContato(contato2);
                pessoa.AddContato(contato3);

                pessoa.InserirContatosNoBancoDeDados();

            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                TesteOK = false;
            } 
        }

        private void InserirEnderecosNoBancoDeDadosTeste() {
            var pessoa = new PessoaTeste();

            try {

                pessoa.SetId(3);

                var endereco1 = new Endereco();

                endereco1.SetPais("Brasil");
                endereco1.SetEstado("AC");
                endereco1.SetCidade("Projaque");
                endereco1.SetEndereco("Rua Roberto Marinho");
                endereco1.SetNumeroEndereco(171);
                endereco1.SetBairro("Bolivar");
                endereco1.SetComplemento("Não existe");
                endereco1.SetCEP("15712371");

                var endereco2 = new Endereco();

                endereco2.SetPais("Argentina");
                endereco2.SetEstado("SP");
                endereco2.SetCidade("Projaque");
                endereco2.SetEndereco("Rua Roberto Marinho");
                endereco2.SetNumeroEndereco(111);
                endereco2.SetBairro("Bolivar");
                endereco2.SetComplemento("Não existe");
                endereco2.SetCEP("15719111");

                pessoa.AddEndereco(endereco1);
                pessoa.AddEndereco(endereco2);

                pessoa.InserirEnderecosNoBancoDeDados();

            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                TesteOK = false;
            }
        }

        public void RodarTestes() {
        }
    }
}
