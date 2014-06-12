using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Entidades;
using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Estoque {
    public static class Estoque {

        private static readonly string InsertProdutoNoEstoque = @"INSERT INTO"
            + " Estoque_Produto(Produto_Id,Quantidade,Quantidade_Minima) VALUES({0},{1},{2})";

        public static void CadastrarProdutoNoEstoque(Produto produto) { 
            string comando;
            try {

                comando = string.Format(InsertProdutoNoEstoque,
                    produto.GetId(),
                    produto.GetQuantidade(),
                    produto.GetQtdMinima());

                BancoDeDados.NovoComandoSql(comando);

            } catch (Exception e) {
                throw e;
            }
        }

    }
}
