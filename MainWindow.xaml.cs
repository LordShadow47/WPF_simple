using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Result.Text = string.Empty;
            Operation.Text = string.Empty; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = string.Empty;

            var button = sender as Button;
            var currentNumber = button.Name[button.Name.Length - 1];

            Operation.Text += currentNumber;
        }
        private void Button_Add(object sender, RoutedEventArgs e)
        {
            var operation = Operation.Text;

            if(ContainOperation(operation))
            {
                Operation.Text = Calculate(operation).ToString();
            }
            Operation.Text += "+";
        }
        private void Button_Sub(object sender, RoutedEventArgs e)
        {
            var operation = Operation.Text;

            if (ContainOperation(operation))
            {
                Operation.Text = Calculate(operation).ToString();
            }
            Operation.Text += "-";
        }
        private void Button_Mul(object sender, RoutedEventArgs e)
        {
            var operation = Operation.Text;

            if (ContainOperation(operation))
            {
                Operation.Text = Calculate(operation).ToString();
            }
            Operation.Text += "*";
        }
        private void Button_Div(object sender, RoutedEventArgs e)
        {
            var operation = Operation.Text;

            if (ContainOperation(operation))
            {
                Operation.Text = Calculate(operation).ToString();
            }
            Operation.Text += "/";
        }
        private void Button_Eql(object sender, RoutedEventArgs e)
        {
            var operation = Operation.Text;

            Result.Text = Calculate(operation).ToString();

            Operation.Text = string.Empty;
        }
        private int Calculate (string operation)
        {
            if (operation.Contains("+"))
            {
                var elements = operation.Split('+');
                return int.Parse(elements[0]) + int.Parse(elements[1]);
            }
            if (operation.Contains("-"))
            {
                var elements = operation.Split('-');
                return int.Parse(elements[0]) - int.Parse(elements[1]);
            }
            if (operation.Contains("*"))
            {
                var elements = operation.Split('*');
                return int.Parse(elements[0]) * int.Parse(elements[1]);
            }
            if (operation.Contains("/"))
            {
                var elements = operation.Split('/');
                return int.Parse(elements[0]) / int.Parse(elements[1]);
            }
            return default;
        }
        private bool ContainOperation(string operation) 
                => operation.Contains("+") || operation.Contains("-") || operation.Contains("*") || operation.Contains("/");           
        
    }
}
