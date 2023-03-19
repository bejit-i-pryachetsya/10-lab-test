using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_lab_test
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool F;
        public Form1()
        {
            F = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void button28_MouseClick(object sender, MouseEventArgs e)
        {
            if (F)
            {
                F = false;
                textBox1.Clear();
            }
            Button but = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = but.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + but.Text;
            }
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button22_MouseClick(object sender, MouseEventArgs e)
        {

            Button but = (Button)sender;
            D = but.Text;
            N1 = textBox1.Text;
            F = true;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double DoN1 = Convert.ToDouble(N1);
            double DoN2 = Convert.ToDouble(textBox1.Text);
            double result = 0;
            if (D == "-")
            {
                result =  DoN1 - DoN2;
            }
            if (D == "+")
            {
                result = DoN1 + DoN2;
            }
            if (D == "*")
            {
                result = DoN1 * DoN2;
            }
            if (D == ":")
            {
                result = DoN1 / DoN2;
            }
            if (D == "%")
            {
                result =  100 / (DoN1 / DoN2); //Сколько % составляет число DoN2 в числе DoN1
            }
            if (D == "sin")
            {
                result = Math.Sin(DoN2);
            }
            if (D == "cos")
            {
                result = Math.Cos(DoN2);
            }
            if (D == "tan")
            {
                result = Math.Tan(DoN2);
            }
            if (D == "asin")
            {
                result = Math.Asin(DoN2);
            }
            if (D == "acos")
            {
                result = Math.Acos(DoN2);
            }
            if (D == "atan")
            {
                result = Math.Atan(DoN2);
            }
            if (D == "Exp")
            {
                result = Math.Exp(DoN2);
            }
            D = "=";
            F = true;
            textBox1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double k = Convert.ToDouble(textBox1.Text);
            double result = Math.Sqrt(k);
            textBox1.Text = result.ToString();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double k = Convert.ToDouble(textBox1.Text);
            double result = Math.Pow(k,2);
            textBox1.Text = result.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double k = Convert.ToDouble(textBox1.Text);
            double result = 1/k;
            textBox1.Text = result.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3,24159";
            F = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text + ",";
            }
            
        }
    }
}
