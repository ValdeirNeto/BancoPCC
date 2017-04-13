using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDoPCC___Primeiro_Controle_de_Conta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Ir ate o BD para buscar os valores e comparar
            ConnectionDB con = new ConnectionDB();
            var user = con.Buscar(textBox1.Text, textBox2.Text, textBox3.Text);

            if (user == null)
            {
                MessageBox.Show("Usuário não encontrado");
            }
            else
            {
                if (user.Agencia == textBox1.Text && user.Senha == textBox2.Text)
                {
                    //MessageBox.Show("Login e senha OK");
                    Menu menu = new Menu();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Login ou senha não conferem");
                }
                try
                {
                    this.Hide();
                    Menu n = new Menu();
                    n.Show();
                }
                finally { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
               Form6 n = new Form6 ();
                n.Show();
            }
            finally { }
        }
    }
    }


