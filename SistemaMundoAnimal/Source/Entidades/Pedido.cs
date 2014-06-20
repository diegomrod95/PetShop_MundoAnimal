using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados.Tipos;

namespace SistemaMundoAnimal.Source.Entidades {

    public enum TipoPedido : int { 
        Venda = 1, BanhoTosa, Veterinario, Outro
    }

    public enum TipoPedidoStatus : int { 
        Cancelado, Finalizado, Andamento, AguardamentoPgt, AguardandoCliente
    }

    public class Pedido : Entidade {
        private TipoPedido Tipo;
        private Funcionario Funcionario;
        private TipoDinheiro ValorTotal;
        private float Desconto;
        private string Descricao;
        private TipoPedidoStatus Status;
        private DateTime DataEntrega;

        private List<ItemPedido> ItemsPedido = new List<ItemPedido>();

        private readonly int DescricaoMaxLength = 150;

        #region Getters e Setters
        public void SetTipoPedido(TipoPedido tipo) {
            this.Tipo = tipo;
        }

        public int GetTipoPedido() {
            return (int)this.Tipo;
        }

        public void SetFuncionario(Funcionario funcionario) {
            try {
                this.Funcionario = funcionario;
            } catch (Exception) {
                throw new ArgumentException("Não é um funcionário não é válido.");
            }
        }

        public Funcionario GetFuncionario() {
            return this.Funcionario;
        }

        public int GetFuncionarioId() {
            return this.Funcionario.GetId();
        }

        public void SetValorTotal(double valor) {
            if (valor > 0) {
                this.ValorTotal = new TipoDinheiro(valor);
            } else {
                throw new ArgumentException(valor + " não é um valor total válido.");
            }
        }

        public float GetDesconto() {
            return this.Desconto;
        }

        public void SetDesconto(float desconto) {
            if (desconto >= 0) {
                this.Desconto = desconto;
            } else {
                throw new ArgumentException(desconto + " não é um desconto válido.");
            }
        }

        public void SetDescricao(string descricao) {
            if (descricao.Length < DescricaoMaxLength) {
                this.Descricao = descricao;
            } else {
                throw new ArgumentException(descricao + " não é uma descricao válida.");
            }
        }

        public string GetDescricao() {
            return this.Descricao;
        }

        public void SetStatus(TipoPedidoStatus status) {
            this.Status = status;
        }

        public int GetStatus() {
            return (int)this.Status;
        }

        public void SetDataEntrega(DateTime data) {
            this.DataEntrega = data;
        }

        public string GetDataEntrega() {
            return this.DataEntrega.ToString();
        }

        public void AddItem(ItemPedido item) {
            this.ItemsPedido.Add(item);
        }

        public List<ItemPedido> GetItemsPedidos() {
            return this.ItemsPedido;
        }

        #endregion
    }
}
