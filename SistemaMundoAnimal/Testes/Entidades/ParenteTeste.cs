using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Entidades;

namespace SistemaMundoAnimal.Testes.Entidades {
    public class ParenteTeste : Parente, ITestavel {

        public bool TesteOK = true;

        private void InserirParenteNoBancoDeDados() {
            var parente = new Parente();

            try {

                parente.SetId(2);
                parente.SetParentesco(TipoParentesco.Conjuge);

                Parente.InserirNoBancoDeDados(parente, 1);

            } catch (Exception e) {
                TesteOK = false;
                Console.WriteLine(e.StackTrace);
            }
        }

        public void RodarTestes() {
        }

    }
}
