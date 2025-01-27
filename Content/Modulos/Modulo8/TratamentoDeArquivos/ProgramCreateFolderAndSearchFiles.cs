using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Course
{
    internal class ProgramCreateFolderAndSearchFiles
    {
        static void ProgramCreatFolder(string[] args)
        {
            string path = @"c:\temp\myfolder";

            try
            {
                // da pra substituir o IEnumerable<string> por var, igual exemplo abaixo 
                /* IEnumerable<string> folders = Directory.EnumerateDirectories
                                    (path, "*.*", SearchOption.AllDirectories); */  // pegar subpastas a partir de uma pasta original
               var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                var files = Directory.EnumerateFiles(path, "*.JPG*", SearchOption.AllDirectories); // buscando files
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newfolder");
            }

            catch(IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}
