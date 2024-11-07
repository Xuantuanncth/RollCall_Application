using FingerPrinter.Forms;
using FingerPrinter.Properties;
using System.Security.Cryptography.X509Certificates;

namespace FingerPrinter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Program.IsLoggedIn)
            {
                Console.WriteLine("This is debug");
                label_notification.Text = "Please Login :)";
                SetControlsEnabled(false);
                statusOfDevice(false);
            }
        }

        public void enableApplication()
        {
            SetControlsEnabled(true);
            label_notification.Text = "";
            Dashboard dashboard_section = new Dashboard();
            dashboard_section.TopLevel = false;
            main_panel.Controls.Clear();
            main_panel.Controls.Add(dashboard_section);
            dashboard_section.Dock = DockStyle.Fill;
            dashboard_section.Show();

        }
        private void statusOfDevice(bool isConnected)
        {
            if (isConnected)
            {
                text_status.Text = "Connected";
                //pb_status.Image = 
            }
            else
            {
                text_status.Text = "Disconnected";
                //pb_status.Image = Image.FromFile("../Icon/disconnected.png");
            }
        }
        private void SetControlsEnabled(bool isEnabled)
        {
            btn_addInfor.Enabled = isEnabled;
            btn_setting.Enabled = isEnabled;
            btn_report.Enabled = isEnabled;
            btn_timesheet.Enabled = isEnabled;
            btn_timeoff.Enabled = isEnabled;
            btn_dashboard.Enabled = isEnabled;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login_section = new Login();
            login_section.Show();
        }

        private void btn_addInfor_Click(object sender, EventArgs e)
        {
            Information add_information = new Information();
            add_information.TopLevel = false;
            main_panel.Controls.Clear();
            main_panel.Controls.Add(add_information);
            add_information.Dock = DockStyle.Fill;
            add_information.Show();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            Setting add_setting = new Setting();
            add_setting.TopLevel = false;
            main_panel.Controls.Clear();
            main_panel.Controls.Add(add_setting);
            add_setting.Dock = DockStyle.Fill;
            add_setting.Show();
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard_section = new Dashboard();
            dashboard_section.TopLevel = false;
            main_panel.Controls.Clear();
            main_panel.Controls.Add(dashboard_section);
            dashboard_section.Dock = DockStyle.Fill;
            dashboard_section.Show();
        }
    }
}
