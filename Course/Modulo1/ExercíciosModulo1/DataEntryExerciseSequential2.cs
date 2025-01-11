using System;
using System.Globalization;

namespace Course.Modulo1.ExercícioModulo1
{
    class Program
    {
        static void ExercisePI(string[] args)
        {

            double R, A, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R; // soma feita PI * raio a 2 potência

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}