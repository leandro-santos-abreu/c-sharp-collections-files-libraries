using ByteBankIO;
using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportas.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
        {
            var contaComoString = "456, 7895, 4785.40, Gustavo Santos";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(contaComoString);

            fluxoDeArquivo.Write(bytes, 0, bytes.Length);
        }
    }

    static void CriarArquivComWriter()
    {
        var caminhoNovoArquivo = "contasExportas.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.Write("456, 65465, 456.0, Pedro");
            }
        }
    }

    static void TesteEscrita()
    {
        var caminhoNovoArquivo = "teste.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {

                for (int i = 0; i < 1000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    escritor.Flush();

                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter...");
                    Console.ReadLine();
                }
            }
        }
    }

}