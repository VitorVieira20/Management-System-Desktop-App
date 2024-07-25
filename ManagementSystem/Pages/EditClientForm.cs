using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ManagementSystem.Pages
{
    public partial class EditClientForm : Form
    {
        private int clientId;
        string connectionString = "Server=localhost;Database=systemmanagement;User ID=root;Password=@//Vitor925139873//@@BASQUETEBOL#@;";

        public EditClientForm(int clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
            LoadClientData();
        }

        private void LoadClientData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Name, Email, Nif, Phone, Address FROM Clients WHERE Id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", clientId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["Name"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtNif.Text = reader["Nif"].ToString();
                            txtPhone.Text = reader["Phone"].ToString();
                            txtAddress.Text = reader["Address"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Clients SET Name=@name, Email=@email, Nif=@nif, Phone=@phone, Address=@address WHERE Id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@nif", txtNif.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@id", clientId);
                    cmd.ExecuteNonQuery();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

