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
        }

        public void displayClienteData() {

            ClienteData ed = new ClienteData();
            List<ClienteData> listaData = ed.clienteData();

            dataGridView1.DataSource = listaData;
        }

        private void bnt_AddCliente_Click(object sender, EventArgs e) {
            AddCliente addCliente = new AddCliente();
            addCliente.Show();
        }

        private void bnt_ConsultarCliente_Click(object sender, EventArgs e) {
            ConsultarCliente consultarCliente = new ConsultarCliente();
            consultarCliente.Show();
        }
    }
}
