using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int horas;
            double valhoras, descontos, salariomes;
            

            horas = int.Parse(txt_valorh.Text);
            valhoras = double.Parse(txt_quantidade.Text);
            descontos = double.Parse(txt_descontos.Text);

            salariomes = (horas * valhoras) - descontos;

            txt_final.Text = salariomes.ToString();


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
