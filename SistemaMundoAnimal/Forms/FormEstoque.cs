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

using SistemaMundoAnimal.Source.Pesquisa;

namespace SistemaMundoAnimal.Forms {
    public partial class FormEstoque : UserControl {
        public FormEstoque() {
            InitializeComponent();
            PesquisaEstoque.Todos(SetEstoque);
        }

        private void SetEstoque(SqlDataReader reader) {
            DataGridEstoque.Rows.Add(
                reader["Id"],
                reader["Codigo"],
                reader["Categoria"],
                reader["Nome"],
                reader["Preco Venda"],
                reader["Medida"],
                reader["Quantidade"],
                reader["Quantidade Minima"],
                reader["Subtotal"]);
        }
    }
}
