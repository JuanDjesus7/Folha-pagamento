﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatização_PIm_3_semestre_OFC
{
    public partial class btn_envia : Form
    {
        public btn_envia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 auto = new Form4();
            auto.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "Salario enviado com sucesso";
           
        }

        private void btn_envia_Load(object sender, EventArgs e)
        {

        }
    }
}
