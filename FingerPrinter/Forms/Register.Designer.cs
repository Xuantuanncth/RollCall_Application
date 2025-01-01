namespace FingerPrinter.Forms
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btn_register = new Button();
            label3 = new Label();
            tb_confirm_pass = new TextBox();
            label2 = new Label();
            tb_user_name = new TextBox();
            label4 = new Label();
            tb_password = new TextBox();
            label5 = new Label();
            tb_mail = new TextBox();
            ltb_back_login = new LinkLabel();
            label6 = new Label();
            cb_Role = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(253, 110, 33);
            label1.Location = new Point(121, 67);
            label1.Name = "label1";
            label1.Size = new Size(176, 53);
            label1.TabIndex = 9;
            label1.Text = "Roll Call";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(303, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.FromArgb(253, 110, 33);
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_register.Location = new Point(67, 625);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(401, 59);
            btn_register.TabIndex = 5;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 411);
            label3.Name = "label3";
            label3.Size = new Size(171, 22);
            label3.TabIndex = 14;
            label3.Text = "Confirm Password";
            // 
            // tb_confirm_pass
            // 
            tb_confirm_pass.BorderStyle = BorderStyle.None;
            tb_confirm_pass.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_confirm_pass.Location = new Point(67, 447);
            tb_confirm_pass.Multiline = true;
            tb_confirm_pass.Name = "tb_confirm_pass";
            tb_confirm_pass.PasswordChar = '*';
            tb_confirm_pass.Size = new Size(401, 48);
            tb_confirm_pass.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 138);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 12;
            label2.Text = "User name";
            // 
            // tb_user_name
            // 
            tb_user_name.BorderStyle = BorderStyle.None;
            tb_user_name.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_user_name.Location = new Point(67, 163);
            tb_user_name.Multiline = true;
            tb_user_name.Name = "tb_user_name";
            tb_user_name.Size = new Size(401, 48);
            tb_user_name.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 314);
            label4.Name = "label4";
            label4.Size = new Size(95, 22);
            label4.TabIndex = 17;
            label4.Text = "Password";
            // 
            // tb_password
            // 
            tb_password.BorderStyle = BorderStyle.None;
            tb_password.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_password.Location = new Point(67, 349);
            tb_password.Multiline = true;
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(401, 48);
            tb_password.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(67, 225);
            label5.Name = "label5";
            label5.Size = new Size(56, 22);
            label5.TabIndex = 19;
            label5.Text = "Email";
            // 
            // tb_mail
            // 
            tb_mail.BorderStyle = BorderStyle.None;
            tb_mail.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_mail.Location = new Point(67, 250);
            tb_mail.Multiline = true;
            tb_mail.Name = "tb_mail";
            tb_mail.Size = new Size(401, 48);
            tb_mail.TabIndex = 2;
            // 
            // ltb_back_login
            // 
            ltb_back_login.AutoSize = true;
            ltb_back_login.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ltb_back_login.LinkColor = Color.Gray;
            ltb_back_login.Location = new Point(233, 709);
            ltb_back_login.Name = "ltb_back_login";
            ltb_back_login.Size = new Size(64, 24);
            ltb_back_login.TabIndex = 6;
            ltb_back_login.TabStop = true;
            ltb_back_login.Text = "Login";
            ltb_back_login.LinkClicked += ltb_back_login_Clicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(67, 533);
            label6.Name = "label6";
            label6.Size = new Size(56, 24);
            label6.TabIndex = 21;
            label6.Text = "Role";
            // 
            // cb_Role
            // 
            cb_Role.FlatStyle = FlatStyle.Flat;
            cb_Role.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_Role.FormattingEnabled = true;
            cb_Role.Items.AddRange(new object[] { "Admin", "User" });
            cb_Role.Location = new Point(163, 532);
            cb_Role.Name = "cb_Role";
            cb_Role.Size = new Size(121, 30);
            cb_Role.TabIndex = 22;
            cb_Role.Text = "User";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 778);
            Controls.Add(cb_Role);
            Controls.Add(label6);
            Controls.Add(ltb_back_login);
            Controls.Add(label5);
            Controls.Add(tb_mail);
            Controls.Add(label4);
            Controls.Add(tb_password);
            Controls.Add(btn_register);
            Controls.Add(label3);
            Controls.Add(tb_confirm_pass);
            Controls.Add(label2);
            Controls.Add(tb_user_name);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_register;
        private Label label3;
        private TextBox tb_confirm_pass;
        private Label label2;
        private TextBox tb_user_name;
        private Label label4;
        private TextBox tb_password;
        private Label label5;
        private TextBox tb_mail;
        private LinkLabel ltb_back_login;
        private Label label6;
        private ComboBox cb_Role;
    }
}