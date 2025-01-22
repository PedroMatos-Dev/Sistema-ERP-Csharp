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
    public partial class Clientes : UserControl {

        public Clientes() {
            InitializeComponent();

            //Para exibir os dados do db no grid view
            displayClienteData();

            AtualizarClientesAtivos();
            AtualizarTotalClientes();
        }



        public void displayClienteData() {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30")) {
                connection.Open();
                dvg_TodosClientes.Rows.Clear();

                try {
                    // Query para buscar todos os clientes com delete_data IS NULL
                    string query = "SELECT * FROM clientes WHERE delete_data IS NULL";

                    // Criar o comando associado à conexão
                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        // Executar o leitor de dados
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                var ID = reader["id_cliente"].ToString();
                                var nome = reader["nome"].ToString();
                                var email = reader["email"].ToString();
                                var cpf = reader["cpf"].ToString().Replace(reader["cpf"].ToString().Substring(3, 6), new string('*', 6));
                                var celular = reader["celular"].ToString().Replace(reader["celular"].ToString().Substring(3, 6), new string('*', 6));
                                var cidade = reader["cidade"].ToString();
                                var cep = reader["cep"].ToString();
                                var endereco = reader["longadouro"].ToString();
                                var data = Convert.ToDateTime(reader["insert_date"]).ToString("dd/MM/yyyy");

                                // Adicionar os dados na DataGridView
                                dvg_TodosClientes.Rows.Add(ID, nome, cpf, celular, email, cidade, endereco, cep, data);
                            }
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show($"Erro ao consultar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bnt_AddCliente_Click(object sender, EventArgs e) {
            AddCliente addCliente = new AddCliente();
            addCliente.Show();
        }

        private void bnt_ConsultarCliente_Click(object sender, EventArgs e) {
            ConsultarCliente consultarCliente = new ConsultarCliente();
            consultarCliente.Show();
        }

        private void AtualizarTotalClientes() {
            try {
                // Conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30")) {
                    connection.Open();

                    // Consulta SQL para contar o total de clientes
                    string query = "SELECT COUNT(*) FROM clientes";

                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        // Executa a consulta e obtém o número total de clientes
                        int totalClientes = (int)command.ExecuteScalar();

                        // Atualiza o texto do Label com o total de clientes
                        lb_TotalClientes.Text =  totalClientes.ToString();
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Erro ao obter o total de clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarClientesAtivos() {
            try {
                // Conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30")) {
                    connection.Open();

                    // Consulta SQL para contar o total de clientes
                    string query = "SELECT COUNT(*) FROM clientes WHERE delete_data IS NULL";

                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        // Executa a consulta e obtém o número total de clientes
                        int ClientesAtivos = (int)command.ExecuteScalar();

                        // Atualiza o texto do Label com o total de clientes
                        lb_ClientesAtivo.Text = ClientesAtivos.ToString();
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Erro ao obter clientes ativos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
