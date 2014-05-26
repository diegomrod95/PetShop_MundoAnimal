using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Dados.Tipos {
    public class TipoRG : Tipo<string> {

        private static int Length = 9;

        public TipoRG(string valor) {
            this.Valor = valor;    
        }

        public static bool ValidarRG(string rg) { 
            // TODO: Validar rg
            return rg.Length == Length;
        }

        public override string ToString() {
            return this.Valor;
        }

    }
}
