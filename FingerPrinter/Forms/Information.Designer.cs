namespace FingerPrinter.Forms
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            add_username = new TextBox();
            add_class = new TextBox();
            add_id = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            add_finish = new Button();
            add_status = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ScrollBar;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 121);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 303);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(253, 110, 33);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(152, 460);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(138, 46);
            button1.TabIndex = 1;
            button1.Text = "Avatar";
            button1.UseVisualStyleBackColor = false;
            // 
            // add_username
            // 
            add_username.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_username.Location = new Point(441, 218);
            add_username.Name = "add_username";
            add_username.Size = new Size(351, 33);
            add_username.TabIndex = 2;
            // 
            // add_class
            // 
            add_class.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_class.Location = new Point(441, 301);
            add_class.Name = "add_class";
            add_class.Size = new Size(351, 33);
            add_class.TabIndex = 3;
            // 
            // add_id
            // 
            add_id.BorderStyle = BorderStyle.None;
            add_id.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_id.Location = new Point(441, 145);
            add_id.Name = "add_id";
            add_id.Size = new Size(351, 26);
            add_id.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(443, 114);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 5;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(446, 190);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 6;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(443, 268);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 7;
            label3.Text = "Class";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(254, 206, 181);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(448, 373);
            button2.Name = "button2";
            button2.Size = new Size(117, 133);
            button2.TabIndex = 8;
            button2.Text = "FingerPrinter";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            // 
            // add_finish
            // 
            add_finish.BackColor = Color.FromArgb(128, 153, 255);
            add_finish.FlatAppearance.BorderSize = 0;
            add_finish.FlatStyle = FlatStyle.Flat;
            add_finish.Location = new Point(656, 454);
            add_finish.Name = "add_finish";
            add_finish.Size = new Size(136, 52);
            add_finish.TabIndex = 9;
            add_finish.Text = "ADD";
            add_finish.UseVisualStyleBackColor = false;
            // 
            // add_status
            // 
            add_status.AutoSize = true;
            add_status.BackColor = Color.White;
            add_status.Location = new Point(693, 382);
            add_status.Name = "add_status";
            add_status.Size = new Size(52, 21);
            add_status.TabIndex = 10;
            add_status.Text = "Done";
            // 
            // Information
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 215, 228);
            ClientSize = new Size(1041, 681);
            Controls.Add(add_status);
            Controls.Add(add_finish);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(add_id);
            Controls.Add(add_class);
            Controls.Add(add_username);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Information";
            Text = "Information";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private TextBox add_username;
        private TextBox add_class;
        private TextBox add_id;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button add_finish;
        private Label add_status;
    }
}