using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo3.Content
{
    internal class Foreach // inclusive, é mais utilizado do que o laço for
    {
        static void LacoForEach(string[] args)
        {
            /* MODELO COM FOR */
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);

            }
            Console.WriteLine("----------------------------");

            foreach (string obj in vect)
            { // <- leitura: Para cada objeto contido no meu vetor
                Console.WriteLine(obj); // eu vou mandar imprimir, este elemento (obj)


            }
        }
    }
}
