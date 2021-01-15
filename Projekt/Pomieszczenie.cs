using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt

{
    /// <summary>klasa abstrakcyjna opisujaca pomieszczenia</summary>
    [Serializable]
    public abstract class Pomieszczenie
    {
        double _metraz;
        int _pietro;
        string _kodpomieszczenia;
        static int _biezacynumer = 0;

        /// <summary>zawiera wlasciwosci metrazu pomieszczenia.</summary>
        /// <value>metraz.</value>
        public double Metraz { get => _metraz; set => _metraz = value; }
        /// <summary>zawiera wlasciwosci pietra na ktorym znajduje sie pomieszczenie</summary>
        /// <value>pietro.</value>
        public int Pietro { get => _pietro; set => _pietro = value; }
        /// <summary>zawiera wlasciwosci kodu pomieszczenia</summary>
        /// <value>kod pomiesczenia.</value>
        public string Kodpomieszczenia { get => _kodpomieszczenia; set => _kodpomieszczenia = value; }
        /// <summary>watrosc statyczna potrzebna do utworzzenia kodu pomieszczenia</summary>
        public static int Biezacynumer { get => _biezacynumer; set => _biezacynumer = value; }
        public Pomieszczenie()
        {

        }
        /// <summary>konstruktor, inicjuje dane dla klasy <see cref="Pomieszczenie" /></summary>
        /// <param name="metraz">metraz.</param>
        /// <param name="pietro">pietro.</param>
        public Pomieszczenie(double metraz, int pietro)
        {
            Metraz = metraz;
            Pietro = pietro;
            Kodpomieszczenia = $"{++Biezacynumer}/{Pietro}";
        }

    }
}
