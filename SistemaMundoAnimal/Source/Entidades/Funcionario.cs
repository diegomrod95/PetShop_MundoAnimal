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
        private int DiaPagamento;
        private DateTime DataDemissao;

        #region Getters e Setters
        public Cargo GetCargo() {
            return this._Cargo; 
        }

        public void SetCargo(TipoCargo tipo) {
            this._Cargo = FabricaCargo.GetCargo(tipo);
        }

        public TipoDinheiro GetSalario() {
            return this.Salario;
        }

        public void SetSalario(double salario) {
            if (salario > 0) {
                this.Salario = new TipoDinheiro(salario);
            } else {
                throw new ArgumentException(salario + " não é um valor válido para um salario.");
            }
        }

        public TipoDinheiro GetValeAlimentacao() {
            return this.ValeAlimentacao;
        }

        public void SetValeAlimentacao(double valor) {
            this.ValeAlimentacao = new TipoDinheiro(valor);
        }

        public TipoDinheiro GetValeTransporte() {
            return this.ValeTransporte;
        }

        public void SetValeTransporte(double valor) {
            this.ValeTransporte = new TipoDinheiro(valor);
        }

        public TipoDinheiro GetAuxilioCreche() {
            return this.AuxilioCreche;
        }

        public void SetAuxilioCreche(double valor) {
            this.AuxilioCreche = new TipoDinheiro(valor);
        }

        public TipoDinheiro GetAssitenciaMedica() {
            return this.AssitenciaMedica;
        }

        public void SetAssitenciaMedica(double valor) {
            this.AssitenciaMedica = new TipoDinheiro(valor);
        }

        public int GetDiaPagamento() {
            return this.DiaPagamento;
        }

        public void SetDiaPagamento(int dia) {
            if (dia <= 31 && dia >= 1) {
                this.DiaPagamento = dia;
            } else {
                throw new ArgumentException(dia + " não é um dia válido.");
            }
        }

        public void SetDataDemissao(int dia, int mes, int ano) {
            if (dia < 31 && mes < 12 && ano > 1800) {
                this.DataDemissao = new DateTime(ano, mes, dia);
            } else {
                throw new ArgumentException(dia + "/" + mes + "/" + ano + " não é uma data válida!");
            }
        }

        public DateTime GetDataDemissao() {
            return this.DataDemissao;
        }
        #endregion
    }
}
