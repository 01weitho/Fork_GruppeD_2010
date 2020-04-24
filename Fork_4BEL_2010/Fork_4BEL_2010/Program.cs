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
            string hallo = "1010";
            Dezimalmethode(hallo);

            Console.ReadKey();
        }

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
            
            for (int i =bitearray.Length-1 ;i >-1; i--)
            {
                Dezimalint += bitearray[i] * Convert.ToInt32(Math.Pow(2, bo));
                bo++;
            }

            Dezimalwert = Convert.ToString(Dezimalint);

        return Dezimalwert;
    }
    }
}
