using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados.Tipos;

namespace SistemaMundoAnimal.Source.Entidades {
    public class Funcionario : Pessoa {
        private Cargo _Cargo;
        private TipoDinheiro Salario;
        private TipoDinheiro ValeAlimentacao;
        private TipoDinheiro ValeTransporte;
        private TipoDinheiro AuxilioCreche;
        private TipoDinheiro AssitenciaMedica;
        private DateTime DiaPagamento;
        private DateTime DataDemissao;

        #region Getters e Setters

        #endregion

    }
}
