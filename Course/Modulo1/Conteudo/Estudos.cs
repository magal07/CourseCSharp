using System;

namespace Course.Modulo1.Conteudo

{
    class Program
    {
        static void Exercico1(string[] args)
        {

            bool completo = false;

            char genero = 'F'; // sempre em aspas simples

            char letra = '\u0041'; // buscar códigos na tabela unicode https://symbl.cc/en/unicode-table/ (neste exemplo A = \u0041

            byte n1 = 126;// máximo 255

            int n2 = 1000;

            int n3 = 2147483647; // limite int

            long n4 = 2147483648L; // LONG s/ limite

            float n5 = 4.5f; // sempre acrescentar f pra usar tipo float

            double n6 = 4.5;

            string nome = "Maria";

            object obj1 = "Alex Bronw";
            object obj2 = 5.7f;

            Console.WriteLine(nome);
            Console.WriteLine(n5);
            Console.WriteLine(completo);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            int g1 = int.MinValue;


            Console.WriteLine(g1);


            // TODA CLASSE EM C#, É UMA SUBCLASSE DE OBJECT 
        }
    }
}

