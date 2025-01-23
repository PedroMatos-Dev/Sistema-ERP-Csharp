namespace SistemaERP {
    partial class ConsultarVenda {
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
            this.dgv_VendasConsulta = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_Jogo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bnt_Sair = new System.Windows.Forms.Button();
            this.bnt_Limpar = new System.Windows.Forms.Button();
            this.bnt_Consultar = new System.Windows.Forms.Button();
            this.Txt_CPF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VendasConsulta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_VendasConsulta
            // 
            this.dgv_VendasConsulta.AllowUserToAddRows = false;
            this.dgv_VendasConsulta.AllowUserToDeleteRows = false;
            this.dgv_VendasConsulta.AllowUserToOrderColumns = true;
            this.dgv_VendasConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.dgv_VendasConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VendasConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.CPF,
            this.Email,
            this.Endereço,
            this.Jogo,
            this.Quantidade,
            this.Plataforma,
            this.Valor,
            this.Data_Venda,
            this.Pagamento,
            this.Parcelas});
            this.dgv_VendasConsulta.Location = new System.Drawing.Point(229, 3);
            this.dgv_VendasConsulta.Name = "dgv_VendasConsulta";
            this.dgv_VendasConsulta.ReadOnly = true;
            this.dgv_VendasConsulta.Size = new System.Drawing.Size(687, 559);
            this.dgv_VendasConsulta.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Endereço
            // 
            this.Endereço.HeaderText = "Endereço";
            this.Endereço.Name = "Endereço";
            this.Endereço.ReadOnly = true;
            // 
            // Jogo
            // 
            this.Jogo.HeaderText = "Jogo";
            this.Jogo.Name = "Jogo";
            this.Jogo.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Plataforma
            // 
            this.Plataforma.HeaderText = "Plataforma";
            this.Plataforma.Name = "Plataforma";
            this.Plataforma.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Data_Venda
            // 
            this.Data_Venda.HeaderText = "Data_Venda";
            this.Data_Venda.Name = "Data_Venda";
            this.Data_Venda.ReadOnly = true;
            // 
            // Pagamento
            // 
            this.Pagamento.HeaderText = "Pagamento";
            this.Pagamento.Name = "Pagamento";
            this.Pagamento.ReadOnly = true;
            // 
            // Parcelas
            // 
            this.Parcelas.HeaderText = "Parcelas";
            this.Parcelas.Name = "Parcelas";
            this.Parcelas.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.Txt_Jogo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bnt_Sair);
            this.panel1.Controls.Add(this.bnt_Limpar);
            this.panel1.Controls.Add(this.bnt_Consultar);
            this.panel1.Controls.Add(this.Txt_CPF);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Txt_Email);
            this.panel1.Controls.Add(this.Txt_Nome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 559);
            this.panel1.TabIndex = 2;
            // 
            // Txt_Jogo
            // 
            this.Txt_Jogo.Location = new System.Drawing.Point(30, 280);
            this.Txt_Jogo.Name = "Txt_Jogo";
            this.Txt_Jogo.Size = new System.Drawing.Size(163, 20);
            this.Txt_Jogo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Jogo:";
            // 
            // bnt_Sair
            // 
            this.bnt_Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.bnt_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Sair.Font = new System.Drawing.Font("Tahoma", 12F);
            this.bnt_Sair.ForeColor = System.Drawing.Color.White;
            this.bnt_Sair.Location = new System.Drawing.Point(65, 469);
            this.bnt_Sair.Name = "bnt_Sair";
            this.bnt_Sair.Size = new System.Drawing.Size(88, 47);
            this.bnt_Sair.TabIndex = 13;
            this.bnt_Sair.Text = "Sair";
            this.bnt_Sair.UseVisualStyleBackColor = false;
            this.bnt_Sair.Click += new System.EventHandler(this.bnt_Sair_Click);
            // 
            // bnt_Limpar
            // 
            this.bnt_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.bnt_Limpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_Limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Limpar.Font = new System.Drawing.Font("Tahoma", 12F);
            this.bnt_Limpar.ForeColor = System.Drawing.Color.White;
            this.bnt_Limpar.Location = new System.Drawing.Point(116, 402);
            this.bnt_Limpar.Name = "bnt_Limpar";
            this.bnt_Limpar.Size = new System.Drawing.Size(88, 47);
            this.bnt_Limpar.TabIndex = 12;
            this.bnt_Limpar.Text = "Limpar";
            this.bnt_Limpar.UseVisualStyleBackColor = false;
            this.bnt_Limpar.Click += new System.EventHandler(this.bnt_Limpar_Click);
            // 
            // bnt_Consultar
            // 
            this.bnt_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.bnt_Consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_Consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Consultar.Font = new System.Drawing.Font("Tahoma", 12F);
            this.bnt_Consultar.ForeColor = System.Drawing.Color.White;
            this.bnt_Consultar.Location = new System.Drawing.Point(12, 402);
            this.bnt_Consultar.Name = "bnt_Consultar";
            this.bnt_Consultar.Size = new System.Drawing.Size(88, 47);
            this.bnt_Consultar.TabIndex = 11;
            this.bnt_Consultar.Text = "Consultar";
            this.bnt_Consultar.UseVisualStyleBackColor = false;
            this.bnt_Consultar.Click += new System.EventHandler(this.bnt_Consultar_Click);
            // 
            // Txt_CPF
            // 
            this.Txt_CPF.Location = new System.Drawing.Point(30, 228);
            this.Txt_CPF.Name = "Txt_CPF";
            this.Txt_CPF.Size = new System.Drawing.Size(163, 20);
            this.Txt_CPF.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email:";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(30, 171);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(163, 20);
            this.Txt_Email.TabIndex = 5;
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(30, 114);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(163, 20);
            this.Txt_Nome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de Venda";
            // 
            // ConsultarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 565);
            this.Controls.Add(this.dgv_VendasConsulta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarVenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VendasConsulta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_VendasConsulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_Jogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bnt_Sair;
        private System.Windows.Forms.Button bnt_Limpar;
        private System.Windows.Forms.Button bnt_Consultar;
        private System.Windows.Forms.TextBox Txt_CPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcelas;
    }
}