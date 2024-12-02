using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo1.Conteudo
{
    class OperadoresDeAtribuicao2
    {
        static void AssignmentOperators(string[] args)
        {
            int a = 10;
            a++; // a ++ soma pra virar 11
            Console.WriteLine(a);

            int b = 10;
            int c = ++b; /* <- ++ = primeiro incrementa o valor da variável b depois atribui o resultado, então no caso seria
                         b = 10 certo? b + ++b = 11 certo? <- incrementou, então neste exemplo, o c já tem o valor de 11
                         se fosse ao contrário, c = b++ e fossemos chamar o CWL, ele iria retornar 10 pois primeiro passa o 
                         valor, depois incrementa */


            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
