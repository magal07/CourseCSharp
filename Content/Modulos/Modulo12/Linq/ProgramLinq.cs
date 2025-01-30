using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class ProgramLinq
    {
        static void ProgramLinqMain(string[] args)
        {

            // Specify the data source

            int[] numbers = new int[] { 2, 3, 4, 5,};

            // Speficy the query expression

            var result = numbers.
                Where(x => x % 2 == 0). // consulta pares
                Select(x => x * 10); // faz pares x 10

            // Execute the query 

            foreach(int x in result)
            {
                Console.WriteLine(x); // result 2x10 = 20, 4x10 = 40, vai aparecer somente o result
            }
        }
    }
}
