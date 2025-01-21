using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Collections;
using System.IO;
using SistemaERP;

namespace SistemaERP {
    public partial class AddCliente : Form {

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand Obj_Cmd = new SqlCommand();
        //SqlDataReader DadosCarregados;

        public void Form1_Load() {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30";
            string query = "SELECT ISNULL(MAX(id_cliente), 0) + 1 AS ProximoID FROM clientes";


            using (SqlConnection connection = new SqlConnection(connectionString)) {
                try {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    // Obtém o próximo ID disponível
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value) {
                        // Converte o id_cliente para int
                        string lastIdCliente = result.ToString();
                        int lastIdNumber = 0;

                        // Tenta converter o id_cliente para um número inteiro
                        if (int.TryParse(lastIdCliente, out lastIdNumber)) {
                            // Configura o valor do NumericUpDown como o próximo id_cliente
                            Txt_ID.Value = lastIdNumber + 2;
                        }
                        else {
                            // Se o id_cliente não for um número válido, define 1
                            Txt_ID.Value = 1;
                        }
                    }
                    else {
                        // Se não houver registros, define 1
                        Txt_ID.Value = 1;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Erro ao carregar o próximo ID: " + ex.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public AddCliente() {
            InitializeComponent();
            Form1_Load(); 
        }

        private void Txt_ID_ValueChanged(object sender, EventArgs e) {
            MostrarDados();
        }

        private void Btn_Sair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Btn_Adicionar_Click(object sender, EventArgs e) {
            string email = Txt_Email.Text;
            string cpf = Txt_CPF.Text.Replace(".", "").Replace("-", "");
            bool cpfValido = ValidacoesCliente.ValidaCPF(cpf);

            if (!VerificarCamposPreenchidos()) {
                return;
            }
            else if (VerificaCpfDuplicado(cpf)) {
                MessageBox.Show("CPF já cadastrado! Insira outro CPF.", "Erro de Duplicidade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_CPF.Focus();
                return;
            }
            else if (!ValidacoesCliente.ValidaEmail(email)) {
                MessageBox.Show("O email usado é invalido! Por favor, corrija-o.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Email.Focus();
                return;
            }
            else {
                try {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30")) {
                        connection.Open();

                        string query = "SELECT COUNT(*) FROM clientes WHERE id_cliente = @id_cliente";

                        using (SqlCommand command = new SqlCommand(query, connection)) {
                            command.Parameters.AddWithValue("@id_cliente", Convert.ToInt32(Txt_ID.Value));

                            int count = Convert.ToInt32(command.ExecuteScalar());

                            if (count > 0) {
                                MessageBox.Show(Txt_ID.Value + " Id já em uso!",
                                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else {

                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO clientes " +
                                    "(id_cliente, nome, cpf, celular, telAlt, sexo, cep," +
                                    "longadouro, numero, bairro, cidade, estado, email, insert_date)" +
                                    "VALUES(@id_cliente, @nome, @cpf, @celular, @telAlt, @sexo, @cep," +
                                    "@longadouro, @numero, @bairro, @cidade, @estado, @email, @insertDate)";
                                
                                 using (SqlCommand cmd = new SqlCommand(insertData, connection)) {

                                            cmd.Parameters.AddWithValue("@id_cliente", Convert.ToInt32(Txt_ID.Value));
                                            cmd.Parameters.AddWithValue("@nome", Txt_Nome.Text.Trim());
                                            cmd.Parameters.AddWithValue("@cpf", Txt_CPF.Text.Replace(".", "").Replace("-", ""));
                                            cmd.Parameters.AddWithValue("@celular", Txt_Celular.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""));
                                            cmd.Parameters.AddWithValue("@telAlt", Txt_TelAlt.Text.Trim());

                                            var sexo = Rdo_Masculino.Checked ? "masculino" : "feminino";
                                            cmd.Parameters.AddWithValue("@sexo", sexo);

                                            cmd.Parameters.AddWithValue("@cep", Txt_CEP.Text.Trim());
                                            cmd.Parameters.AddWithValue("@longadouro", Txt_Longadouro.Text.Trim());
                                            cmd.Parameters.AddWithValue("@numero", Txt_Numero.Text.Trim());
                                            cmd.Parameters.AddWithValue("@bairro", Txt_Bairro.Text.Trim());
                                            cmd.Parameters.AddWithValue("@cidade", Txt_Cidade.Text.Trim());
                                            cmd.Parameters.AddWithValue("@estado", Cbo_Estado.Text.Trim());
                                            cmd.Parameters.AddWithValue("@email", Txt_Email.Text.Trim());
                                            cmd.Parameters.AddWithValue("@insertDate", today);

                                            cmd.ExecuteNonQuery();

                                            MessageBox.Show("Sucesso! Dados salvos.",
                                                            "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                 }
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

        private bool VerificarCamposPreenchidos() {

            bool camposValidos = true;

            string cpf = Txt_CPF.Text.Replace(".", "").Replace("-", "");
            bool cpfValido = ValidacoesCliente.ValidaCPF(cpf);

            string celular = Txt_Celular.Text.Replace("(", "").Replace(")", "").Replace("-", "");

            string sexo = null;

            if (Rdo_Masculino.Checked) {
                sexo = Rdo_Masculino.Text; // "Masculino"
            }
            else if (Rdo_Feminino.Checked) {
                sexo = Rdo_Feminino.Text; // "Feminino"
            }

            // Valida o campo Nome
            if (string.IsNullOrWhiteSpace(Txt_Nome.Text)) {
                MessageBox.Show("O campo 'Nome' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (camposValidos) Txt_Nome.Focus();
                camposValidos = false;
            }

            // Valida o campo CPF
            if (string.IsNullOrWhiteSpace(Txt_CPF.Text)) {
                MessageBox.Show("O campo 'CPF' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (camposValidos) Txt_CPF.Focus();
                camposValidos = false;
            }
            else if (!cpfValido) {
                MessageBox.Show("O CPF informado é inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (camposValidos) Txt_CPF.Focus();
                camposValidos = false;
            }

            // Valida o campo Número de Telefone
            if (string.IsNullOrWhiteSpace(celular)) {
                MessageBox.Show("O campo 'Celular' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (camposValidos) Txt_Celular.Focus();
                camposValidos = false;
            }

            if (sexo == null) {
                MessageBox.Show("O campo 'Sexo' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (camposValidos) Grb_Sexo.Focus();
                camposValidos = false;
            }


            return camposValidos;
        }

        public bool VerificaCpfDuplicado(string cpf) {
            string query = "SELECT COUNT(*) FROM clientes WHERE cpf = @cpf";

            // Substitua por sua string de conexão
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30";

            using (SqlConnection conn = new SqlConnection(connectionString)) {
                try {
                    conn.Open(); // Abre a conexão com o banco
                    using (SqlCommand Obj_Cmd = new SqlCommand(query, conn)) {
                        Obj_Cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;

                        int count = Convert.ToInt32(Obj_Cmd.ExecuteScalar()); // Retorna a contagem
                        return count > 0; // Se count > 0, o CPF já existe
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show($"Erro ao verificar duplicidade: {ex.Message}", "Erro de Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
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
                        command.Parameters.AddWithValue("@id", (int)Txt_ID.Value);

                        using (SqlDataReader reader = command.ExecuteReader()) {

                            MessageBox.Show($"Query: {query}, ID: {Txt_ID.Value}");

                            if (reader.Read()) { // Verifica se encontrou dados
                                                 // Preenche os campos com os valores do banco

                                DesabilitaEdicao();

                                Txt_Nome.Text = reader["nome"].ToString();
                                Txt_CPF.Text = reader["cpf"].ToString();
                                Txt_Celular.Text = reader["celular"].ToString();
                                Txt_TelAlt.Text = reader["telAlt"].ToString();

                                string sexo = reader["sexo"].ToString();
                                Rdo_Masculino.Checked = sexo == "masculino";
                                Rdo_Feminino.Checked = sexo == "feminino";

                                Txt_CEP.Text = reader["cep"].ToString();
                                Txt_Longadouro.Text = reader["longadouro"].ToString();
                                Txt_Numero.Text = reader["numero"].ToString();
                                Txt_Bairro.Text = reader["bairro"].ToString();
                                Txt_Cidade.Text = reader["cidade"].ToString();
                                Cbo_Estado.Text = reader["estado"].ToString();
                                Txt_Email.Text = reader["email"].ToString();


                            }
                            else {
                                MessageBox.Show("ID não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                LimparCampos(); // Limpa os campos se não houver dados

                                HabilitaEdicao();
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LimparCampos() {
            Txt_Nome.Text = "";
            Txt_CPF.Text = "";
            Txt_Celular.Text = "";
            Txt_TelAlt.Text = "";
            Rdo_Masculino.Checked = false;
            Rdo_Feminino.Checked = false;
            Txt_CEP.Text = "";
            Txt_Longadouro.Text = "";
            Txt_Numero.Text = "";
            Txt_Bairro.Text = "";
            Txt_Cidade.Text = "";
            Cbo_Estado.Text = "";
            Txt_Email.Text = "";
        }

        void HabilitaEdicao() {
            Txt_Nome.ReadOnly = false;
            Txt_CPF.ReadOnly = false;
            Txt_Celular.ReadOnly = false;
            Txt_TelAlt.ReadOnly = false;
            Rdo_Feminino.Enabled = true;
            Rdo_Masculino.Enabled = true;
            Txt_CEP.ReadOnly = false;
            Txt_Longadouro.ReadOnly = false;
            Txt_Numero.ReadOnly = false;
            Txt_Bairro.ReadOnly = false;
            Txt_Cidade.ReadOnly = false;
            Cbo_Estado.Enabled = true;
            Txt_Email.ReadOnly = false;
        }

        void DesabilitaEdicao() {
            Txt_Nome.ReadOnly = true;
            Txt_CPF.ReadOnly = true;
            Txt_Celular.ReadOnly = true;
            Txt_TelAlt.ReadOnly = true;
            Rdo_Feminino.Enabled = false;
            Rdo_Masculino.Enabled = false;
            Txt_CEP.ReadOnly = true;
            Txt_Longadouro.ReadOnly = true;
            Txt_Numero.ReadOnly = true;
            Txt_Bairro.ReadOnly = true;
            Txt_Cidade.ReadOnly = true;
            Cbo_Estado.Enabled = false;
            Txt_Email.ReadOnly = true;
        }

        private void Btn_Alterar_Click(object sender, EventArgs e) {
            HabilitaEdicao();

            bnt_CancelarAlterar.Visible = true;
            bnt_CancelarAlterar.Enabled = true;

            bnt_SalvarAlterar.Visible = true;
            bnt_SalvarAlterar.Enabled = true;
        }

        private void bnt_SalvarAlterar_Click(object sender, EventArgs e) {
            string email = Txt_Email.Text;
            string cpf = Txt_CPF.Text.Replace(".", "").Replace("-", "");
            bool cpfValido = ValidacoesCliente.ValidaCPF(cpf);

            if (!VerificarCamposPreenchidos()) {
                return;
            }
            else if (!ValidacoesCliente.ValidaEmail(email)) {
                MessageBox.Show("O email usado é inválido! Por favor, corrija-o.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Email.Focus();
                return;
            }
            else {
                try {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30")) {
                        connection.Open();

                        // Atualiza os dados no banco
                        string updateData = "UPDATE clientes SET " +
                                            "nome = @nome, " +
                                            "cpf = @cpf, " +
                                            "celular = @celular, " +
                                            "telAlt = @telAlt, " +
                                            "sexo = @sexo, " +
                                            "cep = @cep, " +
                                            "longadouro = @longadouro, " +
                                            "numero = @numero, " +
                                            "bairro = @bairro, " +
                                            "cidade = @cidade, " +
                                            "estado = @estado, " +
                                            "email = @email, " +
                                            "update_data = @updateData " +
                                            "WHERE id_cliente = @id_cliente";

                        using (SqlCommand cmd = new SqlCommand(updateData, connection)) {
                            // Passando os parâmetros atualizados
                            cmd.Parameters.AddWithValue("@id_cliente", Convert.ToInt32(Txt_ID.Value));
                            cmd.Parameters.AddWithValue("@nome", Txt_Nome.Text.Trim());
                            cmd.Parameters.AddWithValue("@cpf", Txt_CPF.Text.Replace(".", "").Replace("-", ""));
                            cmd.Parameters.AddWithValue("@celular", Txt_Celular.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""));
                            cmd.Parameters.AddWithValue("@telAlt", Txt_TelAlt.Text.Trim());

                            var sexo = Rdo_Masculino.Checked ? "masculino" : "feminino";
                            cmd.Parameters.AddWithValue("@sexo", sexo);

                            cmd.Parameters.AddWithValue("@cep", Txt_CEP.Text.Trim());
                            cmd.Parameters.AddWithValue("@longadouro", Txt_Longadouro.Text.Trim());
                            cmd.Parameters.AddWithValue("@numero", Txt_Numero.Text.Trim());
                            cmd.Parameters.AddWithValue("@bairro", Txt_Bairro.Text.Trim());
                            cmd.Parameters.AddWithValue("@cidade", Txt_Cidade.Text.Trim());
                            cmd.Parameters.AddWithValue("@estado", Cbo_Estado.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", Txt_Email.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateData", DateTime.Today);

                            // Executa a consulta de atualização
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0) {
                                MessageBox.Show("Sucesso! Dados atualizados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else {
                                MessageBox.Show("Nenhum registro foi alterado. Verifique o ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DesabilitaEdicao();
            bnt_SalvarAlterar.Visible = false;
            bnt_SalvarAlterar.Enabled = false;

        }

        private void Btn_Excluir_Click(object sender, EventArgs e) {
            try {
                // Verifica se o ID foi selecionado para exclusão
                if (Convert.ToInt32(Txt_ID.Value) <= 0) {
                    MessageBox.Show("Selecione um ID válido para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Pergunta ao usuário se realmente deseja excluir
                DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir este registro?",
                                                      "Confirmação de Exclusão",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30")) {
                        connection.Open();


                        // Atualiza os dados para marcar como excluído
                        string deleteDataQuery = "UPDATE clientes SET delete_data = @deleteData WHERE id_cliente = @id_cliente";

                        using (SqlCommand cmd = new SqlCommand(deleteDataQuery, connection)) {
                            cmd.Parameters.AddWithValue("@id_cliente", Convert.ToInt32(Txt_ID.Value));
                            cmd.Parameters.AddWithValue("@deleteData", DateTime.Today); // Marca a data de exclusão

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0) {
                                MessageBox.Show("Registro excluído com sucesso.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else {
                                MessageBox.Show("Erro ao excluir o registro. Verifique o ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bnt_CancelarAlterar_Click(object sender, EventArgs e) {
            DesabilitaEdicao();

            bnt_CancelarAlterar.Visible = false;
            bnt_CancelarAlterar.Enabled = false;

            bnt_SalvarAlterar.Visible = false;
            bnt_SalvarAlterar.Enabled = false;

        }

        private void Btn_Limpar_Click(object sender, EventArgs e) {
            LimparCampos();
        }
    }
}
