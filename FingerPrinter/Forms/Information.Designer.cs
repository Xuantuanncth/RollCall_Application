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
            panel2 = new Panel();
            lb_info_descripton = new Label();
            lb_infor_class = new Label();
            lb_info_name = new Label();
            pb_infor_avatar = new PictureBox();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_avatar).BeginInit();
            panel1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_infor_avatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1033, 653);
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
            panel1.Size = new Size(621, 647);
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
            label4.Size = new Size(97, 21);
            label4.TabIndex = 11;
            label4.Text = "Description";
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
            add_id.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_id.Location = new Point(143, 92);
            add_id.Name = "add_id";
            add_id.Size = new Size(351, 26);
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
            label1.Size = new Size(26, 21);
            label1.TabIndex = 5;
            label1.Text = "Id";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 131);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
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
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1033, 647);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Information";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(235, 238, 249);
            panel2.Controls.Add(lb_info_descripton);
            panel2.Controls.Add(lb_infor_class);
            panel2.Controls.Add(lb_info_name);
            panel2.Controls.Add(pb_infor_avatar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 355);
            panel2.Name = "panel2";
            panel2.Size = new Size(1027, 289);
            panel2.TabIndex = 1;
            // 
            // lb_info_descripton
            // 
            lb_info_descripton.AutoSize = true;
            lb_info_descripton.Location = new Point(284, 121);
            lb_info_descripton.Name = "lb_info_descripton";
            lb_info_descripton.Size = new Size(57, 21);
            lb_info_descripton.TabIndex = 3;
            lb_info_descripton.Text = "label5";
            // 
            // lb_infor_class
            // 
            lb_infor_class.AutoSize = true;
            lb_infor_class.Location = new Point(284, 77);
            lb_infor_class.Name = "lb_infor_class";
            lb_infor_class.Size = new Size(57, 21);
            lb_infor_class.TabIndex = 2;
            lb_infor_class.Text = "label5";
            // 
            // lb_info_name
            // 
            lb_info_name.AutoSize = true;
            lb_info_name.Location = new Point(284, 30);
            lb_info_name.Name = "lb_info_name";
            lb_info_name.Size = new Size(0, 21);
            lb_info_name.TabIndex = 1;
            // 
            // pb_infor_avatar
            // 
            pb_infor_avatar.Location = new Point(27, 19);
            pb_infor_avatar.Name = "pb_infor_avatar";
            pb_infor_avatar.Size = new Size(204, 265);
            pb_infor_avatar.TabIndex = 0;
            pb_infor_avatar.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1027, 346);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 215, 228);
            ClientSize = new Size(1041, 681);
            Controls.Add(tabControl1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Information";
            Text = "Information";
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_avatar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_infor_avatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Panel panel2;
        private Label lb_info_descripton;
        private Label lb_infor_class;
        private Label lb_info_name;
        private PictureBox pb_infor_avatar;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
    }
}