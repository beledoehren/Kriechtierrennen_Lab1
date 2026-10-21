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
            //Random-Objekt erstellen
            Random zufall = new Random();

            //Array von Kriechtieren erstellen
            Kriechtiere[] tiere =
            {
                new Schnecke(zufall),
                new Wurm(zufall),
                new Raupe(zufall),
                new Käfer(zufall),
            };

            //Überprüfungsvariable, ob das Ziel erreicht wurde
            bool zielErreicht = false;

            //Rennen
            while (!zielErreicht)
            {
                //Cursor an den Anfang der Konsole setzen
                Console.CursorTop = 0;

                foreach (Kriechtiere tier in tiere)
                {
                    //Methode "Krieche" für jedes Tier aufrufen
                    tier.Krieche();

                    //Strecke für jedes Tier ausgeben
                    Console.WriteLine(tier.Visualiesierung);

                    //Überprüfen, ob das Ziel erreicht wurde
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

            //Gucken, welches Tier die größte Strecke zurückgelegt hat
            foreach (Kriechtiere tier in tiere)
            {
                if (tier.Strecke > gewinner.Strecke)
                {
                    gewinner = tier;
                }
            }
            //Gewinner ausgeben
            Console.WriteLine();
            Console.WriteLine("Ziel erreicht!");
            Console.WriteLine("Gewinner: " + gewinner.GetType().Name);
            Console.WriteLine("Strecke: " + gewinner.Strecke);

            Console.ReadKey();
        }
    }
}