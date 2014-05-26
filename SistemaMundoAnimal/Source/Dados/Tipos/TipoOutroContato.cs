using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Dados.Tipos {
    public class TipoOutroContato : Tipo<string> {

        public static int Length = 150;

        public TipoOutroContato(string valor) {
            this.Valor = valor;
        }

        public override string ToString() {
            return this.Valor;
        }

    }
}
