﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Testes.Entidades;

namespace SistemaMundoAnimal.Testes {
    public class Teste {

        private static PessoaTeste Pessoa = new PessoaTeste();

        public static void RodarTodosTestes() {
            Pessoa.RodarTestes();
            Console.WriteLine("Teste Entidade Pessoa: " + (Pessoa.TesteOK));
        }
    }
}
