using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaERP {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void lb_Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btn_Logout_Click(object sender, EventArgs e) {
            DialogResult check = MessageBox.Show("Você tem certeza que deseja deslogar?", 
                                                 "Confirmation Mesasge", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes) {
                LoginForms loginForms = new LoginForms();
                loginForms.Show();
                this.Hide();
            }
        }

        private void bnt_Venda_Click(object sender, EventArgs e) {
            painelVenda1.Visible = true;
            dashbord1.Visible = false;
            estoque1.Visible = false;
            clientes1.Visible = false;
        }

        private void bnt_Cliente_Click(object sender, EventArgs e) {
            painelVenda1.Visible = false;
            dashbord1.Visible = false;
            estoque1.Visible = false;
            clientes1.Visible = true;
        }

        private void bnt_Estoque_Click(object sender, EventArgs e) {
            painelVenda1.Visible = false;
            dashbord1.Visible = false;
            estoque1.Visible = true;
            clientes1.Visible = false;
        }

        private void bnt_Dashbord_Click(object sender, EventArgs e) {
            painelVenda1.Visible = false;
            dashbord1.Visible = true;
            estoque1.Visible = false;
            clientes1.Visible = false;
        }
    }
}
