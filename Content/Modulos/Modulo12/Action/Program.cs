﻿using Course.Entities;
using System;
using System.Collections.Generic;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();


            list.Add(new Product("TV,", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));

            //Action<Product> act = UpdatePrice; 

            // forma lambda de substituição do UpdatePrice 
            //Action<Product> act = p => { p.Price += p.Price * 0.1; }; 

            // forma lambda de utilizar diretamente no ForeAch \/ 
            list.ForEach(p => { p.Price += p.Price * 0.1; });
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
