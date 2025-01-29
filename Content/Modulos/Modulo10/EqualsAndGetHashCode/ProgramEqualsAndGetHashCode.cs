using System;
using Course.Entities;

namespace Course
{
    internal class Progam
    {
        static void Main(string[] args)
        {
            
            Client a = new Client() { Name = "Maria", Email = "maria@gmail.com" } ;
            Client b = new Client() { Name = "Alex", Email = "AlexRamadlho@outlook.com" };

            Console.WriteLine(a.Equals(b)); // equipara conforme função: Email (no caso false)
            Console.WriteLine(a == b); // false 
            Console.WriteLine(a.GetHashCode()); // cria um código único aleatório a cada depuração para cada obj, para fins de comparação
            Console.WriteLine(b.GetHashCode());
        }
    }
}
