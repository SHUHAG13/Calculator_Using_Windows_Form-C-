using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(textBox1.Text);
            double val2 = Convert.ToDouble(textBox2.Text);
            double div = val1/val2;
            textBox3.Text = div.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(textBox1.Text);
            double val2 = Convert.ToDouble(textBox2.Text);
            double sum = val1 + val2;
            textBox3.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(textBox1.Text);
            double val2 = Convert.ToDouble(textBox2.Text);
            double diff = val1 - val2;
            textBox3.Text = diff.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(textBox1.Text);
            double val2 = Convert.ToDouble(textBox2.Text);
            double mul = val1*val2;
            textBox3.Text = mul.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(textBox1.Text);
            double val2 = Convert.ToDouble(textBox2.Text);
            double mod = val1 % val2;
            textBox3.Text = mod.ToString();
        }
    }
}
