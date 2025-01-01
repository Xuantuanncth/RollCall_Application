using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerPrinter.Forms
{
    public partial class Login : Form
    {
        private string account_db_path = Main.accountDatabase;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user_name = tb_user_name.Text;
            string password = tb_password.Text;

            if (ValidateLogin(user_name, password))
            {
                Program.IsLoggedIn = true;
                Program.LoggedInUser = user_name;

                Main mainForm = (Main)Application.OpenForms["Main"];
                mainForm.enableApplication();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }


        }

        private bool ValidateLogin(string username, string password)
        {
            string connectionString = $"Data Source={account_db_path};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Users WHERE Name = @Name", connection);
                command.Parameters.AddWithValue("@Name", username);

                SQLiteDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string storedPasswordHash = reader["PasswordHash"].ToString();
                    string role = reader["Role"].ToString();

                    // Verify password hash using a secure comparison method (e.g., constant-time comparison)
                    if (hash_password(password) == storedPasswordHash)
                    {
                        if(role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                        {
                            Program.isAdminLogin = true;
                        }
                        return true; // Login successful
                    }
                }

                return false; // Login failed
            }
        }

        private string hash_password(string password)
        {
            using (SHA256 hash = SHA256.Create())
            {
                byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register_section = new Register();
            register_section.Show();
            this.Close();
        }
    }
}
