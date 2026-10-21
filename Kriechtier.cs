using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kriechrennen
{
	abstract class Kriechtiere
	{
		protected int strecke;
		protected string symbol;
		protected Random zufall;

        // Konstruktor, der ein Random-Objekt als Parameter akzeptiert
        public Kriechtiere(Random zufall)
		{
			this.zufall = zufall;
			this.strecke = 0;		//zurückgelegte Strecke auf 0
		}

        //Property, um die zurückgelegte Strecke abzufragen
        public int Strecke
		{
			get { return strecke; }
		}

        //Property für die Visualisierung der zurückgelegten Strecke
        public string Visualiesierung
		{
			get
			{
				return new string('_', strecke) + symbol;
			}
		}

		//Methode
		public abstract void Krieche();

	}
}

