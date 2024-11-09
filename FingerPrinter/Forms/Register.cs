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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FingerPrinter.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string name = tb_user_name.Text;
            string email = tb_mail.Text;
            string password = tb_password.Text; 
            string confirm_password = tb_confirm_pass.Text;

            if (password == confirm_password) {
                string password_hashed = hash_password(password);

                bool isInsertDB = InsertIntoDatabase(name, email, password_hashed);
                if (isInsertDB)
                {
                    MessageBox.Show("Register successful");
                    clearForm();
                }
                else
                {
                    MessageBox.Show("Register fail, please try again");
                }
                 
            }
            else
            {
                MessageBox.Show("Password and Confirm password not equal");
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

        private static bool InsertIntoDatabase(string name,
                                        string email,
                                        string passwordHashed)
        {
            string connectionString = "Data Source=Account.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString)) 
            { 
                connection.Open();

                SQLiteCommand command = new SQLiteCommand("INSERT INTO Users(Name, Email, PasswordHash) VALUES(@Name, @Email, @PasswordHash)", connection);

                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@PasswordHash", passwordHashed);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch(Exception ex) 
                { 
                    MessageBox.Show("Error inserting data: " + ex.Message);
                    return false;
                }
            }
        }


        private void clearForm()
        {
            tb_confirm_pass.Text = string.Empty;
            tb_mail.Text = string.Empty;
            tb_user_name.Text = string.Empty;
            tb_password.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ltb_back_login_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login_section = new Login();
            login_section.Show();
            this.Close();
        }
    }
}
