using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{
    internal class Program
    {// Napište metodu, která zjišťuje, zda je dané přirozené číslo prvočíslo.
     // S pomocí této funkce napište program, který
     //• čte na vstupu číslo a tiskne, zda je nebo není prvočíslo
     //• čte ze souboru posloupnost přirozených čísel a vypisuje prvočísla.
     public static bool JePrvocislo(int cislo)
        {
            if (cislo < 2) return false;
            for (int i = 2; i <= Math.Sqrt(cislo); i++)
            {
                if (cislo % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("======PRVOČÍSLA======");
            Console.WriteLine("Zadejte číslo:");
            x = int.Parse(Console.ReadLine());
            if (JePrvocislo(x))
            {
                Console.WriteLine("Číslo " + x + " je prvočíslo.");
            }
            else
            {
                Console.WriteLine("Číslo " + x + " není prvočíslo.");
            }
        }
    }
}
