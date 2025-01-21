using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo4.Content
{
    internal class TopicosEspeciais
    {
        static void SwitchCaseAndVar(string[] args)
        {

            var ints = 10; // reconhece o int 
            var y = 10;
            var strings = "Maria"; // reconhece o string
            var doubles = 10.0; // reconhece o double

            string day;
            // switch case = analisar / caso 

            int x = int.Parse(Console.ReadLine());  

            switch (x) {

                case 1:
                    day = "Sunday";
                    break;

                case 2:
                    day = "Monday";
                    break;

                case 3:
                    day = "Tuesday";
                    break;

                case 4:
                    day = "Wednesday";
                    break;

                case 5:
                    day = "Thursday";
                    break;

                case 6:
                    day = "Friday";
                    break;

                case 7:
                    day = "Saturday";
                    break;

                default:
                    day = "Invalid value"; // valor invalido caso não seja nenhum mencionado acima
                    break;
            }

            Console.WriteLine("Day: " + day);
        }
    }
}
