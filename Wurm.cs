using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kriechrennen
{
    internal class Wurm : Kriechtiere
    {
        //Konstruktor
        public Wurm(Random zufall) : base(zufall)
        {
            symbol = "~";
        }

        //Überschreiben der Methode Krieche()
        public override void Krieche()
        {
            strecke += zufall.Next(0, 7);
        }

    }
}
