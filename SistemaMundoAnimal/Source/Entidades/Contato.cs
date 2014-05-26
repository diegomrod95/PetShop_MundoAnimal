using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Entidades {

    public enum TipoContato { 
        Telefone = 1, Celular, Email, Fax, Twitter, Facebook, Outro
    };

    public class Contato : Entidade {
        private TipoContato Tipo;
        private string Valor;
    }
}
