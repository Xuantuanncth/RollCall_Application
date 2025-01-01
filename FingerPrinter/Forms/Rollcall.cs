using FingerPrinter.Forms;
using FingerPrinter.Properties;
using FingerPrinter.Services;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SQLite;
using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FingerPrinter
{
    public partial class Main : Form
    {
        private string databaseFolder = Path.Combine(Application.StartupPath, "Databases");
        public static string? accountDatabase;
        public static string? employeeDatabase;
        public static string? timeSheetDatabase;
        public Main()
        {
            InitializeComponent();
            SerialManager.Instance.DataReceived += OnSerialDataReceived;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(databaseFolder))
            {
                Directory.CreateDirectory(databaseFolder);
            }
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            accountDatabase = Path.Combine(databaseFolder, "Account.db");
            employeeDatabase = Path.Combine(databaseFolder, "Employee.db");
            Debug.WriteLine("Database path: ", accountDatabase);

            bool isDatabase = isDatatbaseExist(accountDatabase);
            if (!isDatabase)
            {
                CreateTableIfNotExistsforAccountion(accountDatabase);
            }
            isDatabase = isDatatbaseExist(employeeDatabase);
            if (!isDatabase)
            {
                CreateTableIfNotExsitsforemployee(employeeDatabase);
            }
            //if (!Program.IsLoggedIn)
            //{
            //    Debug.WriteLine("This is debug");
            //    label_notification.Text = "Please Login :)";
            //    SetControlsEnabled(false);
            //    statusOfDevice(false);
            //}
            statusOfDevice(false);

            //DeleteTable("Timesheet",employeeDatabase);
        }
        private void OnSerialDataReceived(string data)
        {
            string _employee_id, _date, _time, _type;
            Invoke(new Action(() =>
            {
                //MessageBox.Show($"Data received in Form1: {data}");
                Debug.WriteLine($"-----> Serial received data: {data}");
                if (IsVaildData(data))
                {
                    if (ParserDataAndInsertToDatabase(data, out _employee_id, out _date, out _time, out _type))
                    {
                        if (InsertDataToDatabase(_employee_id, _date, _time, _type))
                        {
                            Debug.WriteLine("[OK]");
                            SerialManager.Instance.SendCommand("OK");
                        }
                        else
                        {
                            Debug.WriteLine("[Error]");
                            SerialManager.Instance.SendCommand("ERROR");
                        }
                    }
                }
            }));
        }
        private bool IsVaildData(string data)
        {
            return data.StartsWith("*#") && data.EndsWith("#");
        }
        private bool ParserDataAndInsertToDatabase(string dataString, out string employee_id, out string date, out string time, out string type)
        {
            /*
             * Data type: *#1_30/11/2023_8:22:30_IN_OK#
             */
            dataString = dataString.Substring(2,dataString.Length -3);

            // Split the string by '_' delimiter
            string[] dataParts = dataString.Split('_');

            if (dataParts.Length != 5)
            {
                // Invalid data format
                employee_id = "";
                date = "";
                time = "";
                type = "";
                return false;
            }

            employee_id = dataParts[0];
            //Debug.WriteLine($"--> Data[0]: {employee_id}");
            DateTime _date = DateTime.ParseExact(dataParts[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //DateTime _time = DateTime.ParseExact(dataParts[2], "HH:mm:ss", CultureInfo.InvariantCulture);
            date = _date.ToString("yyyy-MM-dd");
            time = dataParts[2];
            type = dataParts[3] + "_" + dataParts[4]; // Combine the last two parts for the 'type'

            return true;
        }
        private bool InsertDataToDatabase(string emp_id, string date, string time, string type)
        {
            bool isInsertData = false;
            string connectionString = $"Data Source={employeeDatabase};Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(
                    "INSERT INTO Timesheet (EmployeePrivateID, Date, Time, Type)" +
                    "VALUES (" +
                        "@EmployeePrivateID," +
                        "@Date, " +
                        "@Time, " +
                        "@Type)",
                connection);

                command.Parameters.AddWithValue("@EmployeePrivateID", emp_id);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Time", time);
                command.Parameters.AddWithValue("@Type", type);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        //Debug.WriteLine("Done added database");
                        isInsertData = true;
                    }
                    else
                    {
                        //Debug.WriteLine("Error when add database");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Cannot insert database: ", ex);
                }
            }

            return isInsertData;
        }
        private bool isDatatbaseExist(string path)
        {
            return File.Exists(path);
        }

        private void CreateTableIfNotExistsforAccountion(string accountPath)
        {

            string accountConnection = $"Data Source={accountPath};Version=3;";

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

        private void CreateTableIfNotExsitsforemployee(string employeePath)
        {
            string employeeConnection = $"Data Source={employeePath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(employeeConnection))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(
                    @"CREATE TABLE IF NOT EXISTS Employees (
                     Id INTEGER PRIMARY KEY AUTOINCREMENT,
                     Name TEXT,
                     PrivateID TEXT,
                     Department TEXT,
                     AvatarPath TEXT,
                     Description TEXT
                    )", connection
                );

                SQLiteCommand timeSheetCommand = new SQLiteCommand(
                    @"
                    CREATE TABLE IF NOT EXISTS Timesheet (
                        EmployeePrivateID TEXT,
                        Date DATE,
                        Time TIME,
                        Type TEXT,
                        FOREIGN KEY (EmployeePrivateID) REFERENCES Employees(PrivateID)
                    )", connection
                );
                try
                {
                    command.ExecuteNonQuery();
                    timeSheetCommand.ExecuteNonQuery();
                    Debug.WriteLine("------------> Table employee created successfuly");
                }
                catch (SQLiteException ex)
                {
                    Debug.WriteLine("Error create employee: ", ex);
                }
            }
        }

        public void DeleteTable(string tableName, string employeePath)
        {
            string connectionString = $"Data Source={employeePath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand($"DELETE FROM {tableName}", connection);

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
            lable_Tag.Text = "Information";
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
            lable_Tag.Text = "DashBoard";
            Dashboard dashboard_section = new Dashboard();
            dashboard_section.TopLevel = false;
            main_panel.Controls.Clear();
            main_panel.Controls.Add(dashboard_section);
            dashboard_section.Dock = DockStyle.Fill;
            dashboard_section.Show();
        }

        private void btn_timesheet_Click(object sender, EventArgs e)
        {
            lable_Tag.Text = "Timesheet";
            TimeSheet timesheet_section = new TimeSheet();
            timesheet_section.TopLevel = false;
            main_panel.Controls.Clear();
            main_panel.Controls.Add(timesheet_section);
            timesheet_section.Dock = DockStyle.Fill;
            timesheet_section.Show();
        }
    }
}
