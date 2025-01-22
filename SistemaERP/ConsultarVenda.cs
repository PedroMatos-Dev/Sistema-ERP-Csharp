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

namespace SistemaERP {
    public partial class ConsultarVenda : Form {
        public ConsultarVenda() {
            InitializeComponent();
        }

        private void bnt_Consultar_Click(object sender, EventArgs e) {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30")) {
                connection.Open();
                dgv_VendasConsulta.Rows.Clear();

                try {
                    // Usar parâmetros para evitar SQL Injection
                    string query = "SELECT * FROM vendas WHERE nome LIKE @nome AND email LIKE @email AND cpf LIKE @cpf AND jogo LIKE @jogo";

                    // Criar o comando associado à conexão
                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        // Configurar os parâmetros do comando
                        command.Parameters.AddWithValue("@nome", $"%{Txt_Nome.Text}%");
                        command.Parameters.AddWithValue("@email", $"%{Txt_Email.Text}%");
                        command.Parameters.AddWithValue("@cpf", $"%{Txt_CPF.Text}%");
                        command.Parameters.AddWithValue("@jogo", $"%{Txt_Jogo.Text}%");

                        // Executar o leitor de dados
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                var codigo = reader["id_cliente"].ToString();
                                var nome = reader["nome"].ToString();
                                var cpf = reader["cpf"].ToString().Replace(reader["cpf"].ToString().Substring(3, 6), new string('*', 6));
                                var email = reader["email"].ToString();
                                var endereco = reader["rua"].ToString();
                                var jogo = reader["jogo"].ToString();
                                var quantidade = reader["quantidade"].ToString();
                                var plataforma = reader["plataforma"].ToString();
                                var valor = reader["valor"].ToString();
                                var dataVenda = Convert.ToDateTime(reader["data_venda"]).ToString("dd/MM/yyyy");
                                var pagamento = reader["tipo_pagamento"].ToString();
                                var parcelas = reader["parcelas"].ToString();

                                dgv_VendasConsulta.Rows.Add(codigo, nome, cpf, email, endereco, jogo, quantidade, plataforma, valor, dataVenda, pagamento, parcelas);
                            }
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show($"Erro ao consultar venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bnt_Sair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void bnt_Limpar_Click(object sender, EventArgs e) {
            Txt_Jogo.Clear();
            Txt_CPF.Clear();
            Txt_Email.Clear();
            Txt_Nome.Clear();
        }
    }
}
