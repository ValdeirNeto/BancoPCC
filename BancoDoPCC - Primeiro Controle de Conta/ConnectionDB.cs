using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDoPCC___Primeiro_Controle_de_Conta
{
    class ConnectionDB
    {
        public SqlConnection connection { get; set; }

        public ConnectionDB()
        {
            var caminho = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BancoPCC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            connection = new SqlConnection(caminho);
            connection.Open();

        }
        public Conta Buscar(string agencia, string NumeroConta, string Senha)
        {
            var sql = "select * from Conta where agencia=@agencia, NumeroConta=@NumeroConta, senha=@senha";
            var comando = new SqlCommand(sql, connection);
            comando.Parameters.AddWithValue("@agencia", agencia);
            comando.Parameters.AddWithValue("@numeroConta", NumeroConta);
            comando.Parameters.AddWithValue("@senha", Senha);

            SqlDataReader rdr = comando.ExecuteReader();
            Conta usuario = null;
            while (rdr.Read())
            {
                usuario = new Conta();
                usuario.Id = Convert.ToInt32(rdr["id"]);
                usuario.Agencia = rdr["agencia"].ToString();
                usuario.NumeroConta = Convert.ToInt32(rdr["NumeroConta"]);
                usuario.Senha = rdr["senha"].ToString();
            }

            return usuario;
        }
        public bool Inserir(string nome, string cpf, string rg, string endereco, string numero, string bairro, string senha)
        {
            var sql = "INSERT INTO Conta(nome, cpf, rg, endereco, numero, bairro, senha) VALUES (@nome, @cpf, @rg, @endereco, @numero, @bairro, @senha)";
            var comando = new SqlCommand(sql, connection);
           
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@cpf", cpf);
            comando.Parameters.AddWithValue("@rg", rg);
            comando.Parameters.AddWithValue("@endereco", endereco);
            comando.Parameters.AddWithValue("@numero", numero);
            comando.Parameters.AddWithValue("@bairro", bairro);
            comando.Parameters.AddWithValue("@senha", senha);

            var retorno = comando.ExecuteNonQuery();
            if (retorno > 0)
                return true;
            else
                return false;
        }
    }
}
