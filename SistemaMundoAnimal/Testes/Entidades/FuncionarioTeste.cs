using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Entidades;

namespace SistemaMundoAnimal.Testes.Entidades {
    public class FuncionarioTeste : Funcionario, ITestavel {

        public bool TesteOK = true;

        private void InserirFuncionarioNoBancoDeDados() {
            var funcionario = new Funcionario();

            try {

                funcionario.SetId(2);
                funcionario.SetCargo(TipoCargo.Caixa);
                funcionario.SetSalario(400);
                funcionario.SetValeAlimentacao(100);
                funcionario.SetValeTransporte(100);
                funcionario.SetAuxilioCreche(50);
                funcionario.SetAssitenciaMedica(0);
                funcionario.SetDiaPagamento(20);

                Funcionario.InserirNoBancoDeDados(funcionario);

            } catch (Exception e) {
                Console.WriteLine(e.Message);
                TesteOK = false;    
            }
        }
        
        public void RodarTestes() {
            InserirFuncionarioNoBancoDeDados();
        }
    }
}
