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
            openFileDialog1 = new OpenFileDialog();
            tabPage2 = new TabPage();
            pb_avatar = new PictureBox();
            panel1 = new Panel();
            tb_description = new RichTextBox();
            label4 = new Label();
            add_username = new TextBox();
            add_class = new TextBox();
            add_finish = new Button();
            add_id = new TextBox();
            bt_fingerprinter = new Button();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            bt_addPicture = new Button();
            tabPage1 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            panel7 = new Panel();
            textBox6 = new TextBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            pictureBox6 = new PictureBox();
            panel6 = new Panel();
            textBox5 = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            pictureBox5 = new PictureBox();
            panel5 = new Panel();
            textBox4 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            textBox3 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            textBox2 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_avatar).BeginInit();
            panel1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pb_avatar);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(bt_addPicture);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1033, 648);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add user";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pb_avatar
            // 
            pb_avatar.BackColor = SystemColors.ScrollBar;
            pb_avatar.Image = (Image)resources.GetObject("pb_avatar.Image");
            pb_avatar.Location = new Point(77, 77);
            pb_avatar.Margin = new Padding(4);
            pb_avatar.Name = "pb_avatar";
            pb_avatar.Size = new Size(219, 288);
            pb_avatar.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_avatar.TabIndex = 0;
            pb_avatar.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 238, 249);
            panel1.Controls.Add(tb_description);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(add_username);
            panel1.Controls.Add(add_class);
            panel1.Controls.Add(add_finish);
            panel1.Controls.Add(add_id);
            panel1.Controls.Add(bt_fingerprinter);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(409, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(621, 642);
            panel1.TabIndex = 12;
            // 
            // tb_description
            // 
            tb_description.BorderStyle = BorderStyle.None;
            tb_description.Location = new Point(143, 316);
            tb_description.Name = "tb_description";
            tb_description.Size = new Size(353, 132);
            tb_description.TabIndex = 4;
            tb_description.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 277);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 11;
            label4.Text = "Address";
            // 
            // add_username
            // 
            add_username.BorderStyle = BorderStyle.None;
            add_username.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_username.Location = new Point(143, 155);
            add_username.Name = "add_username";
            add_username.Size = new Size(351, 24);
            add_username.TabIndex = 2;
            // 
            // add_class
            // 
            add_class.BorderStyle = BorderStyle.None;
            add_class.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_class.Location = new Point(142, 228);
            add_class.Name = "add_class";
            add_class.Size = new Size(351, 24);
            add_class.TabIndex = 3;
            // 
            // add_finish
            // 
            add_finish.BackColor = Color.FromArgb(128, 153, 255);
            add_finish.FlatAppearance.BorderSize = 0;
            add_finish.FlatStyle = FlatStyle.Flat;
            add_finish.Location = new Point(357, 549);
            add_finish.Name = "add_finish";
            add_finish.Size = new Size(136, 52);
            add_finish.TabIndex = 6;
            add_finish.Text = "ADD";
            add_finish.UseVisualStyleBackColor = false;
            add_finish.Click += add_finish_Click;
            // 
            // add_id
            // 
            add_id.BorderStyle = BorderStyle.None;
            add_id.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_id.Location = new Point(143, 92);
            add_id.Name = "add_id";
            add_id.Size = new Size(351, 24);
            add_id.TabIndex = 1;
            // 
            // bt_fingerprinter
            // 
            bt_fingerprinter.BackColor = Color.FromArgb(254, 206, 181);
            bt_fingerprinter.FlatAppearance.BorderSize = 0;
            bt_fingerprinter.FlatStyle = FlatStyle.Flat;
            bt_fingerprinter.Image = (Image)resources.GetObject("bt_fingerprinter.Image");
            bt_fingerprinter.Location = new Point(142, 468);
            bt_fingerprinter.Name = "bt_fingerprinter";
            bt_fingerprinter.Size = new Size(117, 133);
            bt_fingerprinter.TabIndex = 5;
            bt_fingerprinter.Text = "FingerPrinter";
            bt_fingerprinter.TextImageRelation = TextImageRelation.ImageAboveText;
            bt_fingerprinter.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 57);
            label1.Name = "label1";
            label1.Size = new Size(23, 20);
            label1.TabIndex = 5;
            label1.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 204);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 7;
            label3.Text = "Class";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 131);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 6;
            label2.Text = "Student Name";
            // 
            // bt_addPicture
            // 
            bt_addPicture.BackColor = Color.FromArgb(253, 110, 33);
            bt_addPicture.FlatAppearance.BorderSize = 0;
            bt_addPicture.FlatStyle = FlatStyle.Flat;
            bt_addPicture.Location = new Point(123, 405);
            bt_addPicture.Margin = new Padding(4);
            bt_addPicture.Name = "bt_addPicture";
            bt_addPicture.Size = new Size(138, 46);
            bt_addPicture.TabIndex = 1;
            bt_addPicture.Text = "Avatar";
            bt_addPicture.UseVisualStyleBackColor = false;
            bt_addPicture.Click += bt_addPicture_Click;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(panel7);
            tabPage1.Controls.Add(panel6);
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.ForeColor = SystemColors.ControlDark;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1033, 648);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Information";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(771, 589);
            button2.Name = "button2";
            button2.Size = new Size(93, 41);
            button2.TabIndex = 7;
            button2.Text = "Previous";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(885, 589);
            button1.Name = "button1";
            button1.Size = new Size(93, 41);
            button1.TabIndex = 6;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(textBox6);
            panel7.Controls.Add(label20);
            panel7.Controls.Add(label21);
            panel7.Controls.Add(label22);
            panel7.Controls.Add(pictureBox6);
            panel7.ForeColor = SystemColors.ControlDark;
            panel7.Location = new Point(686, 298);
            panel7.Name = "panel7";
            panel7.Size = new Size(292, 246);
            panel7.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(249, 249, 249);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.ForeColor = SystemColors.WindowFrame;
            textBox6.Location = new Point(158, 136);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(129, 66);
            textBox6.TabIndex = 4;
            textBox6.Text = "Ngũ Hành Sơn, Đà Nẵng";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = SystemColors.ActiveCaptionText;
            label20.Location = new Point(158, 100);
            label20.Name = "label20";
            label20.Size = new Size(68, 20);
            label20.TabIndex = 3;
            label20.Text = "Address";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = SystemColors.ActiveCaptionText;
            label21.Location = new Point(158, 46);
            label21.Name = "label21";
            label21.Size = new Size(76, 20);
            label21.TabIndex = 2;
            label21.Text = "Class: 1A";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(14, 12);
            label22.Name = "label22";
            label22.Size = new Size(103, 19);
            label22.TabIndex = 1;
            label22.Text = "Donal Trump";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 46);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(143, 195);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(textBox5);
            panel6.Controls.Add(label17);
            panel6.Controls.Add(label18);
            panel6.Controls.Add(label19);
            panel6.Controls.Add(pictureBox5);
            panel6.ForeColor = SystemColors.ControlDark;
            panel6.Location = new Point(359, 298);
            panel6.Name = "panel6";
            panel6.Size = new Size(292, 246);
            panel6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(249, 249, 249);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.ForeColor = SystemColors.WindowFrame;
            textBox5.Location = new Point(158, 136);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(129, 66);
            textBox5.TabIndex = 4;
            textBox5.Text = "Ngũ Hành Sơn, Đà Nẵng";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(158, 100);
            label17.Name = "label17";
            label17.Size = new Size(68, 20);
            label17.TabIndex = 3;
            label17.Text = "Address";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = SystemColors.ActiveCaptionText;
            label18.Location = new Point(158, 46);
            label18.Name = "label18";
            label18.Size = new Size(76, 20);
            label18.TabIndex = 2;
            label18.Text = "Class: 1A";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(14, 12);
            label19.Name = "label19";
            label19.Size = new Size(103, 19);
            label19.TabIndex = 1;
            label19.Text = "Donal Trump";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 46);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(143, 195);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(textBox4);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(pictureBox4);
            panel5.ForeColor = SystemColors.ControlDark;
            panel5.Location = new Point(39, 298);
            panel5.Name = "panel5";
            panel5.Size = new Size(292, 246);
            panel5.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(249, 249, 249);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.ForeColor = SystemColors.WindowFrame;
            textBox4.Location = new Point(158, 136);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(129, 66);
            textBox4.TabIndex = 4;
            textBox4.Text = "Ngũ Hành Sơn, Đà Nẵng";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(158, 100);
            label14.Name = "label14";
            label14.Size = new Size(68, 20);
            label14.TabIndex = 3;
            label14.Text = "Address";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(158, 46);
            label15.Name = "label15";
            label15.Size = new Size(76, 20);
            label15.TabIndex = 2;
            label15.Text = "Class: 1A";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(14, 12);
            label16.Name = "label16";
            label16.Size = new Size(103, 19);
            label16.TabIndex = 1;
            label16.Text = "Donal Trump";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 46);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(143, 195);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(pictureBox3);
            panel4.ForeColor = SystemColors.ControlDark;
            panel4.Location = new Point(686, 27);
            panel4.Name = "panel4";
            panel4.Size = new Size(292, 246);
            panel4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(249, 249, 249);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.ForeColor = SystemColors.WindowFrame;
            textBox3.Location = new Point(158, 136);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(129, 66);
            textBox3.TabIndex = 4;
            textBox3.Text = "Ngũ Hành Sơn, Đà Nẵng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(158, 100);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 3;
            label11.Text = "Address";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(158, 46);
            label12.Name = "label12";
            label12.Size = new Size(76, 20);
            label12.TabIndex = 2;
            label12.Text = "Class: 1A";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(14, 12);
            label13.Name = "label13";
            label13.Size = new Size(103, 19);
            label13.TabIndex = 1;
            label13.Text = "Donal Trump";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 46);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(143, 195);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(pictureBox2);
            panel3.ForeColor = SystemColors.ControlDark;
            panel3.Location = new Point(359, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(292, 246);
            panel3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(249, 249, 249);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = SystemColors.WindowFrame;
            textBox2.Location = new Point(158, 136);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(129, 66);
            textBox2.TabIndex = 4;
            textBox2.Text = "Ngũ Hành Sơn, Đà Nẵng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(158, 100);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 3;
            label8.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(158, 46);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 2;
            label9.Text = "Class: 1A";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(14, 12);
            label10.Name = "label10";
            label10.Size = new Size(103, 19);
            label10.TabIndex = 1;
            label10.Text = "Donal Trump";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(143, 195);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox1);
            panel2.ForeColor = SystemColors.ControlDark;
            panel2.Location = new Point(39, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(292, 246);
            panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(249, 249, 249);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(158, 136);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(129, 66);
            textBox1.TabIndex = 4;
            textBox1.Text = "Ngũ Hành Sơn, Đà Nẵng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(158, 100);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 3;
            label7.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(158, 46);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 2;
            label6.Text = "Class: 1A";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(14, 12);
            label5.Name = "label5";
            label5.Size = new Size(103, 19);
            label5.TabIndex = 1;
            label5.Text = "Donal Trump";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1041, 681);
            tabControl1.TabIndex = 13;
            // 
            // Information
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 215, 228);
            ClientSize = new Size(1041, 681);
            Controls.Add(tabControl1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Information";
            Text = "Information";
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_avatar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private TabPage tabPage2;
        private PictureBox pb_avatar;
        private Panel panel1;
        private RichTextBox tb_description;
        private Label label4;
        private TextBox add_username;
        private TextBox add_class;
        private Button add_finish;
        private TextBox add_id;
        private Button bt_fingerprinter;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button bt_addPicture;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private Panel panel2;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
        private Panel panel7;
        private TextBox textBox6;
        private Label label20;
        private Label label21;
        private Label label22;
        private PictureBox pictureBox6;
        private Panel panel6;
        private TextBox textBox5;
        private Label label17;
        private Label label18;
        private Label label19;
        private PictureBox pictureBox5;
        private Panel panel5;
        private TextBox textBox4;
        private Label label14;
        private Label label15;
        private Label label16;
        private PictureBox pictureBox4;
        private Panel panel4;
        private TextBox textBox3;
        private Label label11;
        private Label label12;
        private Label label13;
        private PictureBox pictureBox3;
        private Panel panel3;
        private TextBox textBox2;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button1;
    }
}