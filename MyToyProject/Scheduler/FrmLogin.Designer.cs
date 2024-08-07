﻿namespace Scheduler
{
    partial class FrmLogin
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
            label1 = new Label();
            label2 = new Label();
            TxtId = new TextBox();
            TxtPassword = new TextBox();
            BtnLogin = new Button();
            BtnCancel = new Button();
            BtnSign = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 128);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 175);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "password";
            // 
            // TxtId
            // 
            TxtId.Location = new Point(111, 120);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(100, 23);
            TxtId.TabIndex = 2;
            TxtId.KeyPress += TxtId_KeyPress;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(111, 172);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '●';
            TxtPassword.Size = new Size(100, 23);
            TxtPassword.TabIndex = 3;
            TxtPassword.KeyPress += TxtPassword_KeyPress;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(57, 252);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(75, 27);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "로그인";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(150, 252);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 27);
            BtnCancel.TabIndex = 5;
            BtnCancel.Text = "취소";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSign
            // 
            BtnSign.BackgroundImage = Properties.Resources.free_icon_user_15228538;
            BtnSign.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSign.Location = new Point(236, 32);
            BtnSign.Name = "BtnSign";
            BtnSign.Size = new Size(34, 32);
            BtnSign.TabIndex = 6;
            BtnSign.UseVisualStyleBackColor = true;
            BtnSign.Click += BtnSign_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 344);
            Controls.Add(BtnSign);
            Controls.Add(BtnCancel);
            Controls.Add(BtnLogin);
            Controls.Add(TxtPassword);
            Controls.Add(TxtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtId;
        private TextBox TxtPassword;
        private Button BtnLogin;
        private Button BtnCancel;
        private Button BtnSign;
    }
}