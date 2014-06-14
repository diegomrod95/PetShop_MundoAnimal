using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados.Tipos;

namespace SistemaMundoAnimal.Source.Entidades {
    public class Pedido : Entidade {
        private int Id;
        private int Tipo;
        private int FuncionarioId;
        private TipoDinheiro ValorTotal;
        private float Desconto;
        private string Descricao;
        private int Status;
        private DateTime DataEntrega;

        private List<ItemPedido> ItemsPedido;
    }
}
