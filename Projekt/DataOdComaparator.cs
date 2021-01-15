using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class DataOdComaparator :IComparer<Rezerwacja>
    {
        public int Compare(Rezerwacja x, Rezerwacja y)
        {
            if (x.DataOd == null)
            {
                return 1;
            }
            if (y.DataOd == null)
            {
                return 1;
            }
            return x.DataOd.CompareTo(y.DataOd);
        }
    }
}
