using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados.Tipos;

namespace SistemaMundoAnimal.Testes.Dados.Tipos {
    public class TipoCPFTeste : ITestavel {

        public bool TesteOK = true;

        private void TestarValidarCPFValidos() {
            if (!(TipoCPF.ValidarCPF("63777912913") && TipoCPF.ValidarCPF("36647724826"))) {
                TesteOK = false;
            }
        }

        public void RodarTestes() {
            TestarValidarCPFValidos();
            //TestarValidarCPFInvalidos();
        }
    }
}
