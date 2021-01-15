using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt
{
    /// <summary>Klasa sluzaca do obslugi rezerwacji</summary>
    [Serializable]
    public class Rezerwacje : ICloneable, IRezerwacje
    {
        List<Rezerwacja> _listaRezerwacji = new List<Rezerwacja>();

        /// <summary>Lista zawierajaca Rezerwacje</summary>
        /// <value>lista rezerwacji.</value>
        public List<Rezerwacja> ListaRezerwacji { get => _listaRezerwacji; set => _listaRezerwacji = value; }

        /// <summary>Konstruktor, inicjuje nowe wystapienie danych dla klasy <see cref="Rezerwacje" />
        /// lista rezerwacji na podstawie klasy<see cref="Rezerwacja" /></summary>
        public Rezerwacje()
        {
            ListaRezerwacji = new List<Rezerwacja>();
        }

        /// <summary>Funkcja dodajaca rezerwacje do listy, z klasy <seealso cref="Rezerwacja" /></summary>
        /// <param name="rez">rez, jako dodawana rezerwacja</param>
        /// 
        public void DodajRezerwacje(Rezerwacja rez)
        {
            if (rez.DataDo < rez.DataOd)
            {
                Console.WriteLine("Niepoprawna data, poczatek rezerwacji musi byc przed datą końcową");
                return;
            }
            foreach (Rezerwacja r in ListaRezerwacji)
            {


                if (r.Kodzarezerwowanejsali == rez.Kodzarezerwowanejsali)
                {
                    if (!((r.DataOd >= rez.DataDo) || (r.DataDo <= rez.DataOd)) || ((r.DataOd == rez.DataOd) && (r.DataDo == rez.DataDo))) 
                    {
                        return;
                    }
                }
               
            }
            ListaRezerwacji.Add(rez);
        }
        /// <summary>Funkcja usuwajaca rezerwacje z listy</summary>
        /// <param name="s"> s, jako usuwana rezerwacja</param>
        public void UsunRezerwacje(Rezerwacja s)
        {
            ListaRezerwacji = new List<Rezerwacja>(ListaRezerwacji.Where(x => x.NumerRezerwacji != s.NumerRezerwacji));
        }
        /// <summary>konwertuje obiekty na ciag znakow reprezentujacych Liste rezerwacji</summary>
        /// <returns> <see cref="System.String" /> cag znakow reprezentujacy Liste rezerwacji</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Rezerwacja r in ListaRezerwacji)
            {
                sb.AppendLine(r.ToString());
                sb.AppendLine("------------");
            }
            return sb.ToString();
        }
        /// <summary>Zapisuje Rezerwacje do pliku XML</summary>
        /// <param name="plik"></param>
        public void ZapiszXML(string plik)
        {
            using (StreamWriter file2 = new StreamWriter(plik))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Rezerwacje));
                xml.Serialize(file2, this);
            }
        }
        /// <summary>Odczytuje dane z pliku XML</summary>
        /// <param name="plik">plik.</param>
        public static Rezerwacje OdczytajXML(string plik)
        {
            if (!File.Exists(plik)) { return null; }
            using (StreamReader file2 = new StreamReader(plik))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Rezerwacje));
                return (Rezerwacje)xml.Deserialize(file2);
            }
        }
        /// <summary>sprawdza czy sala nie jest zarezerwowana, dopisuje do listy</summary>
        /// <param name="s"> sala</param>

        public List<Rezerwacja> RezDlaSali(Sala s)
        {
            List<Rezerwacja> wyjscie = new List<Rezerwacja>();
            foreach (Rezerwacja r in ListaRezerwacji)
            {
                if (r.Kodzarezerwowanejsali.Equals(s.KodSali))
                    wyjscie.Add(r);

            }
            return wyjscie;
        }
        /// <summary>Tworzy nowe obiekty rezerwacji, dodaje do listy z poprzednimi rezerwacjami</summary>
        /// <returns>liste z nowymi rezerwacjami </returns>
        public object Clone()
        {
            Rezerwacje noweRezerwacje = new Rezerwacje();
            ListaRezerwacji.ForEach(r => noweRezerwacje.ListaRezerwacji.Add((Rezerwacja)r.Clone()));
            return noweRezerwacje; 
        }

        /// <summary>sortuje liste rezerwacji</summary>
        public void Sortuj()
        {
            ListaRezerwacji.Sort();
        }

        /// <summary>Sortuje liste rezerwacji po dacie rozpoczecia</summary>
        public void SortujPoDataOd()
        {
            ListaRezerwacji.Sort(new DataOdComaparator());
        }
        /// <summary>sortuj liste rezerwacji po dacie zakonczenia</summary>
        public void SortujPoDataDo()
        {
            ListaRezerwacji.Sort(new DataDoComparator() );
        }

    }
}
