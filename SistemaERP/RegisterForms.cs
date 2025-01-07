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
    public partial class RegisterForms : Form {
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
    }
}
