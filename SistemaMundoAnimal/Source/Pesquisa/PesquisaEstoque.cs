using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Pesquisa {
    public static class PesquisaEstoque {

        private static readonly string SelectEstoqueTodosProdutos = @"SELECT * FROM View_Estoque";

        public static void Todos(BancoDeDados.ConsultaSqlCallback callback) {
            BancoDeDados.NovaConsultaSql(SelectEstoqueTodosProdutos, callback);
        }

    }
}
