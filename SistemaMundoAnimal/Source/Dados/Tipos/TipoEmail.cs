using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace SistemaMundoAnimal.Source.Dados.Tipos {
    public class TipoEmail : Tipo<string> {

        private static Regex rg = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");

        public TipoEmail(string email) {
            this.Valor = email;
        }

        public static bool ValidarEmail(string email) {
            return (rg.IsMatch(email));
        }

        public override string ToString() {
            return this.Valor;
        }
    }
}
