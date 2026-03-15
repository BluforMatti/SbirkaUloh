using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{// Napište program, který načítá na vstupu velká písmena a tiskne malá písmena, dokud
 // nebude stisknuto malé nebo velké q.
    internal class Program
    {  
        public static char ToLower(char c)
        {
            if (c >= 'A' && c <= 'Z')
            {
                return (char)(c + ('a' - 'A'));
            }
            return c;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                if (input == 'q' || input == 'Q')
                {
                    break;
                }
                
                Console.Write(ToLower(input));
            }
        }
    }
}
