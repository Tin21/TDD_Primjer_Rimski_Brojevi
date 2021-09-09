using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimjerTDD_a_RimskiBrojevi
{
    public class Konverter
    {
        List<RimskiBrojevi> PopuniListu()
        {
            List<RimskiBrojevi> listaBrojeva = new List<RimskiBrojevi>();
            listaBrojeva.Add(new RimskiBrojevi(5, "V"));
            listaBrojeva.Add(new RimskiBrojevi(4, "IV"));
            listaBrojeva.Add(new RimskiBrojevi(1, "I"));

            return listaBrojeva;
        }
        public string Pretvori(int broj)
        {
            List<RimskiBrojevi> listaBrojeva = PopuniListu();
            string rezultat = string.Empty;

            foreach (var item in listaBrojeva)
            {
                for (int i = broj; i >= item.ArapskiBroj; i -= item.ArapskiBroj)
                {
                    rezultat += item.RimskiBroj;
                    if (rezultat != "") 
                        broj -= item.ArapskiBroj;
                }
            }
            return rezultat;
        }
    }
}
