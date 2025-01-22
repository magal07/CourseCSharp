using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.ModulosDeEstudo.Modulo3.Content
{
    public class ResumeContent
    {
        static void ResumoConteudo(string[] args)
        {
            string desalocacaoDeMemoria = "";
            string garbageCollector = "";
            string escopoLocal = "";


            double? x = null; // modo de permitir usar nullo em valores
            double? y = 10.0; // verificará se é nullo, caso não puxará o 10.0 no GetValueOrDefault

            // GetValueOrDefault = ObterValoresOuPadrões

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            // HasValue = retorna como verdadeiro ou falso, como se fosse um boolean, utlizaremos o if e else para trazer os valores caso sejam verdadeiros
            // ou informar que eles são nullos, caso sejam falsos

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }


        }
    }
}
