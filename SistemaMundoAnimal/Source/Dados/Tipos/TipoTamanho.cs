using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Dados.Tipos {
    public class TipoTamanho : Tipo<double> {

        public TipoTamanho(double valor) {
            this.Valor = valor;
        }
        
        public override string ToString() {
            return this.Valor.ToString("0.000").Replace(",", ".");
        }
    }
}
