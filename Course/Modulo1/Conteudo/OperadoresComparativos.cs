﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo1.Conteudo
{
    internal class OperadoresComparativos
    {
        static void ComparativeOperators(string[] args)
        {
            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("---------------------");

            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10; // == igual
            bool c8 = a != 10; // != diferente

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);




        }
    }
}
