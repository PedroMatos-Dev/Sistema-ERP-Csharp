namespace SistemaERP {
    partial class LoginForms {
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
            this.Txt_Exit = new System.Windows.Forms.Label();
            this.TxtLab_LoginAccount = new System.Windows.Forms.Label();
            this.TxtLab_Username = new System.Windows.Forms.Label();
            this.TxtBox_Username = new System.Windows.Forms.TextBox();
            this.TxtBox_Password = new System.Windows.Forms.TextBox();
            this.TxtLab_Password = new System.Windows.Forms.Label();
            this.checkBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.Btn_Signup = new System.Windows.Forms.Button();
            this.TxtLab_Register = new System.Windows.Forms.Label();
            this.TxtLab_SalesSystem = new System.Windows.Forms.Label();
            this.Picture01 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture01)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Picture01);
            this.panel1.Controls.Add(this.TxtLab_SalesSystem);
            this.panel1.Controls.Add(this.TxtLab_Register);
            this.panel1.Controls.Add(this.Btn_Signup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 400);
            this.panel1.TabIndex = 0;
            // 
            // Txt_Exit
            // 
            this.Txt_Exit.AutoSize = true;
            this.Txt_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_Exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Exit.Location = new System.Drawing.Point(546, 9);
            this.Txt_Exit.Name = "Txt_Exit";
            this.Txt_Exit.Size = new System.Drawing.Size(17, 18);
            this.Txt_Exit.TabIndex = 1;
            this.Txt_Exit.Text = "X";
            this.Txt_Exit.Click += new System.EventHandler(this.Txt_Exit_Click);
            // 
            // TxtLab_LoginAccount
            // 
            this.TxtLab_LoginAccount.AutoSize = true;
            this.TxtLab_LoginAccount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_LoginAccount.Location = new System.Drawing.Point(300, 95);
            this.TxtLab_LoginAccount.Name = "TxtLab_LoginAccount";
            this.TxtLab_LoginAccount.Size = new System.Drawing.Size(126, 23);
            this.TxtLab_LoginAccount.TabIndex = 2;
            this.TxtLab_LoginAccount.Text = "Login Account ";
            // 
            // TxtLab_Username
            // 
            this.TxtLab_Username.AutoSize = true;
            this.TxtLab_Username.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_Username.Location = new System.Drawing.Point(301, 165);
            this.TxtLab_Username.Name = "TxtLab_Username";
            this.TxtLab_Username.Size = new System.Drawing.Size(70, 16);
            this.TxtLab_Username.TabIndex = 3;
            this.TxtLab_Username.Text = "Username:";
            // 
            // TxtBox_Username
            // 
            this.TxtBox_Username.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Username.Location = new System.Drawing.Point(304, 184);
            this.TxtBox_Username.Multiline = true;
            this.TxtBox_Username.Name = "TxtBox_Username";
            this.TxtBox_Username.Size = new System.Drawing.Size(240, 30);
            this.TxtBox_Username.TabIndex = 4;
            // 
            // TxtBox_Password
            // 
            this.TxtBox_Password.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Password.Location = new System.Drawing.Point(304, 249);
            this.TxtBox_Password.Multiline = true;
            this.TxtBox_Password.Name = "TxtBox_Password";
            this.TxtBox_Password.Size = new System.Drawing.Size(240, 30);
            this.TxtBox_Password.TabIndex = 6;
            // 
            // TxtLab_Password
            // 
            this.TxtLab_Password.AutoSize = true;
            this.TxtLab_Password.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_Password.Location = new System.Drawing.Point(301, 230);
            this.TxtLab_Password.Name = "TxtLab_Password";
            this.TxtLab_Password.Size = new System.Drawing.Size(67, 16);
            this.TxtLab_Password.TabIndex = 5;
            this.TxtLab_Password.Text = "Password:";
            // 
            // checkBox_ShowPassword
            // 
            this.checkBox_ShowPassword.AutoSize = true;
            this.checkBox_ShowPassword.Location = new System.Drawing.Point(442, 285);
            this.checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            this.checkBox_ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.checkBox_ShowPassword.TabIndex = 7;
            this.checkBox_ShowPassword.Text = "Show Password";
            this.checkBox_ShowPassword.UseVisualStyleBackColor = true;
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
            this.btn_Login.Location = new System.Drawing.Point(304, 330);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(93, 33);
            this.btn_Login.TabIndex = 8;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = false;
            // 
            // Btn_Signup
            // 
            this.Btn_Signup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Signup.FlatAppearance.BorderSize = 0;
            this.Btn_Signup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Signup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_Signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Signup.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Btn_Signup.Location = new System.Drawing.Point(40, 329);
            this.Btn_Signup.Name = "Btn_Signup";
            this.Btn_Signup.Size = new System.Drawing.Size(186, 33);
            this.Btn_Signup.TabIndex = 0;
            this.Btn_Signup.Text = "SIGNUP";
            this.Btn_Signup.UseVisualStyleBackColor = false;
            // 
            // TxtLab_Register
            // 
            this.TxtLab_Register.AutoSize = true;
            this.TxtLab_Register.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_Register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtLab_Register.Location = new System.Drawing.Point(65, 301);
            this.TxtLab_Register.Name = "TxtLab_Register";
            this.TxtLab_Register.Size = new System.Drawing.Size(132, 16);
            this.TxtLab_Register.TabIndex = 1;
            this.TxtLab_Register.Text = "Register your Account";
            // 
            // TxtLab_SalesSystem
            // 
            this.TxtLab_SalesSystem.AutoSize = true;
            this.TxtLab_SalesSystem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_SalesSystem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtLab_SalesSystem.Location = new System.Drawing.Point(36, 203);
            this.TxtLab_SalesSystem.Name = "TxtLab_SalesSystem";
            this.TxtLab_SalesSystem.Size = new System.Drawing.Size(196, 19);
            this.TxtLab_SalesSystem.TabIndex = 2;
            this.TxtLab_SalesSystem.Text = "Sales Management System";
            // 
            // Picture01
            // 
            this.Picture01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture01.Image = global::SistemaERP.Properties.Resources.Total_Sales;
            this.Picture01.Location = new System.Drawing.Point(78, 80);
            this.Picture01.Name = "Picture01";
            this.Picture01.Size = new System.Drawing.Size(100, 100);
            this.Picture01.TabIndex = 3;
            this.Picture01.TabStop = false;
            // 
            // LoginForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(575, 400);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.checkBox_ShowPassword);
            this.Controls.Add(this.TxtBox_Password);
            this.Controls.Add(this.TxtLab_Password);
            this.Controls.Add(this.TxtBox_Username);
            this.Controls.Add(this.TxtLab_Username);
            this.Controls.Add(this.TxtLab_LoginAccount);
            this.Controls.Add(this.Txt_Exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Txt_Exit;
        private System.Windows.Forms.Label TxtLab_LoginAccount;
        private System.Windows.Forms.Label TxtLab_Username;
        private System.Windows.Forms.TextBox TxtBox_Username;
        private System.Windows.Forms.TextBox TxtBox_Password;
        private System.Windows.Forms.Label TxtLab_Password;
        private System.Windows.Forms.CheckBox checkBox_ShowPassword;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label TxtLab_SalesSystem;
        private System.Windows.Forms.Label TxtLab_Register;
        private System.Windows.Forms.Button Btn_Signup;
        private System.Windows.Forms.PictureBox Picture01;
    }
}

