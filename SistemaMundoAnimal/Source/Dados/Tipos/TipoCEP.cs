using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Dados.Tipos {
    public class TipoCEP : Tipo<string> {
        private static int Length = 8;

        public TipoCEP(string valor) {
            this.Valor = valor;
        }

        public static bool ValidarCEP(string cep) { 
            // TODO: Validar CEP
            return cep.Length == Length;
        }

        public override string ToString() {
            return this.Valor;
        }
    }
}
