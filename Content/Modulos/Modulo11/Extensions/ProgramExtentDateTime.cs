using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class ProgramExtentDateTime
    {
        static void DateTimeElapsedTime(string[] args)
        {
            DateTime dt = new DateTime(2025, 01, 29, 14, 00, 00);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
