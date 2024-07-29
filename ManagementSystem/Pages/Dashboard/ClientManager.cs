using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ManagementSystem.Pages.Dashboard
{
    public static class ClientManager
    {
        private static string connectionString = Configuration.ConnectionString;

        /// <summary>
        /// Loads the clients into the list view.
        /// <param name="listView">ListView to use.</param>
        /// </summary>
        public static void LoadClients(ListView listView)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id, Name, Email, Phone, Nif, Address FROM Clients";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    listView.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["Name"].ToString());
                        item.SubItems.Add(reader["Email"].ToString());
                        item.SubItems.Add(reader["Phone"].ToString());
                        item.SubItems.Add(reader["Nif"].ToString());
                        item.SubItems.Add(reader["Address"].ToString());

                        listView.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Remove a client from database
        /// <param name="clientId">ListView to use.</param>
        /// </summary>
        public static void RemoveClient(int clientId)
        {
            DatabaseHelper.RemoveClient(clientId);
        }
    }
}
