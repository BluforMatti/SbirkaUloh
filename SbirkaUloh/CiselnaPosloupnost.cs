using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{
    internal class Program
    {// Na vstupu je dána posloupnost celých čísel zakončená číslem nula. Vytiskněte největší číslo a
     // kolikrát se v posloupnosti vyskytuje.

        static void Main(string[] args)
        {
            int max = int.MinValue;
            int cetnost = 0;
            Console.WriteLine("Zadej číselnou posloupnost (čísla odděl mezerou):");
            string[] arr = Console.ReadLine().Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "0")
                {
                    break;
                }
                else if (int.Parse(arr[i]) > max)
                {
                    max = int.Parse(arr[i]);
                    cetnost = 1;
                }
                else if (int.Parse(arr[i]) == max)
                {
                    cetnost++;
                }
                    
            }
            Console.WriteLine($"Největší číslo je {max} a v textu se vyskytuje {cetnost}x");
        }
    }
}
