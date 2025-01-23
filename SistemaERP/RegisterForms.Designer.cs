namespace SistemaERP {
    partial class RegisterForms {
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
            this.cb_ShowPassRegister = new System.Windows.Forms.CheckBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.TxtBox_PassRegister = new System.Windows.Forms.TextBox();
            this.TxtLab_Password = new System.Windows.Forms.Label();
            this.TxtBox_NameRegister = new System.Windows.Forms.TextBox();
            this.TxtLab_Username = new System.Windows.Forms.Label();
            this.TxtLab_LoginAccount = new System.Windows.Forms.Label();
            this.TxtLab_Exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture_Sales = new System.Windows.Forms.PictureBox();
            this.TxtLab_SalesSystem = new System.Windows.Forms.Label();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.TxtLab_RegisterAccount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Sales)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_ShowPassRegister
            // 
            this.cb_ShowPassRegister.AutoSize = true;
            this.cb_ShowPassRegister.Location = new System.Drawing.Point(438, 260);
            this.cb_ShowPassRegister.Name = "cb_ShowPassRegister";
            this.cb_ShowPassRegister.Size = new System.Drawing.Size(93, 17);
            this.cb_ShowPassRegister.TabIndex = 16;
            this.cb_ShowPassRegister.Text = "Mostrar senha";
            this.cb_ShowPassRegister.UseVisualStyleBackColor = true;
            this.cb_ShowPassRegister.CheckedChanged += new System.EventHandler(this.checkBox_ShowPassword_CheckedChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Login.Location = new System.Drawing.Point(300, 293);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(106, 34);
            this.btn_Login.TabIndex = 15;
            this.btn_Login.Text = "INSCREVER-SE";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // TxtBox_PassRegister
            // 
            this.TxtBox_PassRegister.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_PassRegister.Location = new System.Drawing.Point(300, 224);
            this.TxtBox_PassRegister.Multiline = true;
            this.TxtBox_PassRegister.Name = "TxtBox_PassRegister";
            this.TxtBox_PassRegister.PasswordChar = '*';
            this.TxtBox_PassRegister.Size = new System.Drawing.Size(240, 30);
            this.TxtBox_PassRegister.TabIndex = 14;
            // 
            // TxtLab_Password
            // 
            this.TxtLab_Password.AutoSize = true;
            this.TxtLab_Password.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_Password.Location = new System.Drawing.Point(297, 205);
            this.TxtLab_Password.Name = "TxtLab_Password";
            this.TxtLab_Password.Size = new System.Drawing.Size(48, 16);
            this.TxtLab_Password.TabIndex = 13;
            this.TxtLab_Password.Text = "Senha:";
            // 
            // TxtBox_NameRegister
            // 
            this.TxtBox_NameRegister.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_NameRegister.Location = new System.Drawing.Point(300, 164);
            this.TxtBox_NameRegister.Multiline = true;
            this.TxtBox_NameRegister.Name = "TxtBox_NameRegister";
            this.TxtBox_NameRegister.Size = new System.Drawing.Size(240, 30);
            this.TxtBox_NameRegister.TabIndex = 12;
            // 
            // TxtLab_Username
            // 
            this.TxtLab_Username.AutoSize = true;
            this.TxtLab_Username.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_Username.Location = new System.Drawing.Point(297, 145);
            this.TxtLab_Username.Name = "TxtLab_Username";
            this.TxtLab_Username.Size = new System.Drawing.Size(109, 16);
            this.TxtLab_Username.TabIndex = 11;
            this.TxtLab_Username.Text = "Nome de usuário:";
            // 
            // TxtLab_LoginAccount
            // 
            this.TxtLab_LoginAccount.AutoSize = true;
            this.TxtLab_LoginAccount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_LoginAccount.Location = new System.Drawing.Point(346, 79);
            this.TxtLab_LoginAccount.Name = "TxtLab_LoginAccount";
            this.TxtLab_LoginAccount.Size = new System.Drawing.Size(128, 23);
            this.TxtLab_LoginAccount.TabIndex = 10;
            this.TxtLab_LoginAccount.Text = "Registrar Conta";
            // 
            // TxtLab_Exit
            // 
            this.TxtLab_Exit.AutoSize = true;
            this.TxtLab_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtLab_Exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_Exit.Location = new System.Drawing.Point(545, 9);
            this.TxtLab_Exit.Name = "TxtLab_Exit";
            this.TxtLab_Exit.Size = new System.Drawing.Size(17, 18);
            this.TxtLab_Exit.TabIndex = 8;
            this.TxtLab_Exit.Text = "X";
            this.TxtLab_Exit.Click += new System.EventHandler(this.TxtLab_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.picture_Sales);
            this.panel1.Controls.Add(this.TxtLab_SalesSystem);
            this.panel1.Controls.Add(this.btn_SignIn);
            this.panel1.Controls.Add(this.TxtLab_RegisterAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 400);
            this.panel1.TabIndex = 9;
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
            this.TxtLab_SalesSystem.Size = new System.Drawing.Size(215, 23);
            this.TxtLab_SalesSystem.TabIndex = 2;
            this.TxtLab_SalesSystem.Text = "Sistema de Venda de jogos";
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SignIn.FlatAppearance.BorderSize = 0;
            this.btn_SignIn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SignIn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignIn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.btn_SignIn.Location = new System.Drawing.Point(29, 293);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(191, 34);
            this.btn_SignIn.TabIndex = 1;
            this.btn_SignIn.Text = "ENTRAR";
            this.btn_SignIn.UseVisualStyleBackColor = false;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // TxtLab_RegisterAccount
            // 
            this.TxtLab_RegisterAccount.AutoSize = true;
            this.TxtLab_RegisterAccount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLab_RegisterAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtLab_RegisterAccount.Location = new System.Drawing.Point(52, 261);
            this.TxtLab_RegisterAccount.Name = "TxtLab_RegisterAccount";
            this.TxtLab_RegisterAccount.Size = new System.Drawing.Size(142, 16);
            this.TxtLab_RegisterAccount.TabIndex = 0;
            this.TxtLab_RegisterAccount.Text = "Faça login na sua conta";
            // 
            // RegisterForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(575, 400);
            this.Controls.Add(this.cb_ShowPassRegister);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.TxtBox_PassRegister);
            this.Controls.Add(this.TxtLab_Password);
            this.Controls.Add(this.TxtBox_NameRegister);
            this.Controls.Add(this.TxtLab_Username);
            this.Controls.Add(this.TxtLab_LoginAccount);
            this.Controls.Add(this.TxtLab_Exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForms";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Sales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_ShowPassRegister;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox TxtBox_PassRegister;
        private System.Windows.Forms.Label TxtLab_Password;
        private System.Windows.Forms.TextBox TxtBox_NameRegister;
        private System.Windows.Forms.Label TxtLab_Username;
        private System.Windows.Forms.Label TxtLab_LoginAccount;
        private System.Windows.Forms.Label TxtLab_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picture_Sales;
        private System.Windows.Forms.Label TxtLab_SalesSystem;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Label TxtLab_RegisterAccount;
    }
}