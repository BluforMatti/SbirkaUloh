using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{/*
  * Sestavte algoritmus a napište program pro výpočet faktoriálu pomocí rekurze.
  */
    internal class Program
    {  
        static int Faktorial (int x)
        {
            if (x == 0) return 1;
            return x * Faktorial(x - 1);
        }
        static void Main(string[] args)
        {
           Console.WriteLine(Faktorial(16));
        }
    }
}
