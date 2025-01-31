﻿using Course.ModuloDeEstudo.Modulo6.CircleOrRectangle.Entities;
using System.Globalization;
using Course.Model.Enum;
using Course.Entities;
/* REAPROVEITAMENTO DE AULA
namespace Course.ModuloDeEstudo.Modulo6.CircleOrRectangle
{
class Program
{

  static void ProgramCircleRectangle(string[] args)
  {
      List<Shape> list = new List<Shape>();
      Console.Write("Enter the number of shapes: ");
      int n = int.Parse(Console.ReadLine());

      for (int i = 1; i <= n; i++)
      {
          Console.WriteLine($"Shape #{i} data: ");
          Console.Write("Rectangle or Circle (r/c)? ");
          char result = char.Parse(Console.ReadLine());
          Console.Write("Color (Black/Blue/Red): ");
          Color color = Enum.Parse<Color>(Console.ReadLine());
          if(result == 'r')
          {
              Console.Write("Width: ");
              double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
              Console.Write("Height: ");
              double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
              list.Add(new Rectangle(width, height, color));
          }
          else
          {
              Console.Write("Radius: ");
              double radius = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
              list.Add(new Circle(radius, color));
          }
      }
      Console.WriteLine();
      Console.WriteLine("SHAPE AREAS: ");
      foreach (Shape shape in list)
      {
          Console.WriteLine(shape.Area().
                          ToString("F2",
                          CultureInfo.InvariantCulture));
      }
      Console.WriteLine("TOTAL TAXES: $");
      double sum = 0.0;

  }
}
}
  */

namespace Course.ModuloDeEstudo.Modulo6.CircleOrRectangle
{

    class ProgramEditModuloDez
    {
        static void EditModelInterfaceImplement(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.Black };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Blue };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }

    }
}

