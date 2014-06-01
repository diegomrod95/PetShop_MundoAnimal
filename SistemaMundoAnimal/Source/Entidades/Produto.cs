using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados.Tipos;

namespace SistemaMundoAnimal.Source.Entidades {
    public class Produto : Entidade {
        private int Id;
        private string Nome;
        private TipoCodigo Codigo;
        private TipoTamanho Tamanho;
        private TipoPeso Peso;
        private TipoMedida Medida;
        private string Descricao;
        private string Especificacoes;


    }
}
