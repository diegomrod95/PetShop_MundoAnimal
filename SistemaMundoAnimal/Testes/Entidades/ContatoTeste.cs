using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Entidades;

namespace SistemaMundoAnimal.Testes.Entidades {
    public class ContatoTeste : Contato, ITestavel {

        public bool TesteOK = true;

        private void InserirContatoNoBancoDeDados() {
            var contato = FabricaContato.GetContato("ronaldo.aguiar.filho", TipoContato.Facebook);

            try {

                Contato.InserirNoBancoDeDados(contato, 3);

            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                TesteOK = false;
            }
        }

        public void RodarTestes() {
        }
    }
}
