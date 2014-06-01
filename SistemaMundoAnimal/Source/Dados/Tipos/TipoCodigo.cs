using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Dados.Tipos {
    public class TipoCodigo : Tipo<string> {

        public static string GerarCodigo() {
            return "TODO";
        }

        public TipoCodigo(string valor) {
            this.Valor = valor;
        }

        public override string ToString() {
            return this.Valor;
        }
    }
}
