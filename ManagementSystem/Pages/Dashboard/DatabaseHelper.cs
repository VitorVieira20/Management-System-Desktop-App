using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ManagementSystem.Pages.Dashboard
{
    public static class DatabaseHelper
    {
        private static string connectionString = Configuration.ConnectionString;

        /// <summary>
        /// Gets the username by user ID.
        /// </summary>
        /// <param name="userId">ID of the user.</param>
        /// <returns>Username of the user.</returns>
        public static string GetUsernameById(int userId)
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

        /// <summary>
        /// Gets the count of clients.
        /// </summary>
        /// <returns>Count of clients as a string.</returns>
        public static string GetClientsCount()
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

        /// <summary>
        /// Remove a client from database
        /// <param name="clientId">ListView to use.</param>
        /// </summary>
        public static void RemoveClient(int clientId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM clients WHERE id = @clientId";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@clientId", clientId);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Gets the count of sold books.
        /// </summary>
        /// <returns>Count of sold books as a string.</returns>
        public static string GetSoldBooksCount()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT SUM(quantity) FROM Sales_items";
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

        /// <summary>
        /// Gets the total revenue from sales.
        /// </summary>
        /// <returns>Total revenue as a string formatted as currency.</returns>
        public static string GetTotalRevenue()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT SUM(Total_amount) FROM Sales";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    decimal totalRevenue = Convert.ToDecimal(cmd.ExecuteScalar());
                    return totalRevenue.ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return "$0.00";
            }
        }

        /// <summary>
        /// Checks if the book stock is low and updates the list view item color.
        /// /// <param name="listView">ListView to use.</param>
        /// </summary>
        public static void CheckLowStock(ListView listView)
        {

            foreach (ListViewItem item in listView.Items)
            {
                int stockQuantity;
                item.BackColor = int.TryParse(item.SubItems[4].Text, out stockQuantity) && stockQuantity < 10
                    ? Color.LightCoral : Color.White;

            }
        }
    }

}
