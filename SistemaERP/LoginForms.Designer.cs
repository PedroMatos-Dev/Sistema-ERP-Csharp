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
            this.picture_Sales = new System.Windows.Forms.PictureBox();
            this.TxtLab_SalesSystem = new System.Windows.Forms.Label();
            this.btn_Signup = new System.Windows.Forms.Button();
            this.TxtLab_RegisterAccount = new System.Windows.Forms.Label();
            this.TxtLab_Exit = new System.Windows.Forms.Label();
            this.TxtLab_LoginAccount = new System.Windows.Forms.Label();
            this.TxtLab_Username = new System.Windows.Forms.Label();
            this.TxtBox_NameLogin = new System.Windows.Forms.TextBox();
            this.TxtBox_PassLogin = new System.Windows.Forms.TextBox();
            this.TxtLab_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.cb_ShowPassLogin = new System.Windows.Forms.CheckBox();
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
            this.panel1.Size = new System.Drawing.Size(256, 400);
            this.panel1.TabIndex = 0;
            // 
            // picture_Sales
            // 
            this.picture_Sales.Image = global::SistemaERP.Properties.Resources.Total_Sales;
            this.picture_Sales.Location = new System.Drawing.Point(68, 55);
            this.picture_Sales.Name = "picture_Sales";
            this.picture_Sales.Size = new System.Drawing.Size(100, 100);
            this.picture_Sales.TabIndex = 3;
            this.picture_Sales.TabStop = false;
            // 
            // TxtLab_SalesSystem
            // 
            this.TxtLab_SalesSystem.AutoSize = true;
            this.TxtLab_SalesSystem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_SalesSystem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtLab_SalesSystem.Location = new System.Drawing.Point(25, 172);
            this.TxtLab_SalesSystem.Name = "TxtLab_SalesSystem";
            this.TxtLab_SalesSystem.Size = new System.Drawing.Size(213, 23);
            this.TxtLab_SalesSystem.TabIndex = 2;
            this.TxtLab_SalesSystem.Text = "Sales Management System";
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
            this.btn_Signup.Location = new System.Drawing.Point(29, 293);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.Size = new System.Drawing.Size(191, 34);
            this.btn_Signup.TabIndex = 1;
            this.btn_Signup.Text = "SIGNUP";
            this.btn_Signup.UseVisualStyleBackColor = false;
            this.btn_Signup.Click += new System.EventHandler(this.btn_Signup_Click);
            // 
            // TxtLab_RegisterAccount
            // 
            this.TxtLab_RegisterAccount.AutoSize = true;
            this.TxtLab_RegisterAccount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_RegisterAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtLab_RegisterAccount.Location = new System.Drawing.Point(65, 261);
            this.TxtLab_RegisterAccount.Name = "TxtLab_RegisterAccount";
            this.TxtLab_RegisterAccount.Size = new System.Drawing.Size(132, 16);
            this.TxtLab_RegisterAccount.TabIndex = 0;
            this.TxtLab_RegisterAccount.Text = "Register your Account";
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
            this.TxtLab_LoginAccount.Location = new System.Drawing.Point(357, 75);
            this.TxtLab_LoginAccount.Name = "TxtLab_LoginAccount";
            this.TxtLab_LoginAccount.Size = new System.Drawing.Size(122, 23);
            this.TxtLab_LoginAccount.TabIndex = 1;
            this.TxtLab_LoginAccount.Text = "Login Account";
            // 
            // TxtLab_Username
            // 
            this.TxtLab_Username.AutoSize = true;
            this.TxtLab_Username.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_Username.Location = new System.Drawing.Point(292, 147);
            this.TxtLab_Username.Name = "TxtLab_Username";
            this.TxtLab_Username.Size = new System.Drawing.Size(70, 16);
            this.TxtLab_Username.TabIndex = 2;
            this.TxtLab_Username.Text = "Username:";
            // 
            // TxtBox_NameLogin
            // 
            this.TxtBox_NameLogin.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_NameLogin.Location = new System.Drawing.Point(295, 166);
            this.TxtBox_NameLogin.Multiline = true;
            this.TxtBox_NameLogin.Name = "TxtBox_NameLogin";
            this.TxtBox_NameLogin.Size = new System.Drawing.Size(240, 30);
            this.TxtBox_NameLogin.TabIndex = 3;
            // 
            // TxtBox_PassLogin
            // 
            this.TxtBox_PassLogin.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_PassLogin.Location = new System.Drawing.Point(295, 226);
            this.TxtBox_PassLogin.Multiline = true;
            this.TxtBox_PassLogin.Name = "TxtBox_PassLogin";
            this.TxtBox_PassLogin.PasswordChar = '*';
            this.TxtBox_PassLogin.Size = new System.Drawing.Size(240, 30);
            this.TxtBox_PassLogin.TabIndex = 5;
            // 
            // TxtLab_Password
            // 
            this.TxtLab_Password.AutoSize = true;
            this.TxtLab_Password.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_Password.Location = new System.Drawing.Point(292, 207);
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
            this.btn_Login.Location = new System.Drawing.Point(295, 293);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(89, 34);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // cb_ShowPassLogin
            // 
            this.cb_ShowPassLogin.AutoSize = true;
            this.cb_ShowPassLogin.Location = new System.Drawing.Point(433, 262);
            this.cb_ShowPassLogin.Name = "cb_ShowPassLogin";
            this.cb_ShowPassLogin.Size = new System.Drawing.Size(102, 17);
            this.cb_ShowPassLogin.TabIndex = 7;
            this.cb_ShowPassLogin.Text = "Show Password";
            this.cb_ShowPassLogin.UseVisualStyleBackColor = true;
            this.cb_ShowPassLogin.CheckedChanged += new System.EventHandler(this.cb_ShowPassLogin_CheckedChanged);
            // 
            // LoginForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(575, 400);
            this.Controls.Add(this.cb_ShowPassLogin);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.TxtBox_PassLogin);
            this.Controls.Add(this.TxtLab_Password);
            this.Controls.Add(this.TxtBox_NameLogin);
            this.Controls.Add(this.TxtLab_Username);
            this.Controls.Add(this.TxtLab_LoginAccount);
            this.Controls.Add(this.TxtLab_Exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForms_Load);
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
        private System.Windows.Forms.TextBox TxtBox_NameLogin;
        private System.Windows.Forms.TextBox TxtBox_PassLogin;
        private System.Windows.Forms.Label TxtLab_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.CheckBox cb_ShowPassLogin;
        private System.Windows.Forms.PictureBox picture_Sales;
        private System.Windows.Forms.Label TxtLab_SalesSystem;
        private System.Windows.Forms.Button btn_Signup;
        private System.Windows.Forms.Label TxtLab_RegisterAccount;
    }
}

