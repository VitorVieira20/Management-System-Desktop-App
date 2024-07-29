using ManagementSystem.Pages.Dashboard;
using System;
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
    }
}
