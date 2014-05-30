using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Pesquisa.Entidade {
    public static class PesquisaCargos {

        /// <summary>
        /// Consulta sql para retornar todos os cargos da tabela Funcionario_Cargo.
        /// </summary>
        private static string SelectTiposDeCargosTodos = @"SELECT [Cargo_Id], [Nome] FROM Funcionario_Cargo ORDER BY Cargo_Id";

        /// <summary>
        /// Retorna um tabela com todos cargos da empresa.
        /// </summary>
        /// <param name="callback">Uma expressão lambda com um SqlDataReader como parâmetro.</param>
        public static void Todos(BancoDeDados.ConsultaSqlCallback callback) {
            BancoDeDados.NovaConsultaSql(SelectTiposDeCargosTodos, callback);
        }
    }
}
