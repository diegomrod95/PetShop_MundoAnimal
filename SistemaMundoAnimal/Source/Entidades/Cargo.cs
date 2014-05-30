using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Entidades {

    /// <summary>
    /// Enumeração TipoCargo, que especifica os tipos de Cargos que podem
    /// haver na empresa.
    /// </summary>
    public enum TipoCargo : int {
        Vendedor = 1, 
        DiretorGeral, 
        DiretorMarketing,
        DiretorVendas,
        DiretorTI,
        AssistenciaTecnica,
        DBA,
        Contador,
        Motorista,
        Caixa,
        Balconista,
        Outro
    };

    /// <summary>
    /// Classe estatica que retorna instancias da Entidade Cargo, usada por entidades
    /// do tipo Funcionario.
    /// </summary>
    /// <example>
    /// <code>
    /// ...
    /// Cargo cargo = FabricaCargo.GetCargo(TipoCargo.Vendedor);
    /// ...
    /// </code>
    /// </example>
    public static class FabricaCargo {
        public static Cargo GetCargo(TipoCargo tipo) {
            if (tipo == TipoCargo.Vendedor) {
                return new Cargo("Vendedor", TipoCargo.Vendedor);
            } else if (tipo == TipoCargo.DiretorGeral) {
                return new Cargo("Diretor Geral", TipoCargo.DiretorGeral);
            } else if (tipo == TipoCargo.DiretorMarketing) {
                return new Cargo("Diretor Marketing", TipoCargo.DiretorMarketing);
            } else if (tipo == TipoCargo.DiretorVendas) {
                return new Cargo("Diretor Vendas", TipoCargo.DiretorVendas);
            } else if (tipo == TipoCargo.DiretorTI) {
                return new Cargo("Diretor de TI", TipoCargo.DiretorTI);
            } else if (tipo == TipoCargo.AssistenciaTecnica) {
                return new Cargo("Assistencia Tecnica", TipoCargo.AssistenciaTecnica);
            } else if (tipo == TipoCargo.DBA) {
                return new Cargo("DBA", TipoCargo.DBA);
            } else if (tipo == TipoCargo.Contador) {
                return new Cargo("Contador", TipoCargo.Contador);
            } else if (tipo == TipoCargo.Motorista) {
                return new Cargo("Motorista", TipoCargo.Motorista);
            } else if (tipo == TipoCargo.Caixa) {
                return new Cargo("Caixa", TipoCargo.Caixa);
            } else if (tipo == TipoCargo.Balconista) {
                return new Cargo("Balconista", TipoCargo.Balconista);
            } else {
                return new Cargo("Outro", TipoCargo.Outro);
            }
        }
    }

    /// <summary>
    /// Entidade do tipo Cargo usado por entidades do tipo Funcionario.
    /// </summary>
    public class Cargo : Entidade {
        private TipoCargo Tipo;
        private string Nome;

        private const int NomeCargoMaxLength = 200;

        public Cargo(string nome, TipoCargo tipo) {
            this.SetNome(nome);
            this.Tipo = tipo;
        }

        #region Getters e Setters
        public void SetNome(string nome) {
            if (nome.Length < NomeCargoMaxLength) {
                this.Nome = nome;
            } else {
                throw new ArgumentException(nome + " não é um nome válido para um cargo.");
            }
        }

        public string GetNome() {
            return this.Nome;
        }

        public int GetTipo() {
            return (int)this.Tipo;
        }
        #endregion
    }
}
