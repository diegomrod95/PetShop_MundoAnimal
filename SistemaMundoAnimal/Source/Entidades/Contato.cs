using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados.Tipos;
using SistemaMundoAnimal.Source.Dados;

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
                return new Contato(new TipoCelular(valor), tipo);
            } else if (tipo == TipoContato.Telefone) {
                return new Contato(new TipoTelefone(valor), tipo);
            } else if (tipo == TipoContato.Email) {
                return new Contato(new TipoEmail(valor), tipo);
            } else if (tipo == TipoContato.Fax) {
                return new Contato(new TipoTelefone(valor), TipoContato.Fax);
            } else if (tipo == TipoContato.Twitter || tipo == TipoContato.Facebook || tipo == TipoContato.Orkut) {
                return new Contato(new TipoRedeSocial(valor, tipo), tipo);
            } else {
                return new Contato(new TipoOutroContato(valor), tipo);
            }
        }
    }

    /// <summary>
    /// Classe que representa uma entidade contato de um tipo qualquer. Classe usada por entidades do tipo
    /// Pessoa.
    /// </summary>
    public class Contato : Entidade {
        private Tipo<string> Valor;
        private TipoContato Tipo;

        private static string InsertContatoSqlQuery = @"INSERT INTO [Pessoa_Contato]"
            + " ([Pessoa_Id], [Tipo_Id], [Contato])"
            + " VALUES ({0}, {1}, '{2}')";

        public static void InserirNoBancoDeDados(Contato contato, int pessoa_id) {
            string comando;
            try {

                comando = string.Format(InsertContatoSqlQuery,
                    pessoa_id,
                    contato.GetTipo(),
                    contato.GetValor());

                BancoDeDados.NovoComandoSql(comando);

            } catch (Exception e) {
                throw e;
            }
        }

        public Contato(Tipo<string> valor, TipoContato tipo) {
            this.Valor = valor;
            this.Tipo = tipo;
        }

        public Contato() { 
        }

        public string GetValor() {
            return this.Valor.ToString();    
        }

        public int GetTipo() {
            return (int)this.Tipo;
        }
    }
}
