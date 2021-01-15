using System;
using System.Collections.Generic;
using System.Linq;
using Projekt;
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
using System.Collections.ObjectModel;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy Sale.xaml
    /// </summary>
    public partial class Sale : Window
    {
        KompleksBudynkow k1 = KompleksBudynkow.OdczytajXML("sale.xml");
        public Sale()
        {
            InitializeComponent();
        }

        private void BtnWyszukaj_Click(object sender, RoutedEventArgs e)
        {
            int x = 0;
            if (CmbTypSali.Text == "Sale PREMIUM") 
                x = 1;
            if (CmbTypSali.Text == "Sale NORMAL")
                x = 2;
            if (CmbTypSali.Text ==  "Wszystkie Sale") 
                x = 3;

            if(!int.TryParse(txtpojemnosc.Text, out int dd))
            {
                MessageBox.Show("Wpisz poprawna liczbe!");
            }
            if(x==0)
            {
                MessageBox.Show("Wybierz typ sali");
            }    
            LstSale.ItemsSource = new ObservableCollection<Sala>(k1.FiltrujPojemnosc(dd, k1.FiltrujPremium(x)));
          
        }


    }
}
