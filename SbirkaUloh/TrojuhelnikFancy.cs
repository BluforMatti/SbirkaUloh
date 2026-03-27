using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{/*
    Naprogramujte metodu, která na základě kartézských souřadnic dvou bodů v rovině spočítá
    jejich vzdálenost. S pomocí této funkce vytvořte program, který ze vstupu přečte souřadnice
    vrcholů trojúhelníka v rovině a spočítá velikosti všech tří jeho stran.
  */
    internal class Program
    {  
        public static double Vzdalenost (double x1, double x2, double y1, double y2)
        {
            double a = x2 - x1;
            double b = y2 - y1;
            double vzdalenost = Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2)); //vzdálenost dvou bodů odpovídá velikosti jejich vektoru
            return vzdalenost;
        }
        static void Main(string[] args)
        {
            double a, b, c, d, e, f;
            
        }
    }
}
