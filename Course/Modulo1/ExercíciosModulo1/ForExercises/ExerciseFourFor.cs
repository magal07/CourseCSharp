using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Modulo1.ExercícioModulo1.ForExercises
{
    internal class ExerciseFourFor
    {
        static void Exercise4ForDiv(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossível");
                }
                else
                {
                    double div = (double)x / y;

                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                    /*
                    //if (y == 0)
                    //{
                    //    Console.WriteLine("divisao impossivel");
                    //}
                    //else
                    //{
                    //    double div = (double)x / y;
                    //    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture); */
                }
            }
        }
    }
}