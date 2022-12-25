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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;

            num1 = 0;

            num1 = int.Parse(txtlendonum.Text);

            if (num1 >= 0)
            {
                Lresultado.Text = ("O número digitado é positivo!");
            }
            else
            {
                Lresultado.Text = ("O número digitado é negativo!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtlendonum.Text = "";
            Lresultado.Text = "";
            txtlendonum.Focus();
        }
    }
}
