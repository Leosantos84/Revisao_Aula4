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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;

            num1 = 0;

            num1 = int.Parse(txtidade.Text);

            if (num1 > 21)
            {
                Lresultado.Text = ("ATENÇÃO... Você têm mais de 21 anos de idade!");
            }
            else
            {
                if (num1 == 21)
                {
                    Lresultado.Text = ("Você têm 21 anos de idade!");
                }
                else
                {
                    Lresultado.Text = ("Você têm " + num1 + " anos de idade.");
                  
                }
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtidade.Text = "";
            Lresultado.Text = "";
            txtidade.Focus();
        }
    }
}
