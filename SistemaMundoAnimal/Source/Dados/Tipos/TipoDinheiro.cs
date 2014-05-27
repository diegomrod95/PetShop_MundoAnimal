using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Dados.Tipos {
    public class TipoDinheiro : Tipo<double> {
        private double Valor;

        public void SetDinheiro(double valor) {
            this.Valor = valor;
        }

        public double GetValor() {
            return this.Valor;
        }

        public override string ToString() {
            return this.Valor.ToString("0.00");
        }
    }
}
