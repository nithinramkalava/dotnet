using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        int operation, left, right;
        public Calculator()
        {
            InitializeComponent();
        }

        private void nine_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void six_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void five_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void four_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void three_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void two_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void one_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            left = int.Parse(display.Text);
            operation = 1;
            display.Text = "";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            left = int.Parse(display.Text);
            operation = 2;
            display.Text = "";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            left = int.Parse(display.Text);
            operation = 3;
            display.Text = "";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            left = int.Parse(display.Text);
            operation = 4;
            display.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            right = int.Parse(display.Text);
            int res = 0;
            switch (operation) {
                case 1: res = left + right; break;
                    case 2: res = left - right;
                    break;
                    case 3: res = left * right;
                    break;
                    case 4: res = left / right;
                    break;
                    default: break;
            }

            display.Text = res.ToString();
        }
    }
}
