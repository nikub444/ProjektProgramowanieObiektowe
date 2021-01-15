using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt


{
/// <summary>
/// typ wyliczeniowy elementy informuja jakie wypsżenie znajduje sie w sali
/// </summary>
    public enum Wyposazenia {
        /// <summary>brak wyposazenia w sali</summary>
        brak,
        /// <summary>krzesla jako wyposazenie sali</summary>
        krzesla,
        /// <summary>pelne wyposazenie sali</summary>
        pelne
    }
    /// <summary>typ wyliczeniowy,  elementy opisuja nazwe budynkow w ktorych znajduje sie sala</summary>
    public enum Budynki { A,B,C}

    /// <summary>klasa opisujaca sale, dziedziczy po klasie pomieszczenia</summary>
    
    [Serializable]
    [XmlInclude(typeof(SalaPremium))]
    public class Sala:Pomieszczenie
    {
        int _pojemnosc;
        Budynki _budynek;
        int _numerSali;
        double _cena;
      
        Wyposazenia _wyposazenie;
        string _kodSali;

        /// <summary>zawiera wlasciwosci o  sali</summary>
        /// <value>pojemnosc.</value>
        public int Pojemnosc { get => _pojemnosc; set => _pojemnosc = value; }

        /// <summary>zawiera wlasciwosci numeru sali</summary>
        /// <value> numer sali.</value>
        public int NumerSali { get => _numerSali; set => _numerSali = value; }
        /// <summary>zawiera wlasciwosci ceny sali</summary>
        /// <value> cena.</value>
        public double Cena { get => _cena; set => _cena = value; }
        /// <summary>zawiera wlasciwosci wyposazenia sali</summary>
        /// <value>wyposazenie.</value>
        public Wyposazenia Wyposazenie { get => _wyposazenie; set => _wyposazenie = value; }
        /// <summary>zawiera wlasciwosci kodu sali</summary>
        /// <value>kod sali.</value>
        public string KodSali { get => _kodSali; set => _kodSali = value; }
        /// <summary>zawiera wlasciwosci budynku w ktorym znajduje sie sala</summary>
        /// <value>The budynek.</value>
        public Budynki Budynek { get => _budynek; set => _budynek = value; }
        public Sala()
        {
           
        }
        /// <summary>  inicjuje nowe zmienne opisujace sale, konstruktor klasy <see cref="Sala" /> </summary>
        /// <param name="metraz">metraz.</param>
        /// <param name="pietro">pietro.</param>
        public Sala(double metraz,int pietro):base(metraz,pietro)
        {
            NumerSali = 0;
            
            Wyposazenie = Wyposazenia.brak;
            Pojemnosc = 0;
            Cena = 0;
            KodSali = $"NORMAL";
            Budynek = Budynki.A;
        }
        /// <summary>Konstruktor danych klasy  <see cref="Sala" /></summary>
        /// <param name="numersali">numersali.</param>
        /// <param name="pietro">pietro.</param>
        /// <param name="budynek">budynek.</param>
        /// <param name="wyposazenie">wyposazenie.</param>
        /// <param name="metraz">metraz.</param>
        /// <param name="pojemnosc">pojemnosc.</param>
        /// <param name="cena">cena.</param>
        public Sala(int numersali, int pietro,Budynki budynek, Wyposazenia wyposazenie, double metraz, int pojemnosc, double cena):base(metraz,pietro)
        {
            NumerSali = numersali;
            Wyposazenie = wyposazenie;
            Pojemnosc = pojemnosc;
            Cena = cena;
            KodSali = $"NORMAL/{Kodpomieszczenia}/{numersali}";
            Budynek = budynek;



        }
        /// <summary>konwertuje obiekty na ciag znakow reprezentujacych sale</summary>
        /// <returns>A <see cref="System.String" /> ciag znakow reprezentjacych sale</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Kod Sali: {KodSali} ");
            stringBuilder.AppendLine($"Numer sali: {NumerSali} Piętro: {Pietro}");
            stringBuilder.AppendLine($"Metraż: {Metraz} m2, Maksymalnie {Pojemnosc} osób , Wyposażenie-{Wyposazenie}");
            return stringBuilder.ToString();
        }

    
    }
}
