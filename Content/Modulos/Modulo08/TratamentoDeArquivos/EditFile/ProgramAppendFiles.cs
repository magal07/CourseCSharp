using Content.Modulos.Modulo10.ComparcaoGetHashCode.Entities;
using Course.Entities; // Importa a classe Product do namespace Course.Entities
using System;
using System.Globalization;
using System.IO; // Biblioteca necessária para manipulação de arquivos

namespace Course
{
    class ProgramAppendFiles
    {
        static void AppendFiles(string[] args)
        {
            // Solicita ao usuário o caminho completo do arquivo de origem
            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                // Lê todas as linhas do arquivo especificado pelo usuário
                string[] lines = File.ReadAllLines(sourceFilePath);

                // Obtém o diretório do arquivo de origem
                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                // Define o diretório de destino como uma subpasta chamada "out"
                string targetFolderPath = sourceFolderPath + @"\out";
                // Define o caminho completo do arquivo de saída chamado "summary.csv"
                string targetFilePath = targetFolderPath + @"\summary.csv";

                // Cria a pasta "out" caso ainda não exista
                Directory.CreateDirectory(targetFolderPath);

                // Abre o arquivo para escrita no modo de adição (append), garantindo que novos dados sejam adicionados sem apagar os existentes
                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    // Percorre todas as linhas do arquivo de entrada
                    foreach (string line in lines)
                    {
                        // Divide a linha em partes separadas por vírgula
                        string[] fields = line.Split(',');
                        string name = fields[0]; // Nome do produto
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture); // Preço do produto
                        int quantity = int.Parse(fields[2]); // Quantidade do produto

                        // Cria um objeto Product com os dados extraídos
                        Product prod = new Product(name, price, quantity);

                        // Escreve no arquivo de saída o nome do produto e o valor total formatado com duas casas decimais
                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                // Captura e exibe mensagens de erro relacionadas à manipulação de arquivos
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
