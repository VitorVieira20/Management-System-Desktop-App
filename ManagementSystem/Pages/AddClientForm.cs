using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ManagementSystem.Pages
{
    public partial class AddClientForm : Form
    {
        string connectionString = "Server=localhost;Database=systemmanagement;User ID=root;Password=@//Vitor925139873//@@BASQUETEBOL#@;";

        public AddClientForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Clients (Name, Email, Nif, Phone, Address) VALUES (@name, @email, @nif, @phone, @address)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@nif", txtNif.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
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
