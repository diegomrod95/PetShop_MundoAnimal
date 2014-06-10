using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMundoAnimal.Source.IO.Imprimir {
    public static class ImprimirDataGrid {

        public static Bitmap ToBitmap(DataGridView grid) {
            var bm = new Bitmap(grid.Width, grid.Height);
            grid.DrawToBitmap(bm, new Rectangle(0, 0, grid.Width, grid.Height));
            return bm;
        }
    }
}
