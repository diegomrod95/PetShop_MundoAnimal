using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Pesquisa.Entidade {
    public static class PesquisaFabricante {

        public enum Filtros : int {}

        private static readonly string SelectFabricanteTodosSqlQuery = @"SELECT "
            + " P.Pessoa_Id, P.Nome_Fantasia, P.CNPJ, P.Data_Cadastro"
            + " FROM [Fabricante] AS F JOIN [Pessoa] AS P ON F.Fabricante_Id = P.Pessoa_Id";

        private static readonly string SelectFabricantesPorProdutoId = @"SELECT "
            + " F.Fabricante_Id, S.Nome_Fantasia, S.CNPJ, S.Data_Cadastro, S.Ativo"
            + " FROM [Fabricante] AS F JOIN [Fabricante_Produto] AS P ON F.Fabricante_Id = P.Fabricante_Id"
            + " JOIN [Pessoa] AS S ON F.Fabricante_Id = S.Pessoa_Id WHERE P.Produto_Id = {0}";

        /// <summary>
        /// Seleciona todos os fabricantes no Banco de Dados.
        /// </summary>
        /// <param name="callback">Callback invocado a cada linha da tabela</param>
        public static void Todos(BancoDeDados.ConsultaSqlCallback callback) {
            BancoDeDados.NovaConsultaSql(SelectFabricanteTodosSqlQuery, callback);
        }

        public static void ProProdutoId(int produto_id, BancoDeDados.ConsultaSqlCallback callback) { 
            var comando = string.Format(SelectFabricantesPorProdutoId, produto_id);
            BancoDeDados.NovaConsultaSql(comando, callback);
        }
    }
}
