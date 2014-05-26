using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Dados.Tipos {
    public class TipoCelular : Tipo<string> {

        private static int Length = 11;

        public TipoCelular(string celular) {
            this.Valor = celular;
        }

        public static bool ValidarCelular(string celular) {
            // TODO: Validar celular
            return celular.Length == Length;
        }

        public override string ToString() {
            return this.Valor;
        }
    }
}
