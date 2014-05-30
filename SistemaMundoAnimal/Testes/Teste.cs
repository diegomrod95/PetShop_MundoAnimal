using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Testes.Entidades;
using SistemaMundoAnimal.Testes.Dados.Tipos;

namespace SistemaMundoAnimal.Testes {
    public class Teste {

        private static PessoaTeste Pessoa = new PessoaTeste();
        private static EnderecoTeste Endereco = new EnderecoTeste();
        private static ContatoTeste Contato = new ContatoTeste();
        private static ParenteTeste Parente = new ParenteTeste();
        private static FuncionarioTeste Funcionario = new FuncionarioTeste();
        private static TipoCPFTeste TipoCPF = new TipoCPFTeste();

        public static void RodarTodosTestes() {
            Pessoa.RodarTestes();
            Console.WriteLine("Teste Entidade Pessoa: " + (Pessoa.TesteOK));
            Endereco.RodarTestes();
            Console.WriteLine("Teste Entidade Endereco: " + (Endereco.TesteOK));
            Contato.RodarTestes();
            Console.WriteLine("Teste Entidade Contato: " + (Contato.TesteOK));
            Parente.RodarTestes();
            Console.WriteLine("Teste Entidade Parente: " + (Parente.TesteOK));
            Funcionario.RodarTestes();
            Console.WriteLine("Teste Entidade Funcionario: " + (Funcionario.TesteOK));

            TipoCPF.RodarTestes();
            Console.WriteLine("Teste Tipo CPF: " + (TipoCPF.TesteOK));
        }
    }
}
