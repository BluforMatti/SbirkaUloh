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
                        // Čtení souboru řádek po řádku
                        while ((line = reader.ReadLine()) != null)
                        {
                         // NAŠEPTAL (ZMRD)
                            // Převod velkých písmen na malá, odstranění číslic a nahrazení mezer novými řádky
                            string Line = new string(line.Where(c => !char.IsDigit(c)).ToArray()).ToLower().Replace(" ", Environment.NewLine);
                            // Zápis zpracovaného řádku do cílového souboru
                            writer.WriteLine(processedLine);
                        }
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
