using System.Text;

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
        private System.Windows.Forms.Button btnPurchases;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblSoldBooks;
        private System.Windows.Forms.Label lblPurchasedBooks;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnHome;
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRequests = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnPurchases = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblPurchasedBooks = new System.Windows.Forms.Label();
            this.lblSoldBooks = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
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
            this.panelLeft.Controls.Add(this.btnRequests);
            this.panelLeft.Controls.Add(this.btnStock);
            this.panelLeft.Controls.Add(this.btnClients);
            this.panelLeft.Controls.Add(this.btnPurchases);
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
            this.btnReports.Location = new System.Drawing.Point(0, 391);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(267, 37);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
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
            // btnRequests
            // 
            this.btnRequests.FlatAppearance.BorderSize = 0;
            this.btnRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRequests.ForeColor = System.Drawing.Color.White;
            this.btnRequests.Location = new System.Drawing.Point(0, 346);
            this.btnRequests.Margin = new System.Windows.Forms.Padding(4);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(267, 37);
            this.btnRequests.TabIndex = 6;
            this.btnRequests.Text = "Requests";
            this.btnRequests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequests.UseVisualStyleBackColor = true;
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
            // btnPurchases
            // 
            this.btnPurchases.FlatAppearance.BorderSize = 0;
            this.btnPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPurchases.ForeColor = System.Drawing.Color.White;
            this.btnPurchases.Location = new System.Drawing.Point(0, 199);
            this.btnPurchases.Margin = new System.Windows.Forms.Padding(4);
            this.btnPurchases.Name = "btnPurchases";
            this.btnPurchases.Size = new System.Drawing.Size(267, 37);
            this.btnPurchases.TabIndex = 3;
            this.btnPurchases.Text = "Purchases";
            this.btnPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchases.UseVisualStyleBackColor = true;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(47, 388);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 23);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Visible = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(127, 388);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(75, 23);
            this.btnEditClient.TabIndex = 2;
            this.btnEditClient.Text = "Edit";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Visible = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Location = new System.Drawing.Point(207, 388);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveClient.TabIndex = 3;
            this.btnRemoveClient.Text = "Remove";
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            this.btnRemoveClient.Visible = false;
            this.btnRemoveClient.Click += new System.EventHandler(this.btnRemoveClient_Click);
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
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dgvClients);
            this.panelMain.Controls.Add(this.btnAddClient);
            this.panelMain.Controls.Add(this.btnEditClient);
            this.panelMain.Controls.Add(this.btnRemoveClient);
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
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(47, 70);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.Size = new System.Drawing.Size(742, 300);
            this.dgvClients.TabIndex = 0;
            this.dgvClients.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
