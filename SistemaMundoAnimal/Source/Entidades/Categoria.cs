using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Entidades {

    public enum TipoCategoria {
        AlimentoGranel = 1,
        AlimentoUnitario,
        HigieneBeleza,
        Duraveis,
        Vestuario,
        Farmacia,
        Conforto,
        Outro
    }

    public static class FabricaCategoria {
        public static Categoria GetCategoria(TipoCategoria tipo) {
            switch (tipo) { 
                case TipoCategoria.AlimentoGranel:
                    return new Categoria("Alimento Granel", tipo);
                case TipoCategoria.AlimentoUnitario:
                    return new Categoria("Alimento Unitário", tipo);
                case TipoCategoria.HigieneBeleza:
                    return new Categoria("Higiene e Beleza", tipo);
                case TipoCategoria.Duraveis:
                    return new Categoria("Duraveis", tipo);
                case TipoCategoria.Vestuario:
                    return new Categoria("Vestuario", tipo);
                case TipoCategoria.Farmacia:
                    return new Categoria("Farmacia", tipo);
                default:
                    return new Categoria("Outro", TipoCategoria.Outro);
            }
        }
    }

    public class Categoria : Entidade {
        private string Nome;
        private TipoCategoria Tipo;

        private static readonly string InsertProdutoCategoriaSqlQuery = @"INSERT INTO [Categoria_Produto]"
            + " ([Categoria_Id], [Produto_Id]) VALUES ({0}, {1});";

        public static void InserirProdutoCategoria(Categoria categoria, int produto_id) {
            string comando;
            try {

                comando = string.Format(InsertProdutoCategoriaSqlQuery,
                    categoria.GetTipo(),
                    produto_id);

                BancoDeDados.NovoComandoSql(comando);

            } catch (Exception e) {
                throw e;
            }
        } 

        public Categoria(string nome, TipoCategoria tipo) {
            this.Nome = nome;
            this.Tipo = tipo;
        }

        public int GetTipo() {
            return (int)Tipo;
        }
    }
}
