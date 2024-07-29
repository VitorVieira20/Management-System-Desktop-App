using ClosedXML.Excel;
using System.Collections.Generic;
using System.Windows.Forms;

public static class ExcelExporter
{
    public static void ExportSalesToExcel(List<SaleItem> saleItems, string clientName, string saleDate, string totalAmount)
    {
        using (var workbook = new XLWorkbook())
        {
            var worksheet = workbook.Worksheets.Add("Sales");

            // Add headers
            worksheet.Cell(1, 1).Value = "Client Name";
            worksheet.Cell(1, 2).Value = clientName;

            worksheet.Cell(2, 1).Value = "Sale Date";
            worksheet.Cell(2, 2).Value = saleDate;

            worksheet.Cell(3, 1).Value = "Total Amount";
            worksheet.Cell(3, 2).Value = totalAmount;

            // Add table headers
            worksheet.Cell(5, 1).Value = "Book Id";
            worksheet.Cell(5, 2).Value = "Title";
            worksheet.Cell(5, 3).Value = "Quantity";
            worksheet.Cell(5, 4).Value = "Unit Price";
            worksheet.Cell(5, 5).Value = "Total Price";

            // Add table data
            int row = 6;
            foreach (var item in saleItems)
            {
                worksheet.Cell(row, 1).Value = item.BookId;
                worksheet.Cell(row, 2).Value = item.Title;
                worksheet.Cell(row, 3).Value = item.Quantity;
                worksheet.Cell(row, 4).Value = item.UnitPrice;
                worksheet.Cell(row, 5).Value = item.TotalPrice;
                row++;
            }

            // Save the workbook
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save an Excel File";
            saveFileDialog.FileName = "SalesReport.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("Sales report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

public class SaleItem
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
}
