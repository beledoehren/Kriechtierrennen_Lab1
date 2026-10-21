using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kriechrennen
{
	internal class Raupe : Kriechtiere
	{
		//Konstruktor
		public Raupe(Random zufall) : base(zufall)
		{
			symbol = "ooo<";
		}

        //Überschreiben der Methode Krieche()
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
