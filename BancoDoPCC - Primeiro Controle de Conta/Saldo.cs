﻿using System;
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
    public partial class Saldo : Form
    {
        public Saldo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
                Menu n = new Menu();
                n.Show();
            }
            finally { }
        }
    }
    }

