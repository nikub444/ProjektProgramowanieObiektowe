using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    interface IKompleksBudynkow
    {
        void DodajSale(Sala s);
        void UsunSale(Sala s);
        List<Sala> FiltrujPojemnosc(int x, List<Sala> wejscie);
        List<Sala> FiltrujPremium(int x);
    }
}
