using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciZadatakk
{
    class Program
    {
        static void Main(string[] args)
        {
            Gepard g = new Gepard();
            g.Opasnost(g.opasna);

            Console.ReadKey();
        }
    }
}
