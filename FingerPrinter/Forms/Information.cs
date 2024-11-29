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

namespace FingerPrinter.Forms
{
    public partial class Information : Form
    {

        private string avatar_Path = string.Empty;
        private int currentOffset = 0;
        private const int Pagesize = 6;
        private string employee_db_path = Main.employeeDatabase;
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
            Debug.WriteLine("Path of avatar: ", ofd.FileName);
        }


        public bool InsertDataIntoDatabase(string name, string employee_id, string department, string avatarPath, string description)
        {
            string connectionString = $"Data Source={employee_db_path};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand("INSERT INTO Employees (Name, PrivateID, Department, AvatarPath, Description) VALUES (@Name,@PrivateID, @Department, @FingerprinterId, @AvatarPath, @Description)", connection);

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
                        Debug.WriteLine("Data inserted successfully!");
                        return true;
                    }
                    else
                    {
                        Debug.WriteLine("Error inserting data.");
                        return false;
                    }
                }
                catch (SQLiteException ex)
                {
                    Debug.WriteLine("Error: " + ex.Message);
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
                }
                else if (control is System.Windows.Forms.TextBox textbox)
                {
                    textbox.Text = address;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
