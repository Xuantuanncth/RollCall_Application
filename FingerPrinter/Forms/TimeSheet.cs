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
using System.Windows.Forms.VisualStyles;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FingerPrinter.Forms
{
    public partial class TimeSheet : Form
    {
        private string employee_db_path = Main.employeeDatabase;
        private bool is_select_month = false;
        private bool is_select_date = false;
        private bool is_select_name = false;
        private bool is_selcet_id = false;
        private string query = @"
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
        public TimeSheet()
        {
            InitializeComponent();
            LoadDataFromDatabase(query, "normal");
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
        private void LoadDataFromDatabase(string custom_query, string mode)
        {
            string connectionString = $"Data Source={employee_db_path};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                //string query = "SELECT * FROM Timesheet";

                using (SQLiteCommand command = new SQLiteCommand(custom_query, connection))
                {
                    if (mode == "search")
                    {
                        if (is_selcet_id)
                        {
                            command.Parameters.AddWithValue("@ID", tb_s_id.Text);
                        }
                        if (is_select_date)
                        {
                            command.Parameters.AddWithValue("@Date", monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"));
                        }
                        if (is_select_month)
                        {
                            command.Parameters.AddWithValue("@Month", value: cb_month.SelectedItem.ToString().PadLeft(2, '0')); // Ensure 2-digit month
                        }
                        if (is_select_name)
                        {
                            command.Parameters.AddWithValue("@Name", "%" + tb_s_name.Text + "%");
                        }
                        Debug.WriteLine(command, "Comand: ");
                    }
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
                        if (dataGridView1.Columns["Date"] != null)
                        {
                            dataGridView1.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        }
                        dataGridView1.Columns["EmployeePrivateID"].HeaderText = "ID";
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            column.Width = 200;  
                        }
                    }
                }
            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            string search_query = @"
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
                                        Timesheet.EmployeePrivateID = Employees.PrivateID
                                    WHERE 1=1";
            if (is_selcet_id)
            {
                search_query += " AND Timesheet.EmployeePrivateID = @ID";
            }
            if (is_select_date)
            {
                search_query += " AND Timesheet.Date = @Date";
            }
            if (is_select_month)
            {
                search_query += " AND strftime('%m', Timesheet.Date) = @Month";
            }
            if (is_select_name)
            {
                search_query += " AND Employees.Name LIKE @Name";
            }

            Debug.WriteLine($"Query: {search_query}");
            LoadDataFromDatabase(search_query, "search");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tb_s_date.Text = monthCalendar1.SelectionStart.ToString("dd/MM/yyyy");
        }

        private void bt_s_month_Click(object sender, EventArgs e)
        {
            if (is_select_date)
            {
                MessageBox.Show("Only date or month select in the time");
            }
            else
            {
                if (!is_select_month)
                {
                    is_select_month = true;
                    bt_s_month.BackColor = Color.FromArgb(143, 228, 143);
                }
                else
                {
                    is_select_month = false;
                    bt_s_month.BackColor = Color.Transparent;
                }
            }
        }

        private void bt_s_date_Click(object sender, EventArgs e)
        {
            if (is_select_month)
            {
                MessageBox.Show("Only date or month select in the time");
            }
            else
            {
                if (is_select_date)
                {
                    is_select_date = false;
                    bt_s_date.BackColor = Color.Transparent;
                }
                else
                {
                    is_select_date = true;
                    bt_s_date.BackColor = Color.FromArgb(143, 228, 143);
                }
            }
        }

        private void bt_s_name_Click(object sender, EventArgs e)
        {
            if (is_selcet_id)
            {
                MessageBox.Show("Only name or id select in the time");
            }
            else
            {
                if (is_select_name)
                {
                    is_select_name = false;
                    bt_s_name.BackColor = Color.Transparent;
                }
                else
                {
                    is_select_name = true;
                    bt_s_name.BackColor = Color.FromArgb(143, 228, 143);
                }
            }
        }

        private void bt_s_id_Click(object sender, EventArgs e)
        {
            if (is_select_name)
            {
                MessageBox.Show("Only name or id select in the time");
            }
            else
            {
                if (is_selcet_id)
                {
                    is_selcet_id = false;
                    bt_s_id.BackColor = Color.Transparent;
                }
                else
                {
                    is_selcet_id = true;
                    bt_s_id.BackColor = Color.FromArgb(143, 228, 143);
                }
            }
        }
        private void ExportDataGridViewToExcel(DataGridView dataGridView, string filePath)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            // Initialize the Excel package
            using (ExcelPackage excel = new ExcelPackage())
            {
                // Create a worksheet
                var worksheet = excel.Workbook.Worksheets.Add("Data");

                // Add column headers
                for (int col = 0; col < dataGridView.Columns.Count; col++)
                {
                    worksheet.Cells[1, col + 1].Value = dataGridView.Columns[col].HeaderText;
                }

                // Add row data
                for (int row = 0; row < dataGridView.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView.Columns.Count; col++)
                    {
                        // Avoid adding empty rows (if AllowUserToAddRows is true)
                        if (dataGridView.Rows[row].IsNewRow) continue;

                        worksheet.Cells[row + 2, col + 1].Value = dataGridView.Rows[row].Cells[col].Value;
                    }
                }

                // Save the Excel file
                FileInfo excelFile = new FileInfo(filePath);
                excel.SaveAs(excelFile);

                MessageBox.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void bt_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Save an Excel File"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportDataGridViewToExcel(dataGridView1, filePath);
            }
        }
    }
}
