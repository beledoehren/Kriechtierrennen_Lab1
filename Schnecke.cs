using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kriechrennen
{
    internal class Schnecke : Kriechtiere
    {
        public Schnecke(Random zufall) : base(zufall)
        {
            symbol = "@";
        }

        public override void Krieche()
        {
            strecke += zufall.Next(2, 5);
        }

    }
}
