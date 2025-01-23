namespace SistemaERP {
    partial class Dashbord {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bnt_ConsultarVenda = new System.Windows.Forms.Button();
            this.bnt_GerarRelatorio = new System.Windows.Forms.Button();
            this.dgv_VendasRelatorio = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VendasRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.bnt_ConsultarVenda);
            this.panel1.Controls.Add(this.bnt_GerarRelatorio);
            this.panel1.Location = new System.Drawing.Point(3, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 97);
            this.panel1.TabIndex = 0;
            // 
            // bnt_ConsultarVenda
            // 
            this.bnt_ConsultarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.bnt_ConsultarVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_ConsultarVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_ConsultarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_ConsultarVenda.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_ConsultarVenda.ForeColor = System.Drawing.Color.White;
            this.bnt_ConsultarVenda.Location = new System.Drawing.Point(502, 18);
            this.bnt_ConsultarVenda.Name = "bnt_ConsultarVenda";
            this.bnt_ConsultarVenda.Size = new System.Drawing.Size(179, 52);
            this.bnt_ConsultarVenda.TabIndex = 1;
            this.bnt_ConsultarVenda.Text = "CONSULTAR VENDA";
            this.bnt_ConsultarVenda.UseVisualStyleBackColor = false;
            this.bnt_ConsultarVenda.Click += new System.EventHandler(this.bnt_ConsultarVenda_Click);
            // 
            // bnt_GerarRelatorio
            // 
            this.bnt_GerarRelatorio.AutoSize = true;
            this.bnt_GerarRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.bnt_GerarRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnt_GerarRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_GerarRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_GerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_GerarRelatorio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_GerarRelatorio.ForeColor = System.Drawing.Color.White;
            this.bnt_GerarRelatorio.Location = new System.Drawing.Point(185, 18);
            this.bnt_GerarRelatorio.Name = "bnt_GerarRelatorio";
            this.bnt_GerarRelatorio.Size = new System.Drawing.Size(179, 52);
            this.bnt_GerarRelatorio.TabIndex = 0;
            this.bnt_GerarRelatorio.Text = "GERAR RELATORIO";
            this.bnt_GerarRelatorio.UseVisualStyleBackColor = false;
            this.bnt_GerarRelatorio.Click += new System.EventHandler(this.bnt_GerarRelatorio_Click);
            // 
            // dgv_VendasRelatorio
            // 
            this.dgv_VendasRelatorio.AllowUserToAddRows = false;
            this.dgv_VendasRelatorio.AllowUserToDeleteRows = false;
            this.dgv_VendasRelatorio.AllowUserToOrderColumns = true;
            this.dgv_VendasRelatorio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.dgv_VendasRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VendasRelatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.CPF,
            this.Email,
            this.Endereço,
            this.Jogo,
            this.Quantidade,
            this.Valor,
            this.Data,
            this.Pagamento,
            this.Parcelas});
            this.dgv_VendasRelatorio.Location = new System.Drawing.Point(3, 3);
            this.dgv_VendasRelatorio.Name = "dgv_VendasRelatorio";
            this.dgv_VendasRelatorio.ReadOnly = true;
            this.dgv_VendasRelatorio.Size = new System.Drawing.Size(859, 456);
            this.dgv_VendasRelatorio.TabIndex = 1;
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
            this.Nome.Width = 140;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 70;
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
            this.Jogo.Width = 120;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 80;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 60;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data_Venda";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 70;
            // 
            // Pagamento
            // 
            this.Pagamento.HeaderText = "Pagamento";
            this.Pagamento.Name = "Pagamento";
            this.Pagamento.ReadOnly = true;
            this.Pagamento.Width = 75;
            // 
            // Parcelas
            // 
            this.Parcelas.HeaderText = "Parcelas";
            this.Parcelas.Name = "Parcelas";
            this.Parcelas.ReadOnly = true;
            this.Parcelas.Width = 70;
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dgv_VendasRelatorio);
            this.Controls.Add(this.panel1);
            this.Name = "Dashbord";
            this.Size = new System.Drawing.Size(865, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VendasRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_VendasRelatorio;
        private System.Windows.Forms.Button bnt_ConsultarVenda;
        private System.Windows.Forms.Button bnt_GerarRelatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcelas;
    }
}
