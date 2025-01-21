using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo4.Sintaxes
{
    internal class FuncoesStrings
    {
        static void Main(string[] args)
        {

            // funções do string : 

            // DEIXAR TUDO MAIÚSCULA ou MINÚSCULA: ToUpper ToLower

            string original = "abcde FGHIJ ABC abc DEFG   ";

            string s1 = original.ToUpper(); // maiúscula
            string s2 = original.ToLower(); // minúscula
            string s3 = original.Trim(); // remover espaços

            int n1 = original.IndexOf("bc"); // vai buscar a primeira string 'bc'
            int n2 = original.LastIndexOf("bc"); // vai buscar a última string 'bc'

            string s4 = original.Substring(3); // cortou a partir da posição d q era o 3 em diante.
            string s5 = original.Substring(3, 5); // começar na posição 3, mas vou cortar apenas 5 caracteres (imprimirá 5 caracteres a partir da 3ª position)

            string s6 = original.Replace('a', 'x'); // substitui um caracter ou substitui uma string (trocará todo 'a' por um 'x'
            string s7 = original.Replace("abc", "xy"); // trocou todos abc por xy

            bool b1 = String.IsNullOrEmpty(original); // testa se a variável original tem conteúdo NULL ou VAZIO = Empty, neste caso vai dar false, pois tem conteúdo
            bool b2 = String.IsNullOrWhiteSpace(original); // vai testar se a variável é nulla ou se é um monte de espaço em branco 

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("-------------");
            Console.WriteLine("ToUpper: -" + s1);
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc): " + n1);
            Console.WriteLine("LastIndexOf('bc): " + n2);
            Console.WriteLine("Substring(3): " + s4);
            Console.WriteLine("Substring(3,5): " + s5);
            Console.WriteLine("Replace 'a' por 'x': " + s6);
            Console.WriteLine("Replace 'abc' por 'xy': " + s7);
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);










        }
    }
}
