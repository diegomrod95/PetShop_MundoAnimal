using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; 

namespace SistemaMundoAnimal.Source.Exportar {
    public static class ExportarDataGrid {

        /// <summary>
        /// Exporta um DataGridView para uma planilha no excel.
        /// </summary>
        /// <param name="grid">Um DataGridView</param>
        public static void ParaExcel(DataGridView grid) {
            SaveFileDialog salvar = new SaveFileDialog();
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

            salvar.Title = "Exportar para Excel";
            salvar.Filter = "Arquivo do Excel *.xls | *.xls";
            salvar.ShowDialog();
            WorkBook.SaveAs(salvar.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            WorkBook.Close(true, misValue, misValue);
            App.Quit();

            MessageBox.Show("Exportado com sucesso em " + salvar.FileName);
        }

    }
}
