namespace FingerPrinter.Forms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel_header = new Panel();
            lb_date = new Label();
            lb_day = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel_main = new Panel();
            panel_3 = new Panel();
            status_3 = new Label();
            lb_name_3 = new Label();
            avatar_3 = new PictureBox();
            panel_2 = new Panel();
            status_2 = new Label();
            lb_name_2 = new Label();
            avatar_2 = new PictureBox();
            panel_1 = new Panel();
            status_1 = new Label();
            lb_name_1 = new Label();
            avatar_1 = new PictureBox();
            panel4 = new Panel();
            bt_back = new Button();
            panel5 = new Panel();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel_header.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_main.SuspendLayout();
            panel_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatar_3).BeginInit();
            panel_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatar_2).BeginInit();
            panel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatar_1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel_header
            // 
            panel_header.BackColor = Color.White;
            panel_header.Controls.Add(lb_date);
            panel_header.Controls.Add(lb_day);
            panel_header.Controls.Add(panel2);
            panel_header.Dock = DockStyle.Top;
            panel_header.Location = new Point(0, 0);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(1074, 198);
            panel_header.TabIndex = 0;
            // 
            // lb_date
            // 
            lb_date.AutoSize = true;
            lb_date.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_date.Location = new Point(86, 117);
            lb_date.Name = "lb_date";
            lb_date.Size = new Size(228, 30);
            lb_date.TabIndex = 2;
            lb_date.Text = "December 4, 2024";
            // 
            // lb_day
            // 
            lb_day.AutoSize = true;
            lb_day.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_day.Location = new Point(86, 73);
            lb_day.Name = "lb_day";
            lb_day.Size = new Size(231, 44);
            lb_day.TabIndex = 1;
            lb_day.Text = "Wednesday";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(244, 246, 246);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(709, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 170);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 92);
            label2.Name = "label2";
            label2.Size = new Size(28, 21);
            label2.TabIndex = 2;
            label2.Text = "30";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 61);
            label1.Name = "label1";
            label1.Size = new Size(148, 22);
            label1.TabIndex = 1;
            label1.Text = "Total Employee";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(174, 214, 241);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(183, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel_main
            // 
            panel_main.Controls.Add(panel_3);
            panel_main.Controls.Add(panel_2);
            panel_main.Controls.Add(panel_1);
            panel_main.Location = new Point(94, 198);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(873, 483);
            panel_main.TabIndex = 1;
            // 
            // panel_3
            // 
            panel_3.Controls.Add(status_3);
            panel_3.Controls.Add(lb_name_3);
            panel_3.Controls.Add(avatar_3);
            panel_3.Location = new Point(615, 123);
            panel_3.Name = "panel_3";
            panel_3.Size = new Size(200, 279);
            panel_3.TabIndex = 1;
            // 
            // status_3
            // 
            status_3.AutoSize = true;
            status_3.Location = new Point(71, 244);
            status_3.Name = "status_3";
            status_3.Size = new Size(57, 21);
            status_3.TabIndex = 3;
            status_3.Text = "label5";
            // 
            // lb_name_3
            // 
            lb_name_3.AutoSize = true;
            lb_name_3.Location = new Point(71, 212);
            lb_name_3.Name = "lb_name_3";
            lb_name_3.Size = new Size(57, 21);
            lb_name_3.TabIndex = 2;
            lb_name_3.Text = "label5";
            // 
            // avatar_3
            // 
            avatar_3.Location = new Point(0, 3);
            avatar_3.Name = "avatar_3";
            avatar_3.Size = new Size(197, 188);
            avatar_3.TabIndex = 1;
            avatar_3.TabStop = false;
            // 
            // panel_2
            // 
            panel_2.Controls.Add(status_2);
            panel_2.Controls.Add(lb_name_2);
            panel_2.Controls.Add(avatar_2);
            panel_2.Location = new Point(347, 123);
            panel_2.Name = "panel_2";
            panel_2.Size = new Size(200, 279);
            panel_2.TabIndex = 1;
            // 
            // status_2
            // 
            status_2.AutoSize = true;
            status_2.Location = new Point(63, 244);
            status_2.Name = "status_2";
            status_2.Size = new Size(57, 21);
            status_2.TabIndex = 3;
            status_2.Text = "label5";
            // 
            // lb_name_2
            // 
            lb_name_2.AutoSize = true;
            lb_name_2.Location = new Point(63, 212);
            lb_name_2.Name = "lb_name_2";
            lb_name_2.Size = new Size(57, 21);
            lb_name_2.TabIndex = 2;
            lb_name_2.Text = "label5";
            // 
            // avatar_2
            // 
            avatar_2.Location = new Point(0, 3);
            avatar_2.Name = "avatar_2";
            avatar_2.Size = new Size(197, 188);
            avatar_2.TabIndex = 1;
            avatar_2.TabStop = false;
            // 
            // panel_1
            // 
            panel_1.Controls.Add(status_1);
            panel_1.Controls.Add(lb_name_1);
            panel_1.Controls.Add(avatar_1);
            panel_1.Location = new Point(97, 123);
            panel_1.Name = "panel_1";
            panel_1.Size = new Size(200, 279);
            panel_1.TabIndex = 0;
            // 
            // status_1
            // 
            status_1.AutoSize = true;
            status_1.Location = new Point(69, 247);
            status_1.Name = "status_1";
            status_1.Size = new Size(57, 21);
            status_1.TabIndex = 2;
            status_1.Text = "label5";
            // 
            // lb_name_1
            // 
            lb_name_1.AutoSize = true;
            lb_name_1.Location = new Point(69, 212);
            lb_name_1.Name = "lb_name_1";
            lb_name_1.Size = new Size(57, 21);
            lb_name_1.TabIndex = 1;
            lb_name_1.Text = "label5";
            // 
            // avatar_1
            // 
            avatar_1.Location = new Point(3, 3);
            avatar_1.Name = "avatar_1";
            avatar_1.Size = new Size(197, 188);
            avatar_1.TabIndex = 0;
            avatar_1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(bt_back);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 198);
            panel4.Name = "panel4";
            panel4.Size = new Size(96, 483);
            panel4.TabIndex = 2;
            // 
            // bt_back
            // 
            bt_back.Dock = DockStyle.Fill;
            bt_back.FlatAppearance.BorderSize = 0;
            bt_back.FlatStyle = FlatStyle.Flat;
            bt_back.Image = (Image)resources.GetObject("bt_back.Image");
            bt_back.Location = new Point(0, 0);
            bt_back.Name = "bt_back";
            bt_back.Size = new Size(96, 483);
            bt_back.TabIndex = 0;
            bt_back.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_back.UseVisualStyleBackColor = true;
            bt_back.Click += bt_back_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button1);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(968, 198);
            panel5.Name = "panel5";
            panel5.Size = new Size(106, 483);
            panel5.TabIndex = 3;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(106, 483);
            button1.TabIndex = 0;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 245, 251);
            ClientSize = new Size(1074, 681);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel_header);
            Controls.Add(panel_main);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Dashboard";
            Text = "Dashboard";
            panel_header.ResumeLayout(false);
            panel_header.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_main.ResumeLayout(false);
            panel_3.ResumeLayout(false);
            panel_3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avatar_3).EndInit();
            panel_2.ResumeLayout(false);
            panel_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avatar_2).EndInit();
            panel_1.ResumeLayout(false);
            panel_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avatar_1).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_header;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label lb_date;
        private Label lb_day;
        private Panel panel_main;
        private Panel panel4;
        private Button bt_back;
        private Panel panel5;
        private Button button1;
        private Panel panel_3;
        private Panel panel_2;
        private Panel panel_1;
        private Label status_3;
        private Label lb_name_3;
        private PictureBox avatar_3;
        private Label status_2;
        private Label lb_name_2;
        private PictureBox avatar_2;
        private Label status_1;
        private Label lb_name_1;
        private PictureBox avatar_1;
        private System.Windows.Forms.Timer timer1;
    }
}