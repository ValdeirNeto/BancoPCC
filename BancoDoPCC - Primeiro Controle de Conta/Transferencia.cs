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
    public partial class Transferencia : Form
    {
        public Transferencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Menu n4 = new Menu();
                n4.Show();
            }
            finally { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transferido com Sucesso");
            try
            {
                this.Hide();
                Menu n4 = new Menu();
                n4.Show();
            }
            finally { }
        }
    }
}
