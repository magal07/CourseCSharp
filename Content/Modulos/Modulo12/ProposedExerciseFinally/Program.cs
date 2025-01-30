using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Entities;
using System.Globalization;

namespace Course
{
    internal class Program
    {

        //static void Print<T>(string message, IEnumerable<T> collections)
        //{
        //    Console.WriteLine(message);
        //    foreach (T obj in collections)
        //    {
        //        Console.WriteLine(obj);
        //    }
        //    Console.WriteLine();


        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    while (!sr.EndOfStream)
                    {
                        string[] employes = sr.ReadLine().Split(',');
                        string name = employes[0];
                        string email = employes[1];
                        double salary = double.Parse(employes[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }
                }

                var emails = list
                        .Where(obj => obj.Salary > limit)
                        .OrderBy(obj => obj.Email)
                        .Select(obj => obj.Email);

                var sum = list
                    .Where(obj => obj.Name[0] == 'M')
                    .Sum(obj => obj.Salary);


                Console.WriteLine("Email of people whose salary is more than " + limit.ToString("F2", CultureInfo.InvariantCulture));
                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }
                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
