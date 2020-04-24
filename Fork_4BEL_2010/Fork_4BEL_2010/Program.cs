using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Umrechnung in verschiedene Zahlensysteme
namespace Fork_4BEL_2010
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static string Binzahl()
        {
            string Eingabe = "";
            bool keinFehler = true;

            Console.WriteLine();
            Console.Write("Binärzahl eingeben: ");
            Eingabe = Console.ReadLine();

            char[] CEingabe = Eingabe.ToCharArray();

            for (int i = 0; i < Eingabe.Length & keinFehler == true; i++)
            {
                if(!(CEingabe[i] == '1' || CEingabe[i] == '0'))
                {
                    Eingabe = "Fehler";
                    keinFehler = false;
                }
            }
            return Eingabe;
        }
    }
}
