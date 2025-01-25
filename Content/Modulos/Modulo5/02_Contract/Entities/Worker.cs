using Course.Entities.Enums;
using System.Diagnostics.Contracts;
using System.Collections.Generic;

namespace Course.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }
        public Worker(string name, WorkerLevel level, double baseSalary, Department departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = departament;
        }

        // MÉTODOS: em AddContract, estou: 

        public void AddContract(HourContract contract) // criando o método, (acessando a lista de propriedades HourContract)
        {
            Contracts.Add(contract); // Buscando a list contracts e Add (contrato(s))
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts) // para cada HourContract contract, na minha lista de contratos
            {
                if (contract.Date.Year == year // se o ano do meu contrato for igual ao ano que eu recebi como argumento
                    && contract.Date.Month == month) // e também o mês do contrato for igual a este mês, significa que este contrato retornará e entrará na soma
                {
                    sum += contract.TotalValue(); // soma, recebe ela mesma + o contrato.TotalValue = (que é a operação que retorna o valor do contrato)
                }
            }
            return sum;
        }
    }
}
