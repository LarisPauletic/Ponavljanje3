using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciZadatakk
{
    class Cat
    {
		public bool opasna;
		public virtual void Opasnost(bool opasna)
		{
			opasna = false;
			Console.WriteLine("Opasnost ove macke je " + opasna);
		}
	}
}
