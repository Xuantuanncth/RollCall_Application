using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerPrinter.Forms
{
    public partial class TimeSheet : Form
    {
        public TimeSheet()
        {
            InitializeComponent();
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
    }
}
