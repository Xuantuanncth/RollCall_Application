using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerPrinter.Forms
{
    public partial class Login : Form
    {
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

            if (check_Login(user_name, password))
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

        private bool check_Login(string user_name, string password)
        {
            bool r_val = false;
            if(user_name == "tuandx" && password == "1")
            {
                r_val = true;
            }
            return r_val;
        }
    }
}
