using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SistemaMundoAnimal.Source.Entidades;

namespace SistemaMundoAnimal.Forms {
    public partial class FormCadastroProduto : UserControl {

        private Produto produto;

        public FormCadastroProduto() {
            InitializeComponent();
            produto = new Produto();
        }
    }
}
