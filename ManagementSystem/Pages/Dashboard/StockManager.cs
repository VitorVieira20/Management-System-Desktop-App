using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;
using System.Linq;

namespace ManagementSystem.Pages.Dashboard
{
    public static class StockManager
    {
        private static string connectionString = Configuration.ConnectionString;

        /// <summary>
        /// Loads the stock into the list view.
        /// </summary>
        /// <param name="listView">ListView to use.</param>
        public static void LoadStock(ListView listView)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT b.Id, b.Title, b.Author, b.Publish_date, s.Quantity FROM Books b INNER JOIN Stock s ON b.Id = s.Book_id ORDER BY s.Quantity ASC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    listView.Items.Clear();

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

                        listView.Items.Add(item);
                        DatabaseHelper.CheckLowStock(listView);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Checks if the book stock is low and updates the list view item color.
        /// /// <param name="listView">ListView to use.</param>
        /// </summary>
        public static void CheckLowStock(ListView listView) 
        { 
            DatabaseHelper.CheckLowStock(listView);
        }

        /// <summary>
        /// Sorts the stock by quantity.
        /// </summary>
        /// <param name="ascending">If true, sort in ascending order; otherwise, sort in descending order.</param>
        /// <param name="listView">ListView to use.</param>
        private static void SortStockByQuantity(bool ascending, ListView listView)
        {
            var items = listView.Items.Cast<ListViewItem>().OrderBy(item =>
            {
                int quantity;
                return int.TryParse(item.SubItems[4].Text, out quantity) ? quantity : 0;
            }).ToList();

            if (!ascending)
            {
                items = items.AsEnumerable().Reverse().ToList();
            }

            listView.Items.Clear();
            listView.Items.AddRange(items.ToArray());
        }

        /// <summary>
        /// Sorts the stock by book title.
        /// </summary>
        /// <param name="ascending">If true, sort in ascending order; otherwise, sort in descending order.</param>
        /// <param name="listView">ListView to use.</param>
        private static void SortStockByTitle(bool ascending, ListView listView)
        {
            var items = listView.Items.Cast<ListViewItem>().OrderBy(item => item.SubItems[1].Text).ToList();

            if (!ascending)
            {
                items = items.AsEnumerable().Reverse().ToList();
            }

            listView.Items.Clear();
            listView.Items.AddRange(items.ToArray());
        }

        /// <summary>
        /// Sorts the stock by book publish date.
        /// </summary>
        /// <param name="ascending">If true, sort in ascending order; otherwise, sort in descending order.</param>
        /// <param name="listView">ListView to use.</param>
        private static void SortStockByPublishDate(bool ascending, ListView listView)
        {
            var items = listView.Items.Cast<ListViewItem>().OrderBy(item => item.SubItems[3].Text).ToList();

            if (!ascending)
            {
                items = items.AsEnumerable().Reverse().ToList();
            }

            listView.Items.Clear();
            listView.Items.AddRange(items.ToArray());
        }

        /// <summary>
        /// Handles the selected index change event of the stock filter combo box.
        /// </summary>
        /// <param name="listView">ListView to use.</param>
        /// <param name="selectedIndex">Selected index in the combo box.</param>
        public static void SortStock(ListView listView, int selectedIndex) 
        {
            switch (selectedIndex)
            {
                case 0:
                    SortStockByQuantity(true, listView);
                    break;
                case 1:
                    SortStockByQuantity(false, listView);
                    break;
                case 2:
                    SortStockByTitle(true, listView);
                    break;
                case 3:
                    SortStockByTitle(false, listView);
                    break;
                case 4:
                    SortStockByPublishDate(true, listView);
                    break;
                case 5:
                    SortStockByPublishDate(false, listView);
                    break;
            }
        }
    }
}
