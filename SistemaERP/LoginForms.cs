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
    public partial class LoginForms : Form {

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30");
       
        public LoginForms() {
            InitializeComponent();
        }

        private void TxtLab_Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btn_Signup_Click(object sender, EventArgs e) {
            RegisterForms registerForm = new RegisterForms();
            registerForm.Show();
            this.Hide();
        }

        private void cb_ShowPassLogin_CheckedChanged(object sender, EventArgs e) {
            TxtBox_PassLogin.PasswordChar = cb_ShowPassLogin.Checked ? '\0' : '*'; 
        }

        private void btn_Login_Click(object sender, EventArgs e) {

            if(TxtBox_NameLogin.Text == "" || TxtBox_PassLogin.Text == ""){
                MessageBox.Show("Por favor, preencha todos os campos em branco! ",
                                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if(connection.State == ConnectionState.Closed) {
                    try {
                        connection.Open();

                        string selectData = "SELECT *FROM users WHERE username = @username " +
                                            "AND password = @password";

                        using(SqlCommand cmd = new SqlCommand(selectData, connection)) {

                            cmd.Parameters.AddWithValue("@username", TxtBox_NameLogin.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", TxtBox_PassLogin.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count >= 1) {
                                MessageBox.Show("Login bem sucedido!", 
                                                "information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MainForm mainForm = new MainForm();
                                mainForm.Show();
                                this.Hide();
                            }
                            else {
                                MessageBox.Show("Nome de usuário ou senha incorretos!",
                                                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LoginForms_Load(object sender, EventArgs e) {

        }
    }
}
