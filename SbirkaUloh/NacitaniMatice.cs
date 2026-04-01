using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte poměr matice (m*n)");
            string[] pomer = Console.ReadLine().Split('*');
            Console.WriteLine("Zadejte matici (po řádcích)");
            Console.WriteLine($"m řádků, n sloupců");
            int[,] matice = new int[int.Parse(pomer[0]),int.Parse(pomer[1])];
            for (int i = 0; i < int.Parse(pomer[0]); i++)
            {
                string[] radek = Console.ReadLine().Split(' ');
                for (int j = 0; j < int.Parse(pomer[1]); j++)
                {
                    matice[i, j] = int.Parse(radek[j]);
                }
            }
            Console.Clear();
            Console.WriteLine("Výsledná matice:");
            for (int i = 0; i < int.Parse(pomer[0]); i++)
            {
                for (int j = 0; j < int.Parse(pomer[1]); j++)
                {
                    Console.Write(matice[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
