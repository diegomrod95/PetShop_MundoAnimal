using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Pesquisa.Entidade {
    public static class PesquisaCategoria {

        private static readonly string SelectCategoriasTodos = @"SELECT [Categoria_Id], [Nome], [Descricao] FROM [Categoria] WHERE Ativo = 'S'";

        public static void Todos(BancoDeDados.ConsultaSqlCallback callback) {
            BancoDeDados.NovaConsultaSql(SelectCategoriasTodos, callback);    
        }

    }
}
