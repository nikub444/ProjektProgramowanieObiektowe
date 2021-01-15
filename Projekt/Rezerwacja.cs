using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt

{
    /// <summary>Klasa opisujaca rezerwacje, 
    /// obsluguje interfejs ICloneable, co pozwala tworzyc nowe rezerwacje o takiej samej wartosci(skopiowane), 
    /// obsluguje interfejs IComparable, co pozwala na porownanie wartosci rezerwacji
    /// </summary>
    [Serializable]
    public class Rezerwacja : ICloneable, IComparable<Rezerwacja>
    {
        DateTime _dataOd;
        DateTime _dataDo;
        string _imie;
        string _nazwisko;
        string _kodzarezerwowanejsali;
        static int _biezacyNumer = 0;
        int _numerRezerwacji;

        /// <summary>zawiera wlasciwosci daty rozpoczecia rezerwacji</summary>
        /// <value>data od.</value>
        public DateTime DataOd { get => _dataOd; set => _dataOd = value; }
        /// <summary>zawiera wlasciwosci daty zakonczenia rezerwacji</summary>
        /// <value>data do</value>
        public DateTime DataDo { get => _dataDo; set => _dataDo = value; }
        /// <summary>zawiera wlasciwosci imienia rezerwujacego</summary>
        /// <value>imie.</value>
        public string Imie { get => _imie; set => _imie = value; }
        /// <summary>zawiera wlasciwosci nazwiska rezerwujacego</summary>
        /// <value>nazwisko</value>
        public string Nazwisko { get => _nazwisko; set => _nazwisko = value; }
        /// <summary>zawiera wlasciwosci o kodzie zarezerwowanej sali</summary>
        /// <value>kodzarezerwowanejsali.</value>
        public string Kodzarezerwowanejsali { get => _kodzarezerwowanejsali; set => _kodzarezerwowanejsali = value; }
        /// <summary> statyczna zmienna potrzebna do informacji na temat numeru rezerwacji </summary>
        /// <value>biezacy numer.</value>
        public static int BiezacyNumer { get => _biezacyNumer; set => _biezacyNumer = value; }
        /// <summary>zawiera wlasciwosci numeru rezerwacji</summary>
        /// <value>numer rezerwacji.</value>
        public int NumerRezerwacji { get => _numerRezerwacji; set => _numerRezerwacji = value; }

        /// <summary>konstruktor  danych klasy <see cref="Rezerwacja" />,</summary>
        public Rezerwacja()
        {
            DataDo = DateTime.Now;
            DataOd = DateTime.Now;
            Imie = string.Empty;
            Nazwisko = string.Empty;
            Kodzarezerwowanejsali = string.Empty;
            NumerRezerwacji = BiezacyNumer++;

        }
        /// <summary>konstruktor danych klasy <see cref="Rezerwacja" />,</summary>
        /// <param name="dataod">dataod.</param>
        /// <param name="datado">datado.</param>
        /// <param name="imie">imie.</param>
        /// <param name="nazwisko">nazwisko.</param>
        /// <param name="sala">sala.</param>
        public Rezerwacja(string dataod, string datado, string imie, string nazwisko, Sala sala)
        {
            DateTime.TryParseExact(dataod, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MM-yy" }, null, System.Globalization.DateTimeStyles.None, out DateTime od);
            DataOd = od;
            DateTime.TryParseExact(datado, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MM-yy" }, null, System.Globalization.DateTimeStyles.None, out DateTime dod);
            DataDo=dod;
            Imie = imie;
            Nazwisko = nazwisko;
            Kodzarezerwowanejsali = sala.KodSali;
            NumerRezerwacji = BiezacyNumer++;
        }

        /// <summary>Tworzy kopie klasy Rezerwacja</summary>
        /// <returns>Nowy  niezalezny obiekt, powstaly przez sklonowaie (skopiowanie)  klasy Rezerwacja </returns>
        public object Clone() 
        {
            return MemberwiseClone(); // robi kopie wszystkiego co jest w klasie
        }

        /// <summary>
        /// Porównuje  Nazwisko rezerwujacego z zmienna Nazwisko innego rezerwujaceo 
        /// </summary>
        /// <param name="other">Za porownanie odpowiedzialna jest klasa Rezerwacja </param>
        /// <returns>
        /// Wartość wskazująca  kolejność porównywanych rezerwujacych. 
        /// Znaczenie: Wartosc ujemna -  To wystąpienie poprzedza inne w kolejności sortowania. 
        /// Wartosc =0 występuje w tej samej pozycji .
        /// Wartosc dodatnia - To wystąpienie następuje po innych w kolejności sortowania.
        /// </returns>
        public int CompareTo(Rezerwacja other)
        {
            int wynik = Nazwisko.CompareTo(other.Nazwisko);
            if (wynik != 0)
            {
                return wynik;
            }
            return Imie.CompareTo(other.Imie); //-1 - a<b, a=b - 0, a>b: 1
        }

        /// <summary>Porownuje daty rozpoczecia rezerwacji</summary>
        /// <param name="other">Za porownanie odpowiedzialna jest klasa Rezerwacja.</param>
        public int CompareToDataOd(Rezerwacja other)
        {
            return DataOd.CompareTo(other.DataOd); //-1 - a<b, a=b - 0, a>b: 1
        }
        /// <summary>Porownuje daty zakonczenia rezerwacji</summary>
        /// <param name="other">Za porownanie odpowiedzialna jest klasa Rezerwacja.</param>
        public int CompareToDataDo(Rezerwacja other)
        {
            return DataDo.CompareTo(other.DataDo); //-1 - a<b, a=b - 0, a>b: 1
        }

        /// <summary>Okresla czy obiekty- informacje na temat rezerwacji- maja rowne wartosci</summary>
        /// <param name="other">za  okreslenie obiektow odpowiedzialna jest klasa Rezerwacja</param>
        /// <returns>
        ///   zwraca prawde lub falsz 
        /// </returns>
        public bool Equals(Rezerwacja other)
        {
            return DataOd.Equals(other.DataOd) && DataDo.Equals(other.DataDo) && Imie.Equals(other.Imie) && Nazwisko.Equals(other.Nazwisko) && Kodzarezerwowanejsali.Equals(other.Kodzarezerwowanejsali) && NumerRezerwacji.Equals(other.NumerRezerwacji);
        }

        /// <summary>konwertuje obiekty na ciag znakow reprezentujacych rezerwacje</summary>
        /// <returns>
        ///   <see cref="System.String" /> -ciag znakow reprezentujacych rezerwacje</returns>
        public override string ToString()
        {
            return $"Rezerwacja numer {NumerRezerwacji}:\n Klient {Imie} {Nazwisko}\n Sala: {Kodzarezerwowanejsali}\n w terminie : {DataOd.ToShortDateString()} do {DataDo.ToShortDateString()}";
        }
    }
}
