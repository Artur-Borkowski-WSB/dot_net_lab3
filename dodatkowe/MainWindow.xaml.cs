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

namespace dodatkowe
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

        private void Wyszukaj(object sender, RoutedEventArgs e)
        {
            var klient = new Usluga.SzukajClient();
            Usluga.Osoba znaleziona = klient.PoNazwisku(searchStr.Text);
            if (znaleziona != null)
            {
                resultBox.Text = $"Znaleziono osobę: {znaleziona.imie} {znaleziona.nazwisko}, {znaleziona.adres}";
            }
            else
            {
                resultBox.Text = "Nie znaleziono osoby o nazwisku: " + searchStr.Text;
            }
        }
    }
}
