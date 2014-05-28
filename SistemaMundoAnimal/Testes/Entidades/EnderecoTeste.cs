using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Entidades;

namespace SistemaMundoAnimal.Testes.Entidades {
    public class EnderecoTeste : Endereco, ITestavel {

        public bool TesteOK = true;

        private void InserirEnderecoNoBancoDeDados() {
            var endereco = new Endereco();

            try {

                endereco.SetPais("Brasil");
                endereco.SetEstado("AC");
                endereco.SetCidade("Projaque");
                endereco.SetEndereco("Rua Roberto Marinho");
                endereco.SetNumeroEndereco(171);
                endereco.SetBairro("Bolivar");
                endereco.SetComplemento("Não existe");
                endereco.SetCEP("15712371");

                Endereco.InserirNoBancoDeDados(endereco, 3);

            } catch (Exception e) {
                Console.WriteLine(e.Message);
                TesteOK = false;           
            }
        }

        public void RodarTestes() {
        }

    }
}
