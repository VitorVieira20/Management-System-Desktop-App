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
            login_username.KeyDown += new KeyEventHandler(LoginFields_KeyDown);
            login_password.KeyDown += new KeyEventHandler(LoginFields_KeyDown);
        }

        // Handle the KeyDown event for both username and password fields
        private void LoginFields_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                login_btn_Click(sender, e);
            }
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

        
        // Perform login
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
                        string query = "SELECT ID, Password FROM Users WHERE Username=@username";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());

                        ComparePasswords(cmd);        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        // Function to compare passwords (inserted by user and in the database)
        private void ComparePasswords(MySqlCommand cmd)
        {
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string storedHash = reader["Password"].ToString();
                int userId = Convert.ToInt32(reader["ID"]);

                if (BCrypt.Net.BCrypt.Verify(login_password.Text.Trim(), storedHash))
                {
                    reader.Close();

                    // Open the Dashboard and pass the user ID
                    Dashboard dashboard = new Dashboard(userId);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }
    }
}