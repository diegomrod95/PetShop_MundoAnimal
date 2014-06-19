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
    public partial class FormPesquisarVenda : UserControl {
        public FormPesquisarVenda() {
            InitializeComponent();
            PesquisaPedido.Todos(SetVenda);
        }

        private void SetVenda(SqlDataReader reader) {
            GridResultado.Rows.Add(
                reader["Pedido_Id"],
                reader["Tipo"],
                reader["Vendedor_Id"],
                reader["Nome"],
                reader["Valor_Total"],
                reader["Desconto"],
                reader["Status"],
                reader["Data_Entrega"],
                reader["Data_Cadastro"]);
        }
    }
}
