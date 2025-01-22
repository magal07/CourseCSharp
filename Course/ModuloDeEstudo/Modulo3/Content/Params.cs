using Course.ModulosDeEstudo.Modulo3.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.ModulosDeEstudo.Modulo3.Content
{
    internal class Params
    {
        static void ContentParams(string[] args)
        {

            //int s1 = Calculator.Sum(int[] {5, 5}); <- modelo sem params porém não muito usual

            int s1 = Calculator.Sum(5, 5); // não precisa informar o vetor int [] por conta do params executado na calculadora, exemplo acima
            int s2 = Calculator.Sum(4, 6);

            Console.WriteLine(s1);
            Console.WriteLine(s2);


        }


    }
}
