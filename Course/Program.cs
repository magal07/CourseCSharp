using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string diretorioRaiz = @"C:\Temp\CRV_01";

        // Verifica se a pasta raiz existe
        if (!Directory.Exists(diretorioRaiz))
        {
            Console.WriteLine("A pasta raiz não foi encontrada. Verifique o caminho.");
            return;
        }

        Console.WriteLine($"🔍 Buscando LOTEs em: {diretorioRaiz}");

        // Percorre cada LOTE-XXXXX dentro do diretório raiz
        foreach (string lote in Directory.EnumerateDirectories(diretorioRaiz, "LOTE-*"))
        {
            Console.WriteLine($"\n📂 Processando pasta LOTE: {lote}");
            string pasta00 = Path.Combine(lote, "00");

            if (Directory.Exists(pasta00))
            {
                Console.WriteLine($"   📁 Encontrada pasta 00 dentro de {lote}");

                foreach (string subpasta in Directory.EnumerateDirectories(pasta00))
                {
                    Console.WriteLine($"      🔍 Verificando subpasta: {subpasta}");

                    // Obtém arquivos .JPG e .TIF (independente de maiúsculas e minúsculas)
                    var arquivos = Directory.EnumerateFiles(subpasta)
                        .Where(f => f.EndsWith(".JPG", StringComparison.OrdinalIgnoreCase) ||
                                    f.EndsWith(".TIF", StringComparison.OrdinalIgnoreCase))
                        .ToList();

                    if (!arquivos.Any())
                    {
                        Console.WriteLine($"      ⚠ Nenhum arquivo .JPG ou .TIF encontrado em {subpasta}");
                    }

                    foreach (string arquivo in arquivos)
                    {
                        string nomeArquivo = Path.GetFileName(arquivo);
                        string destino = Path.Combine(lote, nomeArquivo);

                        try
                        {
                            File.Move(arquivo, destino, true); // Mover (sobrescrevendo se necessário)
                            Console.WriteLine($"      ✅ Movido: {arquivo} → {destino}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"      ❌ Erro ao mover {arquivo}: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine($"   ❌ A pasta '00' não foi encontrada em {lote}");
            }
        }

        Console.WriteLine("\n🚀 Transferência concluída. Chupa Léo");
    }
}
