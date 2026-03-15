using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{// Napište program, který zobrazuje v konzolovém okně vlastních rozměrů na náhodných
 //   místech různě barevné hvězdičky.
    internal class Program
    {  
        public static void Hvezdicky(int sirka, int vyska)
        {
            Random rnd = new Random();
            Console.Clear();
            while (true)
            { 
                int x = rnd.Next(0, sirka);
                int y = rnd.Next(0, vyska);
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16); // Náhodná barva
                Console.Write("*");
            }
        }
        static void Main(string[] args)
        {
            int sirka;
            int vyska;
            Console.WriteLine("Zadejte parametry hvězdiček (šířka, výška)");
            Console.Write("Šířka: ");
            sirka = int.Parse(Console.ReadLine());
            Console.Write("Výška: ");
            vyska = int.Parse(Console.ReadLine());
            Hvezdicky(sirka, vyska);

        }
    }
}
