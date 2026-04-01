using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{/*
    Naprogramujte metodu, která na základě kartézských souřadnic dvou bodů v rovině spočítá
    jejich vzdálenost. S pomocí této funkce vytvořte program, který ze vstupu přečte souřadnice
    vrcholů trojúhelníka v rovině a spočítá velikosti všech tří jeho stran.
  */
    internal class Program
    {
        public static double Vzdalenost(double dvojice)
        {

        }
        static void Main(string[] args)
        {
            List<int> dvojice = new List<int>();
            Console.WriteLine("Zadej souřadnice bodu:");
            while (true)
            {
                string input = Console.ReadLine();
                string[] temp = input.Split(' ');

                int a = int.Parse(temp[0]);
                int b = int.Parse(temp[1]);

                if (a == 0 && b == 0)
                    break;

                dvojice.Add(a);
                dvojice.Add(b);
            }
        }
    }
}
