using Course.ModulosDeEstudo.Modulo3.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.ModulosDeEstudo.Modulo3.Content
{
    internal class Triple
    {
        static void Triplo(string[] args)
        {

            // exemplo de ref

            int a = 10;

            Calculator.TripleRef(ref a);
            Console.WriteLine(a);

            // exemplo de out

            int b = 10;
            int tripleOut;

            Calculator.TripleOut(b, out tripleOut);
            Console.WriteLine(tripleOut);
        }
    }
}
