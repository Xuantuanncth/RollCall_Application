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
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ScrollBar;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 120);
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
            button1.Location = new Point(134, 451);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(138, 46);
            button1.TabIndex = 1;
            button1.Text = "Avatar";
            button1.UseVisualStyleBackColor = false;
            // 
            // add_username
            // 
            add_username.BorderStyle = BorderStyle.None;
            add_username.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_username.Location = new Point(143, 155);
            add_username.Name = "add_username";
            add_username.Size = new Size(351, 26);
            add_username.TabIndex = 2;
            // 
            // add_class
            // 
            add_class.BorderStyle = BorderStyle.None;
            add_class.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_class.Location = new Point(142, 228);
            add_class.Name = "add_class";
            add_class.Size = new Size(351, 26);
            add_class.TabIndex = 3;
            // 
            // add_id
            // 
            add_id.BorderStyle = BorderStyle.None;
            add_id.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_id.Location = new Point(143, 92);
            add_id.Name = "add_id";
            add_id.Size = new Size(351, 26);
            add_id.TabIndex = 4;
            add_id.TextChanged += add_id_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 57);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 5;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 131);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 6;
            label2.Text = "Student Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 204);
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
            button2.Location = new Point(142, 468);
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
            add_finish.Location = new Point(357, 549);
            add_finish.Name = "add_finish";
            add_finish.Size = new Size(136, 52);
            add_finish.TabIndex = 9;
            add_finish.Text = "ADD";
            add_finish.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(143, 316);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(353, 132);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 277);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 11;
            label4.Text = "Description";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 238, 249);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(add_username);
            panel1.Controls.Add(add_class);
            panel1.Controls.Add(add_finish);
            panel1.Controls.Add(add_id);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(417, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 681);
            panel1.TabIndex = 12;
            // 
            // Information
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 215, 228);
            ClientSize = new Size(1041, 681);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Information";
            Text = "Information";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private RichTextBox richTextBox1;
        private Label label4;
        private Panel panel1;
    }
}