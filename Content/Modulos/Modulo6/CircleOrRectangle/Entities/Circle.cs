﻿using Course.Entities;
using System;
using System.Globalization;
namespace Course.ModuloDeEstudo.Modulo6.CircleOrRectangle.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle color = "
                    + Color
                    + ", radius = "
                    + Radius.ToString("F2", CultureInfo.InvariantCulture)
                    + ", area = "
                    + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
