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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnlyNumbers_PreviewInput(object sender, TextCompositionEventArgs e)
        {
            decimal result;
            e.Handled = !decimal.TryParse((sender as TextBox).Text + e.Text, out result);
        }

        private void NotSpace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space) e.Handled = true;
        }

        private void Button_Spocitat(object sender, RoutedEventArgs e)
        {
            double A = 0;
            decimal Wo = 0;
            decimal Wk = 0;
            double F = 0;
            decimal M = 0;

            if ((textBoxFy.Text != null || textBoxFy.Text != ",") && (textBoxFx.Text != null || textBoxFx.Text != ","))
            {
                resultF.Text = Convert.ToString(Math.Sqrt(Math.Pow(Convert.ToDouble(textBoxFx.Text), 2) + Math.Pow(Convert.ToDouble(textBoxFy.Text), 2)));
            }

            if ((textBoxDo.Text != null || textBoxDo.Text != ",") && (textBoxDi.Text != null || textBoxDi.Text != ","))
            {
                resultA.Text = Convert.ToString((Math.PI * (Math.Pow(Convert.ToDouble(textBoxDo.Text), 2) - Math.Pow(Convert.ToDouble(textBoxDi.Text), 2))) / 4);
            }

            resultSmyk.Text = Convert.ToString(Convert.ToDecimal(resultF.Text) / Convert.ToDecimal(resultA.Text));
        }

        private void Button_Vysvetlivky(object sender, RoutedEventArgs e)
        {
            VysvetlivkyWindow vysvetlivkyWindow = new VysvetlivkyWindow();
            vysvetlivkyWindow.Show();
            this.Close();
        }
    }
}
