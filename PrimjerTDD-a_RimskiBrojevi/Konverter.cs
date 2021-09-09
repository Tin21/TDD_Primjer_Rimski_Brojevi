using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimjerTDD_a_RimskiBrojevi
{
    public class Konverter
    {
        public string Pretvori(int broj)
        {
            string rezultat = String.Empty;
            for (int i = broj; i > 0; i--)
            {
                rezultat += "I";
            }
            return rezultat;
        }
    }
}
