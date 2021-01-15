using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class DataDoComparator : IComparer<Rezerwacja>
    {
        public int Compare(Rezerwacja x, Rezerwacja y)
        {
            if (x.DataDo == null)
            {
                return 1;
            }
            if (y.DataDo == null)
            {
                return 1;
            }
            return x.DataDo.CompareTo(y.DataDo);
        }
    }
}
