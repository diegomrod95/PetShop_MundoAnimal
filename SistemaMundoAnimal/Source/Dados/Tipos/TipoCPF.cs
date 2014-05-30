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

        /// <summary>
        /// Verifica se é um cpf original.
        /// </summary>
        /// <param name="cpf">Uma string com um cpf no formato 999999999999</param>
        /// <returns>Verdadeiro se o cpf for valido</returns>
        public static bool ValidarCPF(string cpf) {
            if (cpf.Length != Length) {
                return false;
            }

            int soma1 = 0;
            int soma2 = 0;
            int dig1 = 0;
            int dig2 = 0;
            int resto1 = 0;
            int resto2 = 0;

            for (int i = 0; i < 9; i++) {
                soma1 += Convert.ToInt32(cpf.Substring(i, 1)) * (10 - i);
            }

            resto1 = soma1 % 11;
            dig1 = 11 - resto1;

            if (dig1 > 9) {
                dig1 = 0;
            }

            for (int j = 0; j < 9; j++) {
                soma2 += Convert.ToInt32(cpf.Substring(j, 1)) * (11 - j);
            }

            soma2 += dig1 * 2;
            resto2 = soma2 % 11;
            dig2 = 11 - resto2;

            if (dig2 > 9) {
                dig2 = 0;
            }

            return (dig1 + "" + dig2 == cpf.Substring(9, 2));
        }

        public override string ToString() {
            return this.Valor;
        }
    }
}
