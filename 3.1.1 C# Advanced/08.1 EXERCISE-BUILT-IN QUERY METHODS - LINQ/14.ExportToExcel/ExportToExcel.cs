using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;

namespace _14.ExportToExcel
{
    public class ExportToExcel
    {
        public static void Main()
        {
            var xlsPackage = new ExcelPackage();
            var workSheet = xlsPackage.Workbook.Worksheets.Add("data");

            workSheet.Cells[1, 1].Value = "Softuni OOP Course Results";
            workSheet.Cells[1, 1, 1, 11].Merge = true;
            workSheet.Cells[1, 1].Style.Font.Size = 18;
            workSheet.Cells[1, 1].Style.Font.Bold = true;
            workSheet.Cells[1, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            using (ExcelRange cell = workSheet.Cells[2, 1, 2, 11])
            {
                cell.Style.Font.Color.SetColor(Color.White);
                cell.Style.Fill.PatternType = ExcelFillStyle.Solid;
                cell.Style.Fill.BackgroundColor.SetColor(Color.DarkOliveGreen);
                cell.Style.Border.Left.Style = cell.Style.Border.Right.Style = ExcelBorderStyle.Thin;
            }

            using (var reader = new StreamReader("../../StudentData.txt"))
            {
                var line = reader.ReadLine();
                var row = 2;

                while (line != null)
                {
                    var columns = line.Split('\t');

                    for (int i = 1; i <= columns.Length; i++)
                    {
                        workSheet.Cells[row, i].Value = columns[i - 1];
                    }

                    row++;

                    line = reader.ReadLine();
                }
            }

            var output = new FileStream("../../StudentData.xlsx", FileMode.Create);
            xlsPackage.SaveAs(output);
        }
    }
}
