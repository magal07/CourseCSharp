using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.ModulosDeEstudo.Modulo4.Content
{
    internal class TimeSpanPT2
    {

        static void TimeSpanParteDoisCicleTime(string[] args)
        {
            TimeSpan tMAX = TimeSpan.MaxValue; // valor máximo
            TimeSpan tMIN = TimeSpan.MinValue; // valor mínimo 
            TimeSpan tZERO = TimeSpan.Zero; // zero
            Console.WriteLine(tMAX);
            Console.WriteLine(tMIN);
            Console.WriteLine(tZERO);

            Console.WriteLine("----------------------------");

            // PROPRIEDADES DO TIME SPAN 
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            Console.WriteLine("----------------------------");


            // OPERAÇÕES COM TIMESPAN

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t1.Add(t2); // somou o valor t1 + t2
            TimeSpan dif = t1.Subtract(t2); // subtraiu o valor t1 - t2
            TimeSpan mult = t2.Multiply(2.0); // multiplicou t2 * 2.0 double
            TimeSpan div = t2.Divide(2.0); // dividiu t2 / 2.0/
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);


        }
    }
}