using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
//using Course.Metodos;
using Course.Modulo2.ClassesDosExercícios;
namespace Course.Modulo2
{
    class OrientadaAObjetos
    {
        static void CalculoTriangulo(string[] args)
        {

            CalculoTriangulo x, y; 

            x = new CalculoTriangulo();
            y = new CalculoTriangulo();    

            Console.WriteLine("Entre com as medidas do triângulo X: ");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area(); // utilizando métodos


            Console.WriteLine("Entre com as medidas do triângulo Y: ");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaY = y.Area(); // método!


            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de X = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior Área = X ");
            }
            else if (areaY > areaX)
            {
                Console.WriteLine("Maior Área = Y ");
            }
            else
            {
                Console.WriteLine("Triângulos Iguais!");
                Console.WriteLine("Área Triângulo X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("Área Triângulo Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("Fim do Programa!");

            }
        } 
    }
}
