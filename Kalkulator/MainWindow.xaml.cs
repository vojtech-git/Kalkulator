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
using System.Collections;
using System.Globalization;
using System.Reflection;

namespace Kalkulator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBox[] zadavaciPole = new TextBox[] { textBoxDo, textBoxDi, textBoxFx, textBoxFy, textBoxFz, textBoxMx, textBoxMy, textBoxMz };
            foreach (TextBox textBox in zadavaciPole)
                DataObject.AddPastingHandler(textBox, PasteHandler);
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

        private void Button_Spocitat(object sender, RoutedEventArgs e)
        {
            double numResultA;
            double numResultWo;            
            double numResultWk;
            double numResultF;
            double numResultM;

            double numResultSmyk;
            double numResultOhyb;
            double numResultKrut;
            double numResultTlak;

            if (textBoxFx.Text != "" && textBoxFy.Text != "" && textBoxFz.Text != "" && textBoxDo.Text != "" && textBoxDi.Text != "" && textBoxMx.Text != "" && textBoxMy.Text != "" && textBoxMz.Text != "")
            {
                //bugfixing troubleshooting
                //MessageBox.Show(Convert.ToString(Math.Sqrt(Math.Pow(Convert.ToDouble(textBoxFx.Text), 2) + Math.Pow(Convert.ToDouble(textBoxFy.Text), 2))));
                //MessageBox.Show(Convert.ToString((Math.PI * (Math.Pow(Convert.ToDouble(textBoxDo.Text), 2) - Math.Pow(Convert.ToDouble(textBoxDi.Text), 2))) / 4));

                //výpočet
                numResultF = Math.Sqrt(Math.Pow(Convert.ToDouble(textBoxFx.Text), 2) + Math.Pow(Convert.ToDouble(textBoxFy.Text), 2));
                numResultA = (Math.PI * (Math.Pow(Convert.ToDouble(textBoxDo.Text), 2) - Math.Pow(Convert.ToDouble(textBoxDi.Text), 2))) / 4;
                numResultWo = (Math.PI * (Math.Pow(Convert.ToDouble(textBoxDo.Text), 4) - Math.Pow(Convert.ToDouble(textBoxDi.Text), 4))) / (32 * Convert.ToDouble(textBoxDo.Text));
                numResultWk = numResultWo * 2;
                numResultM = Math.Sqrt(Math.Pow(Convert.ToDouble(textBoxMx.Text), 2) + Math.Pow(Convert.ToDouble(textBoxMy.Text), 2));

                numResultSmyk = numResultF / numResultA;
                numResultOhyb = numResultM / numResultWo;
                numResultKrut = Convert.ToDouble(textBoxMz.Text) / numResultWk;
                numResultTlak = Convert.ToDouble(textBoxFz.Text) / numResultA;

                resultA.Text = numResultA.ToString("g5", NumberFormatInfo.CurrentInfo);
                resultF.Text = numResultF.ToString("g5", NumberFormatInfo.CurrentInfo);
                resultM.Text = numResultM.ToString("g5", NumberFormatInfo.CurrentInfo);
                resultWo.Text = numResultWo.ToString("g5", NumberFormatInfo.CurrentInfo);
                resultWk.Text = numResultWk.ToString("g5", NumberFormatInfo.CurrentInfo);

                resultOhyb.Text = numResultOhyb.ToString("g5", NumberFormatInfo.CurrentInfo);
                resultKrut.Text = numResultKrut.ToString("g5", NumberFormatInfo.CurrentInfo); 
                resultSmyk.Text = numResultSmyk.ToString("g5", NumberFormatInfo.CurrentInfo);
                resultTlak.Text = numResultTlak.ToString("g5", NumberFormatInfo.CurrentInfo);
            }
        }

        private void Button_Vysvetlivky(object sender, RoutedEventArgs e)
        {
            VysvetlivkyWindow vysvetlivkyWindow = new VysvetlivkyWindow();
            vysvetlivkyWindow.Show();
            this.Close();
        }
    }
}
