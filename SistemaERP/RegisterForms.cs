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


namespace SistemaERP {
    public partial class RegisterForms : Form {

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30");

        public RegisterForms() {
            InitializeComponent();
        }

        private void TxtLab_Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btn_SignIn_Click(object sender, EventArgs e) {
            LoginForms loginForms = new LoginForms();
            loginForms.Show();
            this.Hide();
        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e) {
            TxtBox_PassRegister.PasswordChar = cb_ShowPassRegister.Checked ? '\0' : '*';
        }

        private void btn_Login_Click(object sender, EventArgs e) {

            if(TxtBox_NameRegister.Text == "" || TxtBox_PassRegister.Text == "") {
                    MessageBox.Show("Por favor, preencha todos os campos em branco! ",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (connection.State != ConnectionState.Open) {
                    try {
                        connection.Open();

                        //Para verificar se o usuário já existe

                        string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";

                        using(SqlCommand checkUser = new SqlCommand(selectUsername, connection)) {

                            checkUser.Parameters.AddWithValue("@user", TxtBox_NameRegister.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count >= 1) {
                                MessageBox.Show(" Já existe um usuario com esse login!",
                                                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO users " +
                                                    "(username, password, date_register) " +
                                                    "VALUES(@username, @password, @dateReg) ";

                                using (SqlCommand cmd = new SqlCommand(insertData, connection)) {
                                    cmd.Parameters.AddWithValue("@username", TxtBox_NameRegister.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", TxtBox_PassRegister.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Conta criada com sucesso! ",
                                                    "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoginForms loginForms = new LoginForms();
                                    loginForms.Show();
                                    this.Hide();
                                }
                            }   
                        }                     
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Error: " + ex,
                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally {
                        connection.Close();
                    }
                }
            }
        }
    }
}
