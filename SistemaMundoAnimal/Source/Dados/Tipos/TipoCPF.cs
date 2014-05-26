using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Dados.Tipos {
    public class TipoCPF : Tipo<string> {

        private static int Length = 11;

        public TipoCPF(string valor) {
            this.Valor = valor;
        }

        public static bool ValidarCPF(string cpf) { 
            // TODO: Validar CPF
            return cpf.Length == Length;
        }

        public override string ToString() {
            return this.Valor;
        }
    }
}
