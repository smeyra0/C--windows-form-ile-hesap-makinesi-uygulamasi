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
        private decimal previousNumber = 0;
        private string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.ReadOnly = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox1.Text = "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {

            textBox1.Text = "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";


        }

        private void button7_Click(object sender, EventArgs e)
        {

            textBox1.Text = "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {

            textBox1.Text = "8";


        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";


        }

        private void button10_Click(object sender, EventArgs e)
        {

            textBox1.Text = "0";

        }

        private void button11_Click(object sender, EventArgs e)
        {

            operation = "+";
            previousNumber = decimal.Parse(textBox1.Text);
            textBox1.Clear();


        }

        private void button12_Click(object sender, EventArgs e)
        {
            operation = "-";
            previousNumber = decimal.Parse(textBox1.Text);
            textBox1.Clear();


        }

        private void button13_Click(object sender, EventArgs e)
        {

            operation = "x";
            previousNumber = decimal.Parse(textBox1.Text);
            textBox1.Clear();


        }

        private void button14_Click(object sender, EventArgs e)
        {

            operation = "/";
            previousNumber = decimal.Parse(textBox1.Text);
            textBox1.Clear();


        }

        private void button15_Click(object sender, EventArgs e)
        {
            CalculateResult();

        }

        private void CalculateResult()
        {
            decimal currentNumber = decimal.Parse(textBox1.Text);
            decimal result = 0;

            switch (operation)
            {
                case "+":
                    result = previousNumber + currentNumber;
                    break;
                case "-":
                    result = previousNumber - currentNumber;
                    break;
                case "x":
                    result = previousNumber * currentNumber;
                    break;
                case "/":
                    if (currentNumber != 0)
                    {
                        result = previousNumber / currentNumber;
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz bölme işlemi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                default:
                    break;
            }

            textBox1.Text = result.ToString();
            previousNumber = result;
            operation = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            previousNumber = 0;
            operation = "";
        

    }
    }
}
