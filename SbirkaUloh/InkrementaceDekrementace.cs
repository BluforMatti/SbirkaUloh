using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{ //Jsou-li dány definice: int a = 2, b = 2, c = 1, d = 0, e = 4; napište programy, které vypíší
  //  hodnoty následujících výrazů, a správnost zkontrolujte vlastním výpočtem.
  //  a) a++ / ++c* --e
  //  b) --b* c++ - a
  //  c) -b - --c
  //  d) ++a - --e
  //  e) e / --a* b++ / c++
  //  f) a %= b = d = 1 + e / 2
    internal class Program
    {  
        static void Main(string[] args)
        {
            int a = 2, b = 2, c = 1, d = 0, e = 4;
            Console.WriteLine("a) " + (a++ / ++c * --e)); // 2 / 2 * 3 = 3
            Console.WriteLine("b) " + (--b * c++ - a)); // 1 * 2 - 3 = -1
            Console.WriteLine("c) " + (-b - --c)); // -1 - 1 = -2
            Console.WriteLine("d) " + (++a - --e)); // 4 - 3 = 1
            Console.WriteLine("e) " + (e / --a * b++ / c++)); // 3 / 3 * 2 / 2 = 1
            Console.WriteLine("f) " + (a %= b = d = 1 + e / 2)); // a = a % (b = (d = 1 + 3 / 2)) => a = 4 % 2 => a = 0
        }
    }
}
