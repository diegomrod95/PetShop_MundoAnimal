using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Entidades {

    /// <summary>
    /// Enumeração que define o tipo de parentesto entre duas entidades do tipo Pessoa.
    /// </summary>
    public enum TipoParentesco { 
        Pai = 'P',
        Mae = 'M',
        Filho = 'F',
        Irmao = 'I',
        Conjuge = 'C'
    };
    
    /// <summary>
    /// Classe Parente do tipo Pessoa. Cadatrada junto à entidades de tipo Pessoa, realacionada com
    /// outras por meio da tabela de parentesco.
    /// </summary>
    public class Parente : Pessoa {
        private TipoParentesco Parentesco;

        private static string InsertParenteSqlQuery = @"INSERT INTO [Pessoa_Parente]"
            + " ([Pessoa_Id], [Parente_Id], [Parentesco])"
            + " VALUES ({0}, {1}, '{2}');";

        public static void InserirNoBancoDeDados(Parente parente, int pessoa_id) {
            string comando;
            try {

                comando = string.Format(InsertParenteSqlQuery,
                    pessoa_id,
                    parente.GetId(),
                    parente.GetParentesco());

                BancoDeDados.NovoComandoSql(comando);

            } catch (Exception e) {
                throw e;
            }
        }

        public char GetParentesco() {
            return (char) Parentesco;
        }

        public void SetParentesco(TipoParentesco parentesco) {
            this.Parentesco = parentesco;
        }
    }
}
