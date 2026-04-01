using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{ //Naprogramujte automat pro vydávání lístků na vlak, který určuje cenu podle následující
  //  tabulky
  //  vzdálenost v km cena za km
  //  1-3 15 Kč
  //  4-5 13 Kč
  //  6-7 11 Kč
  //  >8 10 Kč
  //  Pro zadanou vzdálenost vytiskne odpovídající cenu jízdenky.
    internal class Program
    {  
        public static double cena (double vzdalenost)
        {
            if (vzdalenost >= 1 && vzdalenost <= 3)
            {
                return vzdalenost * 15;
            }
            else if (vzdalenost >= 4 && vzdalenost <= 5)
            {
                return vzdalenost * 13;
            }
            else if (vzdalenost >= 6 && vzdalenost <= 7)
            {
                return vzdalenost * 11;
            }
            else if (vzdalenost > 8)
            {
                return vzdalenost * 10;
            }
            else
            {
                throw new ArgumentException("Neplatná vzdálenost");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Zadejte vzdálenost v km: ");
            try
            {
                double vzdalenost = double.Parse(Console.ReadLine());
                Console.WriteLine($"cena je {cena(vzdalenost)}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
