using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Testes.Entidades;

namespace SistemaMundoAnimal.Testes {
    public class Teste {

        private PessoaTeste Pessoa = new PessoaTeste();

        public void RodarTodosTestes() {
            Pessoa.RodarTestes();
        }
    }
}
