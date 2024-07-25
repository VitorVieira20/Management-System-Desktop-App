namespace ManagementSystem.Pages
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSaleBooks;
        private System.Windows.Forms.Button btnPurchaseItems;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnViewSales;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblSoldBooks;
        private System.Windows.Forms.Label lblPurchasedBooks;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.PictureBox picLogo;

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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnViewSales = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnPurchaseItems = new System.Windows.Forms.Button();
            this.btnSaleBooks = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblPurchasedBooks = new System.Windows.Forms.Label();
            this.lblSoldBooks = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelLeft.Controls.Add(this.picLogo);
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.btnSettings);
            this.panelLeft.Controls.Add(this.btnViewSales);
            this.panelLeft.Controls.Add(this.btnUsers);
            this.panelLeft.Controls.Add(this.btnExpenses);
            this.panelLeft.Controls.Add(this.btnPurchaseItems);
            this.panelLeft.Controls.Add(this.btnSaleBooks);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(227, 554);
            this.panelLeft.TabIndex = 0;
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
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
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
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 295);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(267, 37);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnViewSales
            // 
            this.btnViewSales.FlatAppearance.BorderSize = 0;
            this.btnViewSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSales.ForeColor = System.Drawing.Color.White;
            this.btnViewSales.Location = new System.Drawing.Point(0, 246);
            this.btnViewSales.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(267, 37);
            this.btnViewSales.TabIndex = 5;
            this.btnViewSales.Text = "View Sales";
            this.btnViewSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewSales.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(0, 197);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(267, 37);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnExpenses
            // 
            this.btnExpenses.FlatAppearance.BorderSize = 0;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExpenses.ForeColor = System.Drawing.Color.White;
            this.btnExpenses.Location = new System.Drawing.Point(0, 148);
            this.btnExpenses.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(267, 37);
            this.btnExpenses.TabIndex = 3;
            this.btnExpenses.Text = "Expenses";
            this.btnExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenses.UseVisualStyleBackColor = true;
            // 
            // btnPurchaseItems
            // 
            this.btnPurchaseItems.FlatAppearance.BorderSize = 0;
            this.btnPurchaseItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseItems.ForeColor = System.Drawing.Color.White;
            this.btnPurchaseItems.Location = new System.Drawing.Point(0, 98);
            this.btnPurchaseItems.Margin = new System.Windows.Forms.Padding(4);
            this.btnPurchaseItems.Name = "btnPurchaseItems";
            this.btnPurchaseItems.Size = new System.Drawing.Size(267, 37);
            this.btnPurchaseItems.TabIndex = 2;
            this.btnPurchaseItems.Text = "Purchase Items";
            this.btnPurchaseItems.UseVisualStyleBackColor = true;
            // 
            // btnSaleBooks
            // 
            this.btnSaleBooks.FlatAppearance.BorderSize = 0;
            this.btnSaleBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleBooks.ForeColor = System.Drawing.Color.White;
            this.btnSaleBooks.Location = new System.Drawing.Point(0, 49);
            this.btnSaleBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaleBooks.Name = "btnSaleBooks";
            this.btnSaleBooks.Size = new System.Drawing.Size(267, 37);
            this.btnSaleBooks.TabIndex = 1;
            this.btnSaleBooks.Text = "Sale Books";
            this.btnSaleBooks.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(267, 37);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
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
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(640, 0);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(200, 62);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "14:08:50";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(400, 31);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, SalaAr HuSyN";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lblCustomers);
            this.panelMain.Controls.Add(this.lblPurchasedBooks);
            this.panelMain.Controls.Add(this.lblSoldBooks);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(227, 62);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(840, 492);
            this.panelMain.TabIndex = 2;
            // 
            // lblCustomers
            // 
            this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.Location = new System.Drawing.Point(533, 62);
            this.lblCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(240, 62);
            this.lblCustomers.TabIndex = 2;
            this.lblCustomers.Text = "512";
            this.lblCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPurchasedBooks
            // 
            this.lblPurchasedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasedBooks.Location = new System.Drawing.Point(280, 62);
            this.lblPurchasedBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchasedBooks.Name = "lblPurchasedBooks";
            this.lblPurchasedBooks.Size = new System.Drawing.Size(240, 62);
            this.lblPurchasedBooks.TabIndex = 1;
            this.lblPurchasedBooks.Text = "1234";
            this.lblPurchasedBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoldBooks
            // 
            this.lblSoldBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldBooks.Location = new System.Drawing.Point(27, 62);
            this.lblSoldBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoldBooks.Name = "lblSoldBooks";
            this.lblSoldBooks.Size = new System.Drawing.Size(240, 62);
            this.lblSoldBooks.TabIndex = 0;
            this.lblSoldBooks.Text = "1000";
            this.lblSoldBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ResumeLayout(false);

        }
    }
}
