using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Entidades {

    public enum Parentesco { 
        Pai = 'P',
        Mae = 'M',
        Filho = 'F',
        Irmao = 'I',
        Conjuge = 'C'
    };
    
    public class Parente : Pessoa {
        private Parentesco Tipo;
    }
}
