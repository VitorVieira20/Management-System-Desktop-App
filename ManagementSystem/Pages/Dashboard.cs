using MySql.Data.MySqlClient;
using System;
using System.Data;
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
            //dgvClients.Visible = false;
            //btnAddClient.Visible = false;
            //btnEditClient.Visible = false;
            //tnRemoveClient.Visible = true;
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
            dgvClients.Visible = true;
            btnAddClient.Visible = true;
            btnEditClient.Visible = true;
            btnRemoveClient.Visible = true;
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
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvClients.DataSource = dt;
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
            if (dgvClients.SelectedRows.Count > 0)
            {
                int clientId = Convert.ToInt32(dgvClients.SelectedRows[0].Cells[0].Value);
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
            if (dgvClients.SelectedRows.Count > 0)
            {
                int clientId = Convert.ToInt32(dgvClients.SelectedRows[0].Cells[0].Value);
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
            dgvClients.Visible = false;
            btnAddClient.Visible = false;
            btnEditClient.Visible = false;
            btnRemoveClient.Visible = false;
        }
        
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
