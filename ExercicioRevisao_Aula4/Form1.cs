using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioRevisao_Aula4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numeroInteiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 TelaNumInt = new Form2();
            TelaNumInt.ShowDialog();
        }

        private void recebendoNumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 TelaQuatroNum = new Form3();
            TelaQuatroNum.ShowDialog();
        }

        private void idadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 TelaIdade = new Form4();
            TelaIdade.ShowDialog();
        }

        private void recebendoTresNumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 TelaMaiorNumero = new Form5();
            TelaMaiorNumero.ShowDialog();
        }
    }
}
