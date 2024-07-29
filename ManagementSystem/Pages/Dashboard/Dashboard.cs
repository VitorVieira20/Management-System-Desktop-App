using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ManagementSystem.Pages.Dashboard
{
    /// <summary>
    /// Main form for the Dashboard.
    /// </summary>
    public partial class Dashboard : Form
    {
        private int userId;
        string connectionString = Configuration.ConnectionString;

        /// /// <summary>
        /// Initializes a new instance of the <see cref="Dashboard"/> class.
        /// </summary>
        /// <param name="userId">ID of the logged-in user.</param>
        public Dashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        /// <summary>
        /// Event triggered when the form is loaded.
        /// </summary>
        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + DatabaseHelper.GetUsernameById(userId);
            UpdateDashboardData();
            timer1.Start();
        }

        /// <summary>
        /// Updates the dashboard data.
        /// </summary>
        private void UpdateDashboardData()
        {
            lblSoldBooks.Text = DatabaseHelper.GetSoldBooksCount();
            lblRevenue.Text = DatabaseHelper.GetTotalRevenue();
            lblCustomers.Text = DatabaseHelper.GetClientsCount();
        }

        /// <summary>
        /// Event triggered by the timer to update the current time.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
        }

        /// <summary>
        /// Handles the selected index change event of the stock filter combo box.
        /// </summary>
        private void cmbStockFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            StockManager.SortStock(lvStock, cmbStockFilter.SelectedIndex);
            StockManager.CheckLowStock(lvStock);
        }

        /// <summary>
        /// Handles the selected index change event of the sales filter combo box.
        /// </summary>
        private void cmbSalesFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            SalesManager.SortSales(lvSales, cmbSalesFilter.SelectedIndex);
        }

        /// <summary>
        /// Loads clients view and shows the related controls.
        /// </summary>
        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientManager.LoadClients(lvClients);
            UIHelper.ShowComponents(lvClients, btnAddClient, btnEditClient, btnRemoveClient, lblSearch, txtSearch, btnSearch);
            UIHelper.HideComponents(lblSoldBooks, lblRevenue, lblCustomers, lvStock, btnAddStock, lblStockSearch, txtStockSearch, btnStockSearch, lblStockFilter, cmbStockFilter, btnAddSales, lvSales, lblSalesFilter, cmbSalesFilter);
        }

        /// <summary>
        /// Loads stock view and shows the related controls.
        /// </summary>
        private void btnStock_Click(object sender, EventArgs e)
        {
            StockManager.LoadStock(lvStock);
            UIHelper.ShowComponents(lvStock, btnAddStock, lblStockSearch, txtStockSearch, btnStockSearch, lblStockFilter ,cmbStockFilter);
            UIHelper.HideComponents(lblSoldBooks, lblRevenue, lblCustomers, lvClients, btnAddClient, btnEditClient, btnRemoveClient, lblSearch, txtSearch, btnSearch, btnAddSales, lvSales, lblSalesFilter, cmbSalesFilter);
            DatabaseHelper.CheckLowStock(lvStock);
            cmbStockFilter.SelectedIndexChanged += cmbStockFilter_SelectedIndexChanged;
        }

        /// <summary>
        /// Loads sales view and shows the related controls.
        /// </summary>
        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesManager.LoadSales(lvSales);
            UIHelper.ShowComponents(btnAddSales, lvSales, lblSalesFilter, cmbSalesFilter);
            UIHelper.HideComponents(lblSoldBooks, lblRevenue, lblCustomers, lvClients, btnAddClient, btnEditClient, btnRemoveClient, lblSearch, txtSearch, btnSearch, lvStock, btnAddStock, lblStockSearch, txtStockSearch, btnStockSearch, lblStockFilter, cmbStockFilter);
            cmbSalesFilter.SelectedIndexChanged += cmbSalesFilter_SelectedIndexChanged;
        }

        /// <summary>
        /// Hides all controls when the Home button is clicked.
        /// </summary>
        private void btnHome_Click(object sender, EventArgs e)
        {
            UpdateDashboardData();
            UIHelper.ShowComponents(lblSoldBooks, lblRevenue, lblCustomers);
            UIHelper.HideComponents(lvClients, btnAddClient, btnEditClient, btnRemoveClient, lblSearch, txtSearch, btnSearch, lvStock, btnAddStock, lblStockSearch, txtStockSearch, btnStockSearch, lblStockFilter, cmbStockFilter, btnAddSales, lvSales, lblSalesFilter, cmbSalesFilter);
        }

        /// <summary>
        /// Opens the Add Client form.
        /// </summary>
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            if (addClientForm.ShowDialog() == DialogResult.OK)
            {
                ClientManager.LoadClients(lvClients);
            }
        }

        /// <summary>
        /// Opens the Edit Client form for the selected client.
        /// </summary>
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (lvClients.SelectedItems.Count > 0)
            {
                int clientId = Convert.ToInt32(lvClients.SelectedItems[0].SubItems[0].Text);
                EditClientForm editClientForm = new EditClientForm(clientId);
                if (editClientForm.ShowDialog() == DialogResult.OK)
                {
                    ClientManager.LoadClients(lvClients);
                }
            }
            else
            {
                MessageBox.Show("Please select a client to edit.");
            }
        }

        /// <summary>
        /// Removes the selected client.
        /// </summary>
        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            if (lvClients.SelectedItems.Count > 0)
            {
                int clientId = Convert.ToInt32(lvClients.SelectedItems[0].SubItems[0].Text);
                var result = MessageBox.Show("Are you sure you want to delete this client?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ClientManager.RemoveClient(clientId);
                    ClientManager.LoadClients(lvClients);
                }
            }
            else
            {
                MessageBox.Show("Please select a client to delete.");
            }
        }

        /// <summary>
        /// Searches for clients based on the search text.
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            bool itemFound = false;

            foreach (ListViewItem item in lvClients.Items)
            {
                if (item.SubItems.Cast<ListViewItem.ListViewSubItem>().Any(subItem => subItem.Text.ToLower().Contains(searchText)))
                {
                    item.BackColor = Color.Yellow;
                    if (!itemFound)
                    {
                        item.EnsureVisible();
                        itemFound = true;
                    }
                }
                else
                {
                    item.BackColor = Color.White;
                }
            }
        }

        /// <summary>
        /// Searches for stock items based on the search text.
        /// </summary>
        private void btnStockSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtStockSearch.Text.Trim().ToLower();
            bool itemFound = false;
            DatabaseHelper.CheckLowStock(lvStock);

            foreach (ListViewItem item in lvStock.Items)
            {   
                if (item.SubItems.Cast<ListViewItem.ListViewSubItem>().Any(subItem => subItem.Text.ToLower().Contains(searchText)))
                {
                    item.BackColor = Color.Yellow;
                    if (!itemFound)
                    {
                        item.EnsureVisible();
                        itemFound = true;
                    }
                }
            }
        }

        /// <summary>
        /// Opens the Add Stock form for the selected book.
        /// </summary>
        private void btnAddStock_Click(object sender, EventArgs e) 
        {
            if (lvStock.SelectedItems.Count > 0)
            {
                int bookId = Convert.ToInt32(lvStock.SelectedItems[0].SubItems[0].Text);
                AddStockForm addStockForm = new AddStockForm(this.userId, bookId);
                if (addStockForm.ShowDialog() == DialogResult.OK)
                {
                    StockManager.LoadStock(lvStock);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to add stock.");
            }
        }

        /// <summary>
        /// Opens the Add Sales form.
        /// </summary>
        private void btnAddSales_Click(object sender, EventArgs e)
        {
            AddSalesForm addSalesForm = new AddSalesForm();
            if (addSalesForm.ShowDialog() == DialogResult.OK)
            {
                SalesManager.LoadSales(lvSales);
            }
        }

        /// <summary>
        /// Logs out the user and shows the login form.
        /// </summary>
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
