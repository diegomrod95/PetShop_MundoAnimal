using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Dados.Tipos {
    public class TipoEmail : Tipo<string> {

        public TipoEmail(string email) {
            this.Valor = email;
        }

        public static bool ValidarEmail(string email) { 
            // TODO: Validar Email
            return true;
        }

        public override string ToString() {
            return this.Valor;
        }
    }
}
