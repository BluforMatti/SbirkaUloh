using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{// Napište program, který přečte řetězec a vytiskne na samostatné řádky:
 // znak a jeho hodnotu v desítkové a šestnáctkové soustavě.
    internal class Program
    {  
        public static void PrintCharInfo(char c)
        {
            Console.WriteLine($"   {c}       {(int)c}         {(int)c:X}");
        }
        static void Main(string[] args)
        {
            Console.Write("Zadejte řetězec: ");
            string input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(" Znak | Desítkově | Šestnáctkově");
            foreach (char c in input)
            {
                PrintCharInfo(c);
            }
        }
    }
}
