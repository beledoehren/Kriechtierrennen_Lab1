using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kriechrennen
{
	internal class Raupe : Kriechtiere
	{
		public Raupe(Random zufall) : base(zufall)
		{
			symbol = "ooo<";
		}

		public override void Krieche()
		{
			int zahl = zufall.Next(0, 2);

			if (zahl == 1)
			{
				strecke += 4;
			}
		}
	}
}
