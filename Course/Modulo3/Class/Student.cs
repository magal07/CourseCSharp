using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo3.Class
{
    public class Student
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }
        public Student(string name, string email, string telephone)
        {
            Name = name;
            Email = email;
            Telephone = telephone;
        }

        public override string ToString()
        {
            return Name + ", " + Email + ", " + Telephone;
        }
    }
}
