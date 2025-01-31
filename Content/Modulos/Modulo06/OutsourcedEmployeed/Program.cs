﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Course.ModuloDeEstudo.Modulo6.OutsourcedEmployeed.Entities;
namespace Course.ModuloDeEstudo.Modulo6.OutsourcedEmployeed
{
    internal class Program
    {

        static void ContentEmployeesAndOutSourced(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("ENTER THE NUMBER OF EMPLOYEES: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if(ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString
                            ("F2", CultureInfo.InvariantCulture)); // pra cada funcionario employee em

            }
        }
    }
}
