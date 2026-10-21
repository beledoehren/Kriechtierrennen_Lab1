using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kriechrennen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random zufall = new Random();

            Kriechtiere[] tiere =
            {
                new Schnecke(zufall),
                new Wurm(zufall),
                new Raupe(zufall),
                new Käfer(zufall),
            };

            bool zielErreicht = false;

            // Rennen
            while (!zielErreicht)
            {
                Console.CursorTop = 0;

                foreach (Kriechtiere tier in tiere)
                {
                    tier.Krieche();

                    Console.WriteLine(tier.Visualiesierung);

                    if (tier.Strecke >= 50)
                    {
                        zielErreicht = true;
                    }
                }

                if (!zielErreicht)
                {
                    Thread.Sleep(500);
                }
            }

            Kriechtiere gewinner = tiere[0];

            foreach (Kriechtiere tier in tiere)
            {
                if (tier.Strecke > gewinner.Strecke)
                {
                    gewinner = tier;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Ziel erreicht!");
            Console.WriteLine("Gewinner: " + gewinner.GetType().Name);
            Console.WriteLine("Strecke: " + gewinner.Strecke);

            Console.ReadKey();
        }
    }
}