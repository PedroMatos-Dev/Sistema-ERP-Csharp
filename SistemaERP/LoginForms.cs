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
    public partial class LoginForms : Form {
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
    }
}
