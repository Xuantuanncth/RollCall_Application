namespace FingerPrinter
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            label2 = new Label();
            btn_addInfor = new Button();
            btn_setting = new Button();
            btn_report = new Button();
            btn_timeoff = new Button();
            btn_timesheet = new Button();
            btn_dashboard = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            text_status = new Label();
            pb_status = new PictureBox();
            lable_Tag = new Label();
            btn_login = new Button();
            main_panel = new Panel();
            label_notification = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_status).BeginInit();
            main_panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 768);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(244, 246, 250);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btn_addInfor);
            panel4.Controls.Add(btn_setting);
            panel4.Controls.Add(btn_report);
            panel4.Controls.Add(btn_timeoff);
            panel4.Controls.Add(btn_timesheet);
            panel4.Controls.Add(btn_dashboard);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(206, 768);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Location = new Point(206, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(399, 194);
            panel3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.OutlineButton;
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(69, 54);
            label4.Name = "label4";
            label4.Size = new Size(94, 32);
            label4.TabIndex = 8;
            label4.Text = "ollCall";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(253, 110, 33);
            label2.Location = new Point(12, 8);
            label2.Name = "label2";
            label2.Size = new Size(79, 90);
            label2.TabIndex = 7;
            label2.Text = "R";
            // 
            // btn_addInfor
            // 
            btn_addInfor.FlatAppearance.BorderSize = 0;
            btn_addInfor.FlatStyle = FlatStyle.Flat;
            btn_addInfor.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_addInfor.Image = (Image)resources.GetObject("btn_addInfor.Image");
            btn_addInfor.Location = new Point(0, 163);
            btn_addInfor.Name = "btn_addInfor";
            btn_addInfor.Size = new Size(206, 56);
            btn_addInfor.TabIndex = 6;
            btn_addInfor.Text = "   Add Infor";
            btn_addInfor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_addInfor.UseVisualStyleBackColor = true;
            btn_addInfor.Click += btn_addInfor_Click;
            // 
            // btn_setting
            // 
            btn_setting.FlatAppearance.BorderSize = 0;
            btn_setting.FlatStyle = FlatStyle.Flat;
            btn_setting.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_setting.Image = (Image)resources.GetObject("btn_setting.Image");
            btn_setting.Location = new Point(0, 709);
            btn_setting.Name = "btn_setting";
            btn_setting.Size = new Size(206, 56);
            btn_setting.TabIndex = 5;
            btn_setting.Text = "   Setting";
            btn_setting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_setting.UseVisualStyleBackColor = true;
            btn_setting.Click += btn_setting_Click;
            // 
            // btn_report
            // 
            btn_report.FlatAppearance.BorderSize = 0;
            btn_report.FlatStyle = FlatStyle.Flat;
            btn_report.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_report.Image = (Image)resources.GetObject("btn_report.Image");
            btn_report.Location = new Point(0, 349);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(206, 56);
            btn_report.TabIndex = 4;
            btn_report.Text = "   Report";
            btn_report.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_report.UseVisualStyleBackColor = true;
            // 
            // btn_timeoff
            // 
            btn_timeoff.FlatAppearance.BorderSize = 0;
            btn_timeoff.FlatStyle = FlatStyle.Flat;
            btn_timeoff.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_timeoff.Image = (Image)resources.GetObject("btn_timeoff.Image");
            btn_timeoff.Location = new Point(0, 287);
            btn_timeoff.Name = "btn_timeoff";
            btn_timeoff.Size = new Size(206, 56);
            btn_timeoff.TabIndex = 3;
            btn_timeoff.Text = "   Time Off";
            btn_timeoff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_timeoff.UseVisualStyleBackColor = true;
            // 
            // btn_timesheet
            // 
            btn_timesheet.FlatAppearance.BorderSize = 0;
            btn_timesheet.FlatStyle = FlatStyle.Flat;
            btn_timesheet.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_timesheet.Image = (Image)resources.GetObject("btn_timesheet.Image");
            btn_timesheet.Location = new Point(0, 225);
            btn_timesheet.Name = "btn_timesheet";
            btn_timesheet.Size = new Size(206, 56);
            btn_timesheet.TabIndex = 2;
            btn_timesheet.Text = "   TimeSheet";
            btn_timesheet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_timesheet.UseVisualStyleBackColor = true;
            // 
            // btn_dashboard
            // 
            btn_dashboard.FlatAppearance.BorderSize = 0;
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_dashboard.Image = (Image)resources.GetObject("btn_dashboard.Image");
            btn_dashboard.Location = new Point(0, 101);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(206, 56);
            btn_dashboard.TabIndex = 1;
            btn_dashboard.Text = "   DashBoard";
            btn_dashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_dashboard.UseVisualStyleBackColor = true;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(0, 163);
            button2.Name = "button2";
            button2.Size = new Size(206, 56);
            button2.TabIndex = 2;
            button2.Text = "   DashBoard";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 101);
            button1.Name = "button1";
            button1.Size = new Size(206, 56);
            button1.TabIndex = 1;
            button1.Text = "   DashBoard";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 19);
            label1.Name = "label1";
            label1.Size = new Size(125, 81);
            label1.TabIndex = 0;
            label1.Text = "RollCall";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(244, 246, 250);
            panel2.Controls.Add(text_status);
            panel2.Controls.Add(pb_status);
            panel2.Controls.Add(lable_Tag);
            panel2.Controls.Add(btn_login);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(206, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1074, 87);
            panel2.TabIndex = 1;
            // 
            // text_status
            // 
            text_status.AutoSize = true;
            text_status.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text_status.Location = new Point(880, 32);
            text_status.Name = "text_status";
            text_status.Size = new Size(96, 19);
            text_status.TabIndex = 4;
            text_status.Text = "Connected";
            // 
            // pb_status
            // 
            pb_status.Image = (Image)resources.GetObject("pb_status.Image");
            pb_status.Location = new Point(841, 26);
            pb_status.Name = "pb_status";
            pb_status.Size = new Size(33, 31);
            pb_status.TabIndex = 3;
            pb_status.TabStop = false;
            // 
            // lable_Tag
            // 
            lable_Tag.AutoSize = true;
            lable_Tag.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lable_Tag.ForeColor = Color.FromArgb(253, 110, 33);
            lable_Tag.Location = new Point(18, 32);
            lable_Tag.Name = "lable_Tag";
            lable_Tag.Size = new Size(158, 28);
            lable_Tag.TabIndex = 1;
            lable_Tag.Text = "DASHBOARD";
            // 
            // btn_login
            // 
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Image = (Image)resources.GetObject("btn_login.Image");
            btn_login.Location = new Point(993, 12);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(69, 62);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // main_panel
            // 
            main_panel.BackColor = Color.FromArgb(216, 215, 228);
            main_panel.Controls.Add(label_notification);
            main_panel.Dock = DockStyle.Fill;
            main_panel.Location = new Point(206, 87);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1074, 681);
            main_panel.TabIndex = 2;
            main_panel.Paint += main_panel_Paint;
            // 
            // label_notification
            // 
            label_notification.AutoSize = true;
            label_notification.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_notification.Location = new Point(450, 239);
            label_notification.Name = "label_notification";
            label_notification.Size = new Size(0, 42);
            label_notification.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1280, 768);
            Controls.Add(main_panel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Main";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_status).EndInit();
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel main_panel;
        private Label label1;
        private Button button1;
        private Panel panel4;
        private Button btn_report;
        private Button btn_timeoff;
        private Button btn_timesheet;
        private Button btn_dashboard;
        private Button button2;
        private Label lable_Tag;
        private Button btn_login;
        private Button btn_addInfor;
        private Button btn_setting;
        private Label label2;
        private Label label4;
        private Label text_status;
        private PictureBox pb_status;
        private Panel panel3;
        private Label label_notification;
    }
}
