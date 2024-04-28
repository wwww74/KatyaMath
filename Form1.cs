using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        string znak = "";
        int a = 0;
        int b = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e) //+
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            znak = "+";
        }

        private void button12_Click(object sender, EventArgs e) // -
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            znak = "-";
        }

        private void button13_Click(object sender, EventArgs e) // *
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            znak = "*";
        }

        private void button15_Click(object sender, EventArgs e) // /
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            znak = "/";
        }

        private void button14_Click(object sender, EventArgs e) // =
        {
            if (textBox1.Text != "")
            {
                b = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
            }
            else
            {
                b = 0;
                textBox1.Clear();
            }
            
            switch(znak)
            {
                case "+":
                    textBox1.Text = (a + b).ToString();
                    break;

                case "-":
                    textBox1.Text = (a - b).ToString();
                    break;

                case "*":
                    textBox1.Text = (a * b).ToString();
                    break;

                case "/":
                    textBox1.Text = (a / b).ToString();
                    break;

                case "0":
                    textBox1.Text = Math.Pow(a, b).ToString();
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            textBox1.Text = Math.Sqrt(a).ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            znak = "0";
        }
    }
}
