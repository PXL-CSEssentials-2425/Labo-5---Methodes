using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Methodes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Deel 1
        private void firstAddButton_Click(object sender, RoutedEventArgs e)
        {
            int number = int.Parse(totalSumTextBox.Text);
            number += 1;
            totalSumTextBox.Text = number.ToString();
        }

        private void secondAddButton_Click(object sender, RoutedEventArgs e)
        {
            int number = int.Parse(totalSumTextBox.Text);
            number += 1;
            totalSumTextBox.Text = number.ToString();
        }

        private void thirdAddButton_Click(object sender, RoutedEventArgs e)
        {
            int number = int.Parse(totalSumTextBox.Text);
            number += 1;
            totalSumTextBox.Text = number.ToString();
        }




        // Deel 3
        // ----------------
        // Paste code here!
        private void subtractByValButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the current value from the textbox:
            int currentValue = int.Parse(resultByValTextBox.Text);
            // Pass the value to the subtractByVal method:
            subtractByVal(currentValue);
            // Display the new value in the textbox:
            resultByValTextBox.Text = currentValue.ToString();
        }

        private void subtractByVal(int currentValue)
        {
            // Subtract 1 from the value passed via the parameter:
            currentValue -= 1;
        }

        private void subtractByRefButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the current value from the textbox:
            int currentValue = int.Parse(resultByRefTextBox.Text);
            // Pass the value to the subtractByVal method:
            subtractByRef(ref currentValue);
            // Display the new value in the textbox:
            resultByRefTextBox.Text = currentValue.ToString();
        }

        private void subtractByRef(ref int currentValue)
        {
            // Subtract 1 from the value passed via the parameter:
            currentValue -= 1;
        }


        // Deel 4
        private void validateButton_Click(object sender, RoutedEventArgs e)
        {
            if(!ValidateInput(inputTextBox.Text, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Invalid text", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private bool ValidateInput(string textToValidate, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrEmpty(textToValidate))
            {
                errorMessage = "The text is empty.";
                return false;
            }

            if (!int.TryParse(textToValidate, out int number))
            {
                errorMessage = "The text is not a valid number.";
                return false;
            }

            if (number <= 0)
            {
                errorMessage = "The number should be greater than 0.";
                return false;
            }

            if (number >= 100)
            {
                errorMessage = "The number should be smaller than 100.";
                return false;
            }

            return true;
        }
    }
}