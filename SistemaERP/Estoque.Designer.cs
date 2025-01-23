namespace SistemaERP {
    partial class Estoque {
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
            this.dgv_MostrarJogos = new System.Windows.Forms.DataGridView();
            this.pcb_FotoJogo = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Cbo_Plataforma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbo_Genero = new System.Windows.Forms.ComboBox();
            this.bnt_AdicionarJogo = new System.Windows.Forms.Button();
            this.bnt_EditarJogo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bnt_ImportaFoto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Quantidade = new System.Windows.Forms.TextBox();
            this.bnt_SalvarAlteracao = new System.Windows.Forms.Button();
            this.Cbo_Jogos = new System.Windows.Forms.ComboBox();
            this.bnt_CancelarAlteracao = new System.Windows.Forms.Button();
            this.JOGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLATAFORMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_ValorJogo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MostrarJogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_FotoJogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_MostrarJogos
            // 
            this.dgv_MostrarJogos.AllowUserToAddRows = false;
            this.dgv_MostrarJogos.AllowUserToDeleteRows = false;
            this.dgv_MostrarJogos.AllowUserToOrderColumns = true;
            this.dgv_MostrarJogos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.dgv_MostrarJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MostrarJogos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JOGO,
            this.VALOR,
            this.QUANTIDADE,
            this.GENERO,
            this.PLATAFORMA});
            this.dgv_MostrarJogos.Location = new System.Drawing.Point(287, 3);
            this.dgv_MostrarJogos.Name = "dgv_MostrarJogos";
            this.dgv_MostrarJogos.ReadOnly = true;
            this.dgv_MostrarJogos.Size = new System.Drawing.Size(575, 559);
            this.dgv_MostrarJogos.TabIndex = 1;
            // 
            // pcb_FotoJogo
            // 
            this.pcb_FotoJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.pcb_FotoJogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb_FotoJogo.Location = new System.Drawing.Point(67, 42);
            this.pcb_FotoJogo.Name = "pcb_FotoJogo";
            this.pcb_FotoJogo.Size = new System.Drawing.Size(140, 140);
            this.pcb_FotoJogo.TabIndex = 0;
            this.pcb_FotoJogo.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Plataforma:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(46, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Jogo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(44, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Valor:";
            // 
            // Cbo_Plataforma
            // 
            this.Cbo_Plataforma.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Plataforma.FormattingEnabled = true;
            this.Cbo_Plataforma.Items.AddRange(new object[] {
            "Todas",
            "Steam",
            "Playstation",
            "Xbox"});
            this.Cbo_Plataforma.Location = new System.Drawing.Point(95, 318);
            this.Cbo_Plataforma.Name = "Cbo_Plataforma";
            this.Cbo_Plataforma.Size = new System.Drawing.Size(171, 22);
            this.Cbo_Plataforma.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Genero:";
            // 
            // Cbo_Genero
            // 
            this.Cbo_Genero.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Genero.FormattingEnabled = true;
            this.Cbo_Genero.Items.AddRange(new object[] {
            "FPS",
            "Ação",
            "Aventura",
            "Estratégia",
            "RPG",
            "Tabuleiro eletrônico",
            "Jogos on-line",
            "Simuladores",
            "Corrida",
            "Esportes",
            "Quebra-cabeças"});
            this.Cbo_Genero.Location = new System.Drawing.Point(95, 290);
            this.Cbo_Genero.Name = "Cbo_Genero";
            this.Cbo_Genero.Size = new System.Drawing.Size(171, 22);
            this.Cbo_Genero.TabIndex = 16;
            // 
            // bnt_AdicionarJogo
            // 
            this.bnt_AdicionarJogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_AdicionarJogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_AdicionarJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_AdicionarJogo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_AdicionarJogo.ForeColor = System.Drawing.Color.White;
            this.bnt_AdicionarJogo.Location = new System.Drawing.Point(9, 419);
            this.bnt_AdicionarJogo.Name = "bnt_AdicionarJogo";
            this.bnt_AdicionarJogo.Size = new System.Drawing.Size(115, 54);
            this.bnt_AdicionarJogo.TabIndex = 17;
            this.bnt_AdicionarJogo.Text = "ADICIONAR";
            this.bnt_AdicionarJogo.UseVisualStyleBackColor = true;
            this.bnt_AdicionarJogo.Click += new System.EventHandler(this.bnt_AdicionarJogo_Click);
            // 
            // bnt_EditarJogo
            // 
            this.bnt_EditarJogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_EditarJogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_EditarJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_EditarJogo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_EditarJogo.ForeColor = System.Drawing.Color.White;
            this.bnt_EditarJogo.Location = new System.Drawing.Point(157, 419);
            this.bnt_EditarJogo.Name = "bnt_EditarJogo";
            this.bnt_EditarJogo.Size = new System.Drawing.Size(119, 54);
            this.bnt_EditarJogo.TabIndex = 18;
            this.bnt_EditarJogo.Text = "EDITAR";
            this.bnt_EditarJogo.UseVisualStyleBackColor = true;
            this.bnt_EditarJogo.Click += new System.EventHandler(this.bnt_EditarJogo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.Txt_ValorJogo);
            this.panel1.Controls.Add(this.bnt_CancelarAlteracao);
            this.panel1.Controls.Add(this.Cbo_Jogos);
            this.panel1.Controls.Add(this.bnt_SalvarAlteracao);
            this.panel1.Controls.Add(this.Txt_Quantidade);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bnt_ImportaFoto);
            this.panel1.Controls.Add(this.bnt_EditarJogo);
            this.panel1.Controls.Add(this.bnt_AdicionarJogo);
            this.panel1.Controls.Add(this.Cbo_Genero);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Cbo_Plataforma);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pcb_FotoJogo);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 559);
            this.panel1.TabIndex = 0;
            // 
            // bnt_ImportaFoto
            // 
            this.bnt_ImportaFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_ImportaFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_ImportaFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_ImportaFoto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_ImportaFoto.ForeColor = System.Drawing.Color.White;
            this.bnt_ImportaFoto.Location = new System.Drawing.Point(67, 188);
            this.bnt_ImportaFoto.Name = "bnt_ImportaFoto";
            this.bnt_ImportaFoto.Size = new System.Drawing.Size(140, 26);
            this.bnt_ImportaFoto.TabIndex = 19;
            this.bnt_ImportaFoto.Text = "Importar Foto";
            this.bnt_ImportaFoto.UseVisualStyleBackColor = true;
            this.bnt_ImportaFoto.Click += new System.EventHandler(this.bnt_ImportaFoto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Quantidade:";
            // 
            // Txt_Quantidade
            // 
            this.Txt_Quantidade.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Quantidade.Location = new System.Drawing.Point(95, 346);
            this.Txt_Quantidade.Name = "Txt_Quantidade";
            this.Txt_Quantidade.Size = new System.Drawing.Size(171, 22);
            this.Txt_Quantidade.TabIndex = 21;
            // 
            // bnt_SalvarAlteracao
            // 
            this.bnt_SalvarAlteracao.Enabled = false;
            this.bnt_SalvarAlteracao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_SalvarAlteracao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_SalvarAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_SalvarAlteracao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_SalvarAlteracao.ForeColor = System.Drawing.Color.White;
            this.bnt_SalvarAlteracao.Location = new System.Drawing.Point(24, 499);
            this.bnt_SalvarAlteracao.Name = "bnt_SalvarAlteracao";
            this.bnt_SalvarAlteracao.Size = new System.Drawing.Size(100, 42);
            this.bnt_SalvarAlteracao.TabIndex = 22;
            this.bnt_SalvarAlteracao.Text = "SALVAR";
            this.bnt_SalvarAlteracao.UseVisualStyleBackColor = true;
            this.bnt_SalvarAlteracao.Visible = false;
            this.bnt_SalvarAlteracao.Click += new System.EventHandler(this.bnt_SalvarAlteracao_Click);
            // 
            // Cbo_Jogos
            // 
            this.Cbo_Jogos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Jogos.FormattingEnabled = true;
            this.Cbo_Jogos.Items.AddRange(new object[] {
            "Counter-Strike 2",
            "Dota 2",
            "PUBG: Battlegrounds",
            "Apex Legends",
            "Baldur’s Gate 3",
            "Grand Theft Auto V",
            "Call of Duty",
            "FIFA 23",
            "Destiny 2",
            "Overwatch 2",
            "Rocket League",
            "Tom Clancy\'s Rainbow Six Siege",
            "The Elder Scrolls Online",
            "World of Warcraft",
            "Final Fantasy XIV",
            "Sea of Thieves",
            "Dead by Daylight",
            "Warframe",
            "Path of Exile",
            "Hearthstone",
            "Star Wars: The Old Republic",
            "Civilization VI",
            "Red Dead Redemption 2",
            "Cyberpunk 2077",
            "The Witcher 3: Wild Hunt",
            "Elden Ring",
            "Assassin\'s Creed Valhalla",
            "Diablo IV",
            "Marvel’s Spider-Man Remastered",
            "Resident Evil 4 (Remake)",
            "Hogwarts Legacy",
            "Dark Souls III",
            "Sekiro: Shadows Die Twice",
            "Monster Hunter: World",
            "Fallout 4",
            "Borderlands 3",
            "Doom Eternal",
            "Ghost of Tsushima",
            "Death Stranding",
            "Horizon Forbidden West",
            "Starfield",
            "Star Wars Jedi: Survivor",
            "Control",
            "Bloodborne",
            "God of War Ragnarok",
            "Uncharted: Legacy of Thieves Collection",
            "Persona 5 Royal",
            "Nioh 2",
            "Final Fantasy VII Remake",
            "Returnal"});
            this.Cbo_Jogos.Location = new System.Drawing.Point(95, 234);
            this.Cbo_Jogos.Name = "Cbo_Jogos";
            this.Cbo_Jogos.Size = new System.Drawing.Size(171, 22);
            this.Cbo_Jogos.TabIndex = 23;
            // 
            // bnt_CancelarAlteracao
            // 
            this.bnt_CancelarAlteracao.Enabled = false;
            this.bnt_CancelarAlteracao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_CancelarAlteracao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(140)))));
            this.bnt_CancelarAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_CancelarAlteracao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_CancelarAlteracao.ForeColor = System.Drawing.Color.White;
            this.bnt_CancelarAlteracao.Location = new System.Drawing.Point(157, 499);
            this.bnt_CancelarAlteracao.Name = "bnt_CancelarAlteracao";
            this.bnt_CancelarAlteracao.Size = new System.Drawing.Size(100, 42);
            this.bnt_CancelarAlteracao.TabIndex = 24;
            this.bnt_CancelarAlteracao.Text = "CANCELAR";
            this.bnt_CancelarAlteracao.UseVisualStyleBackColor = true;
            this.bnt_CancelarAlteracao.Visible = false;
            this.bnt_CancelarAlteracao.Click += new System.EventHandler(this.bnt_CancelarAlteracao_Click);
            // 
            // JOGO
            // 
            this.JOGO.HeaderText = "JOGO";
            this.JOGO.Name = "JOGO";
            this.JOGO.ReadOnly = true;
            this.JOGO.Width = 165;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 80;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.HeaderText = "QUANTIDADE";
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.ReadOnly = true;
            // 
            // GENERO
            // 
            this.GENERO.HeaderText = "GENERO";
            this.GENERO.Name = "GENERO";
            this.GENERO.ReadOnly = true;
            this.GENERO.Width = 90;
            // 
            // PLATAFORMA
            // 
            this.PLATAFORMA.HeaderText = "PLATAFORMA";
            this.PLATAFORMA.Name = "PLATAFORMA";
            this.PLATAFORMA.ReadOnly = true;
            // 
            // Txt_ValorJogo
            // 
            this.Txt_ValorJogo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ValorJogo.Location = new System.Drawing.Point(95, 262);
            this.Txt_ValorJogo.Name = "Txt_ValorJogo";
            this.Txt_ValorJogo.Size = new System.Drawing.Size(171, 22);
            this.Txt_ValorJogo.TabIndex = 25;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dgv_MostrarJogos);
            this.Controls.Add(this.panel1);
            this.Name = "Estoque";
            this.Size = new System.Drawing.Size(865, 565);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MostrarJogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_FotoJogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_MostrarJogos;
        private System.Windows.Forms.PictureBox pcb_FotoJogo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Cbo_Plataforma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbo_Genero;
        private System.Windows.Forms.Button bnt_AdicionarJogo;
        private System.Windows.Forms.Button bnt_EditarJogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bnt_ImportaFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Quantidade;
        private System.Windows.Forms.Button bnt_SalvarAlteracao;
        private System.Windows.Forms.ComboBox Cbo_Jogos;
        private System.Windows.Forms.Button bnt_CancelarAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn JOGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLATAFORMA;
        private System.Windows.Forms.TextBox Txt_ValorJogo;
    }
}
