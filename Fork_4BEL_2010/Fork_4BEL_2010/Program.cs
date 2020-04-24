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
            Console.ReadKey();
        }
        /// <summary>
        /// Wandelt eine Binärzahl in eine Hexadezialzahl um
        /// </summary>
        /// <param name="Bin"></param>
        /// <returns></returns>
        static string Hexmethode(String Bin)
        {
            String Hex = "";
            char[] Array = Bin.ToCharArray();
            int dec = 0;
            int x = 1;
            for (int i = 0; i < Bin.Length; i++)
            {
                if (Array[i] == '1')
                {
                    dec += Convert.ToInt32(Math.Pow(2, Bin.Length - i - 1));
                }
            }
            while (dec != 0)
            {
                if ((dec %16 < 10))
                {
                    Hex = Hex.Insert(0, Convert.ToString(dec % 16));
                }
                else
                {
                    if  ((dec % 16 == 10))
                    {
                        Hex = Hex.Insert(0,"A");
                    }
                    else if (dec %16== 11)
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
                dec = dec - dec%16;
                dec = dec / 16;
                x++;
            }

            return Hex;
        }
    }
}
