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
        static void Metoda (int[] dvojice)
        {
            Console.WriteLine("Šířka  |   Výška   |    Obsah");
            for (int i = 0; i < dvojice.Length; i+=2)
            {
                if (dvojice[i] * dvojice[i + 1] > 12)
                {
                    Console.WriteLine($"  {dvojice[i]}          {dvojice[i+1]}            {dvojice[i] * dvojice[i + 1]}");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Zadej dvojici čísel oddělenou mezerníkem");
            string input;
            string[] temp;
            while ((input = Console.ReadLine()) != "0 0")
            {
                temp = input.Split(' ');
            }
            foreach (string s in temp)
            {
                Console.WriteLine(s);
            }
        }
    }
}
