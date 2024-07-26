using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ManagementSystem.Pages
{
    public partial class EditClientForm : Form
    {
        private int clientId;
        string connectionString = Configuration.ConnectionString;

        public EditClientForm(int clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
            LoadClientData();
        }

        // Function to Load the client data
        private void LoadClientData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    GetClientData(conn);
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

                    string errors = CheckUsersFields(conn);
                    if (!string.IsNullOrEmpty(errors))
                    {
                        MessageBox.Show($"Client with the same {errors} already exists.");
                        return;
                    }

                    UpdateClient(conn);
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
            string checkQuery = $"SELECT COUNT(*) FROM Clients WHERE {fieldName} = @fieldValue AND Id != @clientId";
            MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@fieldValue", fieldValue);
            checkCmd.Parameters.AddWithValue("@clientId", clientId);
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

        // Function to update user data
        private void UpdateClient(MySqlConnection conn) 
        {
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

        // Function to get the client data by id
        private void GetClientData(MySqlConnection conn) 
        {
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

