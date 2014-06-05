using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Pesquisa.Entidade {
    public static class PesquisaFornecedor {

        public enum Filtros : int { }

        private static readonly string SelectFornecedorTodosSqlQuery = @"SELECT "
            + "P.Pessoa_Id, P.Nome_Fantasia, P.CNPJ, P.Data_Cadastro"
            + " FROM [Fornecedor] AS F JOIN [Pessoa] AS P ON F.Fornecedor_Id = P.Pessoa_Id";

        /// <summary>
        /// Seleciona todos os fornecedores no Banco de Dados.
        /// </summary>
        /// <param name="callback">Callback invocado a cada linha da tabela</param>
        public static void Todos(BancoDeDados.ConsultaSqlCallback callback) {
            BancoDeDados.NovaConsultaSql(SelectFornecedorTodosSqlQuery, callback);
        }

    }
}
