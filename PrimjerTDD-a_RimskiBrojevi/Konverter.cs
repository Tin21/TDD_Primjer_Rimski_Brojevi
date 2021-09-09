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
            listaBrojeva.Add(new RimskiBrojevi(1000, "M"));
            listaBrojeva.Add(new RimskiBrojevi(900, "CM"));
            listaBrojeva.Add(new RimskiBrojevi(500, "D"));
            listaBrojeva.Add(new RimskiBrojevi(400, "CD"));
            listaBrojeva.Add(new RimskiBrojevi(100, "C"));
            listaBrojeva.Add(new RimskiBrojevi(90, "XC"));
            listaBrojeva.Add(new RimskiBrojevi(50, "L"));
            listaBrojeva.Add(new RimskiBrojevi(40, "XL"));
            listaBrojeva.Add(new RimskiBrojevi(10, "X"));
            listaBrojeva.Add(new RimskiBrojevi(9, "IX"));
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
