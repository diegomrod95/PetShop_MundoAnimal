using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Pesquisa.Entidade {
    public static class PesquisaEnderecos {

        private static string SelectPessoaEnderecoPorPessoaId = @"SELECT * FROM [Pessoa_Endereco] WHERE [Pessoa_Id] = {0};";

        public static void PorId(int id, BancoDeDados.ConsultaSqlCallback callback) {
            var consulta = string.Format(SelectPessoaEnderecoPorPessoaId, id);
            BancoDeDados.NovaConsultaSql(consulta, callback);
        }

    }
}
