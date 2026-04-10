using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{/*
  * Sestavte algoritmus a napište program pro výpočet NSD(a,b) Euklidovým algoritmem pomocí
  * rekurze.
  */
    internal class Program
    {  
        static int NSD (int x, int y)
        {
            int temp;
            while (y != 0)
            {
                temp = x % y;
                x = y;
                y = temp;
            }
            return x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(NSD(1256,728));
        }
    }
}
