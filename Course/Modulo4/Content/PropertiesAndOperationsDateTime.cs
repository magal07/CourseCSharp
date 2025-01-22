using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo4.Sintaxes
{

    
    internal class PropertiesAndOperationsDateTime
    {
        static void PropOpDateTime(string[] args)
        {

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine("-------------");

            DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = d2.ToLongDateString(); // convertendo do tipo DateTime para string, no padrão do pc 
            string s2 = d2.ToLongTimeString();
            string s3 = d2.ToShortDateString();
            string s4 = d2.ToShortTimeString();
            string s5 = d2.ToString();
            string s6 = d2.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d2.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            Console.WriteLine("---------------");

            // FAZENDO UM INTERVALO DE PRODUÇÃO UTILIZANDO O DateTime e o TimeSpan, imaginando valores aleatórios fornecidos pelo banco de dados.

            DateTime duracaoInicial = new DateTime(2000, 10, 15);

            DateTime duracaoFinal = new DateTime(2000, 10, 18);

            TimeSpan t = duracaoFinal.Subtract(duracaoInicial);

            Console.WriteLine("Intervalo de produção: " + t + " HH/MM//SS ");


        }
    }
}