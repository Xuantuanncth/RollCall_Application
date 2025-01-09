using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace FingerPrinter.Forms
{
    public partial class Dashboard : Form
    {
        private string employee_db_path = Main.employeeDatabase;
        private int currentPage = 0;
        private const int pageSize = 3;
        private SQLiteConnection connection;
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Dashboard()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            InitializeComponent();
            DisplayDateTime();
            InitializeDatabase();
            GetTotalEmployeeCount();
            LoadDashboard();
        }
        private void DisplayDateTime()
        {
            // Get current date and time
            DateTime now = DateTime.Now;

            lb_date.Text = now.ToString("MMMM dd, yyyy"); // Example: January 01, 2024
            lb_day.Text = now.DayOfWeek.ToString();
        }

        private void InitializeDatabase()
        {
            string connectionString = $"Data Source={employee_db_path};Version=3;";
            connection = new SQLiteConnection(connectionString);
            connection.Open();
        }

        private void GetTotalEmployeeCount()
        {
            int totalEmployees = 0;
            try
            {
                string query = "SELECT COUNT(*) FROM Employees";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Execute the query and get the count
                    totalEmployees = Convert.ToInt32(command.ExecuteScalar());
                }

                lb_totalEmp.Text = totalEmployees.ToString();
            } 
            catch(Exception e)
            {
                MessageBox.Show($"Error counting employees: {e.Message}");
            }
        }
        private void LoadDashboard()
        {
            string query = @"
                SELECT e.Name, e.AvatarPath, COALESCE(t.Type, 'No Check-in') AS Type
                FROM Employees e
                        LEFT JOIN Timesheet t ON e.PrivateID = t.EmployeePrivateID 
                        AND t.Date = date('now')
                        LIMIT @limit OFFSET @offset";

            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@limit", pageSize);
                command.Parameters.AddWithValue("@offset", currentPage * pageSize);
                using (var reader = command.ExecuteReader())
                {
                    int panelIndex = 1;
                    while (reader.Read())
                    {
                        string ? name = reader["Name"]?.ToString();
                        string ? avatarPath = reader["AvatarPath"]?.ToString();
                        string ? type = reader["Type"]?.ToString();

                        // Load data into panel components
                        UpdatePanel(panelIndex, name, avatarPath, type);
                        panelIndex++;
                    }

                    // Clear unused panels
                    for (int i = panelIndex; i <= pageSize; i++)
                    {
                        ClearPanel(i);
                    }
                }
            }
            UpdateNavigationButtons();
        }

        private void UpdatePanel(int panelIndex, string name, string avatarPath, string type)
        {
            var panel = this.Controls.Find($"panel_{panelIndex}", true)[0];
            Logger.Info("PanelIndex: "+panelIndex);
            foreach (var control in panel.Controls)
            {
                if (control is System.Windows.Forms.Label label)
                {
                    if (label.Name == $"lb_name{panelIndex}")
                    {
                        label.Text = name;
                    }
                    else if (label.Name == $"lb_status{panelIndex}")
                    {
                        label.Text = type;
                    }
                }
                else if (control is PictureBox picturebox)
                {
                    picturebox.Image = Image.FromFile(avatarPath);
                }
            }
            if (type == "IN_LATE" || type == "OUT_SOON")
            {
                panel.BackColor = Color.FromArgb(236, 112, 99); // Hex: #EC7063
            }
            else if (type == "IN_OK" || type == "OUT_OK")
            {
                panel.BackColor = Color.FromArgb(118, 215, 196); // Hex: #76D7C4
            }
            else
            {
                panel.BackColor = Color.FromArgb(235, 245, 251); // Default background color
            }
        }
        private void ClearPanel(int panelIndex)
        {
            var panel = this.Controls.Find($"panel_{panelIndex}", true)[0];
            foreach (var control in panel.Controls)
            {
                if (control is System.Windows.Forms.Label label)
                {
                    label.Text = "";
                }
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Image = null;
                }
                panel.BackColor = Color.FromArgb(235, 245, 251); // Default background color
            }
        }

        private void UpdateNavigationButtons()
        {
            string countQuery = "SELECT COUNT(*) FROM Employees";
            using (var command = new SQLiteCommand(countQuery, connection))
            {
                int totalCount = Convert.ToInt32(command.ExecuteScalar());

                bt_back.Enabled = currentPage > 0;
                bt_next.Enabled = (currentPage + 1) * pageSize < totalCount;
            }
        }
        private void bt_back_Click(object sender, EventArgs e)
        {
            currentPage--;
            LoadDashboard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadDashboard();
        }

    }
}
