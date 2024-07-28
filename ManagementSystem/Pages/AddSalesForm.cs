using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ManagementSystem
{
    public partial class AddSalesForm : Form
    {
        private string connectionString = Configuration.ConnectionString;

        public AddSalesForm()
        {
            InitializeComponent();
            LoadClients();
            LoadBooks();

            btnSearchBook.Click += btnSearch_Click;
        }

        private void LoadClients()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id, Name FROM Clients";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cmbClients.DataSource = dt;
                    cmbClients.DisplayMember = "Name";
                    cmbClients.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadBooks()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id, Title, Author, Publish_date, Price FROM Books";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    lvBooks.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["Title"].ToString());
                        item.SubItems.Add(reader["Author"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["Publish_date"]).ToString("dd/MM/yyyy"));
                        item.SubItems.Add(reader["Price"].ToString());
                        lvBooks.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SearchBooks(string searchText)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id, Title, Author, Publish_date, Price FROM Books " +
                                   "WHERE Title LIKE @SearchText OR Author LIKE @SearchText";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    MySqlDataReader reader = cmd.ExecuteReader();

                    lvBooks.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["Title"].ToString());
                        item.SubItems.Add(reader["Author"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["Publish_date"]).ToString("dd/MM/yyyy"));
                        item.SubItems.Add(reader["Price"].ToString());
                        lvBooks.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int GetQuantityFromUser()
        {
            using (InputBoxForm inputBox = new InputBoxForm("Enter the quantity:"))
            {
                if (inputBox.ShowDialog() == DialogResult.OK)
                {
                    if (int.TryParse(inputBox.InputValue, out int quantity) && quantity > 0)
                    {
                        return quantity;
                    }
                    else
                    {
                        MessageBox.Show("Invalid quantity. Please enter a valid number greater than 0.");
                        return GetQuantityFromUser();
                    }
                }
                else
                {
                    return 0;
                }
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lvBooks.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvBooks.SelectedItems[0];
                int bookId = Convert.ToInt32(selectedItem.SubItems[0].Text);
                string title = selectedItem.SubItems[1].Text;
                decimal price = Convert.ToDecimal(selectedItem.SubItems[4].Text);
                int quantity = GetQuantityFromUser();

                if (quantity > 0)
                {
                    decimal totalPrice = price * quantity;

                    ListViewItem cartItem = new ListViewItem(bookId.ToString());
                    cartItem.SubItems.Add(title);
                    cartItem.SubItems.Add(quantity.ToString());
                    cartItem.SubItems.Add(price.ToString());
                    cartItem.SubItems.Add(totalPrice.ToString());

                    lvCart.Items.Add(cartItem);
                }
                else
                {
                    MessageBox.Show("Invalid quantity entered.");
                }
            }
            else
            {
                MessageBox.Show("Please select a book to add to cart.");
            }
        }

        private void btnFinalizePurchase_Click(object sender, EventArgs e)
        {
            if (cmbClients.SelectedValue == null)
            {
                MessageBox.Show("Please select a client.");
                return;
            }

            if (lvCart.Items.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            int clientId = Convert.ToInt32(cmbClients.SelectedValue);
            DateTime saleDate = DateTime.Now;
            decimal totalAmount = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // Insert into Sales table
                    string saleQuery = "INSERT INTO Sales (Date, Client_id, Total_amount) VALUES (@SaleDate, @ClientId, @TotalAmount)";
                    MySqlCommand saleCmd = new MySqlCommand(saleQuery, conn, transaction);
                    saleCmd.Parameters.AddWithValue("@SaleDate", saleDate);
                    saleCmd.Parameters.AddWithValue("@ClientId", clientId);

                    // Calculate total amount
                    foreach (ListViewItem item in lvCart.Items)
                    {
                        totalAmount += Convert.ToDecimal(item.SubItems[4].Text);
                    }

                    saleCmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    saleCmd.ExecuteNonQuery();

                    long saleId = saleCmd.LastInsertedId;

                    // Insert into SalesItems table
                    foreach (ListViewItem item in lvCart.Items)
                    {
                        string itemQuery = "INSERT INTO Sales_items (Sales_id, Book_id, Quantity) VALUES (@SaleId, @BookId, @Quantity)";
                        MySqlCommand itemCmd = new MySqlCommand(itemQuery, conn, transaction);
                        itemCmd.Parameters.AddWithValue("@SaleId", saleId);
                        itemCmd.Parameters.AddWithValue("@BookId", Convert.ToInt32(item.SubItems[0].Text));
                        itemCmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(item.SubItems[2].Text));

                        itemCmd.ExecuteNonQuery();

                        // Update stock in Books table
                        string updateStockQuery = "UPDATE Stock SET Quantity = Quantity - @Quantity WHERE Id = @BookId";
                        MySqlCommand updateStockCmd = new MySqlCommand(updateStockQuery, conn, transaction);
                        updateStockCmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(item.SubItems[2].Text));
                        updateStockCmd.Parameters.AddWithValue("@BookId", Convert.ToInt32(item.SubItems[0].Text));

                        updateStockCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Purchase finalized successfully.");
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchBook.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadBooks();
            }
            else
            {
                SearchBooks(searchText);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
