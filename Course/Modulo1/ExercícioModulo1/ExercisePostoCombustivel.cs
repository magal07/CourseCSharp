using System;

namespace Course.Modulo1.ExercícioModulo1
{
    class ExercisePostoCombustivel
    {
        static void ExercisePostoDeCombust(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            string input;

            Console.WriteLine("Digite o tipo de combustível (1-Álcool, 2-Gasolina, 3-Diesel) ou 'stop' para encerrar:");

            while (true)
            {
                input = Console.ReadLine();

                if (input.Equals("stop", StringComparison.OrdinalIgnoreCase))
                {
                    break; // Encerra o loop quando "stop" é digitado
                }

                if (int.TryParse(input, out int tipo))
                {
                    if (tipo == 1)
                    {
                        alcool++;
                    }
                    else if (tipo == 2)
                    {
                        gasolina++;

                    }
                    else if (tipo == 3)
                    {
                        diesel++;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida! Digite 1 para Alcool, 2 para Gasolina, 3 para Diesel ou 'stop' para encerrar.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Digite um número (1, 2, 3) ou 'stop'.");
                }
            }

            Console.WriteLine("MUITO OBRIGADO E VOLTE SEMPRE!");
            Console.WriteLine("1. Álcool = " + alcool);
            Console.WriteLine("2. Gasolina = " + gasolina);
            Console.WriteLine("3. Diesel = " + diesel);
        }
    }
}
