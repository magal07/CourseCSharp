﻿using System.Globalization;

namespace Course.ModuloDeEstudo.Modulo6.PolimorfismoEHerancaExercicio.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name
                + " (used) "
                + " $ "
                + Price.ToString(CultureInfo.InvariantCulture);
        }
    }
}