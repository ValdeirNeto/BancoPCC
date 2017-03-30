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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Login n1 = new Login();
                n1.Show();
            }
            finally { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Saldo n3 = new Saldo();
                n3.Show();
            }
            finally { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Deposito n4 = new Deposito();
                n4.Show();
            }
            finally { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Login n = new Login();
                n.Show();
            }
            finally { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Emprestimo n4 = new Emprestimo();
                n4.Show();
            }
            finally { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Transferencia n4 = new Transferencia();
                n4.Show();
            }
            finally { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Saque n4 = new Saque();
            n4.Show();
        }
    }
}
