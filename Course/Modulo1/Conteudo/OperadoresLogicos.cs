using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo1.Conteudo
{
     class OperadoresLogicos
    {
        static void LogicOperators(string[]args)
        {
            bool c1 = 2 > 3 && 4 != 5; // Para a expressão dar true utilizando o &&, toda operação tem que ser true
            // Exemplo autoescola ( && ) : Pra pegar a habilitação, tem que PASSAR (true) na prova teórica && também PASSAR (true) na prática.

            Console.WriteLine(c1);
            Console.WriteLine("--------------------------");
             
            bool c2 = 2 > 3 || 4 != 5; // TRUE - Para a expressão dar true utilizando o &&, toda operação tem que ser true
            //Neste exemplo ( || ) : Qualquer combinação que contenha 1 dos dados positivos, dará positivo 
            Console.WriteLine(c2);


            // PRECEDÊNCIA =  !   >  &&  > ||   = NÃO MAIOR Q E, e E MAIOR Q OU

            bool c3 = !(2 > 3) && 4 != 5; // TRUE
            Console.WriteLine(c3);
            Console.WriteLine("--------------------------");


            bool c4 = 10 < 5; // FALSE

            bool c5 = c2 || c3 && c4;

            Console.WriteLine($"c5 = {c5}");

        }
    }
}
