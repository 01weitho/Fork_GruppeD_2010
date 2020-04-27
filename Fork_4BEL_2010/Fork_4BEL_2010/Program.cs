using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Umrechnung in verschiedene Zahlensysteme
//Gruppe D
//Thomas Zoeschg; Weiss Lukas; Stefan Unterholzner; Thomas Weithaler


namespace Fork_4BEL_2010
{
    class Program
    {
        static void Main(string[] args)
        {
            String Binaerwert = string.Empty;
            String Ausgabe = string.Empty;

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
                        AuswahlUmrechnung = "Fehler";
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
                        AuswahlUmrechnung = "Fehler";
                        break;
                    }
                    else
                    {
                        Ausgabe = Hexmethode(Binaerwert);
                        break;
                    }
            }

            if (!(AuswahlUmrechnung == "Fehler"))
            {
                Console.WriteLine("\nErgebnis=" + Ausgabe + "");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Wandelt eine Binärzahl in eine Hexadezialzahl um
        /// </summary>
        /// <param name="Bin">Der Methode muss die Binaerzahl als string uebergeben werden</param>
        /// <returns>Gibt die Zahl zur Basisi 16 als string zurueck</returns>
        static string Hexmethode(String Bin)
        {
            String Hex = "";
            int dec = Convert.ToInt32(Dezimalmethode(Bin)); ;
            int x = 1;
            while (dec != 0)
            {
                if ((dec % 16 < 10))
                {
                    Hex = Hex.Insert(0, Convert.ToString(dec % 16));
                }
                else
                {
                    if ((dec % 16 == 10))
                    {
                        Hex = Hex.Insert(0, "A");
                    }
                    else if (dec % 16 == 11)
                    {
                        Hex = Hex.Insert(0, "B");
                    }
                    else if (dec % 16 == 12)
                    {
                        Hex = Hex.Insert(0, "C");
                    }

                    else if (dec % 16 == 13)
                    {
                        Hex = Hex.Insert(0, "D");
                    }
                    else if (dec % x == 14)
                    {
                        Hex = Hex.Insert(0, "E");
                    }
                    else
                    {
                        Hex = Hex.Insert(0, "F");
                    }

                }
                dec = dec - dec % 16;
                dec = dec / 16;
                x++;
            }

            return Hex;
        }

        /// <summary>
        /// Wandelt eine Binaerzahl zu einer Dezimalzahl um.
        /// </summary>
        /// <param name="a">Die Binaerzahl muss als string uebergeben werden</param>
        /// <returns>Gibt die Umgewandelte Zahl als string zurueck</returns>
        static string Dezimalmethode(string a)
        {

            string bin = a;
            String Dezimalwert;
            int Dezimalint = 0;
            int bo = 0;

            byte[] bitearray = Encoding.ASCII.GetBytes(bin);

            for (int i = 0; i < bitearray.Length; i++)
            {
                if (bitearray[i] == 48)
                {

                    bitearray[i] = 0;
                }
                else
                {
                    bitearray[i] = 1;
                }
            }

            for (int i = bitearray.Length - 1; i > -1; i--)
            {
                Dezimalint += bitearray[i] * Convert.ToInt32(Math.Pow(2, bo));
                bo++;
            }

            Dezimalwert = Convert.ToString(Dezimalint);

            return Dezimalwert;
        }

        /// <summary>
        /// Schreibt den Anfang der Benutzeroberflaeche auf die Konsole.
        /// Liesst die Eingabe in welche Zahl umgewandelt wird ein.
        /// </summary>
        /// <returns>Gibt als String zurueck in welche Zahl umgewandelt werden soll.</returns>
        static string start()
        {
            Int16 Auswahl = 0;
            String Rueckgabe = string.Empty;

            Console.WriteLine("Umrechnung von Binär in in Zahlen der Basis 10 oder der Basis 16");

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

        /// <summary>
        /// Liest die Binaerzahl ein und Ueberprueft die Eingabe auf Fehler
        /// </summary>
        /// <returns>Gibt die Binaerzahl als String zurueck</returns>
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
                if (!(CEingabe[i] == '1' || CEingabe[i] == '0'))
                {
                    Eingabe = "Fehler";
                    keinFehler = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Die eingegebene Binaerzahl ist ungueltig.Beliebige Taste druecken.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            return Eingabe;
        }

    }
}

