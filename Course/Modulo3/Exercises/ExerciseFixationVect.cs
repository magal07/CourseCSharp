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
        static void Main(string[] args)
        {

            Student[] vect = new Student[10];

            Console.Write("How many rooms will be rented? ");

            int n = int.Parse(Console.ReadLine());  

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Student(name, email);

            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");

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
