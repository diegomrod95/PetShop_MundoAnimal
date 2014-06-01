using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Dados.Tipos {
    public class TipoMedida : Tipo<string> {

        private static List<string> Medidas = new List<string>() { "UN", "KG", "GR", "DU", "DZ", "LT" };

        public static bool ValidarMedida(string valor) {
            return Medidas.Contains(valor);
        }

        public TipoMedida(string valor) {
            this.Valor = valor;
        }

        public override string ToString() {
            return this.Valor;
        }
    }
}
