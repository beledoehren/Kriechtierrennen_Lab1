using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kriechrennen
{
    internal class Käfer : Kriechtiere
    {
        //Konstruktor
        public Käfer(Random zufall) : base(zufall)
        {
            symbol = ":o:";
        }

        //Überschreiben der Methode Krieche()
        public override void Krieche()
        {
            //Käfer läuft entweder 0,3 oder 6 Schritte vorwärts, abhängig von der zufälligen Zahl
            int zahl = zufall.Next(0, 3);

            if (zahl == 1)
            {
                strecke += 3;
            }
            else if (zahl == 2)
            {
                strecke += 6;
            }
        }
    }
}
