using System;
using System.Windows.Forms;
using OOPCalculator.OneArgumentCalculator;
using OOPCalculator.TwoArgumentsCalculator;

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
            try
            {
                double firstArgument = Convert.ToDouble(textBox1.Text);
                double secondArgument = Convert.ToDouble(textBox2.Text);
                double result;

                ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
                result = calculator.Calculate(firstArgument, secondArgument);
                textBox3.Text = result.ToString();
            }
            catch (Exception exc)
            {
                textBox3.Text = "Error:" + exc.Message;
            }
           
        }
        private void OneArgumentCalculate(object sender, EventArgs e)
        {

            try
            {
                double firstArgument = Convert.ToDouble(textBox1.Text);
                double result;

                IOneArgumentCalculator calculator = OneArgumentsFactory.CreateCalculator(((Button)sender).Name);
                result = calculator.Calculate(firstArgument);
                textBox3.Text = result.ToString();
            }
            catch (Exception exc)
            {
                // обработка исключения
            }
            
        }
    }
}
