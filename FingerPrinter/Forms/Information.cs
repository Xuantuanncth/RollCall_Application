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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FingerPrinter.Forms
{
    public partial class Information : Form
    {
        private string avatar_Path;
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


        public bool InsertDataIntoDatabase(string name, string student_id, string className, string fingerprintId, string avatarPath, string description)
        {
            string connectionString = "Data Source=Student.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand("INSERT INTO Students (Name, PrivateID, Class, FingerprinterId, AvatarPath, Description) VALUES (@Name,@PrivateID, @Class, @FingerprinterId, @AvatarPath, @Description)", connection);

                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@PrivateID", student_id);
                command.Parameters.AddWithValue("@Class", className);
                command.Parameters.AddWithValue("@FingerprinterId", fingerprintId);
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
            if (isFillData)
            {
                string id = add_id.Text;
                string name = add_username.Text;
                string st_class = add_class.Text;
                string st_discription = tb_description.Text;
                string avatar_path = avatar_Path != string.Empty ? avatar_Path : Program.imagePath + "/avatar.png";


                bool isInsertData = InsertDataIntoDatabase(name, id, st_class, "1", avatar_path, st_discription);
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
            string connectionString = "Data Source=Student.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Students", connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                // Access the desired columns
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                string name = row.Cells["Name"].Value.ToString();
                string className = row.Cells["Class"].Value.ToString();
                string description = row.Cells["Description"].Value.ToString();
                string avatar_info_path = row.Cells["AvatarPath"].Value.ToString();

                // Do something with the retrieved data, e.g., display in a TextBox:
                lb_infor_class.Text = className;
                lb_info_name.Text = name;
                lb_info_descripton.Text = description;
                pb_infor_avatar.Image = Image.FromFile(avatar_info_path);
                pb_infor_avatar.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }
    }
}
