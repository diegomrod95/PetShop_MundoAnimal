using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Pesquisa.Entidade {
    public static class PesquisaPedido {

        private static readonly string SelectPedidoTodos = @"SELECT P.*, T.Descricao AS Tipo, S.Nome + ' ' + S.Sobrenome AS Nome"
            + " FROM Pedido AS P JOIN Tipo_Pedido AS T ON P.Tipo_Id = T.Tipo_Id JOIN Pessoa AS S ON P.Vendedor_Id = S.Pessoa_Id"
            + " WHERE P.Ativo = 'S'";

        public static void Todos(BancoDeDados.ConsultaSqlCallback callback) {
            BancoDeDados.NovaConsultaSql(SelectPedidoTodos, callback);
        }

    }
}
