using System;
using System.Windows;
using System.Windows.Controls;

namespace Kalkulator_Netto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int koszty = 250;
        const float kwota_wolna = 43.76F;

        float zus, ubezp_zdr, ubezp_do_odl, przychod, placa_netto;

        int placa_brutto, dochod, zal_na_pod;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TXB_Brutto_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                placa_brutto = int.Parse(TXB_Brutto.Text);
            }
            catch (FormatException fEX)
            {
                MessageBox.Show("Płaca brutto musi być liczbą!");
                TXB_Brutto.Text = "0";
            }
        }

        private void BT_Oblicz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (placa_brutto < 2600 || placa_brutto > 8549)
                {
                    throw new IndexOutOfRangeException();
                }

                zus = placa_brutto * 0.1371F;
                przychod = placa_brutto - zus;
                ubezp_zdr = przychod * 0.09F;
                ubezp_do_odl = przychod * 0.0775F;
                dochod = (int)(przychod - koszty);
                zal_na_pod = (int)(dochod * 0.18F - kwota_wolna - ubezp_do_odl);
                placa_netto = placa_brutto - zus - ubezp_zdr - zal_na_pod;

                zus = (int)zus;
                TXB_Wyniki.Text = "zus: " + zus + Environment.NewLine +
                    "dochod: " + dochod + Environment.NewLine +
                    "zaliczka: " + zal_na_pod + Environment.NewLine +
                    "placa_netto: " + placa_netto;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Płaca brutto musi zawierać się w zakresie od 2600 do 8549zł!");
                placa_brutto = 0;
                TXB_Brutto.Text = "0";
                TXB_Wyniki.Text = "";
            }
        }

        private void BT_Wyczysc_Click(object sender, RoutedEventArgs e)
        {
            TXB_Wyniki.Text = "";
            TXB_Brutto.Text = "0";
        }

    }
}
