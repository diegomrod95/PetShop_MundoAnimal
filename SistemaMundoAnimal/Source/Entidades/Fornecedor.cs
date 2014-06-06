using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Entidades {
    public class Fornecedor : Pessoa {
        private List<Produto> Produtos;

        private static readonly string InsertFornecedorProdutoSqlQuery = @"INSERT INTO [Fornecedor_Produto]"
            + " ([Fornecedor_Id], [Produto_Id], [Preco])"
            + " VALUES ({0}, {1}, {2})";

        public static void InserirFornecedorProduto(Fornecedor fornecedor, int produto_id, double valor) {
            string comando;
            try {

                comando = string.Format(InsertFornecedorProdutoSqlQuery,
                    fornecedor.GetId(),
                    produto_id,
                    valor);

                BancoDeDados.NovoComandoSql(comando);

            } catch (Exception e) {
                throw e;
            }
        }

    }
}
