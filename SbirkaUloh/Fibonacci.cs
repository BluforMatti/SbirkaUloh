using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{/*
  * Napište metodu pro rekurzívní a nerekurzívní výpočet n-tého členu Fibonacciho
  * posloupnosti.
  */
    internal class Program
    {
        static int FibonacciRekurze(int x)
        {
            if (x == 0) return 0;
            if (x == 1) return 1;
            return FibonacciRekurze(x - 1) + FibonacciRekurze(x - 2);
        }
       /*
        static int Fibonacci(int x)
        {
         
        }
       */
        static void Main(string[] args)
        {
            Console.WriteLine(FibonacciRekurze(9));
        }
    }
}
