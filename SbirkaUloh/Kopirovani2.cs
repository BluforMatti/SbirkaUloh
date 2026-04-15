using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SbirkaUloh
{/*
  * Napište program, který zkopíruje obsah souboru stary.txt do souboru novy.txt. Navíc
  * převede velká písmena na malá, vypustí číslice a místo mezer přejde vždy na nový řádek
  */
    internal class Program
    {  
        static void Metoda (string Vstup, string Vystup)
        {
           
            using (StreamReader sr = new StreamReader(Vstup))
            {
                using (StreamWriter wr = new StreamWriter(Vystup))
                {
                    string input;
                    object result;
                    while ((input = sr.ReadLine())!= null)
                    {
                        result = Regex.Replace(input.ToLower().Replace(' ', '\n'), @"\d", "");
                        wr.WriteLine(result);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            string vstup = @"C:\Users\xstraka\test.txt";
            string vystup = @"C:\Users\xstraka\testOut.txt";

            Metoda(vstup, vystup);
        }
    }
}
