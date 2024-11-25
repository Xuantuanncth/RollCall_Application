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
            panel10 = new Panel();
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
            bt_previous = new Button();
            bt_next = new Button();
            panel6 = new Panel();
            textBox6 = new TextBox();
            lb_address6 = new Label();
            lb_class6 = new Label();
            lb_name6 = new Label();
            pictureBox6 = new PictureBox();
            panel5 = new Panel();
            textBox5 = new TextBox();
            lb_address5 = new Label();
            lb_class5 = new Label();
            lb_name5 = new Label();
            pictureBox5 = new PictureBox();
            panel4 = new Panel();
            textBox4 = new TextBox();
            lb_address4 = new Label();
            lb_class4 = new Label();
            lb_name4 = new Label();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            textBox3 = new TextBox();
            lb_address3 = new Label();
            lb_class3 = new Label();
            lb_name3 = new Label();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            textBox2 = new TextBox();
            lb_address2 = new Label();
            lb_class2 = new Label();
            lb_name2 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            lb_address1 = new Label();
            lb_class1 = new Label();
            lb_name1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            lb_id1 = new Label();
            lb_id2 = new Label();
            lb_id3 = new Label();
            lb_id4 = new Label();
            lb_id5 = new Label();
            lb_id6 = new Label();
            lb_count_page = new Label();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_avatar).BeginInit();
            panel10.SuspendLayout();
            tabPage1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
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
            tabPage2.Controls.Add(panel10);
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
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(235, 238, 249);
            panel10.Controls.Add(tb_description);
            panel10.Controls.Add(label4);
            panel10.Controls.Add(add_username);
            panel10.Controls.Add(add_class);
            panel10.Controls.Add(add_finish);
            panel10.Controls.Add(add_id);
            panel10.Controls.Add(bt_fingerprinter);
            panel10.Controls.Add(label1);
            panel10.Controls.Add(label3);
            panel10.Controls.Add(label2);
            panel10.Dock = DockStyle.Right;
            panel10.Location = new Point(409, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(621, 642);
            panel10.TabIndex = 12;
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
            tabPage1.Controls.Add(lb_count_page);
            tabPage1.Controls.Add(bt_previous);
            tabPage1.Controls.Add(bt_next);
            tabPage1.Controls.Add(panel6);
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.ForeColor = SystemColors.ControlDark;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1033, 648);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Information";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_previous
            // 
            bt_previous.BackColor = Color.FromArgb(253, 110, 33);
            bt_previous.ForeColor = SystemColors.ActiveCaptionText;
            bt_previous.Location = new Point(760, 589);
            bt_previous.Name = "bt_previous";
            bt_previous.Size = new Size(93, 41);
            bt_previous.TabIndex = 7;
            bt_previous.Text = "Previous";
            bt_previous.UseVisualStyleBackColor = false;
            bt_previous.Click += button2_Click;
            // 
            // bt_next
            // 
            bt_next.BackColor = Color.FromArgb(253, 110, 33);
            bt_next.FlatAppearance.BorderSize = 0;
            bt_next.ForeColor = SystemColors.ActiveCaptionText;
            bt_next.Location = new Point(885, 589);
            bt_next.Name = "bt_next";
            bt_next.Size = new Size(93, 41);
            bt_next.TabIndex = 6;
            bt_next.Text = "Next";
            bt_next.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(lb_id6);
            panel6.Controls.Add(textBox6);
            panel6.Controls.Add(lb_address6);
            panel6.Controls.Add(lb_class6);
            panel6.Controls.Add(lb_name6);
            panel6.Controls.Add(pictureBox6);
            panel6.ForeColor = SystemColors.ControlDark;
            panel6.Location = new Point(686, 298);
            panel6.Name = "panel6";
            panel6.Size = new Size(292, 246);
            panel6.TabIndex = 5;
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
            // lb_address6
            // 
            lb_address6.AutoSize = true;
            lb_address6.ForeColor = SystemColors.ActiveCaptionText;
            lb_address6.Location = new Point(158, 100);
            lb_address6.Name = "lb_address6";
            lb_address6.Size = new Size(68, 20);
            lb_address6.TabIndex = 3;
            lb_address6.Text = "Address";
            // 
            // lb_class6
            // 
            lb_class6.AutoSize = true;
            lb_class6.ForeColor = SystemColors.ActiveCaptionText;
            lb_class6.Location = new Point(158, 46);
            lb_class6.Name = "lb_class6";
            lb_class6.Size = new Size(76, 20);
            lb_class6.TabIndex = 2;
            lb_class6.Text = "Class: 1A";
            // 
            // lb_name6
            // 
            lb_name6.AutoSize = true;
            lb_name6.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name6.ForeColor = Color.Black;
            lb_name6.Location = new Point(14, 12);
            lb_name6.Name = "lb_name6";
            lb_name6.Size = new Size(103, 19);
            lb_name6.TabIndex = 1;
            lb_name6.Text = "Donal Trump";
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
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lb_id5);
            panel5.Controls.Add(textBox5);
            panel5.Controls.Add(lb_address5);
            panel5.Controls.Add(lb_class5);
            panel5.Controls.Add(lb_name5);
            panel5.Controls.Add(pictureBox5);
            panel5.ForeColor = SystemColors.ControlDark;
            panel5.Location = new Point(359, 298);
            panel5.Name = "panel5";
            panel5.Size = new Size(292, 246);
            panel5.TabIndex = 5;
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
            // lb_address5
            // 
            lb_address5.AutoSize = true;
            lb_address5.ForeColor = SystemColors.ActiveCaptionText;
            lb_address5.Location = new Point(158, 100);
            lb_address5.Name = "lb_address5";
            lb_address5.Size = new Size(68, 20);
            lb_address5.TabIndex = 3;
            lb_address5.Text = "Address";
            // 
            // lb_class5
            // 
            lb_class5.AutoSize = true;
            lb_class5.ForeColor = SystemColors.ActiveCaptionText;
            lb_class5.Location = new Point(158, 46);
            lb_class5.Name = "lb_class5";
            lb_class5.Size = new Size(76, 20);
            lb_class5.TabIndex = 2;
            lb_class5.Text = "Class: 1A";
            // 
            // lb_name5
            // 
            lb_name5.AutoSize = true;
            lb_name5.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name5.ForeColor = Color.Black;
            lb_name5.Location = new Point(14, 12);
            lb_name5.Name = "lb_name5";
            lb_name5.Size = new Size(103, 19);
            lb_name5.TabIndex = 1;
            lb_name5.Text = "Donal Trump";
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
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lb_id4);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(lb_address4);
            panel4.Controls.Add(lb_class4);
            panel4.Controls.Add(lb_name4);
            panel4.Controls.Add(pictureBox4);
            panel4.ForeColor = SystemColors.ControlDark;
            panel4.Location = new Point(39, 298);
            panel4.Name = "panel4";
            panel4.Size = new Size(292, 246);
            panel4.TabIndex = 5;
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
            // lb_address4
            // 
            lb_address4.AutoSize = true;
            lb_address4.ForeColor = SystemColors.ActiveCaptionText;
            lb_address4.Location = new Point(158, 100);
            lb_address4.Name = "lb_address4";
            lb_address4.Size = new Size(68, 20);
            lb_address4.TabIndex = 3;
            lb_address4.Text = "Address";
            // 
            // lb_class4
            // 
            lb_class4.AutoSize = true;
            lb_class4.ForeColor = SystemColors.ActiveCaptionText;
            lb_class4.Location = new Point(158, 46);
            lb_class4.Name = "lb_class4";
            lb_class4.Size = new Size(76, 20);
            lb_class4.TabIndex = 2;
            lb_class4.Text = "Class: 1A";
            // 
            // lb_name4
            // 
            lb_name4.AutoSize = true;
            lb_name4.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name4.ForeColor = Color.Black;
            lb_name4.Location = new Point(14, 12);
            lb_name4.Name = "lb_name4";
            lb_name4.Size = new Size(103, 19);
            lb_name4.TabIndex = 1;
            lb_name4.Text = "Donal Trump";
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
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lb_id3);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(lb_address3);
            panel3.Controls.Add(lb_class3);
            panel3.Controls.Add(lb_name3);
            panel3.Controls.Add(pictureBox3);
            panel3.ForeColor = SystemColors.ControlDark;
            panel3.Location = new Point(686, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(292, 246);
            panel3.TabIndex = 5;
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
            // lb_address3
            // 
            lb_address3.AutoSize = true;
            lb_address3.ForeColor = SystemColors.ActiveCaptionText;
            lb_address3.Location = new Point(158, 100);
            lb_address3.Name = "lb_address3";
            lb_address3.Size = new Size(68, 20);
            lb_address3.TabIndex = 3;
            lb_address3.Text = "Address";
            // 
            // lb_class3
            // 
            lb_class3.AutoSize = true;
            lb_class3.ForeColor = SystemColors.ActiveCaptionText;
            lb_class3.Location = new Point(158, 46);
            lb_class3.Name = "lb_class3";
            lb_class3.Size = new Size(76, 20);
            lb_class3.TabIndex = 2;
            lb_class3.Text = "Class: 1A";
            // 
            // lb_name3
            // 
            lb_name3.AutoSize = true;
            lb_name3.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name3.ForeColor = Color.Black;
            lb_name3.Location = new Point(14, 12);
            lb_name3.Name = "lb_name3";
            lb_name3.Size = new Size(103, 19);
            lb_name3.TabIndex = 1;
            lb_name3.Text = "Donal Trump";
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
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lb_id2);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(lb_address2);
            panel2.Controls.Add(lb_class2);
            panel2.Controls.Add(lb_name2);
            panel2.Controls.Add(pictureBox2);
            panel2.ForeColor = SystemColors.ControlDark;
            panel2.Location = new Point(359, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(292, 246);
            panel2.TabIndex = 1;
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
            // lb_address2
            // 
            lb_address2.AutoSize = true;
            lb_address2.ForeColor = SystemColors.ActiveCaptionText;
            lb_address2.Location = new Point(158, 100);
            lb_address2.Name = "lb_address2";
            lb_address2.Size = new Size(68, 20);
            lb_address2.TabIndex = 3;
            lb_address2.Text = "Address";
            // 
            // lb_class2
            // 
            lb_class2.AutoSize = true;
            lb_class2.ForeColor = SystemColors.ActiveCaptionText;
            lb_class2.Location = new Point(158, 46);
            lb_class2.Name = "lb_class2";
            lb_class2.Size = new Size(76, 20);
            lb_class2.TabIndex = 2;
            lb_class2.Text = "Class: 1A";
            // 
            // lb_name2
            // 
            lb_name2.AutoSize = true;
            lb_name2.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name2.ForeColor = Color.Black;
            lb_name2.Location = new Point(14, 12);
            lb_name2.Name = "lb_name2";
            lb_name2.Size = new Size(103, 19);
            lb_name2.TabIndex = 1;
            lb_name2.Text = "Donal Trump";
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
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lb_id1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lb_address1);
            panel1.Controls.Add(lb_class1);
            panel1.Controls.Add(lb_name1);
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = SystemColors.ControlDark;
            panel1.Location = new Point(39, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 246);
            panel1.TabIndex = 0;
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
            // lb_address1
            // 
            lb_address1.AutoSize = true;
            lb_address1.ForeColor = SystemColors.ActiveCaptionText;
            lb_address1.Location = new Point(158, 100);
            lb_address1.Name = "lb_address1";
            lb_address1.Size = new Size(68, 20);
            lb_address1.TabIndex = 3;
            lb_address1.Text = "Address";
            // 
            // lb_class1
            // 
            lb_class1.AutoSize = true;
            lb_class1.ForeColor = SystemColors.ActiveCaptionText;
            lb_class1.Location = new Point(158, 46);
            lb_class1.Name = "lb_class1";
            lb_class1.Size = new Size(76, 20);
            lb_class1.TabIndex = 2;
            lb_class1.Text = "Class: 1A";
            lb_class1.Click += label6_Click;
            // 
            // lb_name1
            // 
            lb_name1.AutoSize = true;
            lb_name1.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name1.ForeColor = Color.Black;
            lb_name1.Location = new Point(14, 12);
            lb_name1.Name = "lb_name1";
            lb_name1.Size = new Size(103, 19);
            lb_name1.TabIndex = 1;
            lb_name1.Text = "Donal Trump";
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
            // lb_id1
            // 
            lb_id1.AutoSize = true;
            lb_id1.ForeColor = SystemColors.ActiveCaptionText;
            lb_id1.Location = new Point(158, 73);
            lb_id1.Name = "lb_id1";
            lb_id1.Size = new Size(43, 20);
            lb_id1.TabIndex = 5;
            lb_id1.Text = "ID: 1";
            // 
            // lb_id2
            // 
            lb_id2.AutoSize = true;
            lb_id2.ForeColor = SystemColors.ActiveCaptionText;
            lb_id2.Location = new Point(158, 73);
            lb_id2.Name = "lb_id2";
            lb_id2.Size = new Size(43, 20);
            lb_id2.TabIndex = 6;
            lb_id2.Text = "ID: 1";
            // 
            // lb_id3
            // 
            lb_id3.AutoSize = true;
            lb_id3.ForeColor = SystemColors.ActiveCaptionText;
            lb_id3.Location = new Point(160, 74);
            lb_id3.Name = "lb_id3";
            lb_id3.Size = new Size(43, 20);
            lb_id3.TabIndex = 5;
            lb_id3.Text = "ID: 1";
            // 
            // lb_id4
            // 
            lb_id4.AutoSize = true;
            lb_id4.ForeColor = SystemColors.ActiveCaptionText;
            lb_id4.Location = new Point(159, 73);
            lb_id4.Name = "lb_id4";
            lb_id4.Size = new Size(43, 20);
            lb_id4.TabIndex = 5;
            lb_id4.Text = "ID: 1";
            // 
            // lb_id5
            // 
            lb_id5.AutoSize = true;
            lb_id5.ForeColor = SystemColors.ActiveCaptionText;
            lb_id5.Location = new Point(159, 71);
            lb_id5.Name = "lb_id5";
            lb_id5.Size = new Size(43, 20);
            lb_id5.TabIndex = 5;
            lb_id5.Text = "ID: 1";
            // 
            // lb_id6
            // 
            lb_id6.AutoSize = true;
            lb_id6.ForeColor = SystemColors.ActiveCaptionText;
            lb_id6.Location = new Point(161, 72);
            lb_id6.Name = "lb_id6";
            lb_id6.Size = new Size(43, 20);
            lb_id6.TabIndex = 5;
            lb_id6.Text = "ID: 1";
            // 
            // lb_count_page
            // 
            lb_count_page.AutoSize = true;
            lb_count_page.ForeColor = Color.CornflowerBlue;
            lb_count_page.Location = new Point(859, 600);
            lb_count_page.Name = "lb_count_page";
            lb_count_page.Size = new Size(18, 20);
            lb_count_page.TabIndex = 8;
            lb_count_page.Text = "1";
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
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private TabPage tabPage2;
        private PictureBox pb_avatar;
        private Panel panel10;
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
        private Panel panel1;
        private Label lb_name1;
        private PictureBox pictureBox1;
        private Label lb_class1;
        private TextBox textBox1;
        private Label lb_address1;
        private Panel panel6;
        private TextBox textBox6;
        private Label lb_address6;
        private Label lb_class6;
        private Label lb_name6;
        private PictureBox pictureBox6;
        private Panel panel5;
        private TextBox textBox5;
        private Label lb_address5;
        private Label lb_class5;
        private Label lb_name5;
        private PictureBox pictureBox5;
        private Panel panel4;
        private TextBox textBox4;
        private Label lb_address4;
        private Label lb_class4;
        private Label lb_name4;
        private PictureBox pictureBox4;
        private Panel panel3;
        private TextBox textBox3;
        private Label lb_address3;
        private Label lb_class3;
        private Label lb_name3;
        private PictureBox pictureBox3;
        private Panel panel2;
        private TextBox textBox2;
        private Label lb_address2;
        private Label lb_class2;
        private Label lb_name2;
        private PictureBox pictureBox2;
        private Button bt_previous;
        private Button bt_next;
        private Label lb_id6;
        private Label lb_id5;
        private Label lb_id4;
        private Label lb_id3;
        private Label lb_id2;
        private Label lb_id1;
        private Label lb_count_page;
    }
}