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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            uint placa_brutto;
            bool tmp = true;

            try
            {
                placa_brutto = uint.Parse(TextBox_Brutto.Text);

                if (placa_brutto > 8549 || placa_brutto < 2600)
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Płaca brutto musi być dodatnią liczbą.");
                tmp = false;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Wpisano liczbę ujemną lub za dużą!");
                tmp = false;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Płaca brutto musi być w przedziale od 2600 do 8549");
                tmp = false;
            }


            if (tmp == true)
            {
                placa_brutto = uint.Parse(TextBox_Brutto.Text);
                Button_Click_Obliczanie(placa_brutto);
            }
        }

        private void Button_Click_Obliczanie(uint placa_brutto)
        {
            const int koszty = 250;
            const float kwota_wolna = 43.76F;

            float zus, ubezp_zdr, ubezp_do_odl, przychod, placa_netto;

            int dochod, zal_na_pod;

            zus = placa_brutto * 0.1371F;
            przychod = placa_brutto - zus;
            ubezp_zdr = przychod * 0.09F;
            ubezp_do_odl = przychod * 0.0775F;
            dochod = (int)(przychod - koszty);
            zal_na_pod = (int)(dochod * 0.18F - kwota_wolna - ubezp_do_odl);
            placa_netto = placa_brutto - zus - ubezp_zdr - zal_na_pod;

            ListBox.Items.Add("Płaca netto: " + (int)placa_netto);
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox_Brutto.Clear();
            ListBox.Items.Clear();
        }
    }
}
