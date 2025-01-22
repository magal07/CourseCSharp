using System;
using Course.Entities.Enums;
using Course.Entities;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()); // vai pedir pro usuário digitar entre Junior/MidLevel/Senior
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            // For com intuito de informar o contrato e COMPARAR as datas para solucionar o salário base + pendência 
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data"); // lembrar do $ dolar inicial pra interpolar o quantitativo de contracts
                Console.Write("Date (DD/MM/YYYY): "); 
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contrat = new HourContract(date, valuePerHour, hours); // instanciando o contrato junto a data, valor p/ hora, e horas

                // adicionando o contrato no WORKER (Trabalhador) quantidade depende da quantidade de valores da linha 25/26:
                worker.AddContract(contrat); 
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2)); // ele vai recortar o mês do (MM/YYYY)
            int year = int.Parse(monthAndYear.Substring(3)); // vai pegar da posição 3 em diante, após a / então vai iniciar do YYYY e vai até o final
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name); // ACESSEI O DEPARTAMENTO E DEPOIS O NOME DO DEPARTAMENTO
            Console.WriteLine("Income for " + monthAndYear + ": " +  worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)); // income for monthAndYear recebe o método Income com parâmetros do (ano e do mês)
        }

    }
}
