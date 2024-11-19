namespace FingerPrinter.Forms
{
    partial class Setting
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            cb_baudrate = new ComboBox();
            cb_portName = new ComboBox();
            bt_connect = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cb_baudrate);
            panel1.Controls.Add(cb_portName);
            panel1.Controls.Add(bt_connect);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 681);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 166);
            label3.Name = "label3";
            label3.Size = new Size(85, 24);
            label3.TabIndex = 5;
            label3.Text = "Baudrate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 102);
            label2.Name = "label2";
            label2.Size = new Size(54, 24);
            label2.TabIndex = 4;
            label2.Text = "COM";
            // 
            // cb_baudrate
            // 
            cb_baudrate.FormattingEnabled = true;
            cb_baudrate.Items.AddRange(new object[] { "9600", "115200" });
            cb_baudrate.Location = new Point(21, 191);
            cb_baudrate.Name = "cb_baudrate";
            cb_baudrate.Size = new Size(191, 32);
            cb_baudrate.TabIndex = 3;
            // 
            // cb_portName
            // 
            cb_portName.FormattingEnabled = true;
            cb_portName.Location = new Point(21, 127);
            cb_portName.Name = "cb_portName";
            cb_portName.Size = new Size(191, 32);
            cb_portName.TabIndex = 2;
            // 
            // bt_connect
            // 
            bt_connect.Location = new Point(232, 127);
            bt_connect.Name = "bt_connect";
            bt_connect.Size = new Size(119, 94);
            bt_connect.TabIndex = 1;
            bt_connect.Text = "Connect";
            bt_connect.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_connect.UseVisualStyleBackColor = true;
            bt_connect.Click += bt_connect_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(216, 215, 228);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 94);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(253, 110, 33);
            label1.Location = new Point(61, 31);
            label1.Name = "label1";
            label1.Size = new Size(221, 31);
            label1.TabIndex = 0;
            label1.Text = "Connect Device";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(194, 195, 201);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(357, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(717, 94);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(245, 31);
            label4.Name = "label4";
            label4.Size = new Size(233, 33);
            label4.TabIndex = 0;
            label4.Text = "Account Setting";
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 681);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Setting";
            Text = "Setting";
            Load += Setting_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bt_connect;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label2;
        private ComboBox cb_baudrate;
        private ComboBox cb_portName;
        private Panel panel3;
        private Label label4;
    }
}