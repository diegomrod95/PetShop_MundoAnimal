using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados.Tipos;

namespace SistemaMundoAnimal.Source.Entidades {
    public class ItemPedido: Entidade {
        private int ProdutoId;
        private TipoQuantidade Quantidade;
        private TipoDinheiro ValorUnitario;
    }
}
