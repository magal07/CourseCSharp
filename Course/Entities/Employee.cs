using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
            
        }
        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("Comparing error!");
            }
            Employee other = obj as Employee; // OUTRO FUNCIONÁRIO SENDO COMPARADO COM O FUNCIONÁRIO PADRÃO
            return Name.CompareTo(other.Name); // TIPO STRING JÁ IMPLEMENTA A INTERFACE ICOMPARABLE
        }
    }
}
