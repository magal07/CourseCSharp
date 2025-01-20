using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo3.Content
{
    internal class List
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); // Criando uma lista vazia 

            // ADD: Adicionar
            // INSERT: Adicionar informando a posição, igual no SQL Server, lembrando que a conta inicia-se em 0
            // COUNT: Contar membros da lista
            //FIND OU FINDLAST: Encontrar o primeiro ou ultimo elemento da lista que satisfaça um predicado
            // PREDICADO É UMA FUNÇÃO QUE PEGA O VALOR, E VAI RETORNAR VERDADEIRO OU FALSO CONFORME A LÓGICA QUE ESTIVER IMPLEMENTADO NESTA FUNÇÃO
            // LAMBDA: EXPRESSÃO ANÔNIMA, FORMA SIMPLES DE DEFINIR UMA EXPRESSÃO

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco");


            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List Count: " + list.Count);

            Console.WriteLine("---------------");

            string s1 = list.Find(x => x[0] == 'A'); //forma de leitura:  Eu quero que o Objeto X, tal que x na posição [0] , seja = ao caractér 'A' 
                                                     // outra forma de leitura: Dado o string x, eu vou querer que a condição seja que o primeiro caracter de x[0] seja igual == a 'A'.


  /* MODELO DE CRIAÇÃO DE BUSCA, SUBSTITUIDO POR UM PROCEDIMENTO LAMBDA BEM MAIS COMPACTO E SIMPLÓRIO
            string s1 = list.Find(Test);

                Console.WriteLine("Primeiro cara que começa com a letra A: " + s1);
        }
        static bool Test(string s)
            {
                return s[0] == 'A'; // Define o parâmetro de busca */ 
            Console.WriteLine("First 'A': " + s1);


            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("LAST 'A': " + s2);


            // BUSCA FIRST E LAST usando o FindIndex

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First Position 'A': " + pos1); // first

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position 'A': " + pos2); // last

            // filtrar lista com base em um predicado, neste modelo, quero somente nomes == 5 caracteres, pode-se usar <= >= , .. 

            Console.WriteLine("-------------");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine(list2);

            foreach(string obj in list2)
            {
                Console.WriteLine("Filtro para nomes com 5 caracteres: " + obj);
            }

            // filtrar e remover "Alex" da list: SE NÃO ENCONTRAR NADA EXATAMENTE IGUAL, ELE NÃO FARÁ NADA

            /*
            list.RemoveRange(2, 2); // quero remover a partir da posição 2, 2 elementos, logo sobra somente maria, alex e ana
            Console.WriteLine("-------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            */

            list.Remove("Alex"); 
            Console.WriteLine("-------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

             /* Remover o string da posição 2 da lista, lembrando que acabei de remover 1 acima "ALEX" 

           list.RemoveAt(2);
            Console.WriteLine("-------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            } */
            
            // filtrar e remover nomes que começam com M da list


            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);

            }

        }
    }
}
