using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados.Tipos;

namespace SistemaMundoAnimal.Source.Entidades {

    public enum TipoContato { 
        Telefone = 1, Celular, Email, Fax, Twitter, Facebook, Orkut, Outro
    };

    public class FabricaContato {
        public static Contato GetContato(string valor, TipoContato tipo) {
            if (tipo == TipoContato.Celular) {
                return new Contato(new TipoCelular(valor));
            } else if (tipo == TipoContato.Telefone) {
                return new Contato(new TipoTelefone(valor));
            } else if (tipo == TipoContato.Email) {
                return new Contato(new TipoEmail(valor));
            } else if (tipo == TipoContato.Fax) {
                return new Contato(new TipoTelefone(valor));
            } else if (tipo == TipoContato.Twitter || tipo == TipoContato.Facebook || tipo == TipoContato.Orkut) {
                return new Contato(new TipoRedeSocial(valor, tipo));
            } else {
                return new Contato(new TipoOutroContato(valor));
            }
        }
    }

    public class Contato {
        private Tipo<string> Valor;

        public Contato(Tipo<string> valor) {
            this.Valor = valor;
        }

        public Tipo<string> GetValor() {
            return this.Valor;    
        }
    }
}
