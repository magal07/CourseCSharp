using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// O namespace "System" está sendo utilizado, o que não é recomendado para extensões personalizadas, pois pode gerar conflitos, mas afins educativos, coloquei por participar do CUT
namespace System
{
    static class StringExtensions
    {
        // Método de extensão para cortar uma string após um determinado número de caracteres
        public static string Cut(this string thisObj, int count)
        {
            // Se o tamanho da string for menor ou igual ao valor de "count", retorna a string original
            if (thisObj.Length <= count)
            {
                return thisObj;
            }
            else
            {
                // Se a string for maior que "count", retorna apenas os primeiros "count" caracteres, adicionando "..."
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}
