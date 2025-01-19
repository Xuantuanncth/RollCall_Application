using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NLog;

namespace FingerPrinter.Forms
{
    public partial class Information : Form
    {

        private string avatar_Path = string.Empty;
        private int currentOffset = 0;
        private const int Pagesize = 6;
        private string employee_db_path = Main.employeeDatabase;
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public Information()
        {
            InitializeComponent();
            LoadDataFromDatabase();
        }


        private void bt_addPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            ofd.Title = "Select images ";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb_avatar.Image = Image.FromFile(ofd.FileName);
                pb_avatar.SizeMode = PictureBoxSizeMode.Zoom;
                avatar_Path = ofd.FileName;
            }
            Logger.Info("Path of avatar: " + ofd.FileName);
        }


        public bool InsertDataIntoDatabase(string name, string employee_id, string department, string avatarPath, string description)
        {
            string connectionString = $"Data Source={employee_db_path};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(
                    "INSERT INTO Employees (" +
                        "Name, " +
                        "PrivateID, " +
                        "Department, " +
                        "AvatarPath, " +
                        "Description) " +
                    "VALUES (" +
                        "@Name," +
                        "@PrivateID, " +
                        "@Department, " +
                        "@AvatarPath, " +
                        "@Description)",
                connection);

                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@PrivateID", employee_id);
                command.Parameters.AddWithValue("@Department", department);
                command.Parameters.AddWithValue("@AvatarPath", avatarPath);
                command.Parameters.AddWithValue("@Description", description);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Logger.Info("Data inserted successfully!");
                        return true;
                    }
                    else
                    {
                        Logger.Info("Error inserting data.");
                        return false;
                    }
                }
                catch (SQLiteException ex)
                {
                    Logger.Info("Error: " + ex.Message);
                    return false;
                }
            }
        }
        private void add_finish_Click(object sender, EventArgs e)
        {
            bool isFillData = add_id.Text != string.Empty ? (add_class.Text != string.Empty ? (add_username.Text != string.Empty ? (tb_description.Text != string.Empty ? true : false) : false) : false) : false;

            string internalFolder = Path.Combine(Application.StartupPath, "Avatars");
            if (!Directory.Exists(internalFolder))
            {
                Directory.CreateDirectory(internalFolder);
            }

            if (isFillData)
            {
                string id = add_id.Text;
                string name = add_username.Text;
                string st_department = add_class.Text;
                string st_discription = tb_description.Text;
                string avatar_path = avatar_Path != string.Empty ? avatar_Path : Program.imagePath + "/avatar.png";
                string fileName = Path.GetFileName(avatar_path);
                string internalAvatarPath = Path.Combine(internalFolder, fileName);

                try
                {
                    File.Copy(avatar_path, internalAvatarPath, overwrite: true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to copy avatar: {ex.Message}");
                    return;
                }

                bool isInsertData = InsertDataIntoDatabase(name, id, st_department, internalAvatarPath, st_discription);
                if (isInsertData)
                {
                    MessageBox.Show("Add data successfully");
                    clear_all_data();
                }
                else
                {
                    MessageBox.Show("Cannot add data, please try again");
                }
            }
            else
            {
                MessageBox.Show("Please fill all data");
            }
        }

        private void clear_all_data()
        {
            add_class.Text = string.Empty;
            add_id.Text = string.Empty;
            add_username.Text = string.Empty;
            tb_description.Text = string.Empty;
            pb_avatar.Image = Image.FromFile(Program.imagePath + "/avatar.png");
            pb_avatar.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        public void LoadDataFromDatabase()
        {
            string connectionString = $"Data Source={employee_db_path};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT * FROM employees LIMIT {Pagesize} OFFSET {currentOffset * Pagesize}";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        int panelIndex = 0;

                        ClearPanel();
                        while (reader.Read() && panelIndex < Pagesize)
                        {
                            string id = reader["PrivateID"].ToString();
                            string name = reader["Name"].ToString();
                            string employeeClass = reader["Department"].ToString();
                            string avatarPath = reader["AvatarPath"].ToString();
                            string address = reader["Description"].ToString();

                            LoadPanel(panelIndex, id, name, employeeClass, avatarPath, address);
                            panelIndex++;
                        }

                        // Enable or disable the "Next" button
                        bt_next.Enabled = panelIndex == Pagesize;
                        lb_count_page.Text = (currentOffset + 1).ToString();
                    }
                }


            }
        }

        private void ClearPanel()
        {
            for (int i = 0; i < Pagesize; i++)
            {
                var panel = this.Controls.Find($"panel{i + 1}", true)[0];
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
                    if (control is System.Windows.Forms.TextBox textbox)
                    {
                        textbox.Text = "";
                    }
                    if (control is System.Windows.Forms.Button button)
                    {
                        button.Visible = false;
                        button.Enabled = false;
                    }
                }
            }
        }

        private void LoadPanel(int index, string id, string name, string department, string avatarPath, string address)
        {
            var panel = this.Controls.Find($"panel{index + 1}", true)[0];
            foreach (var control in panel.Controls)
            {
                if (control is System.Windows.Forms.Label label)
                {
                    if (label.Name == $"lb_id{index + 1}")
                    {
                        label.Text = "ID: " + id;
                    }
                    else if (label.Name == $"lb_name{index + 1}")
                    {
                        label.Text = name;
                    }
                    else if (label.Name == $"lb_class{index + 1}")
                    {
                        label.Text = "Department: " + department;
                    }
                    else if (label.Name == $"lb_address{index + 1}")
                    {
                        label.Text = "Information";
                    }
                }
                else if (control is PictureBox picturebox)
                {
                    picturebox.Image = Image.FromFile(avatarPath);
                    picturebox.Tag = avatarPath;
                }
                else if (control is System.Windows.Forms.TextBox textbox)
                {
                    textbox.Text = address;
                }
                else if (control is System.Windows.Forms.Button button)
                {
                    button.Visible = true;
                    button.Enabled = true;
                }
            }
        }
        private void bt_next_Click(object sender, EventArgs e)
        {
            currentOffset += 1;
            LoadDataFromDatabase();
        }

        private void bt_previous_Click(object sender, EventArgs e)
        {
            if (currentOffset > 0)
            {
                currentOffset -= 1;
                LoadDataFromDatabase();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int empID = int.Parse(lb_id1.Text.Split(' ')[1]);
            string avt_path = pictureBox1.Tag?.ToString();
            Debug.Write($"ID: {empID}");
            DeleteEmployee(empID, avt_path);
        }

        private void DeleteEmployee(int employeeId, string avatar_path)
        {
            var confirmResult = MessageBox.Show(
                "Do you want to delete it?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                ExecuteDeleteEmployee(employeeId.ToString());
                DeleteAvatarFromPictureBox(avatar_path);
            }
        }

        private void DeleteAvatarFromPictureBox(string avatarPath)
        {
            if (!string.IsNullOrEmpty(avatarPath) && File.Exists(avatarPath))
            {
                try
                {
                    File.Delete(avatarPath);
                    MessageBox.Show("Avatar deleted successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to delete avatar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Avatar file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExecuteDeleteEmployee(string privateId)
        {
            string connectionString = $"Data Source={employee_db_path};Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                try
                {
                    // Delete the employee from the Employees table
                    string deleteEmployeeQuery = "DELETE FROM Employees WHERE PrivateID = @PrivateID";
                    using (var cmd = new SQLiteCommand(deleteEmployeeQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@PrivateID", privateId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee deleted successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            currentOffset = 0;
                            LoadDataFromDatabase();
                        }
                        else
                        {
                            MessageBox.Show("Employee not found for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int empID = int.Parse(lb_id2.Text.Split(' ')[1]);
            string avt_path = pictureBox2.Tag?.ToString();
            DeleteEmployee(empID, avt_path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int empID = int.Parse(lb_id3.Text.Split(' ')[1]);
            string avt_path = pictureBox3.Tag?.ToString();
            DeleteEmployee(empID, avt_path);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int empID = int.Parse(lb_id4.Text.Split(' ')[1]);
            string avt_path = pictureBox4.Tag?.ToString();
            DeleteEmployee(empID, avt_path);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int empID = int.Parse(lb_id5.Text.Split(' ')[1]);
            string avt_path = pictureBox5.Tag?.ToString();
            DeleteEmployee(empID, avt_path);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int empID = int.Parse(lb_id6.Text.Split(' ')[1]);
            string avt_path = pictureBox6.Tag?.ToString();
            DeleteEmployee(empID, avt_path);
        }
    }
}
