using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Pesquisa.Entidade {
    public static class PesquisaParente {

        private static readonly string SelectParentesPorPessoaId = @"SELECT" 
            + " PP.Parentesco, PR.Nome, PR.Sobrenome, PR.Genero, PR.RG, PR.CPF, PR.Nascimento"
            + " FROM Pessoa AS PS JOIN Pessoa_Parente AS PP ON PS.Pessoa_Id = PP.Pessoa_Id"
            + " JOIN Pessoa AS PR ON PP.Parente_Id = PR.Pessoa_Id"
            + " WHERE PS.Pessoa_Id = {0}";

        public static void PorPessoaId(int pessoa_id, BancoDeDados.ConsultaSqlCallback callback) {
            var consulta = string.Format(SelectParentesPorPessoaId, pessoa_id);
            BancoDeDados.NovaConsultaSql(consulta, callback);
        }

    }
}
