using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaERP {
    public partial class Estoque : UserControl {

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand Obj_Cmd = new SqlCommand();

        public Estoque() {
            InitializeComponent();

            displayClienteData();

            Txt_Quantidade.Text = string.Format("0");
            Txt_ValorJogo.Text = string.Format("0000");
        }

        private void bnt_AdicionarJogo_Click(object sender, EventArgs e) {

            if (!VerificarCamposPreenchidos()) {
                return;
            }

            try {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30")) {
                    connection.Open();

                    // Verificar se o jogo já existe no banco apenas com base no nome do jogo
                    string checkQuery = "SELECT COUNT(*) FROM estoqueDeJogos WHERE jogo = @jogo";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection)) {
                        checkCommand.Parameters.AddWithValue("@jogo", Cbo_Jogos.Text.Trim());

                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0) {
                            // O jogo já existe, exibir mensagem e cancelar a inserção
                            MessageBox.Show("Esse jogo já existe no estoque! Por favor, atualize os dados ou escolha outro jogo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Interrompe a execução do código
                        }
                    }
                    

                    string query = "SELECT COUNT(*) FROM estoqueDeJogos ";

                    using (SqlCommand command = new SqlCommand(query, connection)) {

                        DateTime today = DateTime.Today;

                        string insertData = "INSERT INTO estoqueDeJogos " +
                                "(jogo, valor, quantidade, genero, plataforma, fotojogo )" +
                                "VALUES(@jogo, @valor, @quantidade, @genero, @plataforma, @fotoJogo )";

                        using (SqlCommand cmd = new SqlCommand(insertData, connection)) {

                            cmd.Parameters.AddWithValue("@jogo", Cbo_Jogos.Text.Trim());
                            cmd.Parameters.AddWithValue("@valor", Convert.ToDecimal(Txt_ValorJogo.Text.Trim()));
                            cmd.Parameters.AddWithValue("@genero", Cbo_Genero.Text.Trim());
                            cmd.Parameters.AddWithValue("@plataforma", Cbo_Plataforma.Text.Trim());
                            cmd.Parameters.AddWithValue("@quantidade", Convert.ToInt32(Txt_Quantidade.Text.Trim()));

                            // Converter a imagem do PictureBox para um array de bytes
                            byte[] imageBytes;
                            using (MemoryStream ms = new MemoryStream()) {
                                if (pcb_FotoJogo.Image != null) {
                                    pcb_FotoJogo.Image.Save(ms, pcb_FotoJogo.Image.RawFormat);
                                    imageBytes = ms.ToArray();
                                }
                                else {
                                    imageBytes = null; // Caso nenhuma imagem esteja selecionada
                                }
                            }

                            // Adicionar os bytes da imagem ao comando SQL
                            cmd.Parameters.AddWithValue("@fotoJogo", (object)imageBytes ?? DBNull.Value);


                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Sucesso! Dados salvos.",
                                            "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                connection.Close();
            }

            LimparCampos();
        }

        void LimparCampos() {
            Cbo_Jogos.Text = "";
            Cbo_Genero.Text = "";
            Cbo_Plataforma.Text = "";
            Txt_Quantidade.Text = "0";
            Txt_ValorJogo.Text = "00";
            pcb_FotoJogo.Image = null;
        }

        private void bnt_ImportaFoto_Click(object sender, EventArgs e) {

            // Cria um OpenFileDialog para selecionar a imagem
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp"; // Tipos de arquivo suportados
                openFileDialog.Title = "Selecione uma imagem";

                // Verifica se o usuário selecionou um arquivo
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    try {
                        // Carrega a imagem selecionada no PictureBox
                        pcb_FotoJogo.Image = Image.FromFile(openFileDialog.FileName);
                        pcb_FotoJogo.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta a imagem ao tamanho do PictureBox

                        MessageBox.Show("Imagem importada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) {
                        MessageBox.Show($"Erro ao carregar a imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bnt_EditarJogo_Click(object sender, EventArgs e) {

            bnt_AdicionarJogo.Enabled = false;
            Cbo_Jogos.Enabled = false;
            bnt_ImportaFoto.Enabled = false;
            bnt_SalvarAlteracao.Visible = true;
            bnt_SalvarAlteracao.Enabled = true;
            bnt_CancelarAlteracao.Visible = true;
            bnt_CancelarAlteracao.Enabled = true;

        }

        private void bnt_SalvarAlteracao_Click(object sender, EventArgs e) {
            try {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30")) {
                    connection.Open();

                    // Verifica se o campo de nome do jogo está preenchido
                    if (string.IsNullOrWhiteSpace(Cbo_Jogos.Text)) {
                        MessageBox.Show("Por favor, selecione o jogo para editá-lo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Query de atualização
                    string updateQuery = @"
                         UPDATE estoqueDeJogos
                         SET 
                             valor = @valor,
                             genero = @genero,
                             plataforma = @plataforma,
                             quantidade = @quantidade
                        WHERE jogo = @jogo";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection)) {
                        // Adiciona os parâmetros
                        cmd.Parameters.AddWithValue("@valor", Convert.ToDecimal(Txt_ValorJogo.Text.Trim()));
                        cmd.Parameters.AddWithValue("@genero", Cbo_Genero.Text.Trim());
                        cmd.Parameters.AddWithValue("@plataforma", Cbo_Plataforma.Text.Trim());
                        cmd.Parameters.AddWithValue("@quantidade", Convert.ToInt32(Txt_Quantidade.Text.Trim()));
                        cmd.Parameters.AddWithValue("@jogo", Cbo_Jogos.Text.Trim());


                        // Executa o comando
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0) {
                            MessageBox.Show("Informações atualizadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else {
                            MessageBox.Show("Nenhum registro encontrado para o jogo especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao atualizar informações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bnt_ImportaFoto.Enabled = true;
            bnt_AdicionarJogo.Enabled = true;
            Cbo_Jogos.Enabled = true;
            bnt_SalvarAlteracao.Visible = false;
            bnt_SalvarAlteracao.Enabled = false;
            bnt_CancelarAlteracao.Visible = false;
            bnt_CancelarAlteracao.Enabled = false;
        }

        private void bnt_CancelarAlteracao_Click(object sender, EventArgs e) {

            try {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30")) {
                    connection.Open();

                    // Buscar as informações originais do jogo com base no Nome e na Plataforma
                    string query = "SELECT * FROM estoqueDeJogos WHERE jogo = @jogo AND plataforma = @plataforma";

                    using (SqlCommand command = new SqlCommand(query, connection)) {

                        command.Parameters.AddWithValue("@jogo", Cbo_Jogos.Text.Trim());
                        command.Parameters.AddWithValue("@plataforma", Cbo_Plataforma.Text.Trim()); // Garantindo que é único

                        using (SqlDataReader reader = command.ExecuteReader()) {
                            if (reader.Read()) {
                                // Atualizar os campos com os valores do banco de dados
                                Txt_ValorJogo.Text = reader["valor"].ToString();
                                Cbo_Genero.Text = reader["genero"].ToString();
                                Cbo_Plataforma.Text = reader["plataforma"].ToString();
                                Txt_Quantidade.Text = reader["quantidade"].ToString();
                            }
                            else {
                                //MessageBox.Show("Jogo não encontrado no banco de dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }

                MessageBox.Show("Alterações canceladas!", "Cancelamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao cancelar alterações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bnt_AdicionarJogo.Enabled = true;
            Cbo_Jogos.Enabled = true;
            bnt_SalvarAlteracao.Visible = false;
            bnt_SalvarAlteracao.Enabled = false;
            bnt_CancelarAlteracao.Visible = false;
            bnt_CancelarAlteracao.Enabled = false;
        }

        private bool VerificarCamposPreenchidos() {

            bool camposValidos = true;

            if (string.IsNullOrWhiteSpace(Cbo_Jogos.Text)) {
                MessageBox.Show("O campo 'Nome' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (camposValidos) Cbo_Jogos.Focus();
                camposValidos = false;
            }
            else if (string.IsNullOrWhiteSpace(Txt_ValorJogo.Text)) {
                MessageBox.Show("O campo 'CPF' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (camposValidos) Txt_ValorJogo.Focus();
                camposValidos = false;
            }
            else if (string.IsNullOrWhiteSpace(Cbo_Genero.Text)) {
                MessageBox.Show("O campo 'Celular' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (camposValidos) Cbo_Genero.Focus();
                camposValidos = false;
            }
            else if (string.IsNullOrWhiteSpace(Cbo_Plataforma.Text)) {
                MessageBox.Show("O campo 'Celular' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (camposValidos) Cbo_Plataforma.Focus();
                camposValidos = false;
            }
            else if (string.IsNullOrWhiteSpace(Txt_Quantidade.Text)) {
                MessageBox.Show("O campo 'Celular' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (camposValidos) Txt_Quantidade.Focus();
                camposValidos = false;
            }

            return camposValidos;
        }

        public void displayClienteData() {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30")) {
                connection.Open();

                dgv_MostrarJogos.Rows.Clear();

                try {
                    // Query para buscar todos os clientes com delete_data IS NULL
                    string query = "SELECT * FROM estoquedejogos";

                    // Criar o comando associado à conexão
                    using (SqlCommand command = new SqlCommand(query, connection)) {

                        // Executar o leitor de dados
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                var jogo = reader["jogo"].ToString();
                                var valor = reader["valor"].ToString();
                                var quantidade = reader["quantidade"].ToString();
                                var genero = reader["genero"].ToString();
                                var plataforma = reader["quantidade"].ToString();


                                // Adicionar os dados na DataGridView
                                dgv_MostrarJogos.Rows.Add(jogo, valor, quantidade, genero, plataforma);
                            }
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show($"Erro ao consultar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
