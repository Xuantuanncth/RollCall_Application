using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace FingerPrinter.Forms
{
    public partial class Setting : Form
    {
        private SerialPort serialPort = new SerialPort();
        private bool isOpenSerialPort = false;
        public Setting()
        {
            string[] portNames = SerialPort.GetPortNames();
            InitializeComponent();
            cb_portName.Items.AddRange(portNames);

        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)Application.OpenForms["Main"];

            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = cb_portName.Text;
                    int baudRate = int.Parse(cb_baudrate.SelectedItem.ToString());
                    serialPort.BaudRate = baudRate;
                    serialPort.Parity = Parity.None;
                    serialPort.DataBits = 8;
                    serialPort.StopBits = StopBits.One;


                    serialPort.Open();
                    serialPort.WriteLine("*#Ok#");
                    Program.isConnectedDevice = true;
                    mainForm.statusOfDevice(true);
                    bt_connect.Text = "Disconnect";
                }
                else {
                    serialPort.Close();
                    bt_connect.Text = "Connect";
                    mainForm.statusOfDevice(false);
                }
            } 
            catch(Exception ex) 
            {
                MessageBox.Show("Cannot connect the Serial Port");
            }
        }
    }
}
