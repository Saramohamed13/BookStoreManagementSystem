﻿namespace BookStore.WinForms.CustomerForms
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
            btRegisterCustomer = new Button();
            TBEmail = new TextBox();
            TBPassword = new TextBox();
            TBUserName = new TextBox();
            TBPhone = new TextBox();
            TBName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lbNameMsg = new Label();
            lbAddressMsg = new Label();
            lbUserNameMsg = new Label();
            lbEmailMsg = new Label();
            lbPasswordMsg = new Label();
            lbPhoneMsg = new Label();
            TBAddrees = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btRegisterCustomer
            // 
            btRegisterCustomer.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btRegisterCustomer.ForeColor = Color.FromArgb(69, 51, 39);
            btRegisterCustomer.Location = new Point(393, 302);
            btRegisterCustomer.Name = "btRegisterCustomer";
            btRegisterCustomer.Size = new Size(141, 40);
            btRegisterCustomer.TabIndex = 28;
            btRegisterCustomer.Text = "Register";
            btRegisterCustomer.UseVisualStyleBackColor = true;
            btRegisterCustomer.Click += btAddCustomer_Click;
            // 
            // TBEmail
            // 
            TBEmail.ForeColor = Color.FromArgb(69, 51, 39);
            TBEmail.Location = new Point(162, 163);
            TBEmail.Name = "TBEmail";
            TBEmail.Size = new Size(262, 27);
            TBEmail.TabIndex = 27;
            // 
            // TBPassword
            // 
            TBPassword.ForeColor = Color.FromArgb(69, 51, 39);
            TBPassword.Location = new Point(634, 228);
            TBPassword.Name = "TBPassword";
            TBPassword.PasswordChar = '*';
            TBPassword.Size = new Size(262, 27);
            TBPassword.TabIndex = 26;
            // 
            // TBUserName
            // 
            TBUserName.ForeColor = Color.FromArgb(69, 51, 39);
            TBUserName.Location = new Point(634, 163);
            TBUserName.Name = "TBUserName";
            TBUserName.Size = new Size(262, 27);
            TBUserName.TabIndex = 25;
            // 
            // TBPhone
            // 
            TBPhone.ForeColor = Color.FromArgb(69, 51, 39);
            TBPhone.Location = new Point(162, 228);
            TBPhone.Name = "TBPhone";
            TBPhone.Size = new Size(262, 27);
            TBPhone.TabIndex = 23;
            // 
            // TBName
            // 
            TBName.ForeColor = Color.FromArgb(69, 51, 39);
            TBName.Location = new Point(162, 95);
            TBName.Name = "TBName";
            TBName.Size = new Size(262, 27);
            TBName.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(503, 95);
            label7.Name = "label7";
            label7.Size = new Size(86, 28);
            label7.TabIndex = 21;
            label7.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(30, 227);
            label6.Name = "label6";
            label6.Size = new Size(71, 28);
            label6.TabIndex = 20;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(33, 163);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 19;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(33, 95);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 18;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(495, 227);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(489, 163);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 16;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(459, 46);
            label1.TabIndex = 15;
            label1.Text = "Welcome In Our Book Store";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.im;
            pictureBox1.Location = new Point(2, 348);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(928, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // lbNameMsg
            // 
            lbNameMsg.AutoSize = true;
            lbNameMsg.ForeColor = Color.Red;
            lbNameMsg.Location = new Point(33, 133);
            lbNameMsg.Name = "lbNameMsg";
            lbNameMsg.Size = new Size(0, 20);
            lbNameMsg.TabIndex = 31;
            // 
            // lbAddressMsg
            // 
            lbAddressMsg.AutoSize = true;
            lbAddressMsg.ForeColor = Color.Red;
            lbAddressMsg.Location = new Point(503, 133);
            lbAddressMsg.Name = "lbAddressMsg";
            lbAddressMsg.Size = new Size(0, 20);
            lbAddressMsg.TabIndex = 32;
            // 
            // lbUserNameMsg
            // 
            lbUserNameMsg.AutoSize = true;
            lbUserNameMsg.ForeColor = Color.Red;
            lbUserNameMsg.Location = new Point(505, 198);
            lbUserNameMsg.Name = "lbUserNameMsg";
            lbUserNameMsg.Size = new Size(0, 20);
            lbUserNameMsg.TabIndex = 34;
            // 
            // lbEmailMsg
            // 
            lbEmailMsg.AutoSize = true;
            lbEmailMsg.ForeColor = Color.Red;
            lbEmailMsg.Location = new Point(35, 198);
            lbEmailMsg.Name = "lbEmailMsg";
            lbEmailMsg.Size = new Size(0, 20);
            lbEmailMsg.TabIndex = 33;
            // 
            // lbPasswordMsg
            // 
            lbPasswordMsg.AutoSize = true;
            lbPasswordMsg.ForeColor = Color.Red;
            lbPasswordMsg.Location = new Point(503, 262);
            lbPasswordMsg.Name = "lbPasswordMsg";
            lbPasswordMsg.Size = new Size(0, 20);
            lbPasswordMsg.TabIndex = 36;
            // 
            // lbPhoneMsg
            // 
            lbPhoneMsg.AutoSize = true;
            lbPhoneMsg.ForeColor = Color.Red;
            lbPhoneMsg.Location = new Point(33, 262);
            lbPhoneMsg.Name = "lbPhoneMsg";
            lbPhoneMsg.Size = new Size(0, 20);
            lbPhoneMsg.TabIndex = 35;
            // 
            // TBAddrees
            // 
            TBAddrees.ForeColor = Color.FromArgb(69, 51, 39);
            TBAddrees.Location = new Point(634, 95);
            TBAddrees.Name = "TBAddrees";
            TBAddrees.Size = new Size(262, 27);
            TBAddrees.TabIndex = 37;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 51, 39);
            ClientSize = new Size(934, 450);
            Controls.Add(TBAddrees);
            Controls.Add(lbPasswordMsg);
            Controls.Add(lbPhoneMsg);
            Controls.Add(lbUserNameMsg);
            Controls.Add(lbEmailMsg);
            Controls.Add(lbAddressMsg);
            Controls.Add(lbNameMsg);
            Controls.Add(pictureBox1);
            Controls.Add(btRegisterCustomer);
            Controls.Add(TBEmail);
            Controls.Add(TBPassword);
            Controls.Add(TBUserName);
            Controls.Add(TBPhone);
            Controls.Add(TBName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btRegisterCustomer;
        private TextBox TBEmail;
        private TextBox TBPassword;
        private TextBox TBUserName;
        private TextBox TBPhone;
        private TextBox TBName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lbNameMsg;
        private Label lbAddressMsg;
        private Label lbUserNameMsg;
        private Label lbEmailMsg;
        private Label lbPasswordMsg;
        private Label lbPhoneMsg;
        private TextBox TBAddrees;
    }
}