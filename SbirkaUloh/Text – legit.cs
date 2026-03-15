using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbirkaUloh
{// Napište program, který zkopíruje obsah souboru stary.txt do souboru novy.txt. Navíc
 // převede velká písmena na malá, vypustí číslice a místo mezer přejde vždy na nový řádek
    internal class Program
    {  
        public static void CopyFile(string sourceFile, string destinationFile)
        {
            try
            {
                // Otevření zdrojového souboru pro čtení
                using (StreamReader reader = new StreamReader(sourceFile))
                {
                    // Otevření cílového souboru pro zápis
                    using (StreamWriter writer = new StreamWriter(destinationFile))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        // DODELAT
                    }
                }
                Console.WriteLine("Soubor byl úspěšně zkopírován a zpracován.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Došlo k chybě: " + ex.Message);
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
