using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo1.Conteudo
{
    class OperadoresAritimeticos
    {
        static void OperadorAritimetico(string[] args)
        {
            // COMO NA MATEMÁTICA, A *, / e % tem precedência maior que + e - .. % = mod pronuncia

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3; // 17 / 3 = 5, desce o 2 , então o resultado será 2 pois o resto é o q chamamos de "mod"
            double n4 = (double)10 / 8; // colocar o double ou colocar a casa decimal 10.0 / 8.0; pelo menos 1 dos valores tem q estar com a casa decimal


            double a = 1.0, b = -3.0, c = -4.0;

            // double delta = b * b - 4.0 * a * c; // potência <- b * b
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; // ou usar assim - > 

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); // RAIZ 1  // SQRT = RAIZ QUADRADA, atentar aos parenteses
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a); // RAIZ 2 // BHASKARA TEM 2 RAÍZES DE SAIDA 

            Console.WriteLine(delta);
            Console.WriteLine(x1);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

        }
    }
}
