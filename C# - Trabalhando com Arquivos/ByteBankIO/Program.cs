using ByteBankIO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {

        //Console.WriteLine("Digite o Seu Nome");
        //var nome = Console.ReadLine();

        var linhas = File.ReadAllLines("contas.txt");
        Console.WriteLine(linhas.Length);

        foreach (var linha in linhas)
        {
            Console.WriteLine(linha);
        }

        var bytesArquivo = File.ReadAllBytes("contas.txt");
        Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

        File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WritallAllText");

        Console.WriteLine("Aplicação Finalizada...");

        Console.ReadLine();
    }
    

}