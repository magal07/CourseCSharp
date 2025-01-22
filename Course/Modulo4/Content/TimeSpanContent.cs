using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo4.Sintaxes
{
    internal class TimeSpanContent
    {
        static void ContentTimeSpan(string[] args)
        {
            /* TIMESPAN, INTERVALO ENTRE DURAÇÕES

             TimeSpan t1 = new TimeSpan(0, 1, 30); // 0h, 1min, 30seg

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            */

            /* Formas de uso, TimeSpan
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L); // REFERÊNCIA AO 1:30 em nanosegundos (ticks)
            TimeSpan t3 = new TimeSpan(2, 11, 21); // horas até segundos
            TimeSpan t4 = new TimeSpan(2, 11, 21, 21); // dia até segundos
            TimeSpan t5 = new TimeSpan(2, 11, 21, 21, 321); // dia até milissegundos 

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            */

            TimeSpan t1 = TimeSpan.FromDays(1.5); // solicitamos 1 dia e meio, resultado é 24h + 12h
            TimeSpan t2 = TimeSpan.FromHours(1.5); // 1 hora e meia
            TimeSpan t3 = TimeSpan.FromMinutes(1.5); // 1 minuto e meio
            TimeSpan t4 = TimeSpan.FromSeconds(1.5); // 1 segundo e meio
            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5); // 1 milissegundos e meio
            TimeSpan t6 = TimeSpan.FromTicks(900000000L); // ticks


            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
        }
    }
}
