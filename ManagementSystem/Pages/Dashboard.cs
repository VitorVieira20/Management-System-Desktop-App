using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            // Inicialize os componentes do dashboard e carregue os dados específicos do utilizador, se necessário.
            lblWelcome.Text = "Welcome, " + GetUsernameById(userId);
            UpdateDashboardData();
        }

        private void UpdateDashboardData()
        {
            lblSoldBooks.Text = "1000"; /* GetBooksSold */
            lblPurchasedBooks.Text = "1234"; /* GetPurchasedBooks */
            lblCustomers.Text = "512"; /* GetCustomers (count) */

            // Atualize os gráficos, se necessário.
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

        private void searchBookBtn_Click(object sender, EventArgs e)
        {
            // Código para abrir o formulário de busca de livros.
        }

        private void purchaseBookBtn_Click(object sender, EventArgs e)
        {
            // Código para abrir o formulário de compra de livros.
        }

        private void viewStockBtn_Click(object sender, EventArgs e)
        {
            // Código para abrir o formulário de visualização de estoque.
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // Código para fazer logout e retornar ao formulário de login.
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
