using System;
using System.Windows;
using System.Windows.Controls;

namespace Zliczanie
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
            ListBox.Items.Clear();

            string napis;
            char litera;

            try
            {
                napis = TextBox_Napis.Text;
                litera = char.Parse(TextBox_Litera.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("W drugim polu tekstowym należy podać jeden znak! Zostanie pobrany pierwszy znak.");
                napis = TextBox_Napis.Text;

                if (TextBox_Litera.Text == "")
                {
                    litera = ' ';
                }
                else
                {
                    string tmp = TextBox_Litera.Text;
                    litera = tmp[0];
                }
            }

            Button_Click_Obliczanie(napis, litera);
        }

        private void Button_Click_Obliczanie(string napis, char litera)
        {
            int licznik = 0;

            for (int i = 0; i < napis.Length; i++)
            {
                if (napis[i] == litera)
                {
                    licznik++;
                    ListBox.Items.Add("[" + licznik + "]" + " Wystąpienie na pozycji: " + i);
                }
            }

            if (licznik == 0)
                ListBox.Items.Add("Znak nie wystąpił w napisie ani razu.");
            else
                ListBox.Items.Add("Ilość wystąpień znaku w danym napisie: " + licznik);
        }
    }
}
