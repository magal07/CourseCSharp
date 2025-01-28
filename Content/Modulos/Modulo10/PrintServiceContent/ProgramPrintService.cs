using System;
using System.Collections.Generic;
using System.Data;
using Course.Entities;


namespace Course
{
    internal class ProgramPrintService
    {
        static void PServiceContent(string[] args)
        /* BRINCADEIRA
    {

        List<string> list = new List<string>();

        list.Add("Teste");
        list.Add("Teste2");

        string name = list[0];

        foreach (string s in list)
        {
            Console.WriteLine(s);

        } */
        {

            PrintService<int> printService = new PrintService<int>(); // o PrintService será agora printService
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);  // armazenando o valor x dentro do printService
            }

            printService.Print();
            Console.WriteLine("First: " + printService.FirstElement());
        }
    }
}
