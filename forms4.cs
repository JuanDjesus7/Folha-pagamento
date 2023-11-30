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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pIM2023DataSet3.Salario'. Você pode movê-la ou removê-la conforme necessário.
            this.salarioTableAdapter.Fill(this.pIM2023DataSet3.Salario);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            salarioBindingSource.RemoveCurrent();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            salarioBindingSource.MovePrevious();
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            salarioBindingSource.MoveNext();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            salarioBindingSource.AddNew();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            salarioBindingSource.EndEdit();
            salarioTableAdapter.Update(pIM2023DataSet3);
        }

        private void btn_volr_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
