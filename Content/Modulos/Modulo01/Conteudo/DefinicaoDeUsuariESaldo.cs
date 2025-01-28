using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.ModulosDeEstudo.Modulo1.Conteudo
{
    class DefinicaoDeUsuariESaldo
    {
        static void ConcetanandoEInterpolando(string[] args)
        {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); // modelo com interpolar


            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString
                             ("F2", CultureInfo.InvariantCulture) + " reais"); // + = concatenar


        }
    }

}

