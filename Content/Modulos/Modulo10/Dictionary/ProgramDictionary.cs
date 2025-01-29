using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class ProgramDictionary
    {
        static void DictionaryTKEYandTVALUE(string[] args)
        {
            //TKEY e TVALUE
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail";
            cookies["phone"] = "9991211";
            cookies["phone"] = "123123123";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no email key");
            }

            Console.WriteLine("Size: " + cookies.Count);
            Console.WriteLine("All cookies: ");


            //foreach(KeyValuePair<string, string> item in cookies) // pra cada item KeysValuePair<string..> dentro do meu cookies, IMPRIMA! OU...
            foreach (var item in cookies)
            {
                {
                    Console.WriteLine(item.Key + ": " + item.Value); // pra acessar a chave item.Key, pra acessar os valores item.Value
                }
            }
        }
    }
}
