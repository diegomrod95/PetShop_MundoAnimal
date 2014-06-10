using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; 

namespace SistemaMundoAnimal.Source.IO.Exportar {
    public static class ExportarDataGrid {

        /// <summary>
        /// Exporta um DataGridView para uma planilha no excel.
        /// </summary>
        /// <param name="grid">Um DataGridView</param>
        public static void ParaExcel(DataGridView grid) {
            Excel.Application App; // Aplicação Excel
            Excel.Workbook WorkBook; // Pasta
            Excel.Worksheet WorkSheet; // Planilha
            object misValue = System.Reflection.Missing.Value;
            
            App = new Excel.Application();
            WorkBook = App.Workbooks.Add(misValue);
            WorkSheet = (WorkBook.Worksheets.get_Item(1) as Excel.Worksheet);

            for (int i = 0; i < grid.RowCount; i += 1) {
                for (int j = 0; j < grid.ColumnCount; j += 1) {
                    DataGridViewCell cell = grid[j, i];
                    WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            using (var salvar = new SaveFileDialog()) {
                salvar.Title = "Exportar para Excel";
                salvar.Filter = "Arquivo do Excel *.xls | *.xls";
                if (salvar.ShowDialog() == DialogResult.OK) {
                    WorkBook.SaveAs(salvar.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                        Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                }
            }

            WorkBook.Close(true, misValue, misValue);
            App.Quit();
        }

        /// <summary>
        /// Exporta um DataGridView para o formato CSV, comma separated values, que pode ser aberto em editores 
        /// de planilhas, como o excel ou open office.
        /// </summary>
        /// <param name="grid">Um DataGridView com informações de uma pesquisa.</param>
        public static void ParaCsv(DataGridView grid) {
            var salvar = new SaveFileDialog();

            salvar.DefaultExt = "csv";
            salvar.Filter = "Comma Separated Values (*.csv)|*.csv";
            salvar.FileName = "Resultado";

            if (salvar.ShowDialog() == DialogResult.OK) {
                using (var sw = new StreamWriter(salvar.FileName)) {

                    for (int i = 0, len = grid.Columns.Count; i < len; i += 1) {
                        sw.Write(grid.Columns[i].HeaderText);
                        sw.Write((i < len - 1) ? ";" : "");
                    }

                    sw.WriteLine();

                    for (int i = 0, rows = grid.RowCount; i < rows; i += 1) {
                        for (int j = 0, cols = grid.Columns.Count; j < cols; j += 1) {
                            sw.Write(grid[j, i].Value.ToString());
                            sw.Write((j < cols - 1) ? ";" : "");
                        }
                        sw.WriteLine();
                    }

                    sw.Close();
                }
            }
        }

    }
}
