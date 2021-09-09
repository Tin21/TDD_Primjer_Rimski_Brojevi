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
            listaBrojeva.Add(new RimskiBrojevi(4, "IV"));
            listaBrojeva.Add(new RimskiBrojevi(3, "III"));
            listaBrojeva.Add(new RimskiBrojevi(2, "II"));
            listaBrojeva.Add(new RimskiBrojevi(1, "I"));

            return listaBrojeva;
        }
        public string Pretvori(int broj)
        {
            List<RimskiBrojevi> listaBrojeva = PopuniListu();

            foreach (var item in listaBrojeva)
            {
                if (item.ArapskiBroj == broj)
                    return item.RimskiBroj;
            }
            return String.Empty; ;
        }
    }
}
