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

        private void createAccount_Click(object sender, EventArgs e)
        { 
            command.CommandText = "INSERT INTO Conta(nome, cpf, rg, endereco, numero, bairro, senha) VALUES (@nome, @cpf, @rg, @endereco, @numero, @bairro, @senha)";
            command.Parameters.AddWithValue("@nome", txtName.Text);
            command.Parameters.AddWithValue("@cpf", txtCpf.Text);
            command.Parameters.AddWithValue("@rg", txtRg.Text);
            command.Parameters.AddWithValue("@endereco", txtAddress.Text);
            command.Parameters.AddWithValue("@numero", txtNumber);
            command.Parameters.AddWithValue("@bairro", txtDistrict.Text);
            command.Parameters.AddWithValue("@senha", Convert.ToInt16(txtPassword.Text));

            command.ExecuteNonQuery();
        }
            

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
