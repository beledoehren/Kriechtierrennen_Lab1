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

		public Kriechtiere(Random zufall)
		{
			this.zufall = zufall;
			this.strecke = 0;
		}

		public int Strecke
		{
			get { return strecke; }
		}

		public string Visualiesierung
		{
			get
			{
				return new string('_', strecke) + symbol;
			}
		}

		public abstract void Krieche();

	}
}

