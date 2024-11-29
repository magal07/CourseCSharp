using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
     class OperadoresDeAtribuicao
    {
        static void OperadoresAtribuicao(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            s += "DEF"; 

            Console.WriteLine(s);

            // ++ = Incrementar o valor de uma variável de 1 
            // -- = Decrementar o valor de uma variavel de -1
        }
    }
}
