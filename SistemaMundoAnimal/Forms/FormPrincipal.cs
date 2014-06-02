using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMundoAnimal.Forms {
    public partial class FormPrincipal : Form {

        public FormPrincipal() {
            InitializeComponent();
        }

        private void BtnCadastrarFuncionario_Click(object sender, EventArgs e) {
            PainelPrincipal.Controls.Clear();
            PainelPrincipal.Controls.Add(new FormCadastroFuncionario());
        }

        private void BtnPesquisaFuncionario_Click(object sender, EventArgs e) {
            PainelPrincipal.Controls.Clear();
            PainelPrincipal.Controls.Add(new FormPesquisarFuncionarios());
        }

        private void BtnVisualizarFuncionario_Click(object sender, EventArgs e) {
            PainelPrincipal.Controls.Clear();
            PainelPrincipal.Controls.Add(new FormVisualizarFuncionario());
        }

        private void BtnCadastrarProduto_Click(object sender, EventArgs e) {
            PainelPrincipal.Controls.Clear();
            PainelPrincipal.Controls.Add(new FormCadastroProduto());
        }

    }
}
