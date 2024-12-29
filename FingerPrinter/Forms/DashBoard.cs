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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Debug.Write("Dashboard loaded");
            DisplayDateTime();
        }

        private void DisplayDateTime()
        {
            // Get current date and time
            DateTime now = DateTime.Now;

            // Format the date and display it in the label
            lb_date.Text = now.ToString("MMMM dd, yyyy"); // Example: January 01, 2024
            // You can use other formats as needed:
            // now.ToString("d") - Short date format
            // now.ToString("D") - Long date format
            // now.ToString("MM/dd/yyyy") - Another common format

            // Get the day of the week and display it
            lb_day.Text = now.DayOfWeek.ToString();

            //Optional: Display time as well
            //lb_time.Text = now.ToString("hh:mm:ss tt"); // Example: 03:30:45 PM
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //timer1.Start(); // Start the timer when the form loads
            Debug.Write("Dashboard loaded");
        }

        private void bt_back_Click(object sender, EventArgs e)
        {

        }
    }
}
