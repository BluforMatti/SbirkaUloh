using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{/*
  * Napište program, který vytvoří kopii souboru, ve které očísluje jednotlivé řádky.
  */
    internal class Program
    {
        static void Kopiruj(string cestaIn, string cestaOut)
        {
            string input;
            int i = 1;
            using (StreamReader sr = new StreamReader(cestaIn))
            {
                using (StreamWriter wr = new StreamWriter(cestaOut))
                {
                    while ((input = sr.ReadLine()) != null)
                    {
                        wr.WriteLine($"{i++} {input}");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            string vstup = @"C:\Users\xstraka\test.txt";
            string vystup = @"C:\Users\xstraka\testOut.txt";

            Kopiruj(vstup, vystup);
        }
    }
}
