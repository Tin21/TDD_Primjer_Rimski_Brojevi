using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimjerTDD_a_RimskiBrojevi
{
    public class RimskiBrojevi
    {
        public int ArapskiBroj { get; set; }
        public string RimskiBroj { get; set; }

        public RimskiBrojevi(int arapski, string rimski)
        {
            ArapskiBroj = arapski;
            RimskiBroj = rimski;
        }
    }
}
