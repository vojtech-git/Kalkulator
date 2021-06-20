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
using System.Windows.Shapes;
using System.Text.RegularExpressions;


namespace Kalkulator
{
    /// <summary>
    /// Interaction logic for WindowPyth.xaml
    /// </summary>
    public partial class WindowPyth : Window
    {
        public WindowPyth()
        {
            InitializeComponent();
            if (MainWindow.vzorecek == 1)
            {
                ATextBlock.Visibility = Visibility.Collapsed;
                ATextBox.Visibility = Visibility.Collapsed;
            }
            else if (MainWindow.vzorecek == 2)
            {
                BTextBlock.Visibility = Visibility.Collapsed;
                BTextBox.Visibility = Visibility.Collapsed;
            }
            else if(MainWindow.vzorecek == 3)
            {
                CTextBlock.Visibility = Visibility.Collapsed;
                CTextBox.Visibility = Visibility.Collapsed;
            }
        }

        private void PasteHandler(object sender, DataObjectPastingEventArgs e)
        {
            TextBox tb = sender as TextBox;
            bool textOK = false;

            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string pasteText = e.DataObject.GetData(typeof(string)) as string;
                Regex r = new Regex(@"^\d+,{1}\d+$");
                if (r.IsMatch(pasteText))
                    textOK = true;
            }

            if (!textOK)
                e.CancelCommand();
        }

        private void OnlyNumbers_PreviewInput(object sender, TextCompositionEventArgs e)
        {
            decimal result;
            e.Handled = !decimal.TryParse((sender as TextBox).Text + e.Text, out result);
        }

        private void NotSpace_KeyDown(object sender, KeyEventArgs e)
        {
            //zakazuje mezeru
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void textBox_PreviewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Regex r = new Regex(@"^\d+,{1}\d+$");
            if ((sender as TextBox).Text != "")
            {
                if (e.Command == ApplicationCommands.Paste)
                    e.Handled = true;

                // PLUS přidat co se deje proc nejde kopírovat
            }
        }

        private void MenuItem_PythagorA(object sender, RoutedEventArgs e)
        {

        }
        private void MenuItem_PythagorB(object sender, RoutedEventArgs e)
        {

        }
        private void MenuItem_PythagorC(object sender, RoutedEventArgs e)
        {

        }
        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Smajlík(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(":) nic");
        }
    }
}
