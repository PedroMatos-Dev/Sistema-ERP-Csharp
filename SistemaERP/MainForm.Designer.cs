namespace SistemaERP
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bnt_Venda = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.bnt_Dashbord = new System.Windows.Forms.Button();
            this.bnt_Estoque = new System.Windows.Forms.Button();
            this.bnt_Cliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainForms = new System.Windows.Forms.Panel();
            this.painelVenda1 = new SistemaERP.PainelVenda();
            this.estoque1 = new SistemaERP.Estoque();
            this.clientes1 = new SistemaERP.Clientes();
            this.dashbord1 = new SistemaERP.Dashbord();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.lb_Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 35);
            this.panel1.TabIndex = 0;
            // 
            // lb_Exit
            // 
            this.lb_Exit.AutoSize = true;
            this.lb_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Exit.ForeColor = System.Drawing.Color.White;
            this.lb_Exit.Location = new System.Drawing.Point(1071, 7);
            this.lb_Exit.Name = "lb_Exit";
            this.lb_Exit.Size = new System.Drawing.Size(17, 18);
            this.lb_Exit.TabIndex = 1;
            this.lb_Exit.Text = "X";
            this.lb_Exit.Click += new System.EventHandler(this.lb_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Vendas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.bnt_Venda);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_Logout);
            this.panel2.Controls.Add(this.bnt_Dashbord);
            this.panel2.Controls.Add(this.bnt_Estoque);
            this.panel2.Controls.Add(this.bnt_Cliente);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 565);
            this.panel2.TabIndex = 1;
            // 
            // bnt_Venda
            // 
            this.bnt_Venda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_Venda.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(135)))));
            this.bnt_Venda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_Venda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_Venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Venda.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Venda.ForeColor = System.Drawing.Color.White;
            this.bnt_Venda.Image = global::SistemaERP.Properties.Resources.customers1;
            this.bnt_Venda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_Venda.Location = new System.Drawing.Point(21, 244);
            this.bnt_Venda.Name = "bnt_Venda";
            this.bnt_Venda.Size = new System.Drawing.Size(195, 45);
            this.bnt_Venda.TabIndex = 7;
            this.bnt_Venda.Text = "VENDA";
            this.bnt_Venda.UseVisualStyleBackColor = true;
            this.bnt_Venda.Click += new System.EventHandler(this.bnt_Venda_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Deslogar";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(135)))));
            this.btn_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(135)))));
            this.btn_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(135)))));
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Image = global::SistemaERP.Properties.Resources.Move_Up;
            this.btn_Logout.Location = new System.Drawing.Point(3, 527);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(35, 35);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // bnt_Dashbord
            // 
            this.bnt_Dashbord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_Dashbord.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(135)))));
            this.bnt_Dashbord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_Dashbord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_Dashbord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Dashbord.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Dashbord.ForeColor = System.Drawing.Color.White;
            this.bnt_Dashbord.Image = global::SistemaERP.Properties.Resources.Dashboard1;
            this.bnt_Dashbord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_Dashbord.Location = new System.Drawing.Point(21, 432);
            this.bnt_Dashbord.Name = "bnt_Dashbord";
            this.bnt_Dashbord.Size = new System.Drawing.Size(195, 45);
            this.bnt_Dashbord.TabIndex = 4;
            this.bnt_Dashbord.Text = "DASHBORD";
            this.bnt_Dashbord.UseVisualStyleBackColor = true;
            this.bnt_Dashbord.Click += new System.EventHandler(this.bnt_Dashbord_Click);
            // 
            // bnt_Estoque
            // 
            this.bnt_Estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_Estoque.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(135)))));
            this.bnt_Estoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_Estoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_Estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Estoque.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Estoque.ForeColor = System.Drawing.Color.White;
            this.bnt_Estoque.Image = global::SistemaERP.Properties.Resources.Sell_Stock1;
            this.bnt_Estoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_Estoque.Location = new System.Drawing.Point(21, 370);
            this.bnt_Estoque.Name = "bnt_Estoque";
            this.bnt_Estoque.Size = new System.Drawing.Size(195, 45);
            this.bnt_Estoque.TabIndex = 3;
            this.bnt_Estoque.Text = "ESTOQUE";
            this.bnt_Estoque.UseVisualStyleBackColor = true;
            this.bnt_Estoque.Click += new System.EventHandler(this.bnt_Estoque_Click);
            // 
            // bnt_Cliente
            // 
            this.bnt_Cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_Cliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(135)))));
            this.bnt_Cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_Cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Cliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Cliente.ForeColor = System.Drawing.Color.White;
            this.bnt_Cliente.Image = global::SistemaERP.Properties.Resources.customers1;
            this.bnt_Cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_Cliente.Location = new System.Drawing.Point(21, 306);
            this.bnt_Cliente.Name = "bnt_Cliente";
            this.bnt_Cliente.Size = new System.Drawing.Size(195, 45);
            this.bnt_Cliente.TabIndex = 2;
            this.bnt_Cliente.Text = "CLIENTE";
            this.bnt_Cliente.UseVisualStyleBackColor = true;
            this.bnt_Cliente.Click += new System.EventHandler(this.bnt_Cliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Olá, Usuario!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaERP.Properties.Resources.Total_Sales;
            this.pictureBox1.Location = new System.Drawing.Point(65, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForms
            // 
            this.MainForms.Controls.Add(this.painelVenda1);
            this.MainForms.Controls.Add(this.estoque1);
            this.MainForms.Controls.Add(this.clientes1);
            this.MainForms.Controls.Add(this.dashbord1);
            this.MainForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForms.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainForms.Location = new System.Drawing.Point(235, 35);
            this.MainForms.Name = "MainForms";
            this.MainForms.Size = new System.Drawing.Size(865, 565);
            this.MainForms.TabIndex = 2;
            // 
            // painelVenda1
            // 
            this.painelVenda1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.painelVenda1.Location = new System.Drawing.Point(0, 0);
            this.painelVenda1.Name = "painelVenda1";
            this.painelVenda1.Size = new System.Drawing.Size(865, 565);
            this.painelVenda1.TabIndex = 3;
            // 
            // estoque1
            // 
            this.estoque1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.estoque1.Location = new System.Drawing.Point(0, 0);
            this.estoque1.Name = "estoque1";
            this.estoque1.Size = new System.Drawing.Size(865, 565);
            this.estoque1.TabIndex = 2;
            // 
            // clientes1
            // 
            this.clientes1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientes1.Location = new System.Drawing.Point(0, 0);
            this.clientes1.Name = "clientes1";
            this.clientes1.Size = new System.Drawing.Size(865, 565);
            this.clientes1.TabIndex = 1;
            // 
            // dashbord1
            // 
            this.dashbord1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashbord1.Location = new System.Drawing.Point(0, 0);
            this.dashbord1.Name = "dashbord1";
            this.dashbord1.Size = new System.Drawing.Size(865, 565);
            this.dashbord1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.MainForms);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainForms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnt_Cliente;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button bnt_Dashbord;
        private System.Windows.Forms.Button bnt_Estoque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bnt_Venda;
        private System.Windows.Forms.Panel MainForms;
        private Clientes clientes1;
        private Dashbord dashbord1;
        private PainelVenda painelVenda1;
        private Estoque estoque1;
    }
}