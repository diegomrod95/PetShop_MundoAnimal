using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Dados.Tipos {
    public abstract class Tipo<T> {
        protected T Valor;

        public abstract override string ToString();
    }
}
