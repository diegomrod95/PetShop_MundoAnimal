using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string GetParentesco() {
            if (Parentesco == TipoParentesco.Pai) { 
                return "Pai";
            } else if (Parentesco == TipoParentesco.Mae) {
                return "Mãe";
            } else if (Parentesco == TipoParentesco.Filho) {
                return "Filho";
            } else if (Parentesco == TipoParentesco.Irmao) {
                return "Irmão";
            } else if (Parentesco == TipoParentesco.Conjuge) {
                return "Conjuge";
            } else {
                return "Outro";
            }
        }
    }
}
