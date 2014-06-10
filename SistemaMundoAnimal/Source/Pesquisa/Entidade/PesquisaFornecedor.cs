using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Pesquisa.Entidade {
    public static class PesquisaFornecedor {

        public enum Filtros : int { }

        private static readonly string SelectFornecedorTodosSqlQuery = @"SELECT"
            + " P.Pessoa_Id, P.Nome_Fantasia, P.CNPJ, P.Data_Cadastro"
            + " FROM [Fornecedor] AS F JOIN [Pessoa] AS P ON F.Fornecedor_Id = P.Pessoa_Id";

        private static readonly string SelectFornecedorPorProdutoId = "@SELECT"
            + " F.Fornecedor_Id, S.Nome_Fantasia, S.CNPJ, S.Data_Cadastro, S.Ativo"
            + " FROM [Fornecedor] AS F JOIN [Fornecedor_Produto] AS P ON F.Fornecedor_Id = P.Fornecedor_Id"
            + " JOIN [Pessoa] AS S ON F.Fornecedor_Id = S.Pessoa_Id "
            + " WHERE P.Produto_Id = {0}";

        /// <summary>
        /// Seleciona todos os fornecedores no Banco de Dados.
        /// </summary>
        /// <param name="callback">Callback invocado a cada linha da tabela</param>
        public static void Todos(BancoDeDados.ConsultaSqlCallback callback) {
            BancoDeDados.NovaConsultaSql(SelectFornecedorTodosSqlQuery, callback);
        }

        public static void PorProdutoId(int produto_id, BancoDeDados.ConsultaSqlCallback callback) {
            var comando = string.Format(SelectFornecedorPorProdutoId, produto_id);
            BancoDeDados.NovaConsultaSql(comando, callback);
        }

    }
}
