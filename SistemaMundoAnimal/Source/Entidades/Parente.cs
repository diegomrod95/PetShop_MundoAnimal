using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Entidades {

    public enum TipoParentesco { 
        Pai = 'P',
        Mae = 'M',
        Filho = 'F',
        Irmao = 'I',
        Conjuge = 'C'
    };
    
    public class Parente : Pessoa {
        private TipoParentesco Parentesco;

        public string GetParentesco() {
            return "";
        }
    }
}
