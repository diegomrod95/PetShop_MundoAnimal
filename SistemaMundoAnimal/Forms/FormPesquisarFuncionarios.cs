using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

using SistemaMundoAnimal.Source.Pesquisa.Entidade;

namespace SistemaMundoAnimal.Forms {
    public partial class FormPesquisarFuncionarios : UserControl {

        private void PrencherTodosFuncionarios() {
            PesquisaFuncionario.Todos((SqlDataReader reader) => {
                AddResultadosDePesquisaAoGrid(reader);
            });
        }

        private void AddResultadosDePesquisaAoGrid(SqlDataReader reader) {
            GridResultado.Rows.Add(
                    reader["Código da Pessoa"],
                    reader["Nome"],
                    reader["Sobrenome"],
                    reader["Genero"],
                    reader["Cargo"],
                    reader["RG"],
                    reader["CPF"],
                    reader["Idade"],
                    reader["Salario"],
                    reader["Assitencia Medica"],
                    reader["Auxilio Creche"],
                    reader["Vale Alimentção"],
                    reader["Vale Transporte"],
                    reader["Dia de Pagamento"]);
        }
        
        public FormPesquisarFuncionarios() {
            InitializeComponent();
            PrencherTodosFuncionarios();
        }
    }
}
