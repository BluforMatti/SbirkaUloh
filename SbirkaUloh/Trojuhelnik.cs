using System;
using System.Runtime.InteropServices;

namespace SbirkaUloh
{
    // Sestavte algoritmus, kterým po zadání tří hodnot a, b, c zjistíte, zda existuje trojúhelník
    // s délkami stran a, b, c a pokud existuje, je-li pravoúhlý.
    internal class Program
    {
        public static bool JeTrojuhelnik(int a, int b, int c, out string d)
        {
            d = string.Empty;

            // Kontrola kladnosti stran
            if (a <= 0 || b <= 0 || c <= 0)
            {
                d = "Délky stran musí být kladná čísla.";
                return false;
            }

            // Kontrola trojúhelníkové nerovnosti
            if (a + b > c && a + c > b && b + c > a)
            {
                // Pro kontrolu pravoúhlosti (pythagorovka)
                int[] s = new[] { a, b, c };
                Array.Sort(s);
                long x = s[0], y = s[1], z = s[2];

                if (x * x + y * y == z * z)
                    d = "Trojúhelník je pravoúhlý.";
                else
                    d = "Trojúhelník není pravoúhlý.";

                return true;
            }
            else
            {
                d = "Zadané délky netvoří trojúhelník.";
                return false;
            }
        }

        static void Main(string[] args)
        {
            int a, b, c;
            try
            {
                Console.Write("Zadejte délku strany a: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Zadejte délku strany b: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Zadejte délku strany c: ");
                c = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Neplatný vstup. Zadejte celé číslo.");
                return;
            }
            string d;
            if (JeTrojuhelnik(a, b, c, out d))
            {
                Console.WriteLine("Trojúhelník existuje.");
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine("Trojúhelník neexistuje.");
                Console.WriteLine(d);
            }
        }
    }
}
