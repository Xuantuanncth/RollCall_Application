using FingerPrinter.Forms;
using FingerPrinter.Properties;
using System.Data.SQLite;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace FingerPrinter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //string databasePath = Path.Combine(appDataPath, "Account.db");
            //Debug.WriteLine("Database path: ",databasePath);

            //bool isDatabase = isDatatbaseExist(databasePath);
            //if (!isDatabase)
            //{
            //    CreateTableIfNotExistsforAccountion();
            //}
            //if (!Program.IsLoggedIn)
            //{
            //    Debug.WriteLine("This is debug");
            //    label_notification.Text = "Please Login :)";
            //    SetControlsEnabled(false);
            //    statusOfDevice(false);
            //}
            statusOfDevice(false);
            CreateTableIfNotExsitsforStudent();
            //DeleteTable("Students");
        }

        private bool isDatatbaseExist(string path)
        {
            return File.Exists(path);
        }

        private void CreateTableIfNotExistsforAccountion()
        {

            string accountConnection = "Data Source=Account.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(accountConnection))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(
                        @"CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    Email TEXT,
                    PasswordHash TEXT
                )", connection);

                try
                {
                    command.ExecuteNonQuery();
                    Debug.WriteLine("Table created successfully.");
                }
                catch (SQLiteException ex)
                {
                    Debug.WriteLine("Error creating table: " + ex.Message);
                }
            }
        }

        private void CreateTableIfNotExsitsforStudent()
        {
            string studentConnection = "Data Source=Student.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(studentConnection))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(
                    @"CREATE TABLE IF NOT EXISTS Students (
                     Id INTEGER PRIMARY KEY AUTOINCREMENT,
                     Name TEXT,
                     PrivateID TEXT,
                     Class TEXT,
                     FingerprinterId TEXT,
                     AvatarPath TEXT,
                     Description TEXT
                    )", connection
                    );

                try
                {
                    command.ExecuteNonQuery();
                    Debug.WriteLine("Table student created successfuly");
                }
                catch (SQLiteException ex)
                {
                    Debug.WriteLine("Error create student: ", ex);
                }
            }
        }

        public void DeleteTable(string tableName)
        {
            string connectionString = "Data Source=Student.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand($"DROP TABLE IF EXISTS {tableName}",
         connection);

                try
                {
                    command.ExecuteNonQuery();
                    Debug.WriteLine($"Table '{tableName}' deleted successfully.");
                }
                catch (SQLiteException ex)
                {
                    Debug.WriteLine($"Error deleting table: {ex.Message}");
                }
            }
        }
        public void enableApplication()
        {
            SetControlsEnabled(true);
            label_notification.Text = string.Empty;
            btn_login.Enabled = false;
            btn_login.Text = Program.LoggedInUser;
            btn_login.Image = null;
            Dashboard dashboard_section = new Dashboard();
            dashboard_section.TopLevel = false;
            main_panel.Controls.Clear();
            main_panel.Controls.Add(dashboard_section);
            dashboard_section.Dock = DockStyle.Fill;
            dashboard_section.Show();

        }
        public void statusOfDevice(bool isConnected)
        {
            if (isConnected)
            {
                text_status.Text = "Connected";
                pb_status.Image = Image.FromFile(Program.imagePath + "/connected.png");
            }
            else
            {
                text_status.Text = "Disconnected";
                pb_status.Image = Image.FromFile(Program.imagePath + "/disconnected.png");
            }
        }
        private void SetControlsEnabled(bool isEnabled)
        {
            btn_addInfor.Enabled = isEnabled;
            btn_setting.Enabled = isEnabled;
            btn_report.Enabled = isEnabled;
            btn_timesheet.Enabled = isEnabled;
            btn_timeoff.Enabled = isEnabled;
            btn_dashboard.Enabled = isEnabled;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login_section = new Login();
            login_section.Show();
        }

        private void btn_addInfor_Click(object sender, EventArgs e)
        {
            lable_Tag.Text = "Add Infor";
            Information add_information = new Information();
            add_information.TopLevel = false;
            main_panel.Controls.Clear();
            main_panel.Controls.Add(add_information);
            add_information.Dock = DockStyle.Fill;
            add_information.Show();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            lable_Tag.Text = "Setting";
            Setting add_setting = new Setting();
            add_setting.TopLevel = false;
            main_panel.Controls.Clear();
            main_panel.Controls.Add(add_setting);
            add_setting.Dock = DockStyle.Fill;
            add_setting.Show();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard_section = new Dashboard();
            dashboard_section.TopLevel = false;
            main_panel.Controls.Clear();
            main_panel.Controls.Add(dashboard_section);
            dashboard_section.Dock = DockStyle.Fill;
            dashboard_section.Show();
        }

    }
}
