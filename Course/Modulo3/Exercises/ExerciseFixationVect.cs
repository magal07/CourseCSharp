using Course.Modulo3.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo3.Exercises
{
    class ExerciseFixationVectRooms
    {
        static void RoomRented(string[] args)
        {

            Student[] vect = new Student[10];

            Console.Write("How many rooms will be rented? "); // quantos quartos serão alugados

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) // Começa em 1 para contar corretamente até n. 
                                         // Se começássemos em 0 e fôssemos até n, contaríamos (n + 1) vezes.
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Telephone: ");
                string telephone = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Student(name, email, telephone);

            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");

            // laço for para trazer somente os quartos ocupados, ou seja, != null (que foram cadastrados no ReadLine) 


            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
