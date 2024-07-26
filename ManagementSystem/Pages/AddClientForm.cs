using MySql.Data.MySqlClient;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ManagementSystem.Pages
{
    public partial class AddClientForm : Form
    {
        string connectionString = Configuration.ConnectionString;

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

                    string errors = CheckUsersFields(conn);
                    if (!string.IsNullOrEmpty(errors))
                    {
                        MessageBox.Show($"Client with the same {errors} already exists.");
                        return;
                    }

                    InsertClient(conn);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Function to if exists a user with that value in a certain field
        private int CheckExistingField(MySqlConnection conn, string fieldName, string fieldValue)
        {
            string checkQuery = $"SELECT COUNT(*) FROM Clients WHERE {fieldName} = @fieldValue";
            MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@fieldValue", fieldValue);
            return Convert.ToInt32(checkCmd.ExecuteScalar());
        }

        // Function to check the fields
        private string CheckUsersFields(MySqlConnection conn)
        {
            string errors = "";
            if (CheckExistingField(conn, "Email", txtEmail.Text) > 0)
            {
                errors += "Email ";
            }
            if (CheckExistingField(conn, "Nif", txtNif.Text) > 0)
            {
                errors += "NIF ";
            }
            if (CheckExistingField(conn, "Phone", txtPhone.Text) > 0)
            {
                errors += "Phone ";
            }
            return errors.Trim();
        }

        // Function to insert the new user data
        private void InsertClient(MySqlConnection conn) 
        {
            string insertQuery = "INSERT INTO Clients (Name, Email, Nif, Phone, Address) VALUES (@name, @email, @nif, @phone, @address)";
            MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
            insertCmd.Parameters.AddWithValue("@name", txtName.Text);
            insertCmd.Parameters.AddWithValue("@email", txtEmail.Text);
            insertCmd.Parameters.AddWithValue("@nif", txtNif.Text);
            insertCmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            insertCmd.Parameters.AddWithValue("@address", txtAddress.Text);
            insertCmd.ExecuteNonQuery();
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
