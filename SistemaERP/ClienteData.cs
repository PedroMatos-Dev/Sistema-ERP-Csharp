using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaERP {
    class ClienteData {

        public string id_Cliente { get; set; }
        public string Nome { get; set; }
        public string cpf {  get; set; }
        public string celular {  get; set; }
        public string telAlt { get; set; }
        public string sexo { get; set; }
        public string cep { get; set; }
        public string longadouro { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string email { get; set; }
        public string imagem {  get; set; }
        

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programação\Banco\SalesSystem - C#\SalesSystem.mdf"";Integrated Security=True;Connect Timeout=30");
    
        public List<ClienteData> clienteData() {

            List<ClienteData> listaData = new List<ClienteData>();

            if(connection.State != ConnectionState.Open) {
                try {
                    connection.Open();

                    string selectData = "SELECT * FROM clientes WHERE delete_date IS NULL";

                    using(SqlCommand cmd = new SqlCommand(selectData, connection)) {

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read()) {
                            ClienteData ed = new ClienteData();

                            ed.id_Cliente = reader["id_cliente"].ToString();
                            ed.Nome = reader["nome"].ToString();
                            ed.cpf = reader["cpf"].ToString();
                            ed.celular = reader["celular"].ToString();
                            ed.telAlt = reader["telAlt"].ToString();
                            ed.sexo = reader["sexo"].ToString();
                            ed.cep = reader["cep"].ToString();
                            ed.longadouro = reader["longadouro"].ToString();
                            ed.numero = reader["numero"].ToString();
                            ed.bairro = reader["bairro"].ToString();
                            ed.cidade = reader["cidade"].ToString();
                            ed.estado = reader["estado"].ToString();
                            ed.email = reader["email"].ToString();
                            ed.imagem = reader["imagem"].ToString();

                            listaData.Add(ed);
                        }
                    }


                }catch(Exception ex) {
                    Console.WriteLine("Erro:" + ex.Message);

                }
                finally {
                    connection.Close();
                }
            }

            return listaData;
        }
    
    
    
    
    }



}
