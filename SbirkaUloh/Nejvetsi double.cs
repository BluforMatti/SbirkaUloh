using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{/*
  * Naprogramujte metodu se čtyřmi double parametry, která vrací největší z nich.
  */
    internal class Program
    {
        public static double Nejvetsi(double a, double b, double c, double d)
        {
            double max = double.MinValue;
            if (max < a) { max = a; }
            if (max < b) { max = b; }
            if (max < c) { max = c; }
            if (max < d) { max = d; }
            return max;
        }
        static void Main(string[] args)
        {

        }
    }
}
