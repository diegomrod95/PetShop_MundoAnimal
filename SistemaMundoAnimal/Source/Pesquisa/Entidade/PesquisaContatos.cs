using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Pesquisa.Entidade {
    public static class PesquisaContatos {

        private static string SelectContatosPorPessoaId = @"SELECT T.Nome, P.Contato, P.Data_Cadastro, P.Ativo "
            + " FROM [Pessoa_Contato] AS P JOIN [Tipo_Contato] AS T ON T.Tipo_Id = P.Tipo_Id "
            + " WHERE [Pessoa_Id] = {0}";

        private static string SelectContatosPorFuncionarioId = @"SELECT T.Nome, P.Contato, P.Data_Cadastro, P.Ativo"
            + " FROM [Funcionario] AS F JOIN [Pessoa_Contato] AS P ON F.Pessoa_Id = P.Pessoa_Id"
            + " JOIN [Tipo_Contato] AS T ON P.Tipo_Id = T.Tipo_Id"
            + " WHERE F.Pessoa_Id = {0}";

        /// <summary>
        /// Pesquisa os contatos de uma entidade pessoa pelo id.
        /// </summary>
        /// <param name="id">O id da entidade pessoa</param>
        /// <param name="callback">Uma lambda que receba um SqlDataReader como argumento</param>
        public static void PorId(int id, BancoDeDados.ConsultaSqlCallback callback) {
            var consulta = string.Format(SelectContatosPorPessoaId, id);
            BancoDeDados.NovaConsultaSql(consulta, callback);
        }

        /// <summary>
        /// Pesquisa os contatos de uma entidade funcionario pelo id.
        /// </summary>
        /// <param name="id">O id da entidade funcionario</param>
        /// <param name="callback">Uma lambda que receba um SqlDataReader como argumento</param>
        public static void PorFuncionarioId(int id, BancoDeDados.ConsultaSqlCallback callback) {
            var consulta = string.Format(SelectContatosPorFuncionarioId, id);
            BancoDeDados.NovaConsultaSql(consulta, callback);
        }

    }
}
