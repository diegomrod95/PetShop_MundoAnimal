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

        public void RodarTestes() {
        }
    }
}
