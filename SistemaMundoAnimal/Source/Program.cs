using SistemaMundoAnimal.Forms;
using SistemaMundoAnimal.Testes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMundoAnimal {
    static class Program {

        /// <summary>
        /// Ponto de partida da aplicação.
        /// </summary>
        [STAThread]
        public static void Main(string[] args) {
            Teste.RodarTodosTestes();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }
}
