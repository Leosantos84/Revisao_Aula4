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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;

            num1 = 0;
            num2 = 0;
            num3 = 0;

            num1 = int.Parse(txtnum1.Text);
            num2 = int.Parse(txtnum2.Text);
            num3 = int.Parse(txtnum3.Text);

            if ((num1 > num2) & (num1 > num3))
            {
                Lresultado.Text = ("O número " + num1 + " foi o maior número digitado!");
            }
            else
            {
                if ((num2 > num1) & (num2 > num3))
                {
                    Lresultado.Text = ("O número " + num2 + " foi o maior número digitado!");
                }
                else
                {
                    Lresultado.Text = ("O número " + num3 + " foi o maior número digitado!");

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "";
            txtnum2.Text = "";
            txtnum3.Text = "";
            Lresultado.Text = "";
            txtnum1.Focus();
        }
    }
}
