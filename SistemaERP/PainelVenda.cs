using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaERP {
    public partial class PainelVenda : UserControl {

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand Obj_Cmd = new SqlCommand();

        public PainelVenda() {
            InitializeComponent();

            MostrarDados();
            AtualizarLabelComData();
        }

        private void bnt_GerarVenda_Click(object sender, EventArgs e) {
            string email = txt_Email.Text;
            string cpf = txt_Cpf.Text.Replace(".", "").Replace("-", "");
            

            if (!VerificarCamposPreenchidos()) {
                return;
            }
            else {
                try {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30")) {
                        connection.Open();

                        string query = "SELECT COUNT(*) FROM vendas";

                        using (SqlCommand command = new SqlCommand(query, connection)) {
                            
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO vendas " +
                                    "(id_cliente, nome, cpf, celular, email, cep," +
                                    "cidade, rua, estado, bairro, numero, jogo, quantidade," + 
                                    "plataforma, valor, tipo_venda, tipo_pagamento, parcelas, data_venda)" +
                                    "VALUES(@id_cliente, @nome, @cpf, @celular, @email, @cep," +
                                    "@cidade, @rua, @estado, @bairro, @numero, @jogo, @quantidade," +
                                    "@plataforma, @valor, @tipo_venda, @tipo_pagamento, @parcelas, @data_venda)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connection)) {

                                    cmd.Parameters.AddWithValue("@id_cliente", Convert.ToInt32(txt_ID.Value));
                                    cmd.Parameters.AddWithValue("@nome", txt_Nome.Text.Trim());
                                    cmd.Parameters.AddWithValue("@cpf", txt_Cpf.Text.Replace(".", "").Replace("-", ""));
                                    cmd.Parameters.AddWithValue("@celular", txt_Celular.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""));
                                    cmd.Parameters.AddWithValue("@email", txt_Email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@cep", txt_Cep.Text.Trim());
                                    cmd.Parameters.AddWithValue("@cidade", txt_Cidade.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Rua", txt_Rua.Text.Trim());
                                    cmd.Parameters.AddWithValue("@estado", cbo_Estado.Text.Trim());
                                    cmd.Parameters.AddWithValue("@bairro", txt_Bairro.Text.Trim());
                                    cmd.Parameters.AddWithValue("@numero", txt_Numero.Text.Trim());
                                    cmd.Parameters.AddWithValue("@jogo", txt_Jogo.Text.Trim());
                                    cmd.Parameters.AddWithValue("@quantidade", txt_Quantidade.Text.Trim());
                                    cmd.Parameters.AddWithValue("@plataforma", txt_Plataforma.Text.Trim());
                                    cmd.Parameters.AddWithValue("@valor", Convert.ToDecimal(txt_ValorJogo.Text.Trim()));
                                    cmd.Parameters.AddWithValue("@tipo_venda", txt_TipoVenda.Text.Trim());
                                    cmd.Parameters.AddWithValue("@tipo_pagamento", cbo_TipoDePagamento.Text.Trim());
                                    cmd.Parameters.AddWithValue("@parcelas", cbo_Parcelas.Text.Trim());
                                    cmd.Parameters.AddWithValue("@data_venda", today);

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
            }
            LimparCampos();
        }
    

        private void txt_ID_ValueChanged(object sender, EventArgs e) {
            MostrarDados();
        }
        void MostrarDados() {
            try {
                // Abre a conexão com o banco
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30")) {
                    connection.Open();

                    // Consulta SQL para buscar pelo ID
                    string query = "SELECT * FROM clientes WHERE id_cliente = @id AND delete_data IS NULL";

                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        // Define o parâmetro como inteiro
                        command.Parameters.AddWithValue("@id", (int)txt_ID.Value);

                        using (SqlDataReader reader = command.ExecuteReader()) {


                            if (reader.Read()) { // Verifica se encontrou dados
                                                 // Preenche os campos com os valores do banco

                                DesabilitaEdicao();


                                lb_cliente.Text = reader["nome"].ToString();
                                txt_Nome.Text = reader["nome"].ToString();
                                txt_Cpf.Text = reader["cpf"].ToString();
                                txt_Celular.Text = reader["celular"].ToString();
                                txt_Cep.Text = reader["cep"].ToString();
                                txt_Rua.Text = reader["longadouro"].ToString();
                                txt_Numero.Text = reader["numero"].ToString();
                                txt_Bairro.Text = reader["bairro"].ToString();
                                txt_Cidade.Text = reader["cidade"].ToString();
                                cbo_Estado.Text = reader["estado"].ToString();
                                txt_Email.Text = reader["email"].ToString();


                            }
                            else {
                                MessageBox.Show("ID não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                LimparCampos(); // Limpa os campos se não houver dados
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarLabelComData() {
            // Define o texto da label com a data atual formatada
            lb_Data.Text = DateTime.Now.ToString("dd/MM/yy");
        }

        void LimparCampos() {
            cb_Jogos.Text = "";
            txt_Jogo.Text = "";
            txt_Quantidade.Text = "";
            txt_ValorJogo.Text = "";
            txt_TipoVenda.Text = "";
            txt_Plataforma.Text = "";
            cbo_Parcelas.Text = "";
            cbo_TipoDePagamento.Text = "";
            rb_Online.Checked = false;
            rb_Presencial.Checked = false;
            rb_Playstation.Checked = false;
            rb_Steam.Checked = false;
            rb_Xbox.Checked = false;
        }

        void DesabilitaEdicao() {
            txt_Nome.ReadOnly = true;
            txt_Cpf.ReadOnly = true;
            txt_Celular.ReadOnly = true;
            txt_Cep.ReadOnly = true;
            txt_Rua.ReadOnly = true;
            txt_Numero.ReadOnly = true;
            txt_Bairro.ReadOnly = true;
            txt_Cidade.ReadOnly = true;
            cbo_Estado.Enabled = false;
            txt_Email.ReadOnly = true;
        }

        private bool VerificarCamposPreenchidos() {
            bool camposValidos = true;

            if (string.IsNullOrEmpty(txt_Quantidade.Text)) {
                MessageBox.Show("O campo Quantidade é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Quantidade.Focus();
                camposValidos = false;
            }

            // Valida o campo Tipo de Pagamento
            if (string.IsNullOrWhiteSpace(cbo_TipoDePagamento.Text)) {
                MessageBox.Show("O campo Tipo de Pagamento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbo_TipoDePagamento.Focus();
                camposValidos = false;
            }
            else if (cbo_TipoDePagamento.SelectedItem.ToString() == "Credito") {
                // Se o Tipo de Pagamento for Crédito, verifica se o campo Parcelas está vazio
                if (string.IsNullOrWhiteSpace(cbo_Parcelas.Text)) {
                    MessageBox.Show("O campo Parcelas é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbo_Parcelas.Focus();
                    camposValidos = false;
                }
            }

            return camposValidos;
        }


        private void cb_Jogos_SelectedIndexChanged(object sender, EventArgs e) {
            txt_Jogo.Text = cb_Jogos.SelectedItem.ToString();
        }

        private void rb_Online_CheckedChanged(object sender, EventArgs e) {
            if (rb_Online.Checked)
                txt_TipoVenda.Text = "Online";
        }

        private void rb_Presencial_CheckedChanged(object sender, EventArgs e) {
            if (rb_Presencial.Checked)
                txt_TipoVenda.Text = "Presencial";
        }

        private void rb_Steam_CheckedChanged(object sender, EventArgs e) {
            if (rb_Steam.Checked)
                txt_Plataforma.Text = "Steam";
        }

        private void rb_Xbox_CheckedChanged(object sender, EventArgs e) {
            if (rb_Xbox.Checked)
                txt_Plataforma.Text = "Xbox";
        }

        private void rb_Playstation_CheckedChanged(object sender, EventArgs e) {
            if (rb_Playstation.Checked)
                txt_Plataforma.Text = "Playstantion";
        }
    }
}
