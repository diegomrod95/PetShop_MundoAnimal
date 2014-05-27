using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Dados.Tipos {
    /// <summary>
    /// Classe abstrataque representa tipos de dados usados por entidades no banco de dados.
    /// </summary>
    /// <typeparam name="T">Tipo primitivo do tipo composto Tipo</typeparam>
    public abstract class Tipo<T> {
        protected T Valor;

        /// <summary>
        /// Metodo obrigatório de todos tipos, pois será usado para cadastrar no banco de dados e
        /// visualizar na tela.
        /// </summary>
        /// <returns>O tipo T convertido para string</returns>
        public abstract override string ToString();
    }
}
