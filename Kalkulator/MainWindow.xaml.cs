using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace Kalkulator
{
    public partial class MainWindow : Window
    {
        decimal number;

        public MainWindow()
        {
            InitializeComponent();

            number = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != string.Empty)
            {
                number += Convert.ToDecimal(textbox1.Text);
            }
            if (textbox2.Text != string.Empty)
            {
                number += Convert.ToDecimal(textbox2.Text);

            }
            if (textbox3.Text != string.Empty)
            {
                number += Convert.ToDecimal(textbox3.Text);
            }

            resultTextBox.Text = "Výsledek: " + Convert.ToString(number);

            number = 0;
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            decimal result;
            e.Handled = !decimal.TryParse((sender as TextBox).Text + e.Text, out result);
        }

        private void textbox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space) e.Handled = true;
        }

        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textbox1.Text != string.Empty)
            {
                number += Convert.ToDecimal(textbox1.Text);
            }
            if (textbox2.Text != string.Empty)
            {
                number += Convert.ToDecimal(textbox2.Text);

            }
            if (textbox3.Text != string.Empty)
            {
                number += Convert.ToDecimal(textbox3.Text);
            }

            resultTextBox.Text = "Výsledek: " + Convert.ToString(number);

            number = 0;
        }
    }
}
