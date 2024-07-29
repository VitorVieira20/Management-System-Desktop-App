using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ManagementSystem.Pages
{
    public partial class AddStockForm : Form
    {
        private int userId;
        private int bookId;
        string connectionString = Configuration.ConnectionString;

        public AddStockForm(int userId, int bookId)
        {
            InitializeComponent();
            this.userId = userId;
            this.bookId = bookId;
            LoadBookData();
        }

        // Function to load the book data
        private void LoadBookData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    GetBookData(conn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Function to get the book data by id
        private void GetBookData(MySqlConnection conn)
        {
            string query = "SELECT Id, Author, Publish_date FROM Books WHERE Id=@id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", this.bookId);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    txtBookId.Text = reader["Id"].ToString();
                    txtBookId.ReadOnly = true;
                    txtAuthor.Text = reader["Author"].ToString();
                    txtAuthor.ReadOnly = true;

                    if (DateTime.TryParse(reader["Publish_date"].ToString(), out DateTime publishDate))
                    {
                        string formattedDate = publishDate.ToString("dd/MM/yyyy");
                        txtPublishDate.Text = formattedDate;
                    }
                    else
                    {
                        txtPublishDate.Text = "Data inválida";
                    }
                    txtPublishDate.ReadOnly = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    int existingQuantity = GetStockQuantity(conn);
                    int quantityToAdd = Int32.Parse(txtQuantity.Text);
                    int newQuantity = existingQuantity + quantityToAdd;

                    string query = "UPDATE Stock SET Quantity=@quantity WHERE Book_id=@bookId";
                    MySqlCommand updateCmd = new MySqlCommand(query, conn);
                    updateCmd.Parameters.AddWithValue("@quantity", newQuantity);
                    updateCmd.Parameters.AddWithValue("@bookId", this.bookId);

                    updateCmd.ExecuteNonQuery();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Get existing stock
        private int GetStockQuantity(MySqlConnection conn) 
        {
            string getQuantityQuery = "SELECT Quantity FROM Stock WHERE Book_id = @bookId";
            MySqlCommand getQuantityCmd = new MySqlCommand(getQuantityQuery, conn);
            getQuantityCmd.Parameters.AddWithValue("@bookId", this.bookId);

            return Convert.ToInt32(getQuantityCmd.ExecuteScalar());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
