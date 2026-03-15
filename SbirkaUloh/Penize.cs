using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{// Napište program, který pro zadanou sumu peněz (1–200 Kč) vytiskne výčetku českých
 // kovových platidel potřebných k vyplacení zadané sumy.
   
    internal class Program
    {  
        public static string Vypis(int sum)
        {
            int[] mince = { 50, 20, 10, 5, 2, 1 };
            string result = "";
            foreach (int m in mince)
            {
                int count = sum / m;
                if (count > 0)
                {
                    result += $"{count} x {m} Kč\n";
                    sum -= count * m;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int sum = 0;
            while (sum < 1 || sum > 200)
            {
                Console.Write("Zadejte sumu peněz (1–200 Kč): ");
                sum = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Výčetka:\n" + Vypis(sum));
        }
    }
}
