using FingerPrinter.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerPrinter.Forms
{
    public partial class Setting : Form
    {
        private string databaseFolder = Path.Combine(Application.StartupPath, "Databases");
        public Setting()
        {
            string[] portNames = SerialManager.Instance.GetAvailablePortNames();
            InitializeComponent();
            cb_portName.Items.AddRange(portNames);

        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            Main? mainForm = (Main)Application.OpenForms["Main"];

            try
            {
                if (!Program.isConnectedDevice)
                {
                    int baudRate = 9600;
                    if (cb_baudrate.SelectedItem != null)
                    {
                        string selectedValue = cb_baudrate.SelectedItem?.ToString() ?? "0";
                        baudRate = int.Parse(selectedValue);
                    }

                    SerialManager.Instance.Connect(cb_portName.Text, baudRate);
                    SerialManager.Instance.SendCommand("*#OK#");
                    Program.isConnectedDevice = true;
                    mainForm.statusOfDevice(true);
                    bt_connect.Text = "Disconnect";
                }
                else
                {
                    SerialManager.Instance.Disconnect();
                    bt_connect.Text = "Connect";
                    Program.isConnectedDevice = false;
                    mainForm.statusOfDevice(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot connect the Serial Port");
                Debug.WriteLine("Error: ", ex);
            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            if (Program.isConnectedDevice)
            {
                cb_portName.Text = SerialManager.Instance.GetPortName();
                cb_baudrate.Text = SerialManager.Instance.GetBaudrate().ToString();
                bt_connect.Text = "Disconnect";
            }
        }

        private void bt_load_database_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(databaseFolder))
            {
                Directory.CreateDirectory(databaseFolder);
            }

            // Get all .db files in the folder
            string[] databaseFiles = Directory.GetFiles(databaseFolder, "*.db");

            // Clear existing items in ComboBox
            comboBox1.Items.Clear();

            // Add file names (without path) to ComboBox
            foreach (string file in databaseFiles)
            {
                comboBox1.Items.Add(Path.GetFileName(file));
            }

            // Select the first item by default if available
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }
    }
}
