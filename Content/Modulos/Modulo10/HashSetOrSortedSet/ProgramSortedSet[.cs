using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class ProgramABC10
    {
        static void Main(string[] args)
        {

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 } ; // instanciando coleção
            SortedSet<int> b = new SortedSet<int>() { 5, 6 ,7 ,8 ,9, 10 } ; // instanciando coleção

            PrintCollection(a); // organizado pelo IEnumerable
       

            SortedSet<int> c = new SortedSet<int>(a); // meu conjunto c também terá todos elementos do conjunto a
            // union
            c.UnionWith(b); // vou inserir dentro do c, todos os elementos de b que já estejam em c, sem repetição
            PrintCollection(c);

            // intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b); // intersecção dos elemntos de A e B (SE MANDAR IMPRIMIR, VAI APARECER OS ELENTOS QUE EXISTEM NOS DOIS CONJUNTOS.
            PrintCollection(d);

            // DIFERENCE

            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b); // elementos de A, excluidos elementos que tinham no B (EXCETO)
            PrintCollection(e);

        }

        static void PrintCollection<T>(IEnumerable<T> collection) // vai buscar o Enumerator do IEnumerable que dentro da função tem um GetEnumerator
        {
            foreach(T obj in collection)
            {
                Console.Write(obj + " ");
            }

            Console.WriteLine();
        }

    }
}
