using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiform_Calculator
{
    public partial class MultiplyDivideForm : Form
    {
        public MultiplyDivideForm()
        {
            InitializeComponent();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            // Declare double variables to hold the first number, second number and the result.
            double firstNumber = 0;
            double secondNumber = 0;
            double result = 0;

            // Get the first number from the firstNumberTextBox.
            firstNumber = double.Parse(firstNumberTextBox.Text);

            // Get the second number from the secondNumberTextBox.
            secondNumber = double.Parse(secondNumberTextBox.Text);

            // Add the two numbers together and assign it to result.
            result = firstNumber * secondNumber;

            // Display the result.
            resultLabel.Text = result.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            // Declare double variables to hold the first number, second number and the result.
            double firstNumber = 0;
            double secondNumber = 0;
            double result = 0;

            // Get the first number from the firstNumberTextBox.
            firstNumber = double.Parse(firstNumberTextBox.Text);

            // Get the second number from the secondNumberTextBox.
            secondNumber = double.Parse(secondNumberTextBox.Text);

            // Add the two numbers together and assign it to result.
            result = firstNumber / secondNumber;

            // Display the result.
            resultLabel.Text = result.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
