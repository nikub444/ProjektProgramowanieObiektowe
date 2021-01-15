using Projekt;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy listarezerwacji.xaml
    /// </summary>
    public partial class listarezerwacji : Window
    {
        KompleksBudynkow k1 = KompleksBudynkow.OdczytajXML("sale.xml");
        Rezerwacje rezerw = new Rezerwacje();

        public Rezerwacje Rezerw { get => rezerw; set => rezerw = value; }

        public listarezerwacji(Rezerwacje rezerw1)
        {
            InitializeComponent();

            Rezerw = rezerw1;
            Rezerw.SortujPoDataOd();
            foreach (Sala s in k1.ListaSal)
            {
                CmbSala.Items.Add(s);
                CmbSala_1.Items.Add(s);
            }
       
            LstRezerwacje.ItemsSource = new ObservableCollection<Rezerwacja>(rezerw.ListaRezerwacji);


        }

        private void BtnPokaz_Click(object sender, RoutedEventArgs e)
        {
            if ((Sala)CmbSala_1.SelectedItem != null) {
                LstRezerwacje.ItemsSource = new ObservableCollection<Rezerwacja>(Rezerw.RezDlaSali((Sala)CmbSala_1.SelectedItem));
            }
            else
            {
                MessageBox.Show("Zaznacz salę do pokazania rezerwacji!");
            }
            
        }

        private void BtnWszystkie_Click(object sender, RoutedEventArgs e)
        {
            LstRezerwacje.ItemsSource = new ObservableCollection<Rezerwacja>(Rezerw.ListaRezerwacji);
        }

        private void BtnUsun_Click(object sender, RoutedEventArgs e)
        {
            if ((Rezerwacja)LstRezerwacje.SelectedItem != null) {
                Rezerw.UsunRezerwacje((Rezerwacja)LstRezerwacje.SelectedItem);
                LstRezerwacje.ItemsSource = new ObservableCollection<Rezerwacja>(Rezerw.ListaRezerwacji);
                Rezerw.ZapiszXML("textxml.xml");
                MessageBox.Show("Usunieto wybrana rezerwacje !");
            }
            else
            {
                MessageBox.Show("Zaznacz rezerwację do usunięcia!");
            }
            
        }
        private void BtnDodaj_Click(object sender, RoutedEventArgs e)
        {
            int x = rezerw.ListaRezerwacji.Count();
            if((Sala)CmbSala.SelectedItem != null)
            {
                
                    Rezerwacja r = new Rezerwacja(txtod.Text, txtdo.Text, txtimie.Text, txtnazwisko.Text, (Sala)CmbSala.SelectedItem);
                if (txtimie.Text == "" || txtnazwisko.Text == ""||txtdo.Text==""||txtod.Text==""  )
                {

                    MessageBox.Show("Wszystkie pola muszą być wypełnione !");
                    return;
                }
                if(r.DataOd>r.DataDo)
                {
                    MessageBox.Show("Błędna data");
                    return;
                }
                rezerw.DodajRezerwacje(r);
                rezerw.ZapiszXML("bazarezerwacji.xml");

                LstRezerwacje.ItemsSource = new ObservableCollection<Rezerwacja>(rezerw.ListaRezerwacji);
                int y = rezerw.ListaRezerwacji.Count();
                    if(x==y)
                {
                    MessageBox.Show("Sala jest w tym terminie zarezerwowana. Wybierz inna sale lub inny termin");
                }
                    else
                MessageBox.Show("Dodano rezerwacje !");
                }
                else
                {
                    MessageBox.Show("Dodaj sale");
                }

        }

    }
}
