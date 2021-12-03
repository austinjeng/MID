using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MID_09156213_3
{
    public partial class Form1 : Form
    {
        int timeLeft;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                timerText.Text = (timeLeft / 60).ToString() + "分" + (timeLeft % 60).ToString() + "秒";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("時間到囉");
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeLeft = Convert.ToInt32(number1.Text) * 60 + Convert.ToInt32(number2.Text);
            timerText.Text = number1.Text + "分" + number2.Text + "秒";
            button1.Enabled = false;
            timer1.Start();
            
        }
    }
}
