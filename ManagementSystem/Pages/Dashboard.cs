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
        string connectionString = "Server=localhost;Database=systemmanagement;User ID=root;Password=@//Vitor925139873//@@BASQUETEBOL#@;";

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
            lblCustomers.Text = "512"; /* GetCustomers (count) */
        }

        
        // Get time function
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
        }

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

        private void btnClients_Click(object sender, EventArgs e)
        {
            LoadClients();
            lvClients.Visible = true;
            btnAddClient.Visible = true;
            btnEditClient.Visible = true;
            btnRemoveClient.Visible = true;
            lblSearch.Visible = true;
            txtSearch.Visible = true;
            btnSearch.Visible = true;

            // Other Components
            lvStock.Visible = false;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            LoadStock();
            lvStock.Visible = true;

            // Other Components
            lvClients.Visible = false;
            btnAddClient.Visible = false;
            btnEditClient.Visible = false;
            btnRemoveClient.Visible = false;
            lblSearch.Visible = false;
            txtSearch.Visible = false;
            btnSearch.Visible = false;
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
                    string query = "SELECT b.Id, b.Title, s.Quantity FROM Books b INNER JOIN Stock s ON b.Id = s.Book_id ORDER BY s.Quantity ASC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    lvStock.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["Title"].ToString());
                        item.SubItems.Add(reader["Quantity"].ToString());

                        lvStock.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
            // Client Page
            lvClients.Visible = false;
            btnAddClient.Visible = false;
            btnEditClient.Visible = false;
            btnRemoveClient.Visible = false;
            lblSearch.Visible = false;
            txtSearch.Visible = false;
            btnSearch.Visible = false;

            // Stock Page
            lvStock.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            foreach (ListViewItem item in lvClients.Items)
            {
                item.BackColor = item.SubItems.Cast<ListViewItem.ListViewSubItem>().Any(subItem => subItem.Text.ToLower().Contains(searchText)) ? Color.LightYellow : Color.White;
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
