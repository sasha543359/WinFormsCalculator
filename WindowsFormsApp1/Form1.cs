using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        double a = 0;
        double b = 0;
        char c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            b = Convert.ToDouble(textBox1.Text);
            switch (c)
            {
                case '+':
                    textBox1.Text = (a + b).ToString();

                    break;
                case '-':
                    textBox1.Text = (a - b).ToString();

                    break;
                case '/':
                    {
                        if (b != 0)
                            textBox1.Text = (a / b).ToString();
                    }                 
                    break;
                case '*':
                    textBox1.Text = (a * b).ToString();

                    break;
            }
           

        }

        private void One_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            c = '+';
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            c = '-';
        }

        private void Devide_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            c = '/';
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            c = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            textBox1.Text = null;
        }
    }
}
