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
        public static string GetSoldBooksCountByActualMonth()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COALESCE(SUM(i.quantity), 0) FROM Sales_items i " +
                        "INNER JOIN Sales s ON i.sales_id = s.id " +
                        "WHERE MONTH(s.date) = MONTH(CURRENT_DATE) " +
                        "AND YEAR(s.date) = YEAR(CURRENT_DATE)";
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
        public static string GetTotalRevenueByActualMonth()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COALESCE(SUM(total_amount), 0) FROM Sales " +
                        "WHERE MONTH(date) = MONTH(CURRENT_DATE) " +
                        "AND YEAR(date) = YEAR(CURRENT_DATE)";
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

        /// <summary>
        /// Gets the book of the month (the most sold).
        /// </summary>
        /// <returns>Title of the book and the quantity sold.</returns>
        public static (string Title, int Quantity) GetBookOfTheMonth()
        {
            string title = "";
            int quantity = 0;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT b.title, SUM(si.quantity) as TotalSold " +
                                   "FROM Sales s " +
                                   "INNER JOIN Sales_items si ON s.id = si.sales_id " +
                                   "INNER JOIN Books b ON si.book_id = b.id " +
                                   "WHERE MONTH(s.date) = MONTH(CURRENT_DATE()) AND YEAR(s.date) = YEAR(CURRENT_DATE()) " +
                                   "GROUP BY b.id " +
                                   "ORDER BY TotalSold DESC " +
                                   "LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        title = reader["title"].ToString();
                        quantity = Convert.ToInt32(reader["TotalSold"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return (title, quantity);
        }

    }

}
