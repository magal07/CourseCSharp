using System;
using System.Globalization;


namespace Course.Modulo1.Conteudo
{
    class Course
    {
        static void ExemploDePontuacaoEQuebraDeLinha(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";


            Console.Write("Bom dia! ");
            Console.WriteLine("Boa tarde!"); // Inclui a quebra de linhav
            Console.WriteLine("Boa Noite!"); // Inclui a quebra de linhav
            Console.WriteLine("--------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2")); // CÓDIGO F2 SOMADO AO ToString delimita o número de casas para 2 (F3 PARA 3, F4 ...)
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // CultureInfo + Culture informa que queremos imprimir com o ponto de separado de sinais (10.0) (using System.Globalization) tem que estar incluso
        }
    }
}