using System;
using System.Windows;
using CalculatorLibrary;

namespace ArgontsovCalculatorWPF
{
    public partial class MainWindow : Window
    {
        private readonly Calculator _calculator = new Calculator();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ExecuteOperation((a, b) => _calculator.Add(a, b));
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            ExecuteOperation((a, b) => _calculator.Subtract(a, b));
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            ExecuteOperation((a, b) => _calculator.Multiply(a, b));
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            ExecuteOperation((a, b) => _calculator.Divide(a, b));
        }

        private void Power_Click(object sender, RoutedEventArgs e)
        {
            ExecuteOperation((a, b) => _calculator.Power(a, b));
        }

        private void ExecuteOperation(Func<double, double, double> operation)
        {
            try
            {
                if (double.TryParse(txtNum1.Text, out double num1) &&
                double.TryParse(txtNum2.Text, out double num2))
                {
                    double result = operation(num1, num2);
                    txtResult.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите корректные числа.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка вычисления", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}