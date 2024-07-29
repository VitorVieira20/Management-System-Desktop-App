using ManagementSystem.Pages.Dashboard;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagementSystem.Pages.SalesForms
{
    public partial class SaleInfoForm : Form
    {
        private int salesId;
        
        public SaleInfoForm(int salesId)
        {
            InitializeComponent();
            this.salesId = salesId;
        }

        private void SaleInfoForm_Load(object sender, EventArgs e)
        {
            string[] salesInfo = SalesManager.LoadSalesInfo(this.salesId);

            if (salesInfo != null && salesInfo.Length == 3)
            {
                lblClientNameValue.Text = salesInfo[0];
                lblSaleDateValue.Text = salesInfo[1];
                lblTotalAmountValue.Text = salesInfo[2];
            }

            SalesManager.LoadSalesById(lvSaleItems, this.salesId);
        }

        private void btnExportToExcel_Click(object sender, EventArgs e) 
        {
            var saleItems = new List<SaleItem>();
            foreach (ListViewItem item in lvSaleItems.Items)
            {
                saleItems.Add(new SaleItem
                {
                    BookId = int.Parse(item.SubItems[0].Text),
                    Title = item.SubItems[1].Text,
                    Quantity = int.Parse(item.SubItems[2].Text),
                    UnitPrice = decimal.Parse(item.SubItems[3].Text),
                    TotalPrice = decimal.Parse(item.SubItems[4].Text)
                });
            }

            ExcelExporter.ExportSalesToExcel(saleItems, lblClientNameValue.Text, lblSaleDateValue.Text, lblTotalAmountValue.Text);
        }
    }
}
