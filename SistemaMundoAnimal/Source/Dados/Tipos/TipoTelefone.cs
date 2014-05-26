using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Dados.Tipos {
    public class TipoTelefone : Tipo<string> {

        private static int Length = 10;

        public TipoTelefone(string telefone) {
            this.Valor = telefone;
        }

        public static bool ValidarTelefone(string telefone) {
            // TODO: Validar telefone
            return telefone.Length == Length;
        }

        public override string ToString() {
            return this.Valor;
        }
    }
}
