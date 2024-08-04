namespace ManagementSystem.Pages.Dashboard
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox picLogo;

        // Home
        private System.Windows.Forms.Label lblSoldBooks;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblCustomersDescription;
        private System.Windows.Forms.Label lblRevenueDescription;
        private System.Windows.Forms.Label lblSoldBooksDescription;
        private System.Windows.Forms.Label lblBookOfTheMonth;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblQuantitySold;


        // Clients
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvClients;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chPhone;
        private System.Windows.Forms.ColumnHeader chNif;
        private System.Windows.Forms.ColumnHeader chAddress;

        // Stock
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Label lblStockSearch;
        private System.Windows.Forms.TextBox txtStockSearch;
        private System.Windows.Forms.Button btnStockSearch;
        private System.Windows.Forms.ListView lvStock;
        private System.Windows.Forms.ColumnHeader chBookId;
        private System.Windows.Forms.ColumnHeader chBookTitle;
        private System.Windows.Forms.ColumnHeader chBookStock;
        private System.Windows.Forms.ColumnHeader chBookAuthor;
        private System.Windows.Forms.ColumnHeader chBookPublishDate;
        private System.Windows.Forms.ComboBox cmbStockFilter;
        private System.Windows.Forms.Label lblStockFilter;

        // Sales
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnAddSales;
        private System.Windows.Forms.ListView lvSales;
        private System.Windows.Forms.ColumnHeader chSalesId;
        private System.Windows.Forms.ColumnHeader chClientName;
        private System.Windows.Forms.ColumnHeader chSalesDate;
        private System.Windows.Forms.ColumnHeader chBookAmount;
        private System.Windows.Forms.ColumnHeader chTotalPrice;
        private System.Windows.Forms.ComboBox cmbSalesFilter;
        private System.Windows.Forms.Label lblSalesFilter;
        private System.Windows.Forms.Button btnSeeSaleInfo;

        // Reports
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnMonthlySalesReport;
        private System.Windows.Forms.Button btnSalesByCategoryReport;
        private System.Windows.Forms.Button btnCustomerReport;
        private System.Windows.Forms.Button btnBestSellingProductsReport;
        private System.Windows.Forms.Button btnRevenueReport;

        private System.Windows.Forms.ListView lvReport;
        private System.Windows.Forms.ColumnHeader chReportHeader1;
        private System.Windows.Forms.ColumnHeader chReportHeader2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Home
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblSoldBooks = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblCustomersDescription = new System.Windows.Forms.Label();
            this.lblRevenueDescription = new System.Windows.Forms.Label();
            this.lblSoldBooksDescription = new System.Windows.Forms.Label();
            this.lblBookOfTheMonth = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblQuantitySold = new System.Windows.Forms.Label();

            // Clients
            this.btnClients = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.lvClients = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();

            // Stock
            this.btnStock = new System.Windows.Forms.Button();
            this.lvStock = new System.Windows.Forms.ListView();
            this.chBookId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookPublishDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddStock = new System.Windows.Forms.Button();
            this.lblStockSearch = new System.Windows.Forms.Label();
            this.txtStockSearch = new System.Windows.Forms.TextBox();
            this.btnStockSearch = new System.Windows.Forms.Button();
            this.cmbStockFilter = new System.Windows.Forms.ComboBox();
            this.lblStockFilter = new System.Windows.Forms.Label();

            // Sales
            this.btnSales = new System.Windows.Forms.Button();
            this.btnAddSales = new System.Windows.Forms.Button();
            this.lvSales = new System.Windows.Forms.ListView();
            this.chSalesId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSalesDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbSalesFilter = new System.Windows.Forms.ComboBox();
            this.lblSalesFilter = new System.Windows.Forms.Label();
            this.btnSeeSaleInfo = new System.Windows.Forms.Button();

            // Reports
            this.btnReports = new System.Windows.Forms.Button();
            this.btnMonthlySalesReport = new System.Windows.Forms.Button();
            this.btnSalesByCategoryReport = new System.Windows.Forms.Button();
            this.btnCustomerReport = new System.Windows.Forms.Button();
            this.btnBestSellingProductsReport = new System.Windows.Forms.Button();
            this.btnRevenueReport = new System.Windows.Forms.Button();
            this.lvReport = new System.Windows.Forms.ListView();
            this.chReportHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chReportHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));

            // Others
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomers
            // 
            this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.Location = new System.Drawing.Point(533, 62);
            this.lblCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(240, 62);
            this.lblCustomers.TabIndex = 2;
            this.lblCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoldBooks
            // 
            this.lblSoldBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldBooks.Location = new System.Drawing.Point(27, 62);
            this.lblSoldBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoldBooks.Name = "lblSoldBooks";
            this.lblSoldBooks.Size = new System.Drawing.Size(240, 62);
            this.lblSoldBooks.TabIndex = 0;
            this.lblSoldBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRevenue
            // 
            this.lblRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.Location = new System.Drawing.Point(280, 62);
            this.lblRevenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(240, 62);
            this.lblRevenue.TabIndex = 1;
            this.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomersDescription
            // 
            this.lblCustomersDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomersDescription.Location = new System.Drawing.Point(533, 124);
            this.lblCustomersDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomersDescription.Name = "lblCustomersDescription";
            this.lblCustomersDescription.Size = new System.Drawing.Size(240, 30);
            this.lblCustomersDescription.TabIndex = 5;
            this.lblCustomersDescription.Text = "Registered Customers";
            this.lblCustomersDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRevenueDescription
            // 
            this.lblRevenueDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueDescription.Location = new System.Drawing.Point(280, 124);
            this.lblRevenueDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRevenueDescription.Name = "lblRevenueDescription";
            this.lblRevenueDescription.Size = new System.Drawing.Size(240, 30);
            this.lblRevenueDescription.TabIndex = 4;
            this.lblRevenueDescription.Text = "Revenue This Month";
            this.lblRevenueDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoldBooksDescription
            // 
            this.lblSoldBooksDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldBooksDescription.Location = new System.Drawing.Point(27, 124);
            this.lblSoldBooksDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoldBooksDescription.Name = "lblSoldBooksDescription";
            this.lblSoldBooksDescription.Size = new System.Drawing.Size(240, 30);
            this.lblSoldBooksDescription.TabIndex = 3;
            this.lblSoldBooksDescription.Text = "Books Sold This Month";
            this.lblSoldBooksDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookOfTheMonth
            // 
            this.lblBookOfTheMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookOfTheMonth.Location = new System.Drawing.Point(150, 250);
            this.lblBookOfTheMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookOfTheMonth.Name = "lblBookOfTheMonth";
            this.lblBookOfTheMonth.Size = new System.Drawing.Size(500, 30);
            this.lblBookOfTheMonth.TabIndex = 6;
            this.lblBookOfTheMonth.Text = "Book of the Month:";
            this.lblBookOfTheMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.Location = new System.Drawing.Point(150, 290);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(500, 30);
            this.lblBookTitle.TabIndex = 7;
            this.lblBookTitle.Text = "Title: ";
            this.lblBookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantitySold
            // 
            this.lblQuantitySold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantitySold.Location = new System.Drawing.Point(150, 330);
            this.lblQuantitySold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantitySold.Name = "lblQuantitySold";
            this.lblQuantitySold.Size = new System.Drawing.Size(500, 30);
            this.lblQuantitySold.TabIndex = 8;
            this.lblQuantitySold.Text = "Quantity Sold: ";
            this.lblQuantitySold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClients
            // 
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClients.ForeColor = System.Drawing.Color.White;
            this.btnClients.Location = new System.Drawing.Point(0, 248);
            this.btnClients.Margin = new System.Windows.Forms.Padding(4);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(227, 37);
            this.btnClients.TabIndex = 4;
            this.btnClients.Text = "Clients";
            this.btnClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(47, 439);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(100, 30);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Visible = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnEditClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditClient.FlatAppearance.BorderSize = 0;
            this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClient.ForeColor = System.Drawing.Color.White;
            this.btnEditClient.Location = new System.Drawing.Point(160, 439);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(100, 30);
            this.btnEditClient.TabIndex = 2;
            this.btnEditClient.Text = "Edit";
            this.btnEditClient.UseVisualStyleBackColor = false;
            this.btnEditClient.Visible = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnRemoveClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveClient.FlatAppearance.BorderSize = 0;
            this.btnRemoveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveClient.ForeColor = System.Drawing.Color.White;
            this.btnRemoveClient.Location = new System.Drawing.Point(273, 439);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveClient.TabIndex = 3;
            this.btnRemoveClient.Text = "Remove";
            this.btnRemoveClient.UseVisualStyleBackColor = false;
            this.btnRemoveClient.Visible = false;
            this.btnRemoveClient.Click += new System.EventHandler(this.btnRemoveClient_Click);
            // 
            // lvClients
            // 
            this.lvClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chName,
            this.chEmail,
            this.chPhone,
            this.chNif,
            this.chAddress});
            this.lvClients.FullRowSelect = true;
            this.lvClients.GridLines = true;
            this.lvClients.HideSelection = false;
            this.lvClients.Location = new System.Drawing.Point(47, 47);
            this.lvClients.Name = "lvClients";
            this.lvClients.Size = new System.Drawing.Size(742, 319);
            this.lvClients.TabIndex = 0;
            this.lvClients.UseCompatibleStateImageBehavior = false;
            this.lvClients.View = System.Windows.Forms.View.Details;
            this.lvClients.Visible = false;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 50;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 150;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.Width = 150;
            // 
            // chPhone
            // 
            this.chPhone.Text = "Phone";
            this.chPhone.Width = 100;
            // 
            // chNif
            // 
            this.chNif.Text = "NIF";
            this.chNif.Width = 100;
            // 
            // chAddress
            // 
            this.chAddress.Text = "Address";
            this.chAddress.Width = 150;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(395, 424);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 16);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Client Info";
            this.lblSearch.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(398, 443);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(207, 22);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(620, 439);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnStock
            // 
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Location = new System.Drawing.Point(0, 297);
            this.btnStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(267, 37);
            this.btnStock.TabIndex = 5;
            this.btnStock.Text = "Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // lvStock
            // 
            this.lvStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBookId,
            this.chBookTitle,
            this.chBookAuthor,
            this.chBookPublishDate,
            this.chBookStock});
            this.lvStock.FullRowSelect = true;
            this.lvStock.GridLines = true;
            this.lvStock.HideSelection = false;
            this.lvStock.Location = new System.Drawing.Point(47, 47);
            this.lvStock.Name = "lvStock";
            this.lvStock.Size = new System.Drawing.Size(742, 319);
            this.lvStock.TabIndex = 0;
            this.lvStock.UseCompatibleStateImageBehavior = false;
            this.lvStock.View = System.Windows.Forms.View.Details;
            this.lvStock.Visible = false;
            // 
            // chBookId
            // 
            this.chBookId.Text = "BOOK_ID";
            this.chBookId.Width = 75;
            // 
            // chBookTitle
            // 
            this.chBookTitle.Text = "Book Title";
            this.chBookTitle.Width = 150;
            // 
            // chBookAuthor
            // 
            this.chBookAuthor.Text = "Author";
            this.chBookAuthor.Width = 100;
            // 
            // chBookPublishDate
            // 
            this.chBookPublishDate.Text = "Publish Date";
            this.chBookPublishDate.Width = 75;
            // 
            // chBookStock
            // 
            this.chBookStock.Text = "Stock";
            this.chBookStock.Width = 50;
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnAddStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStock.FlatAppearance.BorderSize = 0;
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.Location = new System.Drawing.Point(47, 439);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(100, 30);
            this.btnAddStock.TabIndex = 1;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Visible = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // lblStockSearch
            // 
            this.lblStockSearch.AutoSize = true;
            this.lblStockSearch.Location = new System.Drawing.Point(395, 424);
            this.lblStockSearch.Name = "lblStockSearch";
            this.lblStockSearch.Size = new System.Drawing.Size(68, 16);
            this.lblStockSearch.TabIndex = 6;
            this.lblStockSearch.Text = "Book Title";
            this.lblStockSearch.Visible = false;
            // 
            // txtStockSearch
            // 
            this.txtStockSearch.Location = new System.Drawing.Point(398, 443);
            this.txtStockSearch.Name = "txtStockSearch";
            this.txtStockSearch.Size = new System.Drawing.Size(207, 22);
            this.txtStockSearch.TabIndex = 5;
            this.txtStockSearch.Visible = false;
            // 
            // btnStockSearch
            // 
            this.btnStockSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnStockSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockSearch.FlatAppearance.BorderSize = 0;
            this.btnStockSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockSearch.ForeColor = System.Drawing.Color.White;
            this.btnStockSearch.Location = new System.Drawing.Point(620, 439);
            this.btnStockSearch.Name = "btnStockSearch";
            this.btnStockSearch.Size = new System.Drawing.Size(100, 30);
            this.btnStockSearch.TabIndex = 4;
            this.btnStockSearch.Text = "Search";
            this.btnStockSearch.UseVisualStyleBackColor = false;
            this.btnStockSearch.Visible = false;
            this.btnStockSearch.Click += new System.EventHandler(this.btnStockSearch_Click);
            // 
            // cmbStockFilter
            // 
            this.cmbStockFilter.FormattingEnabled = true;
            this.cmbStockFilter.Items.AddRange(new object[] {
            "Stock Ascending",
            "Stock Descending",
            "Title Ascending",
            "Title Descending",
            "Date Ascending",
            "Date Descending"});
            this.cmbStockFilter.Location = new System.Drawing.Point(250, 442);
            this.cmbStockFilter.Name = "cmbStockFilter";
            this.cmbStockFilter.Size = new System.Drawing.Size(121, 24);
            this.cmbStockFilter.TabIndex = 10;
            this.cmbStockFilter.Visible = false;
            // 
            // lblStockFilter
            // 
            this.lblStockFilter.AutoSize = true;
            this.lblStockFilter.Location = new System.Drawing.Point(250, 424);
            this.lblStockFilter.Name = "lblStockFilter";
            this.lblStockFilter.Size = new System.Drawing.Size(36, 16);
            this.lblStockFilter.TabIndex = 6;
            this.lblStockFilter.Text = "Filter";
            this.lblStockFilter.Visible = false;
            // 
            // btnSales
            // 
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Location = new System.Drawing.Point(0, 199);
            this.btnSales.Margin = new System.Windows.Forms.Padding(4);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(267, 37);
            this.btnSales.TabIndex = 3;
            this.btnSales.Text = "Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnAddSales
            // 
            this.btnAddSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnAddSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSales.FlatAppearance.BorderSize = 0;
            this.btnAddSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSales.ForeColor = System.Drawing.Color.White;
            this.btnAddSales.Location = new System.Drawing.Point(47, 439);
            this.btnAddSales.Name = "btnAddSales";
            this.btnAddSales.Size = new System.Drawing.Size(100, 30);
            this.btnAddSales.TabIndex = 1;
            this.btnAddSales.Text = "Add Sale";
            this.btnAddSales.UseVisualStyleBackColor = false;
            this.btnAddSales.Visible = false;
            this.btnAddSales.Click += new System.EventHandler(this.btnAddSales_Click);
            // 
            // lvSales
            // 
            this.lvSales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSalesId,
            this.chClientName,
            this.chSalesDate,
            this.chBookAmount,
            this.chTotalPrice});
            this.lvSales.FullRowSelect = true;
            this.lvSales.GridLines = true;
            this.lvSales.HideSelection = false;
            this.lvSales.Location = new System.Drawing.Point(47, 47);
            this.lvSales.Name = "lvSales";
            this.lvSales.Size = new System.Drawing.Size(742, 319);
            this.lvSales.TabIndex = 0;
            this.lvSales.UseCompatibleStateImageBehavior = false;
            this.lvSales.View = System.Windows.Forms.View.Details;
            this.lvSales.Visible = false;
            // 
            // chSalesId
            // 
            this.chSalesId.Text = "ID";
            this.chSalesId.Width = 50;
            // 
            // chClientName
            // 
            this.chClientName.Text = "Client Name";
            this.chClientName.Width = 100;
            // 
            // chSalesDate
            // 
            this.chSalesDate.Text = "Sale Date";
            this.chSalesDate.Width = 75;
            // 
            // chBookAmount
            // 
            this.chBookAmount.Text = "Books Amount";
            this.chBookAmount.Width = 100;
            // 
            // chTotalPrice
            // 
            this.chTotalPrice.Text = "Total Price";
            this.chTotalPrice.Width = 75;
            // 
            // cmbSalesFilter
            // 
            this.cmbSalesFilter.FormattingEnabled = true;
            this.cmbSalesFilter.Items.AddRange(new object[] {
            "Book Amount Ascending",
            "Book Amount Descending",
            "Price Ascending",
            "Price Descending",
            "Date Ascending",
            "Date Descending"});
            this.cmbSalesFilter.Location = new System.Drawing.Point(175, 442);
            this.cmbSalesFilter.Name = "cmbSalesFilter";
            this.cmbSalesFilter.Size = new System.Drawing.Size(121, 24);
            this.cmbSalesFilter.TabIndex = 10;
            this.cmbSalesFilter.Visible = false;
            // 
            // lblSalesFilter
            // 
            this.lblSalesFilter.AutoSize = true;
            this.lblSalesFilter.Location = new System.Drawing.Point(175, 424);
            this.lblSalesFilter.Name = "lblSalesFilter";
            this.lblSalesFilter.Size = new System.Drawing.Size(36, 16);
            this.lblSalesFilter.TabIndex = 6;
            this.lblSalesFilter.Text = "Filter";
            this.lblSalesFilter.Visible = false;
            // 
            // btnSeeSaleInfo
            // 
            this.btnSeeSaleInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnSeeSaleInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeeSaleInfo.FlatAppearance.BorderSize = 0;
            this.btnSeeSaleInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeSaleInfo.ForeColor = System.Drawing.Color.White;
            this.btnSeeSaleInfo.Location = new System.Drawing.Point(320, 439);
            this.btnSeeSaleInfo.Name = "btnSeeSaleInfo";
            this.btnSeeSaleInfo.Size = new System.Drawing.Size(100, 30);
            this.btnSeeSaleInfo.TabIndex = 3;
            this.btnSeeSaleInfo.Text = "See Info";
            this.btnSeeSaleInfo.UseVisualStyleBackColor = false;
            this.btnSeeSaleInfo.Visible = false;
            this.btnSeeSaleInfo.Click += new System.EventHandler(this.btnSeeSaleInfo_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Controls.Add(this.picLogo);
            this.panelLeft.Controls.Add(this.btnReports);
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.btnStock);
            this.panelLeft.Controls.Add(this.btnClients);
            this.panelLeft.Controls.Add(this.btnSales);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(227, 554);
            this.panelLeft.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 149);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(267, 37);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Image = global::ManagementSystem.Properties.Resources.open_book;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(227, 123);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(0, 342);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(267, 37);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 517);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(227, 37);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelTop.Controls.Add(this.lblTime);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(227, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(840, 62);
            this.panelTop.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(640, 0);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(200, 62);
            this.lblTime.TabIndex = 2;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(-5, 14);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(400, 31);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, SalaAr HuSyN";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMonthlySalesReport
            // 
            this.btnMonthlySalesReport.Location = new System.Drawing.Point(20, 20);
            this.btnMonthlySalesReport.Name = "btnMonthlySalesReport";
            this.btnMonthlySalesReport.Size = new System.Drawing.Size(250, 40);
            this.btnMonthlySalesReport.TabIndex = 0;
            this.btnMonthlySalesReport.Text = "Monthly Sales Report";
            this.btnMonthlySalesReport.UseVisualStyleBackColor = true;
            this.btnMonthlySalesReport.Click += new System.EventHandler(this.btnMonthlySalesReport_Click);
            this.btnMonthlySalesReport.Visible = false;
            this.btnMonthlySalesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnMonthlySalesReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonthlySalesReport.FlatAppearance.BorderSize = 0;
            this.btnMonthlySalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthlySalesReport.ForeColor = System.Drawing.Color.White;
            // 
            // btnSalesByCategoryReport
            // 
            this.btnSalesByCategoryReport.Location = new System.Drawing.Point(300, 20);
            this.btnSalesByCategoryReport.Name = "btnSalesByCategoryReport";
            this.btnSalesByCategoryReport.Size = new System.Drawing.Size(250, 40);
            this.btnSalesByCategoryReport.TabIndex = 1;
            this.btnSalesByCategoryReport.Text = "Monthly Genre Report";
            this.btnSalesByCategoryReport.UseVisualStyleBackColor = true;
            this.btnSalesByCategoryReport.Click += new System.EventHandler(this.btnSalesByCategoryReport_Click);
            this.btnSalesByCategoryReport.Visible = false;
            this.btnSalesByCategoryReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnSalesByCategoryReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesByCategoryReport.FlatAppearance.BorderSize = 0;
            this.btnSalesByCategoryReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesByCategoryReport.ForeColor = System.Drawing.Color.White;
            // 
            // btnCustomerReport
            // 
            this.btnCustomerReport.Location = new System.Drawing.Point(580, 20);
            this.btnCustomerReport.Name = "btnCustomerReport";
            this.btnCustomerReport.Size = new System.Drawing.Size(250, 40);
            this.btnCustomerReport.TabIndex = 2;
            this.btnCustomerReport.Text = "Monthly Clients Report";
            this.btnCustomerReport.UseVisualStyleBackColor = true;
            this.btnCustomerReport.Click += new System.EventHandler(this.btnCustomerReport_Click);
            this.btnCustomerReport.Visible = false;
            this.btnCustomerReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnCustomerReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerReport.FlatAppearance.BorderSize = 0;
            this.btnCustomerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerReport.ForeColor = System.Drawing.Color.White;
            // 
            // btnBestSellingProductsReport
            // 
            this.btnBestSellingProductsReport.Location = new System.Drawing.Point(20, 80);
            this.btnBestSellingProductsReport.Name = "btnBestSellingProductsReport";
            this.btnBestSellingProductsReport.Size = new System.Drawing.Size(250, 40);
            this.btnBestSellingProductsReport.TabIndex = 3;
            this.btnBestSellingProductsReport.Text = "Most Sold Book Report";
            this.btnBestSellingProductsReport.UseVisualStyleBackColor = true;
            this.btnBestSellingProductsReport.Click += new System.EventHandler(this.btnBestSellingProductsReport_Click);
            this.btnBestSellingProductsReport.Visible = false;
            this.btnBestSellingProductsReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnBestSellingProductsReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBestSellingProductsReport.FlatAppearance.BorderSize = 0;
            this.btnBestSellingProductsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBestSellingProductsReport.ForeColor = System.Drawing.Color.White;
            // 
            // btnRevenueReport
            // 
            this.btnRevenueReport.Location = new System.Drawing.Point(300, 80);
            this.btnRevenueReport.Name = "btnRevenueReport";
            this.btnRevenueReport.Size = new System.Drawing.Size(250, 40);
            this.btnRevenueReport.TabIndex = 4;
            this.btnRevenueReport.Text = "Revenue Report";
            this.btnRevenueReport.UseVisualStyleBackColor = true;
            this.btnRevenueReport.Click += new System.EventHandler(this.btnRevenueReport_Click);
            this.btnRevenueReport.Visible = false;
            this.btnRevenueReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnRevenueReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevenueReport.FlatAppearance.BorderSize = 0;
            this.btnRevenueReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenueReport.ForeColor = System.Drawing.Color.White;
            // 
            // lvReport
            // 
            this.lvReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chReportHeader1,
            this.chReportHeader2});
            this.lvReport.FullRowSelect = true;
            this.lvReport.GridLines = true;
            this.lvReport.Location = new System.Drawing.Point(50, 150);
            this.lvReport.Name = "lvReport";
            this.lvReport.Size = new System.Drawing.Size(740, 320);
            this.lvReport.TabIndex = 6;
            this.lvReport.UseCompatibleStateImageBehavior = false;
            this.lvReport.View = System.Windows.Forms.View.Details;
            this.lvReport.Visible = false;
            // 
            // chReportHeader1
            // 
            this.chReportHeader1.Text = "";
            this.chReportHeader1.Width = 150;
            // 
            // chReportHeader2
            // 
            this.chReportHeader2.Text = "";
            this.chReportHeader2.Width = 350;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lvClients);
            this.panelMain.Controls.Add(this.lvStock);
            this.panelMain.Controls.Add(this.lvSales);
            this.panelMain.Controls.Add(this.lblSearch);
            this.panelMain.Controls.Add(this.txtSearch);
            this.panelMain.Controls.Add(this.btnSearch);
            this.panelMain.Controls.Add(this.btnAddStock);
            this.panelMain.Controls.Add(this.lblStockSearch);
            this.panelMain.Controls.Add(this.txtStockSearch);
            this.panelMain.Controls.Add(this.btnStockSearch);
            this.panelMain.Controls.Add(this.btnAddClient);
            this.panelMain.Controls.Add(this.btnEditClient);
            this.panelMain.Controls.Add(this.btnRemoveClient);
            this.panelMain.Controls.Add(this.lblCustomersDescription);
            this.panelMain.Controls.Add(this.lblRevenueDescription);
            this.panelMain.Controls.Add(this.lblSoldBooksDescription);
            this.panelMain.Controls.Add(this.lblCustomers);
            this.panelMain.Controls.Add(this.lblRevenue);
            this.panelMain.Controls.Add(this.lblSoldBooks);
            this.panelMain.Controls.Add(this.lblBookOfTheMonth);
            this.panelMain.Controls.Add(this.lblBookTitle);
            this.panelMain.Controls.Add(this.lblQuantitySold);
            this.panelMain.Controls.Add(this.lblStockFilter);
            this.panelMain.Controls.Add(this.cmbStockFilter);
            this.panelMain.Controls.Add(this.lblSalesFilter);
            this.panelMain.Controls.Add(this.cmbSalesFilter);
            this.panelMain.Controls.Add(this.btnAddSales);
            this.panelMain.Controls.Add(this.btnSeeSaleInfo);
            this.panelMain.Controls.Add(this.btnMonthlySalesReport);
            this.panelMain.Controls.Add(this.btnSalesByCategoryReport);
            this.panelMain.Controls.Add(this.btnCustomerReport);
            this.panelMain.Controls.Add(this.btnBestSellingProductsReport);
            this.panelMain.Controls.Add(this.btnRevenueReport);
            this.panelMain.Controls.Add(this.lvReport);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(227, 62);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(840, 492);
            this.panelMain.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
