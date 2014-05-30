using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Pesquisa.Entidade {
    public static class PesquisaEnderecos {

        private static string SelectPessoaEnderecoPorPessoaId = @"SELECT * FROM [Pessoa_Endereco] WHERE [Pessoa_Id] = {0};";

        private static string SelectPessoaEnderecoPorFuncionarioId = @"SELECT P.*" 
            + " FROM [Funcionario] AS F JOIN [Pessoa_Endereco] AS P ON F.Pessoa_Id = P.Pessoa_Id " 
            + " WHERE F.Pessoa_Id = {0}";

        public static void PorId(int id, BancoDeDados.ConsultaSqlCallback callback) {
            var consulta = string.Format(SelectPessoaEnderecoPorPessoaId, id);
            BancoDeDados.NovaConsultaSql(consulta, callback);
        }

        public static void PorFuncionarioId(int id, BancoDeDados.ConsultaSqlCallback callback) {
            var consulta = string.Format(SelectPessoaEnderecoPorFuncionarioId, id);
            BancoDeDados.NovaConsultaSql(consulta, callback);
        }

    }
}
