using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPCalculator
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

        private void Label2_Click(object sender, EventArgs e)
        {

        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Calculate(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(textBox1.Text);
            double secondArgument = Convert.ToDouble(textBox2.Text);
            double result;
            switch (((Button)sender).Name)
            {
                case "Add":
                    result = firstArgument + secondArgument;
                    break;
                case "Substraction":
                    result = firstArgument - secondArgument;
                    break;
                case "Multiplication":
                    result = firstArgument * secondArgument;
                    break;
                case "Division":
                    result = firstArgument / secondArgument;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
            textBox3.Text = result.ToString();
        }
    }
}
