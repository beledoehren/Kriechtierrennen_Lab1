using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kriechrennen
{
    internal class Käfer : Kriechtiere
    {
        public Käfer(Random zufall) : base(zufall)
        {
            symbol = "°#°";
        }

        public override void Krieche()
        {
            strecke += 3;
        }
    }
}
