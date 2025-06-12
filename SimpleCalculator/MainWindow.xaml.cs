using System;
using System.Windows;

namespace SimpleCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Calculator calculator = new Calculator();

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (TryParseInputs(out double num1, out double num2))
                ResultText.Text = $"Result: {calculator.Add(num1, num2)}";
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            if (TryParseInputs(out double num1, out double num2))
                ResultText.Text = $"Result: {calculator.Subtract(num1, num2)}";
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            if (TryParseInputs(out double num1, out double num2))
                ResultText.Text = $"Result: {calculator.Multiply(num1, num2)}";
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            if (TryParseInputs(out double num1, out double num2))
            {
                try
                {
                    ResultText.Text = $"Result: {calculator.Divide(num1, num2)}";
                }
                catch (DivideByZeroException)
                {
                    ResultText.Text = "Cannot divide by zero.";
                }
            }
        }
        private bool TryParseInputs(out double num1, out double num2)
        {
            bool isNum1Valid = double.TryParse(Input1.Text, out num1);
            bool isNum2Valid = double.TryParse(Input2.Text, out num2);

            if (!isNum1Valid || !isNum2Valid)
            {
                ResultText.Text = "Please enter valid numbers.";
                return false;
            }
            return true;
        }
    }
}
