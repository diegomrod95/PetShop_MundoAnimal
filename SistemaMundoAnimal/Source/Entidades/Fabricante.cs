using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Entidades {
    public class Fabricante : Pessoa {
        private List<Produto> Produtos;

        private static readonly string InsertFabricanteProdutoSqlQuery = @"INSERT INTO [Fabricante_Produto]"
            + " ([Fabricante_Id], [Produto_Id])"
            + " VALUES ({0}, {1})";

        public static void InserirFabricanteProduto(Fabricante fabricante, int produto_id) {
            string comando;
            try {

                comando = string.Format(InsertFabricanteProdutoSqlQuery,
                    fabricante.GetId(),
                    produto_id);

                BancoDeDados.NovoComandoSql(comando);

            } catch (Exception e) {
                throw e;    
            }
        }
    }
}
