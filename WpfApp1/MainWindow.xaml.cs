using Projekt;
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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
  
    public partial class MainWindow : Window
    {
        Rezerwacje lol = Rezerwacje.OdczytajXML("bazarezerwacji.xml");

        public Rezerwacje Lol { get => lol; set => lol = value; }
       
        public MainWindow()
        {
            InitializeComponent();

            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                this.dateText.Text =$"Witaj w systemie rezerwacji sal :            {DateTime.Now.ToString()}";
            }, this.Dispatcher);
        }





   

        private void Buttonlistarezerwacji_Click(object sender, RoutedEventArgs e)
        {
            listarezerwacji open = new listarezerwacji(Lol);
            open.ShowDialog();
        }

        private void ButtonSale_Click(object sender, RoutedEventArgs e)
        {
            Sale open = new Sale();
            open.ShowDialog();
            
        }

       
    }
}
