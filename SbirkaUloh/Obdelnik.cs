using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{/*
    Na vstupu je posloupnost dvojic hodnot, které udávají délku a šířku obdélníka.Dvojice
    hodnot 0 0 označuje konec vstupních údajů.Sestavte algoritmus a napište program, který
    vytiskne tabulku s postupně očíslovanými řádky, které budou obsahovat délku, šířku a obsah
    obdélníka. Do tabulky nechť se zobrazí pouze obdélníky s obvodem větším než 12.
 */
    internal class Program
    {
        static void Metoda(List<int> dvojice)
        {
            Console.WriteLine("Č. | Šířka | Výška | Obsah");

            int radek = 1;

            for (int i = 0; i < dvojice.Count; i += 2)
            {
                int sirka = dvojice[i];
                int vyska = dvojice[i + 1];

                int obvod = 2 * (sirka + vyska);
                int obsah = sirka * vyska;

                if (obvod > 12)
                {
                    Console.WriteLine($"{radek}  |   {sirka}   |   {vyska}   |   {obsah}");
                    radek++;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> dvojice = new List<int>();
            Console.WriteLine("Zadej dvojice čísel (0 0 pro konec):");

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
            Metoda(dvojice);
        }
    }
}
