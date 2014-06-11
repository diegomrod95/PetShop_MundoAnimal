using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; 

namespace SistemaMundoAnimal.Source.IO.Exportar {
    public static class ExportarDataGrid {

        private static readonly string HTMLHeader = @"<!doctype HTML><html><head><meta charset='iso-8859-1'><title>{0}</title></head>";
        private static readonly string HTMLBody = @"<body>{0}</body>";
        private static readonly string HTMLTable = @"<table style='text-align:left; border: 1px solid #DFDFDF; width: 100%; border-radius: 3px;font-family: Arial;'>{0}</table>";
        private static readonly string HTMLTableRow = @"<tr>{0}</tr>";
        private static readonly string HTMLTableHeader = @"<th style='border-bottom: 1px solid #DFDFDF;border-top-color: white;'>{0}</th>";
        private static readonly string HTMLTableCell = @"<td style='border-bottom: 1px solid #DFDFDF;vertical-align: top;border-top-color: white;'>{0}</td>";
        private static readonly string HTMLEnd = @"</html>";

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
                using (var sw = new StreamWriter(File.Open(salvar.FileName, FileMode.Create), 
                                                                                 Encoding.GetEncoding("iso-8859-1"))) {

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

        /// <summary>
        /// Exporta o datagrid no formato html.
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="titulo"></param>
        public static void ParaHTML(DataGridView grid, string titulo) {
            var salvar = new SaveFileDialog();

            salvar.DefaultExt = "html";
            salvar.Filter = "HTML - Página da Web |*.html";
            salvar.FileName = "Resultado";

            if (salvar.ShowDialog() == DialogResult.OK) {
                using (var sw = new StreamWriter(File.Open(salvar.FileName, FileMode.Create), Encoding.GetEncoding("iso-8859-1"))) {
                    string header = "", table = "", row = "";

                    sw.Write(string.Format(HTMLHeader, titulo));

                    for (int i = 0, len = grid.Columns.Count; i < len; i += 1) {
                        header += string.Format(HTMLTableHeader, grid.Columns[i].HeaderText);
                    }

                    header = string.Format(HTMLTableRow, header);

                    for (int i = 0, rows = grid.RowCount; i < rows; i += 1) {
                        row = "";
                        for (int j = 0, cols = grid.Columns.Count; j < cols; j += 1) {
                            row += string.Format(HTMLTableCell, grid[j, i].Value.ToString());
                        }
                        table += string.Format(HTMLTableRow, row);
                    }

                    table = string.Format(HTMLTable, header + table);

                    sw.Write(string.Format(HTMLBody, table));
                    sw.Write(HTMLEnd);
                }

                Process.Start(salvar.FileName);
            }
        }

    }
}
