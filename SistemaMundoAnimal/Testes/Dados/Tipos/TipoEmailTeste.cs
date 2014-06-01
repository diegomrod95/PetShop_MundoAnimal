using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados.Tipos;

namespace SistemaMundoAnimal.Testes.Dados.Tipos {
    public class TipoEmailTeste : ITestavel {

        public bool TesteOK = true;

        private void TestarEmailsValidos() {
            if (!(TipoEmail.ValidarEmail("teste@gmail.com") && TipoEmail.ValidarEmail("teste@gmail.com.br"))) {
                TesteOK = false;
            }
        }

        private void TestarEmailsInvalidos() {
            if (TipoEmail.ValidarEmail("testeemail.com") && (TipoEmail.ValidarEmail("@"))) {
                TesteOK = false;
            }
        }

        public void RodarTestes() {
            TestarEmailsValidos();
            TestarEmailsInvalidos();
        }
    }
}
