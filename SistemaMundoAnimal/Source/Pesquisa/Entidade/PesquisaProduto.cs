using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Pesquisa.Entidade {
    public static class PesquisaProduto {

        public enum Filtros : int { }

        public static readonly string SelectProdutoTodos = @"SELECT P.*, A.Nome AS Categoria FROM [Produto] AS P"
            + " LEFT JOIN [Categoria_Produto] AS C ON P.Produto_Id = C.Produto_Id"
            + " LEFT JOIN [Categoria] AS A ON C.Categoria_Id = A.Categoria_Id";

        public static void Todos(BancoDeDados.ConsultaSqlCallback callback) {
            BancoDeDados.NovaConsultaSql(SelectProdutoTodos, callback);
        }

    }
}
