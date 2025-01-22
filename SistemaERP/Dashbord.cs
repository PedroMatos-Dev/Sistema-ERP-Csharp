﻿using System;
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
    public partial class Dashbord : UserControl {
        public Dashbord() {
            InitializeComponent();

            displayClienteData();
        }
        public void displayClienteData() {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30")) {
                connection.Open();
                dgv_VendasRelatorio.Rows.Clear();

                try {
                    // Query para buscar todos os clientes com delete_data IS NULL
                    string query = "SELECT * FROM vendas";

                    // Criar o comando associado à conexão
                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        // Executar o leitor de dados
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                var ID = reader["id_cliente"].ToString();
                                var nome = reader["nome"].ToString();
                                var cpf = reader["cpf"].ToString().Replace(reader["cpf"].ToString().Substring(3, 6), new string('*', 6));
                                var email = reader["email"].ToString();
                                var endereco = reader["rua"].ToString();
                                var jogo = reader["jogo"].ToString();
                                var quantidade = reader["quantidade"].ToString();
                                var valorJogo = reader["valor"].ToString();
                                var data = Convert.ToDateTime(reader["data_venda"]).ToString("dd/MM/yyyy");
                                var pagamento = reader["tipo_pagamento"].ToString();
                                var parcelas = reader["parcelas"].ToString();

                                // Adicionar os dados na DataGridView
                                dgv_VendasRelatorio.Rows.Add(ID, nome, cpf, email, endereco, jogo, quantidade, valorJogo, data, pagamento, parcelas);
                            }
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show($"Erro ao consultar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bnt_ConsultarVenda_Click(object sender, EventArgs e) {
            ConsultarVenda consultarVenda = new ConsultarVenda();
            consultarVenda.Show();
        }

        private void bnt_GerarRelatorio_Click(object sender, EventArgs e) {

        }
    }
}
