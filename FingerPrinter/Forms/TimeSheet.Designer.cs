namespace FingerPrinter.Forms
{
    partial class TimeSheet
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
            openFileDialog1 = new OpenFileDialog();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            monthCalendar1 = new MonthCalendar();
            bt_s_date = new Button();
            tb_s_id = new TextBox();
            bt_s_id = new Button();
            label1 = new Label();
            bt_s_name = new Button();
            tb_s_name = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tb_s_date = new TextBox();
            bt_search = new Button();
            bt_export = new Button();
            label4 = new Label();
            label5 = new Label();
            cb_month = new ComboBox();
            bt_s_month = new Button();
            tabControl1 = new TabControl();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(bt_s_month);
            tabPage1.Controls.Add(cb_month);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(bt_export);
            tabPage1.Controls.Add(bt_search);
            tabPage1.Controls.Add(tb_s_date);
            tabPage1.Controls.Add(tb_s_name);
            tabPage1.Controls.Add(tb_s_id);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(bt_s_name);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(bt_s_id);
            tabPage1.Controls.Add(bt_s_date);
            tabPage1.Controls.Add(monthCalendar1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1033, 648);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "TimeSheet";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.Location = new Point(8, 183);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1017, 446);
            dataGridView1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(8, 9);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // bt_s_date
            // 
            bt_s_date.Location = new Point(604, 46);
            bt_s_date.Name = "bt_s_date";
            bt_s_date.Size = new Size(100, 30);
            bt_s_date.TabIndex = 2;
            bt_s_date.Text = "Date";
            bt_s_date.UseVisualStyleBackColor = true;
            bt_s_date.Click += bt_s_date_Click;
            // 
            // tb_s_id
            // 
            tb_s_id.Location = new Point(426, 123);
            tb_s_id.Name = "tb_s_id";
            tb_s_id.Size = new Size(147, 26);
            tb_s_id.TabIndex = 3;
            tb_s_id.TextChanged += textBox1_TextChanged;
            // 
            // bt_s_id
            // 
            bt_s_id.Location = new Point(604, 123);
            bt_s_id.Name = "bt_s_id";
            bt_s_id.Size = new Size(100, 30);
            bt_s_id.TabIndex = 4;
            bt_s_id.Text = "ID";
            bt_s_id.UseVisualStyleBackColor = true;
            bt_s_id.Click += bt_s_id_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 124);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 5;
            label1.Text = "Search with ID";
            // 
            // bt_s_name
            // 
            bt_s_name.Location = new Point(604, 86);
            bt_s_name.Name = "bt_s_name";
            bt_s_name.Size = new Size(100, 30);
            bt_s_name.TabIndex = 6;
            bt_s_name.Text = "Name";
            bt_s_name.UseVisualStyleBackColor = true;
            bt_s_name.Click += bt_s_name_Click;
            // 
            // tb_s_name
            // 
            tb_s_name.Location = new Point(426, 86);
            tb_s_name.Name = "tb_s_name";
            tb_s_name.Size = new Size(147, 26);
            tb_s_name.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 89);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 8;
            label2.Text = "Search with Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 54);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 9;
            label3.Text = "Search with Date";
            // 
            // tb_s_date
            // 
            tb_s_date.Location = new Point(426, 48);
            tb_s_date.Name = "tb_s_date";
            tb_s_date.Size = new Size(147, 26);
            tb_s_date.TabIndex = 10;
            // 
            // bt_search
            // 
            bt_search.Location = new Point(736, 12);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(100, 40);
            bt_search.TabIndex = 11;
            bt_search.Text = "Search";
            bt_search.UseVisualStyleBackColor = true;
            bt_search.Click += bt_search_Click;
            // 
            // bt_export
            // 
            bt_export.Location = new Point(736, 103);
            bt_export.Name = "bt_export";
            bt_export.Size = new Size(100, 41);
            bt_export.TabIndex = 12;
            bt_export.Text = "Export";
            bt_export.UseVisualStyleBackColor = true;
            bt_export.Click += bt_export_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(736, 80);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 13;
            label4.Text = "Export excel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 20);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 14;
            label5.Text = "Search with month";
            // 
            // cb_month
            // 
            cb_month.FormattingEnabled = true;
            cb_month.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cb_month.Location = new Point(426, 12);
            cb_month.Name = "cb_month";
            cb_month.Size = new Size(147, 28);
            cb_month.TabIndex = 15;
            // 
            // bt_s_month
            // 
            bt_s_month.Location = new Point(604, 10);
            bt_s_month.Name = "bt_s_month";
            bt_s_month.Size = new Size(100, 30);
            bt_s_month.TabIndex = 16;
            bt_s_month.Text = "Month";
            bt_s_month.UseVisualStyleBackColor = true;
            bt_s_month.Click += bt_s_month_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1041, 681);
            tabControl1.TabIndex = 0;
            // 
            // TimeSheet
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 681);
            Controls.Add(tabControl1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "TimeSheet";
            Text = "TimeSheet";
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private TabPage tabPage1;
        private Button bt_s_month;
        private ComboBox cb_month;
        private Label label5;
        private Label label4;
        private Button bt_export;
        private Button bt_search;
        private TextBox tb_s_date;
        private TextBox tb_s_name;
        private TextBox tb_s_id;
        private Label label3;
        private Label label2;
        private Button bt_s_name;
        private Label label1;
        private Button bt_s_id;
        private Button bt_s_date;
        private MonthCalendar monthCalendar1;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
    }
}