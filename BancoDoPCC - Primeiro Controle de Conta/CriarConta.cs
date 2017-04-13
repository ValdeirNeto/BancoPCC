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

namespace BancoDoPCC___Primeiro_Controle_de_Conta
{
    public partial class Form6 : Form
    {
        String conn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BancoPCC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection;
        SqlCommand command;

       
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(conn);
            connection.Open();
            command = connection.CreateCommand();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nome = txtName.Text;
            var cpf = txtCpf.Text;
            var rg = txtRg.Text;
            var endereco = txtAddress.Text;
            var numero = txtNumber.Text;
            var bairro = txtDistrict.Text;
            var senha = txtPassword.Text;

            ConnectionDB db = new ConnectionDB();

            var resultado = db.Inserir(nome,cpf, rg, endereco, numero, bairro, senha);
            if (resultado)
            {
                MessageBox.Show("Inserção OK");
            }
            else
            {
                MessageBox.Show("Falha na inserção, faça novamente");
            }
            this.Close();
        }
            

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
