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
            if (broj == 1)
                return "I";
            if (broj == 2)
                return "II";
            return String.Empty;
        }
    }
}
