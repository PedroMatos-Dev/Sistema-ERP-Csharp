﻿namespace SistemaERP {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtLab_Exit = new System.Windows.Forms.Label();
            this.TxtLab_LoginAccount = new System.Windows.Forms.Label();
            this.TxtLab_Username = new System.Windows.Forms.Label();
            this.TxtBox_Name = new System.Windows.Forms.TextBox();
            this.TxtBox_Passaword = new System.Windows.Forms.TextBox();
            this.TxtLab_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.checkBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.TxtLab_RegisterAccount = new System.Windows.Forms.Label();
            this.btn_Signup = new System.Windows.Forms.Button();
            this.TxtLab_SalesSystem = new System.Windows.Forms.Label();
            this.picture_Sales = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Sales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.picture_Sales);
            this.panel1.Controls.Add(this.TxtLab_SalesSystem);
            this.panel1.Controls.Add(this.btn_Signup);
            this.panel1.Controls.Add(this.TxtLab_RegisterAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 361);
            this.panel1.TabIndex = 0;
            // 
            // TxtLab_Exit
            // 
            this.TxtLab_Exit.AutoSize = true;
            this.TxtLab_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtLab_Exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_Exit.Location = new System.Drawing.Point(532, 9);
            this.TxtLab_Exit.Name = "TxtLab_Exit";
            this.TxtLab_Exit.Size = new System.Drawing.Size(17, 18);
            this.TxtLab_Exit.TabIndex = 0;
            this.TxtLab_Exit.Text = "X";
            this.TxtLab_Exit.Click += new System.EventHandler(this.TxtLab_Exit_Click);
            // 
            // TxtLab_LoginAccount
            // 
            this.TxtLab_LoginAccount.AutoSize = true;
            this.TxtLab_LoginAccount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_LoginAccount.Location = new System.Drawing.Point(345, 82);
            this.TxtLab_LoginAccount.Name = "TxtLab_LoginAccount";
            this.TxtLab_LoginAccount.Size = new System.Drawing.Size(122, 23);
            this.TxtLab_LoginAccount.TabIndex = 1;
            this.TxtLab_LoginAccount.Text = "Login Account";
            // 
            // TxtLab_Username
            // 
            this.TxtLab_Username.AutoSize = true;
            this.TxtLab_Username.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_Username.Location = new System.Drawing.Point(280, 153);
            this.TxtLab_Username.Name = "TxtLab_Username";
            this.TxtLab_Username.Size = new System.Drawing.Size(70, 16);
            this.TxtLab_Username.TabIndex = 2;
            this.TxtLab_Username.Text = "Username:";
            // 
            // TxtBox_Name
            // 
            this.TxtBox_Name.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Name.Location = new System.Drawing.Point(283, 172);
            this.TxtBox_Name.Multiline = true;
            this.TxtBox_Name.Name = "TxtBox_Name";
            this.TxtBox_Name.Size = new System.Drawing.Size(240, 30);
            this.TxtBox_Name.TabIndex = 3;
            // 
            // TxtBox_Passaword
            // 
            this.TxtBox_Passaword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Passaword.Location = new System.Drawing.Point(283, 232);
            this.TxtBox_Passaword.Multiline = true;
            this.TxtBox_Passaword.Name = "TxtBox_Passaword";
            this.TxtBox_Passaword.Size = new System.Drawing.Size(240, 30);
            this.TxtBox_Passaword.TabIndex = 5;
            // 
            // TxtLab_Password
            // 
            this.TxtLab_Password.AutoSize = true;
            this.TxtLab_Password.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_Password.Location = new System.Drawing.Point(280, 213);
            this.TxtLab_Password.Name = "TxtLab_Password";
            this.TxtLab_Password.Size = new System.Drawing.Size(67, 16);
            this.TxtLab_Password.TabIndex = 4;
            this.TxtLab_Password.Text = "Password:";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Login.Location = new System.Drawing.Point(283, 293);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(89, 34);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = false;
            // 
            // checkBox_ShowPassword
            // 
            this.checkBox_ShowPassword.AutoSize = true;
            this.checkBox_ShowPassword.Location = new System.Drawing.Point(421, 268);
            this.checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            this.checkBox_ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.checkBox_ShowPassword.TabIndex = 7;
            this.checkBox_ShowPassword.Text = "Show Password";
            this.checkBox_ShowPassword.UseVisualStyleBackColor = true;
            // 
            // TxtLab_RegisterAccount
            // 
            this.TxtLab_RegisterAccount.AutoSize = true;
            this.TxtLab_RegisterAccount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_RegisterAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtLab_RegisterAccount.Location = new System.Drawing.Point(60, 267);
            this.TxtLab_RegisterAccount.Name = "TxtLab_RegisterAccount";
            this.TxtLab_RegisterAccount.Size = new System.Drawing.Size(132, 16);
            this.TxtLab_RegisterAccount.TabIndex = 0;
            this.TxtLab_RegisterAccount.Text = "Register your Account";
            // 
            // btn_Signup
            // 
            this.btn_Signup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Signup.FlatAppearance.BorderSize = 0;
            this.btn_Signup.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Signup.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Signup.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btn_Signup.Location = new System.Drawing.Point(34, 293);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.Size = new System.Drawing.Size(191, 34);
            this.btn_Signup.TabIndex = 1;
            this.btn_Signup.Text = "SIGNUP";
            this.btn_Signup.UseVisualStyleBackColor = false;
            // 
            // TxtLab_SalesSystem
            // 
            this.TxtLab_SalesSystem.AutoSize = true;
            this.TxtLab_SalesSystem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_SalesSystem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtLab_SalesSystem.Location = new System.Drawing.Point(30, 171);
            this.TxtLab_SalesSystem.Name = "TxtLab_SalesSystem";
            this.TxtLab_SalesSystem.Size = new System.Drawing.Size(213, 23);
            this.TxtLab_SalesSystem.TabIndex = 2;
            this.TxtLab_SalesSystem.Text = "Sales Management System";
            // 
            // picture_Sales
            // 
            this.picture_Sales.Image = global::SistemaERP.Properties.Resources.Total_Sales;
            this.picture_Sales.Location = new System.Drawing.Point(73, 54);
            this.picture_Sales.Name = "picture_Sales";
            this.picture_Sales.Size = new System.Drawing.Size(100, 100);
            this.picture_Sales.TabIndex = 3;
            this.picture_Sales.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(559, 361);
            this.Controls.Add(this.checkBox_ShowPassword);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.TxtBox_Passaword);
            this.Controls.Add(this.TxtLab_Password);
            this.Controls.Add(this.TxtBox_Name);
            this.Controls.Add(this.TxtLab_Username);
            this.Controls.Add(this.TxtLab_LoginAccount);
            this.Controls.Add(this.TxtLab_Exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Sales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TxtLab_Exit;
        private System.Windows.Forms.Label TxtLab_LoginAccount;
        private System.Windows.Forms.Label TxtLab_Username;
        private System.Windows.Forms.TextBox TxtBox_Name;
        private System.Windows.Forms.TextBox TxtBox_Passaword;
        private System.Windows.Forms.Label TxtLab_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.CheckBox checkBox_ShowPassword;
        private System.Windows.Forms.PictureBox picture_Sales;
        private System.Windows.Forms.Label TxtLab_SalesSystem;
        private System.Windows.Forms.Button btn_Signup;
        private System.Windows.Forms.Label TxtLab_RegisterAccount;
    }
}

