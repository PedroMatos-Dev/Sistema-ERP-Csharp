namespace SistemaERP {
    partial class Clientes {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel2 = new System.Windows.Forms.Panel();
            this.dvg_TodosClientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bnt_GerarRelatorio = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_ClientesAtivo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bnt_ConsultarCliente = new System.Windows.Forms.Button();
            this.bnt_AddCliente = new System.Windows.Forms.Button();
            this.pnl_TotalCliente = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_TotalClientes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_TodosClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_TotalCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.dvg_TodosClientes);
            this.panel2.Location = new System.Drawing.Point(13, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 412);
            this.panel2.TabIndex = 1;
            // 
            // dvg_TodosClientes
            // 
            this.dvg_TodosClientes.AllowUserToAddRows = false;
            this.dvg_TodosClientes.AllowUserToDeleteRows = false;
            this.dvg_TodosClientes.AllowUserToOrderColumns = true;
            this.dvg_TodosClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.dvg_TodosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_TodosClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.CPF,
            this.Celular,
            this.Email,
            this.Cidade,
            this.Endereço,
            this.CEP,
            this.Data});
            this.dvg_TodosClientes.Location = new System.Drawing.Point(0, 0);
            this.dvg_TodosClientes.Name = "dvg_TodosClientes";
            this.dvg_TodosClientes.ReadOnly = true;
            this.dvg_TodosClientes.Size = new System.Drawing.Size(838, 412);
            this.dvg_TodosClientes.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 140;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 70;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 70;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 130;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // Endereço
            // 
            this.Endereço.HeaderText = "Endereço";
            this.Endereço.Name = "Endereço";
            this.Endereço.ReadOnly = true;
            this.Endereço.Width = 140;
            // 
            // CEP
            // 
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            this.CEP.Width = 70;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.bnt_GerarRelatorio);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.bnt_ConsultarCliente);
            this.panel1.Controls.Add(this.bnt_AddCliente);
            this.panel1.Controls.Add(this.pnl_TotalCliente);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 103);
            this.panel1.TabIndex = 2;
            // 
            // bnt_GerarRelatorio
            // 
            this.bnt_GerarRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_GerarRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_GerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_GerarRelatorio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_GerarRelatorio.ForeColor = System.Drawing.Color.White;
            this.bnt_GerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_GerarRelatorio.Location = new System.Drawing.Point(702, 27);
            this.bnt_GerarRelatorio.Name = "bnt_GerarRelatorio";
            this.bnt_GerarRelatorio.Size = new System.Drawing.Size(113, 63);
            this.bnt_GerarRelatorio.TabIndex = 4;
            this.bnt_GerarRelatorio.Text = "Gerar Relatorio";
            this.bnt_GerarRelatorio.UseVisualStyleBackColor = false;
            this.bnt_GerarRelatorio.Click += new System.EventHandler(this.bnt_GerarRelatorio_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.lb_ClientesAtivo);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(231, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 78);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::SistemaERP.Properties.Resources.customers;
            this.pictureBox2.Location = new System.Drawing.Point(3, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lb_ClientesAtivo
            // 
            this.lb_ClientesAtivo.AutoSize = true;
            this.lb_ClientesAtivo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ClientesAtivo.ForeColor = System.Drawing.Color.White;
            this.lb_ClientesAtivo.Location = new System.Drawing.Point(89, 15);
            this.lb_ClientesAtivo.Name = "lb_ClientesAtivo";
            this.lb_ClientesAtivo.Size = new System.Drawing.Size(18, 19);
            this.lb_ClientesAtivo.TabIndex = 1;
            this.lb_ClientesAtivo.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Clientes Ativos";
            // 
            // bnt_ConsultarCliente
            // 
            this.bnt_ConsultarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_ConsultarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_ConsultarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_ConsultarCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_ConsultarCliente.ForeColor = System.Drawing.Color.White;
            this.bnt_ConsultarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_ConsultarCliente.Location = new System.Drawing.Point(573, 27);
            this.bnt_ConsultarCliente.Name = "bnt_ConsultarCliente";
            this.bnt_ConsultarCliente.Size = new System.Drawing.Size(113, 63);
            this.bnt_ConsultarCliente.TabIndex = 3;
            this.bnt_ConsultarCliente.Text = "Consultar Cliente";
            this.bnt_ConsultarCliente.UseVisualStyleBackColor = false;
            this.bnt_ConsultarCliente.Click += new System.EventHandler(this.bnt_ConsultarCliente_Click);
            // 
            // bnt_AddCliente
            // 
            this.bnt_AddCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_AddCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_AddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_AddCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_AddCliente.ForeColor = System.Drawing.Color.White;
            this.bnt_AddCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_AddCliente.Location = new System.Drawing.Point(443, 27);
            this.bnt_AddCliente.Name = "bnt_AddCliente";
            this.bnt_AddCliente.Size = new System.Drawing.Size(113, 63);
            this.bnt_AddCliente.TabIndex = 2;
            this.bnt_AddCliente.Text = "Adicionar Cliente";
            this.bnt_AddCliente.UseVisualStyleBackColor = false;
            this.bnt_AddCliente.Click += new System.EventHandler(this.bnt_AddCliente_Click);
            // 
            // pnl_TotalCliente
            // 
            this.pnl_TotalCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.pnl_TotalCliente.Controls.Add(this.pictureBox1);
            this.pnl_TotalCliente.Controls.Add(this.lb_TotalClientes);
            this.pnl_TotalCliente.Controls.Add(this.label1);
            this.pnl_TotalCliente.Location = new System.Drawing.Point(28, 12);
            this.pnl_TotalCliente.Name = "pnl_TotalCliente";
            this.pnl_TotalCliente.Size = new System.Drawing.Size(148, 78);
            this.pnl_TotalCliente.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::SistemaERP.Properties.Resources.customers;
            this.pictureBox1.Location = new System.Drawing.Point(3, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lb_TotalClientes
            // 
            this.lb_TotalClientes.AutoSize = true;
            this.lb_TotalClientes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalClientes.ForeColor = System.Drawing.Color.White;
            this.lb_TotalClientes.Location = new System.Drawing.Point(89, 15);
            this.lb_TotalClientes.Name = "lb_TotalClientes";
            this.lb_TotalClientes.Size = new System.Drawing.Size(18, 19);
            this.lb_TotalClientes.TabIndex = 1;
            this.lb_TotalClientes.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Clientes";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Clientes";
            this.Size = new System.Drawing.Size(865, 565);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_TodosClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_TotalCliente.ResumeLayout(false);
            this.pnl_TotalCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_TotalCliente;
        private System.Windows.Forms.DataGridView dvg_TodosClientes;
        private System.Windows.Forms.Label lb_TotalClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bnt_AddCliente;
        private System.Windows.Forms.Button bnt_ConsultarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_ClientesAtivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bnt_GerarRelatorio;
    }
}
