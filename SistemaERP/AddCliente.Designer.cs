namespace SistemaERP {
    partial class AddCliente {
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bnt_SalvarAlterar = new System.Windows.Forms.Button();
            this.Btn_Adicionar = new System.Windows.Forms.Button();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Grb_Endereco = new System.Windows.Forms.GroupBox();
            this.Txt_Numero = new System.Windows.Forms.TextBox();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_Longadouro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_CEP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Grb_DadosPessoais = new System.Windows.Forms.GroupBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_ID = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.Txt_Celular = new System.Windows.Forms.MaskedTextBox();
            this.Txt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.Grb_Sexo = new System.Windows.Forms.GroupBox();
            this.Rdo_Masculino = new System.Windows.Forms.RadioButton();
            this.Rdo_Feminino = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_TelAlt = new System.Windows.Forms.TextBox();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bnt_CancelarAlterar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Grb_Endereco.SuspendLayout();
            this.Grb_DadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ID)).BeginInit();
            this.Grb_Sexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 104);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(232, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 37);
            this.label1.TabIndex = 37;
            this.label1.Text = "Cadastro de Cliente";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.bnt_CancelarAlterar);
            this.panel2.Controls.Add(this.bnt_SalvarAlterar);
            this.panel2.Controls.Add(this.Btn_Adicionar);
            this.panel2.Controls.Add(this.Btn_Alterar);
            this.panel2.Controls.Add(this.Btn_Excluir);
            this.panel2.Controls.Add(this.Btn_Sair);
            this.panel2.Controls.Add(this.Btn_Limpar);
            this.panel2.Controls.Add(this.Grb_Endereco);
            this.panel2.Controls.Add(this.Grb_DadosPessoais);
            this.panel2.Location = new System.Drawing.Point(3, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 420);
            this.panel2.TabIndex = 1;
            // 
            // bnt_SalvarAlterar
            // 
            this.bnt_SalvarAlterar.Enabled = false;
            this.bnt_SalvarAlterar.Location = new System.Drawing.Point(188, 314);
            this.bnt_SalvarAlterar.Name = "bnt_SalvarAlterar";
            this.bnt_SalvarAlterar.Size = new System.Drawing.Size(90, 70);
            this.bnt_SalvarAlterar.TabIndex = 41;
            this.bnt_SalvarAlterar.Text = "Salvar";
            this.bnt_SalvarAlterar.UseVisualStyleBackColor = true;
            this.bnt_SalvarAlterar.Visible = false;
            this.bnt_SalvarAlterar.Click += new System.EventHandler(this.bnt_SalvarAlterar_Click);
            // 
            // Btn_Adicionar
            // 
            this.Btn_Adicionar.Location = new System.Drawing.Point(62, 314);
            this.Btn_Adicionar.Name = "Btn_Adicionar";
            this.Btn_Adicionar.Size = new System.Drawing.Size(90, 70);
            this.Btn_Adicionar.TabIndex = 24;
            this.Btn_Adicionar.Text = "Adicionar";
            this.Btn_Adicionar.UseVisualStyleBackColor = true;
            this.Btn_Adicionar.Click += new System.EventHandler(this.Btn_Adicionar_Click);
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.Location = new System.Drawing.Point(188, 314);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(90, 70);
            this.Btn_Alterar.TabIndex = 25;
            this.Btn_Alterar.Text = "Alterar";
            this.Btn_Alterar.UseVisualStyleBackColor = true;
            this.Btn_Alterar.Click += new System.EventHandler(this.Btn_Alterar_Click);
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Location = new System.Drawing.Point(315, 314);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(90, 70);
            this.Btn_Excluir.TabIndex = 26;
            this.Btn_Excluir.Text = "&Excluir";
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(577, 314);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(90, 70);
            this.Btn_Sair.TabIndex = 40;
            this.Btn_Sair.Text = "&Sair";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Location = new System.Drawing.Point(445, 314);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(90, 70);
            this.Btn_Limpar.TabIndex = 39;
            this.Btn_Limpar.Text = "&Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Grb_Endereco
            // 
            this.Grb_Endereco.Controls.Add(this.Txt_Numero);
            this.Grb_Endereco.Controls.Add(this.Cbo_Estado);
            this.Grb_Endereco.Controls.Add(this.label13);
            this.Grb_Endereco.Controls.Add(this.label12);
            this.Grb_Endereco.Controls.Add(this.Txt_Cidade);
            this.Grb_Endereco.Controls.Add(this.Txt_Bairro);
            this.Grb_Endereco.Controls.Add(this.label11);
            this.Grb_Endereco.Controls.Add(this.label10);
            this.Grb_Endereco.Controls.Add(this.Txt_Longadouro);
            this.Grb_Endereco.Controls.Add(this.label9);
            this.Grb_Endereco.Controls.Add(this.Txt_CEP);
            this.Grb_Endereco.Controls.Add(this.label8);
            this.Grb_Endereco.ForeColor = System.Drawing.Color.White;
            this.Grb_Endereco.Location = new System.Drawing.Point(20, 201);
            this.Grb_Endereco.Name = "Grb_Endereco";
            this.Grb_Endereco.Size = new System.Drawing.Size(696, 84);
            this.Grb_Endereco.TabIndex = 35;
            this.Grb_Endereco.TabStop = false;
            this.Grb_Endereco.Text = "Endereço";
            // 
            // Txt_Numero
            // 
            this.Txt_Numero.Location = new System.Drawing.Point(70, 46);
            this.Txt_Numero.Name = "Txt_Numero";
            this.Txt_Numero.Size = new System.Drawing.Size(60, 20);
            this.Txt_Numero.TabIndex = 14;
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PE",
            "PB",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SE",
            "SC",
            "SP",
            "TO"});
            this.Cbo_Estado.Location = new System.Drawing.Point(185, 46);
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(41, 21);
            this.Cbo_Estado.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(136, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Estado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(442, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = " Cidade:";
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Location = new System.Drawing.Point(494, 46);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(163, 20);
            this.Txt_Cidade.TabIndex = 16;
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(289, 46);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(154, 20);
            this.Txt_Bairro.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(246, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Bairro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Número:";
            // 
            // Txt_Longadouro
            // 
            this.Txt_Longadouro.Location = new System.Drawing.Point(289, 19);
            this.Txt_Longadouro.Name = "Txt_Longadouro";
            this.Txt_Longadouro.Size = new System.Drawing.Size(368, 20);
            this.Txt_Longadouro.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Longadouro:";
            // 
            // Txt_CEP
            // 
            this.Txt_CEP.Location = new System.Drawing.Point(70, 19);
            this.Txt_CEP.Name = "Txt_CEP";
            this.Txt_CEP.Size = new System.Drawing.Size(134, 20);
            this.Txt_CEP.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "CEP:";
            // 
            // Grb_DadosPessoais
            // 
            this.Grb_DadosPessoais.Controls.Add(this.Txt_Email);
            this.Grb_DadosPessoais.Controls.Add(this.Txt_ID);
            this.Grb_DadosPessoais.Controls.Add(this.label14);
            this.Grb_DadosPessoais.Controls.Add(this.Txt_Celular);
            this.Grb_DadosPessoais.Controls.Add(this.Txt_CPF);
            this.Grb_DadosPessoais.Controls.Add(this.Grb_Sexo);
            this.Grb_DadosPessoais.Controls.Add(this.label7);
            this.Grb_DadosPessoais.Controls.Add(this.label6);
            this.Grb_DadosPessoais.Controls.Add(this.label5);
            this.Grb_DadosPessoais.Controls.Add(this.Txt_TelAlt);
            this.Grb_DadosPessoais.Controls.Add(this.Txt_Nome);
            this.Grb_DadosPessoais.Controls.Add(this.label3);
            this.Grb_DadosPessoais.Controls.Add(this.label2);
            this.Grb_DadosPessoais.ForeColor = System.Drawing.Color.White;
            this.Grb_DadosPessoais.Location = new System.Drawing.Point(20, 14);
            this.Grb_DadosPessoais.Name = "Grb_DadosPessoais";
            this.Grb_DadosPessoais.Size = new System.Drawing.Size(696, 181);
            this.Grb_DadosPessoais.TabIndex = 34;
            this.Grb_DadosPessoais.TabStop = false;
            this.Grb_DadosPessoais.Text = "Dados Pessoais";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(321, 71);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(336, 20);
            this.Txt_Email.TabIndex = 18;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Location = new System.Drawing.Point(70, 19);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(120, 20);
            this.Txt_ID.TabIndex = 21;
            this.Txt_ID.ValueChanged += new System.EventHandler(this.Txt_ID_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(277, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "E-mail:";
            // 
            // Txt_Celular
            // 
            this.Txt_Celular.Location = new System.Drawing.Point(70, 99);
            this.Txt_Celular.Mask = "(99) 0 0000-0000";
            this.Txt_Celular.Name = "Txt_Celular";
            this.Txt_Celular.Size = new System.Drawing.Size(154, 20);
            this.Txt_Celular.TabIndex = 7;
            // 
            // Txt_CPF
            // 
            this.Txt_CPF.Location = new System.Drawing.Point(70, 71);
            this.Txt_CPF.Mask = "000,000,000-99";
            this.Txt_CPF.Name = "Txt_CPF";
            this.Txt_CPF.Size = new System.Drawing.Size(154, 20);
            this.Txt_CPF.TabIndex = 6;
            // 
            // Grb_Sexo
            // 
            this.Grb_Sexo.Controls.Add(this.Rdo_Masculino);
            this.Grb_Sexo.Controls.Add(this.Rdo_Feminino);
            this.Grb_Sexo.ForeColor = System.Drawing.Color.White;
            this.Grb_Sexo.Location = new System.Drawing.Point(19, 122);
            this.Grb_Sexo.Name = "Grb_Sexo";
            this.Grb_Sexo.Size = new System.Drawing.Size(206, 47);
            this.Grb_Sexo.TabIndex = 9;
            this.Grb_Sexo.TabStop = false;
            this.Grb_Sexo.Text = "Sexo:";
            // 
            // Rdo_Masculino
            // 
            this.Rdo_Masculino.AutoSize = true;
            this.Rdo_Masculino.Location = new System.Drawing.Point(112, 18);
            this.Rdo_Masculino.Name = "Rdo_Masculino";
            this.Rdo_Masculino.Size = new System.Drawing.Size(73, 17);
            this.Rdo_Masculino.TabIndex = 11;
            this.Rdo_Masculino.TabStop = true;
            this.Rdo_Masculino.Text = "Masculino";
            this.Rdo_Masculino.UseVisualStyleBackColor = true;
            // 
            // Rdo_Feminino
            // 
            this.Rdo_Feminino.AutoSize = true;
            this.Rdo_Feminino.Location = new System.Drawing.Point(28, 18);
            this.Rdo_Feminino.Name = "Rdo_Feminino";
            this.Rdo_Feminino.Size = new System.Drawing.Size(67, 17);
            this.Rdo_Feminino.TabIndex = 10;
            this.Rdo_Feminino.TabStop = true;
            this.Rdo_Feminino.Text = "Feminino";
            this.Rdo_Feminino.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tel. Alternativo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "C.P.F.:";
            // 
            // Txt_TelAlt
            // 
            this.Txt_TelAlt.Location = new System.Drawing.Point(321, 96);
            this.Txt_TelAlt.Name = "Txt_TelAlt";
            this.Txt_TelAlt.Size = new System.Drawing.Size(154, 20);
            this.Txt_TelAlt.TabIndex = 8;
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(70, 44);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(587, 20);
            this.Txt_Nome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // bnt_CancelarAlterar
            // 
            this.bnt_CancelarAlterar.Enabled = false;
            this.bnt_CancelarAlterar.Location = new System.Drawing.Point(62, 314);
            this.bnt_CancelarAlterar.Name = "bnt_CancelarAlterar";
            this.bnt_CancelarAlterar.Size = new System.Drawing.Size(90, 70);
            this.bnt_CancelarAlterar.TabIndex = 42;
            this.bnt_CancelarAlterar.Text = "Cancelar";
            this.bnt_CancelarAlterar.UseVisualStyleBackColor = true;
            this.bnt_CancelarAlterar.Visible = false;
            this.bnt_CancelarAlterar.Click += new System.EventHandler(this.bnt_CancelarAlterar_Click);
            // 
            // AddCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(747, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.Grb_Endereco.ResumeLayout(false);
            this.Grb_Endereco.PerformLayout();
            this.Grb_DadosPessoais.ResumeLayout(false);
            this.Grb_DadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ID)).EndInit();
            this.Grb_Sexo.ResumeLayout(false);
            this.Grb_Sexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Excluir;
        private System.Windows.Forms.Button Btn_Alterar;
        private System.Windows.Forms.Button Btn_Adicionar;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox Grb_Endereco;
        private System.Windows.Forms.TextBox Txt_Numero;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_Longadouro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_CEP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox Grb_DadosPessoais;
        private System.Windows.Forms.MaskedTextBox Txt_Celular;
        private System.Windows.Forms.MaskedTextBox Txt_CPF;
        private System.Windows.Forms.GroupBox Grb_Sexo;
        private System.Windows.Forms.RadioButton Rdo_Masculino;
        private System.Windows.Forms.RadioButton Rdo_Feminino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_TelAlt;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Txt_ID;
        private System.Windows.Forms.Button bnt_SalvarAlterar;
        private System.Windows.Forms.Button bnt_CancelarAlterar;
    }
}
