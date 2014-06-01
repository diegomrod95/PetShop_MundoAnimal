using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                default:
                    return new Categoria("Outro", TipoCategoria.Outro);
            }
        }
    }

    public class Categoria : Entidade {
        private string Nome;
        private TipoCategoria Tipo;

        public Categoria(string nome, TipoCategoria tipo) {
            this.Nome = nome;
            this.Tipo = tipo;
        }
    }
}
