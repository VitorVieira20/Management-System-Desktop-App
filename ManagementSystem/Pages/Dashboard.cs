using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ManagementSystem.Pages
{
    public partial class Dashboard : Form
    {
        private int userId;
        string connectionString = Configuration.ConnectionString;

        public Dashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + GetUsernameById(userId);
            UpdateDashboardData();
            timer1.Start();
        }

        private void UpdateDashboardData()
        {
            lblSoldBooks.Text = "1000"; /* GetBooksSold */
            lblPurchasedBooks.Text = "1234"; /* GetPurchasedBooks */
            lblCustomers.Text = GetClientsCount();
        }

        
        // Get time function
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
        }


        // Function to set components visibility
        private void SetVisibility(bool visible, params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Visible = visible;
            }
        }

        // Function to Hide Components
        private void HideComponents(params Control[] controls)
        {
            SetVisibility(false, controls);
        }

        // Function to Show Components
        private void ShowComponents(params Control[] controls)
        {
            SetVisibility(true, controls);
        }

        // Load clients function
        private void LoadClients()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id, Name, Email, Phone, Nif, Address FROM Clients";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    lvClients.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["Name"].ToString());
                        item.SubItems.Add(reader["Email"].ToString());
                        item.SubItems.Add(reader["Phone"].ToString());
                        item.SubItems.Add(reader["Nif"].ToString());
                        item.SubItems.Add(reader["Address"].ToString());

                        lvClients.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Load stock function
        private void LoadStock()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT b.Id, b.Title, b.Author, b.Publish_date, s.Quantity FROM Books b INNER JOIN Stock s ON b.Id = s.Book_id ORDER BY s.Quantity ASC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    lvStock.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["Title"].ToString());
                        item.SubItems.Add(reader["Author"].ToString());

                        if (DateTime.TryParse(reader["Publish_date"].ToString(), out DateTime publishDate))
                        {
                            string formattedDate = publishDate.ToString("dd/MM/yyyy");
                            item.SubItems.Add(formattedDate);
                        }
                        else
                        {
                            item.SubItems.Add("Data inválida");
                        }
                        item.SubItems.Add(reader["Quantity"].ToString());

                        lvStock.Items.Add(item);
                        CheckLowStock();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Function to get a Username by ID
        private string GetUsernameById(int userId)
        {
            string username = null;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                // Open a SQL connection and try to get a user by id
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Users WHERE Id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", userId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            username = reader["Username"].ToString();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return username;
        }

        // Function to get count of clients
        private string GetClientsCount() 
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Clients";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return "0";
            }
        }

        // Check if the book stock is low
        private void CheckLowStock()
        {

            foreach (ListViewItem item in lvStock.Items)
            {
                int stockQuantity;
                item.BackColor = int.TryParse(item.SubItems[4].Text, out stockQuantity) && stockQuantity < 10
                    ? Color.LightCoral : Color.White;

            }
        }

        // Order Stock by quantity
        private void SortStockByQuantity(bool ascending)
        {
            var items = lvStock.Items.Cast<ListViewItem>().OrderBy(item =>
            {
                int quantity;
                return int.TryParse(item.SubItems[4].Text, out quantity) ? quantity : 0;
            }).ToList();

            if (!ascending)
            {
                items = items.AsEnumerable().Reverse().ToList();
            }

            lvStock.Items.Clear();
            lvStock.Items.AddRange(items.ToArray());
        }

        // Order Stock by book title
        private void SortStockByTitle(bool ascending)
        {
            var items = lvStock.Items.Cast<ListViewItem>().OrderBy(item => item.SubItems[1].Text).ToList();

            if (!ascending)
            {
                items = items.AsEnumerable().Reverse().ToList();
            }

            lvStock.Items.Clear();
            lvStock.Items.AddRange(items.ToArray());
        }

        // Order Stock by book publish date
        private void SortStockByPublishDate(bool ascending)
        {
            var items = lvStock.Items.Cast<ListViewItem>().OrderBy(item => item.SubItems[3].Text).ToList();

            if (!ascending)
            {
                items = items.AsEnumerable().Reverse().ToList();
            }

            lvStock.Items.Clear();
            lvStock.Items.AddRange(items.ToArray());
        }

        // Switch case to choose the filter
        private void cmbStockFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbStockFilter.SelectedIndex)
            {
                case 0:
                    SortStockByQuantity(true);
                    break;
                case 1:
                    SortStockByQuantity(false);
                    break;
                case 2:
                    SortStockByTitle(true);
                    break;
                case 3:
                    SortStockByTitle(false);
                    break;
                case 4:
                    SortStockByPublishDate(true);
                    break;
                case 5:
                    SortStockByPublishDate(false);
                    break;
            }
            CheckLowStock();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            LoadClients();
            ShowComponents(lvClients, btnAddClient, btnEditClient, btnRemoveClient, lblSearch, txtSearch, btnSearch);
            HideComponents(lvStock, btnAddStock, lblStockSearch, txtStockSearch, btnStockSearch, lblStockFilter, cmbStockFilter);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            LoadStock();
            ShowComponents(lvStock, btnAddStock, lblStockSearch, txtStockSearch, btnStockSearch, lblStockFilter ,cmbStockFilter);
            HideComponents(lvClients, btnAddClient, btnEditClient, btnRemoveClient, lblSearch, txtSearch, btnSearch);
            CheckLowStock();
            cmbStockFilter.SelectedIndexChanged += cmbStockFilter_SelectedIndexChanged;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            if (addClientForm.ShowDialog() == DialogResult.OK)
            {
                LoadClients();
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (lvClients.SelectedItems.Count > 0)
            {
                int clientId = Convert.ToInt32(lvClients.SelectedItems[0].SubItems[0].Text);
                EditClientForm editClientForm = new EditClientForm(clientId);
                if (editClientForm.ShowDialog() == DialogResult.OK)
                {
                    LoadClients();
                }
            }
            else
            {
                MessageBox.Show("Please select a client to edit.");
            }
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            if (lvClients.SelectedItems.Count > 0)
            {
                int clientId = Convert.ToInt32(lvClients.SelectedItems[0].SubItems[0].Text);
                var result = MessageBox.Show("Are you sure you want to delete this client?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "DELETE FROM Clients WHERE Id=@id";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@id", clientId);
                            cmd.ExecuteNonQuery();
                            LoadClients();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a client to delete.");
            }
        }

        private void btnHome_Click(object sender, EventArgs e) 
        {
            HideComponents(lvClients, btnAddClient, btnEditClient, btnRemoveClient, lblSearch, txtSearch, btnSearch, lvStock, btnAddStock, lblStockSearch, txtStockSearch, btnStockSearch, lblStockFilter, cmbStockFilter);
        }

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

        private void btnStockSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtStockSearch.Text.Trim().ToLower();
            bool itemFound = false;
            CheckLowStock();

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

        private void btnAddStock_Click(object sender, EventArgs e) 
        {
            if (lvStock.SelectedItems.Count > 0)
            {
                int bookId = Convert.ToInt32(lvStock.SelectedItems[0].SubItems[0].Text);
                AddStockForm addStockForm = new AddStockForm(this.userId, bookId);
                if (addStockForm.ShowDialog() == DialogResult.OK)
                {
                    LoadStock();
                }
            }
            else
            {
                MessageBox.Show("Please select a book to add stock.");
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
