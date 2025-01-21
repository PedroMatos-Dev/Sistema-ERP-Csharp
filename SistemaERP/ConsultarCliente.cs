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
    public partial class ConsultarCliente : Form {

        public ConsultarCliente() {
            InitializeComponent();
        }

        private void ConsultarCliente_Load(object sender, EventArgs e) {

        }

        private void bnt_Sair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void bnt_Consultar_Click(object sender, EventArgs e) {

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30")) {
                connection.Open();
                dgv_ClientesConsulta.Rows.Clear();

                try {
                    // Usar parâmetros para evitar SQL Injection
                    string query = "SELECT * FROM clientes WHERE nome LIKE @nome AND email LIKE @email AND cpf LIKE @cpf AND cidade LIKE @cidade AND delete_data IS NULL";

                    // Criar o comando associado à conexão
                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        // Configurar os parâmetros do comando
                        command.Parameters.AddWithValue("@nome", $"%{Txt_Nome.Text}%");
                        command.Parameters.AddWithValue("@email", $"%{Txt_Email.Text}%");
                        command.Parameters.AddWithValue("@cpf", $"%{Txt_CPF.Text}%");
                        command.Parameters.AddWithValue("@cidade", $"%{Txt_Cidade.Text}%");

                        // Executar o leitor de dados
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                var codigo = reader["id_cliente"].ToString();
                                var nome = reader["nome"].ToString();
                                var email = reader["email"].ToString();
                                var cpf = reader["cpf"].ToString().Replace(reader["cpf"].ToString().Substring(3, 6), new string('*', 6));
                                var celular = reader["celular"].ToString().Replace(reader["celular"].ToString().Substring(3, 6), new string('*', 6));
                                var cidade = reader["cidade"].ToString();
                                var cep = reader["cep"].ToString();

                                dgv_ClientesConsulta.Rows.Add(codigo, nome, email, cpf, celular, cidade, cep);
                            }
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show($"Erro ao consultar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bnt_Limpar_Click(object sender, EventArgs e) {
            Txt_Cidade.Clear();
            Txt_CPF.Clear();
            Txt_Email.Clear();
            Txt_Nome.Clear();
        }
    }
}
