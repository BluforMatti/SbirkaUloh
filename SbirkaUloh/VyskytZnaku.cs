using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{/*
  * Spočítejte výskyt zadaného znaku ve vstupním souboru dopis.txt. Výskyt vyjádřete
    absolutním číslem i v procentech.
  */
    internal class Program
    {  
        static void Vyskyt(string Cesta, int znak)
        {
            int pocitadlo = 0;
            int pocidadilko = 0;
            using (StreamReader sr = new StreamReader(Cesta))
            {
                int input;
                while ((input = sr.Read()) != -1)
                {
                    if (input == znak)
                    {
                        pocidadilko++;
                    }
                    pocitadlo++;
                }
            }
            Console.Clear();
            Console.WriteLine($"\nV textu se znak {(char)znak} objevuje {pocidadilko}x, to je {(((double)pocidadilko/(double)pocitadlo)*100):F2}% z celku ({pocitadlo} znaků)");
        }
        static void Main(string[] args)
        {
            string cesta = @"C:\Users\xstraka\test.txt";
            Console.WriteLine("Zadej hledaný znak:");
            int znak = Console.Read();
            Vyskyt(cesta, znak);
        }
    }
}
