using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt
{

    /// <summary>Typ wyliczeniowy, elementy informuja "tak" lub "nie" czy dany sprzet znajduje sie w sali</summary>
    /// <seealso cref="tak">jesli urzadzenie znajduje sie w sali</seealso>
    /// <seealso cref="nie">jesli sala nie jest wyposazona w urzadzenie</seealso>
    public enum Taknie { tak,nie }
}

namespace Projekt
{
    /// <summary>
    /// klasa opisujaca sale premium, dziedziczy po klasie Sala
    /// </summary>
    [Serializable]



    public class SalaPremium : Sala
    {
        Taknie _projektor;
        Taknie _glosniki;
        Taknie _mikrofon;
        Taknie _klimatyzacja;
        Taknie _wifi;


        /// <summary>Zawiera dane o projektorze</summary>
        /// <value> projektor.</value>
        public Taknie Projektor { get => _projektor; set => _projektor = value; }
        /// <summary>Zawiera dane o glosnikach</summary>
        /// <value> glosniki.</value>
        public Taknie Glosniki { get => _glosniki; set => _glosniki = value; }
        /// <summary>zawiera dane o mikrofonie</summary>
        /// <value>mikrofon</value>
        public Taknie Mikrofon { get => _mikrofon; set => _mikrofon = value; }
        /// <summary>zawiera dane o klimatyzacji</summary>
        /// <value> klimatyzacja.</value>
        public Taknie Klimatyzacja { get => _klimatyzacja; set => _klimatyzacja = value; }
        /// <summary>zawiera dane o wifi</summary>
        /// <value>wifi.</value>
        public Taknie Wifi { get => _wifi; set => _wifi = value; }

        public SalaPremium()
        {
           
        }
        /// <summary>konstruktor danych klasy SalaPremium</summary>
        /// <param name="numersali"> numersali.</param>
        /// <param name="pietro"> pietro.</param>
        /// <param name="budynek"> budynek.</param>
        /// <param name="wyposazenie"> wyposazenie.</param>
        /// <param name="metraz"> metraz.</param>
        /// <param name="pojemnosc"> pojemnosc.</param>
        /// <param name="cena"> cena.</param>
        /// <param name="projektor"> projektor.</param>
        /// <param name="glosniki"> glosniki.</param>
        /// <param name="mikrofon"> mikrofon.</param>
        /// <param name="klimatyzacja"> klimatyzacja.</param>
        /// <param name="wifi"> wifi.</param>
        public SalaPremium(int numersali, int pietro,Budynki budynek, Wyposazenia wyposazenie, double metraz, int pojemnosc, double cena,Taknie projektor, Taknie glosniki, Taknie mikrofon, Taknie klimatyzacja, Taknie wifi):base(numersali,pietro,budynek,wyposazenie,metraz,pojemnosc,cena)
        {
            Projektor = projektor;
            Glosniki = glosniki;
            Mikrofon = mikrofon;
            Klimatyzacja = klimatyzacja;
            Wifi = wifi;
            KodSali = $"PREMIUM/{Kodpomieszczenia}/{numersali}";
        }
        /// <summary>atrybuty sali premikum</summary>
        /// <returns>zwraca nazwe urzadzenia, jesli znajduje sie w sali  premium</returns>
        public string atrybuty()
        {
            StringBuilder str = new StringBuilder();
            if (Projektor == Taknie.tak) str.Append("Projektor ");
            if (Glosniki == Taknie.tak) str.Append(", Glosniki ");
            if (Mikrofon == Taknie.tak) str.Append(", Mikrofon ");
            if (Klimatyzacja == Taknie.tak) str.Append(", Klimatyzacja ");
            if (Wifi == Taknie.tak) str.Append(", Bezpłatne Wifi ");
            return str.ToString();
        }
        /// <summary>konwertuje obiekty na ciag znakow reprezentujacych sale premium</summary>
        /// <returns>A <see cref="System.String" /> ciag znakow reprezentujacych sale premium.</returns>
        public override string ToString()
        {
            return (base.ToString() + atrybuty());
        }


    }
}