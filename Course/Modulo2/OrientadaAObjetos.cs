using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Course.Modulo2
{
     class OrientadaAObjetos
    {
        static void Main(string[] args)
        {

            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X: ");

            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));


            Console.WriteLine("Entre com as medidas do triângulo Y: ");

            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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
                Console.WriteLine("Triângulos Iguais! ");
                Console.WriteLine("Area Triângulo X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("Area Triângulo Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("Fim do progama!");

            }
        } 
    }
}
