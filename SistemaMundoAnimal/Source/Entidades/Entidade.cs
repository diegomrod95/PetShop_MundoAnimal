using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Entidades {
    /// <summary>
    /// Classe abstrata que representa entidades.
    /// </summary>
    public abstract class Entidade {
        protected char Ativo;
        protected DateTime DataCadastro;

        #region Getters e Setters

        public void SetAtivo(char ativo) {
            if (ativo == 'S' || ativo == 'N') {
                this.Ativo = ativo;
            } else {
                throw new ArgumentException(ativo + " não é um caractere válido para o campo ativo");
            }
        }

        public char GetAtivo() {
            return this.Ativo;
        }

        public DateTime GetDataCadastro() {
            return this.DataCadastro;
        }

        #endregion
    }
}
