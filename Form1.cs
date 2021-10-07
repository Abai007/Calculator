using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        private double a = 0, b = 0, c = 0;
        private double f, d;
        private char sign = '+';
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text += (sender as Button).Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text += (sender as Button).Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += (sender as Button).Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text += (sender as Button).Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += (sender as Button).Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += (sender as Button).Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += (sender as Button).Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text += (sender as Button).Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += (sender as Button).Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox2.Text += (sender as Button).Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox2.Text += (sender as Button).Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox2.Text);
            sign = (sender as Button).Text[0];
            textBox2.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox2.Text);
            sign = (sender as Button).Text[0];
            textBox2.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox2.Text);
            sign = (sender as Button).Text[0];
            textBox2.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text != string.Empty)
            {
                double s = Convert.ToDouble(textBox2.Text);
                if (s > 0)
                {
                    textBox2.Clear();
                    s *= -1;
                    textBox2.Text = s.ToString();
                }else if(s < 0)
                {
                    textBox2.Clear();
                    s *= -1;
                    textBox2.Text = s.ToString();
                }else if(s == 0)
                {
                    textBox2.Clear();
                    textBox2.Text = s.ToString();
                }
            }
            else
            {
                textBox2.Text = "-";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox2.Text);
            d = Math.Sqrt(f);
            textBox2.Text = d.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox2.Text);
            d = Math.Pow(f, 2);
            textBox2.Text = d.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox2.Text);
            d = Math.Pow(f,3);
            textBox2.Text = d.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox2.Text);
            d = Math.Cos(f);
            textBox2.Text = d.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox2.Text);
            d = Math.Sin(f);
            textBox2.Text = d.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox2.Text);
            d = Math.Tan(f);
            textBox2.Text = d.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty)
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox2.Text);
            sign = (sender as Button).Text[0];
            textBox2.Clear();
        }
        
        private void button12_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox2.Text);
            switch (sign)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '/':
                    c = a / b;
                    if (b == 0)
                    {
                        MessageBox.Show("Нельзя делить на ноль!");
                        textBox2.Text = "Ошибка!";
                    }
                    break;
                case 'x':
                    c = a * b;
                    break;
            }
            textBox2.Text = c.ToString();
        }
    }
}
