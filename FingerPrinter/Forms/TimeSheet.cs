using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerPrinter.Forms
{
    public partial class TimeSheet : Form
    {
        private string employee_db_path = Main.employeeDatabase;
        public TimeSheet()
        {
            InitializeComponent();
            LoadDataFromDatabase();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void trip_loadData_Click(object sender, EventArgs e)
        {
            if (Program.isConnectedDevice)
            {
                //Load data form program
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadDataFromDatabase()
        {
            string connectionString = $"Data Source={employee_db_path};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                //string query = "SELECT * FROM Timesheet";
                string query = @"
                                SELECT 
                                    Timesheet.EmployeePrivateID, 
                                    Employees.Name, 
                                    Timesheet.Date, 
                                    Timesheet.Time, 
                                    Timesheet.Type
                                FROM 
                                    Timesheet
                                JOIN 
                                    Employees 
                                ON 
                                    Timesheet.EmployeePrivateID = Employees.PrivateID";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        Debug.WriteLine("Data: ", dataTable);
                        adapter.Fill(dataTable);


                        // Assign the DataTable to the DataGridView's DataSource
                        dataGridView1.DataSource = dataTable;

                        if (dataGridView1.Columns["Time"] != null) // Ensure the column exists
                        {
                            dataGridView1.Columns["Time"].DefaultCellStyle.Format = "HH:mm:ss";
                        }
                        if (dataGridView1.Columns["Date" ] != null)
                        {
                            dataGridView1.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        }
                    }
                }
            }
        }
    }
}
