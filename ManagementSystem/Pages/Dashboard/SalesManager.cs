using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace ManagementSystem.Pages.Dashboard
{
    public static class SalesManager
    {
        private static string connectionString = Configuration.ConnectionString;

        /// <summary>
        /// Loads the stock into the list view.
        /// </summary>
        /// <param name="listView">ListView to use.</param>
        public static void LoadSales(ListView listView)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT s.id, c.name, s.date, SUM(i.quantity) as books_amount, s.total_amount FROM Sales s " +
                        "INNER JOIN Clients c ON s.client_id = c.id " +
                        "INNER JOIN Sales_items i ON s.id = sales_id " +
                        "GROUP BY s.id " +
                        "ORDER BY s.date";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    listView.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["Name"].ToString());

                        if (DateTime.TryParse(reader["Date"].ToString(), out DateTime publishDate))
                        {
                            string formattedDate = publishDate.ToString("dd/MM/yyyy");
                            item.SubItems.Add(formattedDate);
                        }
                        else
                        {
                            item.SubItems.Add("Data inválida");
                        }
                        item.SubItems.Add(reader["Books_amount"].ToString());
                        item.SubItems.Add(reader["Total_amount"].ToString());

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
        /// Sorts the sales by book amount.
        /// </summary>
        /// <param name="ascending">If true, sort in ascending order; otherwise, sort in descending order.</param>
        /// <param name="listView">ListView to use.</param>
        private static void SortSalesByBookAmount(bool ascending, ListView listView)
        {
            var items = listView.Items.Cast<ListViewItem>().OrderBy(item =>
            {
                int quantity;
                return int.TryParse(item.SubItems[3].Text, out quantity) ? quantity : 0;
            }).ToList();

            if (!ascending)
            {
                items = items.AsEnumerable().Reverse().ToList();
            }

            listView.Items.Clear();
            listView.Items.AddRange(items.ToArray());
        }

        /// <summary>
        /// Sorts the sales by price.
        /// </summary>
        /// <param name="ascending">If true, sort in ascending order; otherwise, sort in descending order.</param>
        /// <param name="listView">ListView to use.</param>
        private static void SortSalesByPrice(bool ascending, ListView listView)
        {
            var items = listView.Items.Cast<ListViewItem>().OrderBy(item =>
            {
                decimal price;
                return decimal.TryParse(item.SubItems[4].Text, out price) ? price : 0;
            }).ToList();

            if (!ascending)
            {
                items = items.AsEnumerable().Reverse().ToList();
            }

            listView.Items.Clear();
            listView.Items.AddRange(items.ToArray());
        }

        /// <summary>
        /// Sorts the sales by date.
        /// </summary>
        /// <param name="ascending">If true, sort in ascending order; otherwise, sort in descending order.</param>
        /// <param name="listView">ListView to use.</param>
        private static void SortSalesByDate(bool ascending, ListView listView)
        {
            var items = listView.Items.Cast<ListViewItem>().OrderBy(item => item.SubItems[2].Text).ToList();

            if (!ascending)
            {
                items = items.AsEnumerable().Reverse().ToList();
            }

            listView.Items.Clear();
            listView.Items.AddRange(items.ToArray());
        }

        /// <summary>
        /// Handles the selected index change event of the sales filter combo box.
        /// </summary>
        /// <param name="listView">ListView to use.</param>
        /// <param name="selectedIndex">Selected index in the combo box.</param>
        public static void SortSales(ListView listView, int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    SortSalesByBookAmount(true, listView);
                    break;
                case 1:
                    SortSalesByBookAmount(false, listView);
                    break;
                case 2:
                    SortSalesByPrice(true, listView);
                    break;
                case 3:
                    SortSalesByPrice(false, listView);
                    break;
                case 4:
                    SortSalesByDate(true, listView);
                    break;
                case 5:
                    SortSalesByDate(false, listView);
                    break;
            }
        }

        /// <summary>
        /// Loads the sales info into the list view.
        /// </summary>
        /// <param name="listView">ListView to use.</param>
        public static void LoadSalesById(ListView listView, int salesId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT b.id, b.title, SUM(i.quantity) as Amount, b.price, (b.price * SUM(i.quantity)) as Total_price FROM Sales s " +
                        "INNER JOIN Sales_items i ON s.id = i.sales_id " +
                        "INNER JOIN Books b ON i.book_id = b.id " +
                        "WHERE s.id = @salesId " +
                        "GROUP BY b.id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@salesId", salesId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    listView.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["Title"].ToString());
                        item.SubItems.Add(reader["Amount"].ToString());
                        item.SubItems.Add(reader["Price"].ToString());
                        item.SubItems.Add(reader["Total_price"].ToString());

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
        /// Loads the sales info.
        /// </summary>
        /// <param name="listView">ListView to use.</param>
        public static string[] LoadSalesInfo(int salesId)
        {
            List<string> data = new List<string>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT c.name, s.date, s.total_amount FROM Sales s " +
                        "INNER JOIN Clients c ON s.client_id = c.id " +
                        "WHERE s.id = @salesId ";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@salesId", salesId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        data.Add(reader["name"].ToString());

                        if (DateTime.TryParse(reader["date"].ToString(), out DateTime publishDate))
                        {
                            string formattedDate = publishDate.ToString("dd/MM/yyyy");
                            data.Add(formattedDate);
                        }
                        else
                        {
                            data.Add("");
                        }

                        data.Add(reader["total_amount"].ToString());
                    }
                }
                return data.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
    }
}
