using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Taschenrechner
{
    internal class RechenCore
    {
        // ich bekomm eine luste aus strings die operratoren beinhaltet 
        // eine schleife die nach operratoren sucht und dan die werte davor und danach 
        // mit den jeweiligen operatoren berechnert  . vor -
        List<string> eingangsListeBerechnung = new List<string>();
        List<decimal> sum = new List<decimal>();
        decimal sum1 = 0;
        decimal summe = 0;
        public decimal Berechnung(List<string> myList)
        {

            eingangsListeBerechnung = myList;
            // eine schleife die so lange geht bis die liste nur noch einen wert hat
            Console.WriteLine(String.Join(" ", eingangsListeBerechnung));
            int i = 0;
            int malZ = 0;
            int geZ = 0;
            int miZ = 0;
            int plZ = 0;
            foreach (string s in eingangsListeBerechnung)
            {
                if (s == "*")
                {
                    malZ = malZ + 1;
                }
                if (s == "/") { geZ = geZ + 1; }
                if (s == "-") { miZ = miZ + 1; }
                if (s == "+") { plZ = plZ + 1; }
            }
            if (malZ >= 1)
            {
                while (malZ > 0)
                {

                    if (eingangsListeBerechnung[i] == "*")
                    {
                        summe = decimal.Parse(eingangsListeBerechnung[i - 1]) * decimal.Parse(eingangsListeBerechnung[i + 1]);
                        eingangsListeBerechnung[i] = summe.ToString();
                        eingangsListeBerechnung.RemoveAt(i - 1);
                        eingangsListeBerechnung.RemoveAt(i);
                        Console.WriteLine(String.Join(" ", eingangsListeBerechnung));
                        malZ = malZ - 1;
                        i = 0;
                    }
                    i++;

                }
                i = 0;
            }
            if (geZ > 0)
            {
                while (geZ >= 1)
                {

                    if (eingangsListeBerechnung[i] == "/")
                    {
                        summe = decimal.Parse(eingangsListeBerechnung[i - 1]) / decimal.Parse(eingangsListeBerechnung[i + 1]);
                        eingangsListeBerechnung[i] = summe.ToString();
                        eingangsListeBerechnung.RemoveAt(i - 1);
                        eingangsListeBerechnung.RemoveAt(i);
                        Console.WriteLine(String.Join(" ", eingangsListeBerechnung));
                        geZ = geZ - 1;
                        i = 0;
                    }
                    i++;
                }
                i = 0;
            }
            if (plZ > 0)
            {
                while (plZ >= 1)
                {

                    if (eingangsListeBerechnung[i] == "+")
                    {
                        summe = decimal.Parse(eingangsListeBerechnung[i - 1]) + decimal.Parse(eingangsListeBerechnung[i + 1]);
                        eingangsListeBerechnung[i] = summe.ToString();
                        eingangsListeBerechnung.RemoveAt(i - 1);
                        eingangsListeBerechnung.RemoveAt(i);
                        Console.WriteLine(String.Join(" ", eingangsListeBerechnung));
                        plZ = plZ - 1;
                        i = 0;
                    }
                    i++;
                }
                i = 0;
            }
            if (miZ > 0)
            {
                while (miZ >= 1)
                {

                    if (eingangsListeBerechnung[i] == "-")
                    {
                        summe = decimal.Parse(eingangsListeBerechnung[i - 1]) - decimal.Parse(eingangsListeBerechnung[i + 1]);
                        eingangsListeBerechnung[i] = summe.ToString();
                        eingangsListeBerechnung.RemoveAt(i - 1);
                        eingangsListeBerechnung.RemoveAt(i);
                        Console.WriteLine(String.Join(" ", eingangsListeBerechnung));
                        miZ = miZ - 1;
                        i = 0;
                    }
                    i++;

                }
                i = 0;
            }

            Console.WriteLine(String.Join(" ", eingangsListeBerechnung));
            return summe;
        }
    }
}