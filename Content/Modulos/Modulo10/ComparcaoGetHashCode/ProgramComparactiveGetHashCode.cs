using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Content.Modulos.Modulo10.ComparcaoGetHashCode.Entities;
using Course.Entities;

namespace Course
{
    internal class ProgramComparactiveGetHashCode
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.00));
            a.Add(new Product("Notebook", 1200.00));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            //TIPO CLASSE: Daria true pois a comparação é da referência
            // EDIT: Atualizado o Product e acrescentado o GetHashCode
            Product prod = new Product("Notebook", 1200.00);
            Console.WriteLine(a.Contains(prod));


            // TIPO STRUCT \/ : Vai dar verdadeiro pois vai comparar o conteudo
            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p));
        }
    }
}
