using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimjerTDD_a_RimskiBrojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj koji želite pretvoriti u rimski: ");
            int arapskiBroj = int.Parse(Console.ReadLine());
            Konverter konverter = new Konverter();
            string rimskiBroj = konverter.Pretvori(arapskiBroj);
            Console.WriteLine(rimskiBroj);
            Console.Read();
        }
    }
}
