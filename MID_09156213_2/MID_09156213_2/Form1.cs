using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MID_09156213_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(textBox1.Text);
            int number2 = Convert.ToInt32(textBox2.Text);
            double outputNumber = 0;

            if (plus.Checked)
                outputNumber = number1 + number2;
            else if (minus.Checked)
                outputNumber = number1 - number2;
            else if (multiply.Checked)
                outputNumber = number1 * number2;
            else if (divide.Checked)
            {
                outputNumber = (double)number1 / (double)number2;
                if (number2 == 0)
                    outputNumber = 0;
            }

            output.Text = String.Format("{0:0.##}", outputNumber);
        }
    }

    
}
