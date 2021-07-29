using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        private int num1, num2;
        private char operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EvalButton_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = int.Parse(display.Text);
                long result = 0;
                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        display.Text = result + "";
                        break;
                    case '-':
                        result = num1 - num2;
                        display.Text = result + "";
                        break;
                    case '×':
                    case '*':
                        result = num1 * num2;
                        display.Text = result + "";
                        break;
                    case '÷':
                    case '/':
                        if (num2 != 0)
                        {
                            double res = (double)num1 / num2;
                            res = Math.Round(res, 10);
                            display.Text = res + "";
                        }
                        else
                        {
                            display.Text = "Err";
                        }
                        break;
                }
                if (result > int.MaxValue) display.Text = "Err";
                num1 = int.Parse(display.Text);
            }
            catch (FormatException) { }
            catch (OverflowException) { display.Text = "Err"; }
        }

        private void OpButton_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Int32.Parse(display.Text);
            }
            catch (FormatException) { }
            operation = Char.Parse(((Button)sender).Text);
            display.Text = "";
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            display.Text += ((Button)sender).Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
