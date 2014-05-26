using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Dados.Tipos {
    public class TipoCNPJ : Tipo<string> {
        
        private static int Length = 14;

        public TipoCNPJ(string valor) {
            this.Valor = valor;
        }

        public static bool ValidarCNPJ(string cnpj) { 
            // TODO: Validar CNPJ
            return cnpj.Length == Length;
        }

        public override string ToString() {
            return this.Valor;
        }
    }
}
