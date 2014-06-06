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
    public partial class FormPesquisarProduto : UserControl {
        public FormPesquisarProduto() {
            InitializeComponent();
            PesquisaProduto.Todos(AddResultadoDePesquisaAoGrid);
        }

        private void AddResultadoDePesquisaAoGrid(SqlDataReader reader) {
            GridResultado.Rows.Add(reader["Produto_Id"],
                reader["Codigo"],
                reader["Nome"],
                reader["Categoria"],
                reader["Tamanho"],
                reader["Preco_Venda"],
                reader["Peso"],
                reader["Tipo_Medida"],
                reader["Data_Cadastro"],
                reader["Ativo"]);
        }
    }
}
