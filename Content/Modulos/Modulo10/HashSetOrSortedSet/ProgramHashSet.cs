using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Course
{
    internal class ProgramHashSet
    {
        static void Main(string[] args)
        {

            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("TV")); // VERIFICARÁ SE TV CONTEM (CONTAINS) NA LIST ACIMA HASHSET

            foreach(string p in set) // pra cada string p no set
            {
                Console.WriteLine(p);
            }



        }
    }
}
