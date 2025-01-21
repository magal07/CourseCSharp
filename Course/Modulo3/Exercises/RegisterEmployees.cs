using Course.Modulo3.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Modulo3.Exercises
{
    internal class RegisterEmployees
    {
        static void EmployeesRegistered(string[] args)
        {
            Console.Write("How many employees will be registered: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++) /* "Para i começando em 1, enquanto i for menor ou igual a n, incremente i em 1 a cada iteração."
                Ou, de forma mais simples:
"Para cada i de 1 até n, faça..." */
            {
                Console.WriteLine();
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary)); // "Adicione um novo objeto Employee, criado com id, name e salary, à lista list."
                Console.WriteLine();
            }
            // Solicita ao usuário que insira o ID do funcionário cujo salário será aumentado
            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            // Procura na lista um funcionário cujo ID corresponda ao ID inserido pelo usuário
            Employee emp = list.Find(x => x.Id == searchId);

            // Verifica se o funcionário foi encontrado na lista
            if (emp != null)
            {
                // Se o funcionário existir, solicita ao usuário o percentual de aumento
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Chama o método que aumenta o salário do funcionário com o percentual informado
                emp.IncreaseSalary(percentage);
            }
            else
            {
                // Caso o funcionário não seja encontrado, exibe uma mensagem de erro
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");

            // Percorre a lista de funcionários e imprime os dados atualizados de cada um
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
