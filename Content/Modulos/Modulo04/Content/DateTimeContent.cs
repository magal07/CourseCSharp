using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.ModulosDeEstudo.Modulo4.Content
{
    internal class DateTimeContent
    {
        static void ContenteDateTime(string[] args)

        {
            /* DATETIME
            DateTime d1 = new DateTime(2018, 11, 25); 
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);
            DateTime d3 = new DateTime(2018, 11, 25, 2, 45, 3, 500);

            DateTime d4 = DateTime.Now; // mostrar horário atual
            DateTime d5 = DateTime.Today; // data de hj horário zerado 00h00min00seg
            DateTime d6 = DateTime.UtcNow;
            */

            /* Padrões DateTime
            DateTime d1 = DateTime.Parse("2000-08-15"); Ele puxa padrões conforme DB para sintetizar a escolha de barras e disposição da data
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");

            DateTime d3 = DateTime.Parse("15/08/2000"); formatação PTBR
            DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");

            
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            */

            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);

        }
    }
}
