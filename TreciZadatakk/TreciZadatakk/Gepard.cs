using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciZadatakk
{
    class Gepard : Cat
    {
        public override void Opasnost(bool opasna)
        {
            opasna = true;
            Console.WriteLine("Opasnost ove macke je " + opasna);
        }
    }
}
