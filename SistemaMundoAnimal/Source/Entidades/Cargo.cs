using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Entidades {

    public enum TipoCargo {
        Vendedor = 1, 
        DiretorGeral, 
        DiretorMarketing,
        DiretorVendas,
        Caixa,
        Balconista,
        Outro
    };

    public class FabricaCargo {
        public static Cargo GetCargo(TipoCargo tipo) {
            // TODO: Terminar Fabrica de cargos e deixar consistente com o banco
            if (tipo == TipoCargo.Vendedor) {
                return new Cargo("Vendedor", TipoCargo.Vendedor);
            } else {
                return new Cargo("Outro", TipoCargo.Outro);
            }
        }
    }

    public class Cargo : Entidade {
        private TipoCargo Tipo;
        private string Nome;

        private const int NomeCargoMaxLength = 200;

        public Cargo(string nome, TipoCargo tipo) {
            this.SetNome(nome);
            this.Tipo = tipo;
        }

        public void SetNome(string nome) {
            if (nome.Length < NomeCargoMaxLength) {
                this.Nome = nome;
            } else {
                throw new ArgumentException(nome + " não é um nome válido para um cargo.");
            }
        }

        public string GetNome() {
            return this.Nome;
        }

        public int GetTipo() {
            return (int)this.Tipo;
        }
    }
}
