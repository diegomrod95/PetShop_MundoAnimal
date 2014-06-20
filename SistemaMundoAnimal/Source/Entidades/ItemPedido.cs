using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados.Tipos;

namespace SistemaMundoAnimal.Source.Entidades {
    public class ItemPedido: Entidade {
        private Produto _Produto;
        private TipoQuantidade Quantidade;
        private TipoDinheiro ValorUnitario;

        #region Getters e Setters

        public void SetProduto(Produto produto) {
            this._Produto = produto;
        }

        public Produto GetProduto() {
            return this._Produto;
        }

        public void SetQuantidade(double quantidade) {
            if (quantidade > 0) {
                this.Quantidade = new TipoQuantidade(quantidade);
            } else {
                throw new ArgumentException(quantidade + " não é uma quantidade válida.");
            }
        }

        public TipoQuantidade GetQuantidade() {
            return this.Quantidade;
        }

        public void SetValorUnitario(double valor) {
            if (valor > 0) {
                this.ValorUnitario = new TipoDinheiro(valor);
            } else {
                throw new ArgumentException(valor + " não é um valor válido.");
            }
        }

        public TipoDinheiro GetValorUnitario() {
            return this.ValorUnitario;
        }

        #endregion
    }
}
