using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Pesquisa.Entidade {
    public static class PesquisaProduto {

        public enum Filtros : int { 
            Id = 1,
            Nome,
            Codigo
        }

        public static readonly string SelectProdutoTodos = @"SELECT P.*, A.Nome AS Categoria FROM [Produto] AS P"
            + " LEFT JOIN [Categoria_Produto] AS C ON P.Produto_Id = C.Produto_Id"
            + " LEFT JOIN [Categoria] AS A ON C.Categoria_Id = A.Categoria_Id";

        public static readonly string SelectProdutoPorId = @"SELECT P.*, A.Nome AS Categoria FROM [Produto] AS P"
            + " LEFT JOIN [Categoria_Produto] AS C ON P.Produto_Id = C.Produto_Id"
            + " LEFT JOIN [Categoria] AS A ON C.Categoria_Id = A.Categoria_Id"
            + " WHERE P.Produto_Id = {0}";

        public static readonly string SelectProdutoPorCampo = @"SELECT P.*, A.Nome AS Categoria FROM [Produto] AS P"
            + " LEFT JOIN [Categoria_Produto] AS C ON P.Produto_Id = C.Produto_Id"
            + " LEFT JOIN [Categoria] AS A ON C.Categoria_Id = A.Categoria_Id"
            + " WHERE P.{0} LIKE '{1}%'";

        public static void Todos(BancoDeDados.ConsultaSqlCallback callback) {
            BancoDeDados.NovaConsultaSql(SelectProdutoTodos, callback);
        }

        public static void PorId(string id, BancoDeDados.ConsultaSqlCallback callback) {
            var consulta = string.Format(SelectProdutoPorId, id);
            BancoDeDados.NovaConsultaSql(consulta, callback);
        }

        public static void PorNome(string nome, BancoDeDados.ConsultaSqlCallback callback) {
            var consulta = string.Format(SelectProdutoPorCampo, "Nome", nome);
            BancoDeDados.NovaConsultaSql(consulta, callback);
        }

        public static void PorCodigo(string codigo, BancoDeDados.ConsultaSqlCallback callback) {
            var consulta = string.Format(SelectProdutoPorCampo, "Codigo", codigo);
            BancoDeDados.NovaConsultaSql(consulta, callback);
        }
    }
}
