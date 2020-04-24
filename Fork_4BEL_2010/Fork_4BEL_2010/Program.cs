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
            String Binaerwert=string.Empty;
            String Ausgabe=string.Empty;
            String AuswahlUmrechnung = start();

            switch (AuswahlUmrechnung)
            { 
                case "Fehler":
                    //nichts
                    break;

                case "zuBasis10":
                    Binaerwert = Binzahl();
                    if (Binaerwert == "Fehler")
                    {
                        break;
                    }
                    else
                    {
                        Ausgabe = Dezimalmethode(Binaerwert);
                        break;
                    }

                case "zuBasis16":
                    Binaerwert = Binzahl();
                    if (Binaerwert == "Fehler")
                    {
                        break;
                    }
                    else
                    {
                        Ausgabe = Hexmethode(Binaerwert);
                        break;
                    }
            }

            Console.WriteLine("Ergebnis=" + Ausgabe + "");
            Console.ReadKey();
        }

        static string start()
        { 
            Int16 Auswahl=0;
            String Rueckgabe=string.Empty;

            Console.WriteLine("Umrechnung von Binär in in Zahlen der Basis 10 der");

            Console.WriteLine("In welches Zahlensystem moechten Sie umwandeln\n1 In Zahl zur Basis 10\n2 In Zahl zur Basis 16");
            while (!Int16.TryParse(Console.ReadLine(), out Auswahl) || Auswahl <= 0 || Auswahl >= 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Die Eingabe ist Ungueltig, druecken Sie eine beliebige Taste");
                Console.ForegroundColor = ConsoleColor.White;
                Rueckgabe = "Fehler";
                return Rueckgabe;
            }

            switch (Auswahl)
            { 
                case 1:
                    Rueckgabe = "zuBasis10";
                    break;

                case 2:
                    Rueckgabe = "zuBasis16";
                    break;
            }

            return Rueckgabe;
        }
    }
}
