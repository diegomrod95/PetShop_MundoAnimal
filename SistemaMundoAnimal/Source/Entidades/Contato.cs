using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados.Tipos;

namespace SistemaMundoAnimal.Source.Entidades {

    /// <summary>
    /// Enumeração que identifica os tipos de contatos registrados no banco, caso queira adicionar
    /// um novo tipo de contato, o enum TipoContato deve ser alterado de forma que o valor seja igual
    /// ao cadstrado no banco de dados.
    /// </summary>
    public enum TipoContato { 
        Telefone = 1, Celular, Email, Fax, Twitter, Facebook, Orkut, Outro
    };

    /// <summary>
    /// Classe que retorna o instâncias da classe Contato com o seu devido tipo e valor. Implementa o Padrão
    /// de Design, Fabrica.
    /// </summary>
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

    /// <summary>
    /// Classe que representa uma entidade contato de um tipo qualquer. Classe usada por entidades do tipo
    /// Pessoa.
    /// </summary>
    public class Contato : Entidade {
        private Tipo<string> Valor;

        public Contato(Tipo<string> valor) {
            this.Valor = valor;
        }

        public Tipo<string> GetValor() {
            return this.Valor;    
        }
    }
}
