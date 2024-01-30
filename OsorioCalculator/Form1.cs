using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OsorioCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double result = 0;
        double x = 0;
        double y = 0;

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if(textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += sevenButton.Text;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += zeroButton.Text;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += threeButton.Text;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += sixButton.Text;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += nineButton.Text;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += twoButton.Text;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += fiveButton.Text;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += eightButton.Text;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += oneButton.Text;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += fourButton.Text;
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += pointButton.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            operationLabel.Text = "Division";
            x = double.Parse(textBox.Text);
            textBox.Text = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            operationLabel.Text = "Multiplication";
            x = double.Parse(textBox.Text);
            textBox.Text = "";
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            operationLabel.Text = "Subtraction";
            x = double.Parse(textBox.Text);
            textBox.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            operationLabel.Text = "Addition";
            x = double.Parse(textBox.Text);
            textBox.Text = "";
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            y = double.Parse(textBox.Text);
            if (operationLabel.Text == "Addition")
                result = x + y;
            if (operationLabel.Text == "Subtraction")
                result = x - y;
            if (operationLabel.Text == "Multiplication")
                result = x * y;
            if (operationLabel.Text == "Division")
                result = x / y;

            textBox.Text = result + "";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string txt = textBox.Text;
            if (txt.Length > 0)
            {
                txt = txt.Remove(txt.Length - 1);
            }
            textBox.Text = txt;
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void ceButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            operationLabel.Text = "-";
            x = 0;
            y = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox.Text);
            x *= -1;
            textBox.Text = x.ToString();
        }
    }
}
