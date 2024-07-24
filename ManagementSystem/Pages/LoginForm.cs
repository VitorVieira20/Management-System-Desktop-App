using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace ManagementSystem.Pages
{
    public partial class LoginForm : Form
    {
        string connectionString = "Server=localhost;Database=systemmanagement;User ID=root;Password=@//Vitor925139873//@@BASQUETEBOL#@;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        
        // Exits the application
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        // Show Register Page and hide Login Page
        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        
        // Function to able user viewing the entered password
        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Open a SQL connection and try to get a user by username and password
                    try
                    {
                        conn.Open();
                        string query = "SELECT Password FROM Users WHERE Username=@username";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());

                        string storedHash = (string)cmd.ExecuteScalar();

                        if (storedHash != null && BCrypt.Net.BCrypt.Verify(login_password.Text.Trim(), storedHash))
                        {
                            MessageBox.Show("Login successful!");
                            // Proceed to the next form or main application
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

            }
        }
    }
}