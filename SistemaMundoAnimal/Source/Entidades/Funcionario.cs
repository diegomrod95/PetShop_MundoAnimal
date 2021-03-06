﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados;
using SistemaMundoAnimal.Source.Dados.Tipos;

namespace SistemaMundoAnimal.Source.Entidades {
    /// <summary>
    /// Entidade do tipo Funcionario, que extende a entidade Pessoa.
    /// </summary>
    public class Funcionario : Pessoa {
        private Cargo _Cargo;
        private TipoDinheiro Salario;
        private TipoDinheiro ValeAlimentacao;
        private TipoDinheiro ValeTransporte;
        private TipoDinheiro AuxilioCreche;
        private TipoDinheiro AssitenciaMedica;
        private int DiaPagamento;
        private DateTime DataDemissao;

        /// <summary>
        /// Consulta Sql usada para inserir Funcionarios na tabela Funcionario.
        /// </summary>
        private static readonly string InsertFuncionarioSqlQuery = @"INSERT INTO [Funcionario]"
            + " ([Pessoa_Id], [Cargo_Id], [Salario], [Vale_Alimentacao], [Vale_Transporte], [Auxilio_Creche],"
            + " [Assitencia_Medica], [Dia_Pagamento])"
            + " VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7});";

        private static readonly string UpdateFuncionarioSqlQuery = @"UPDATE Funcionario SET"
            + " [Cargo_Id] = {1},"
            + " [Salario] = {2},"
            + " [Vale_Alimentacao] = {3},"
            + " [Vale_Transporte] = {4},"
            + " [Auxilio_Creche] = {5},"
            + " [Assitencia_Medica] = {6},"
            + " [Dia_Pagamento] = {7}"
            + " WHERE [Pessoa_Id] = {0}";
 

        /// <summary>
        /// Metodo que insere Entidades do tipo Pessoa no banco de dados.
        /// </summary>
        /// <example>
        /// <code>
        /// Funcionario func = new Funcionario();
        /// func.SetNome("Teste");
        /// ...
        /// Pessoa.InserirNoBancoDeDados(func);
        /// Funcionario.InserirNoBancoDeDados(func);
        /// </code>
        /// </example>
        /// <param name="funcionario">Uma entidade com todas propriedades prenchidas</param>
        public static void InserirNoBancoDeDados(Funcionario funcionario) {
            string comando;

            try {

                comando = string.Format(InsertFuncionarioSqlQuery, 
                    funcionario.GetId(),
                    funcionario.GetCargo().GetTipo(),
                    funcionario.GetSalario(),
                    funcionario.GetValeAlimentacao(),
                    funcionario.GetValeTransporte(),
                    funcionario.GetAuxilioCreche(),
                    funcionario.GetAssitenciaMedica(),
                    funcionario.GetDiaPagamento());

                BancoDeDados.NovoComandoSql(comando);
            
            } catch (Exception e) {
                throw e;
            }
        }

        /// <summary>
        /// Atualiza os dados do funcionário passado como argumento no banco de dados.
        /// </summary>
        /// <param name="funcionario">Uma entidade do tipo Funcionario</param>
        public static void UpdateNoBancoDeDados(Funcionario funcionario) {
            string comando;

            try {

                comando = string.Format(UpdateFuncionarioSqlQuery,
                    funcionario.GetId(),
                    funcionario.GetCargo().GetTipo(),
                    funcionario.GetSalario(),
                    funcionario.GetValeAlimentacao(),
                    funcionario.GetValeTransporte(),
                    funcionario.GetAuxilioCreche(),
                    funcionario.GetAssitenciaMedica(),
                    funcionario.GetDiaPagamento());

                BancoDeDados.NovoComandoSql(comando);

            } catch (Exception e) {
                throw e;
            }
        } 

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
