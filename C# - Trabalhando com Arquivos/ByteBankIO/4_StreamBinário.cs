using ByteBankIO;
using System.Text;

partial class Program
{

    static void EscritaBinaria()
    {
        using (var fluxoDeArquivo = new FileStream("TestaEscrita.txt", FileMode.Create))
        {
            using (var escritor = new BinaryWriter(fluxoDeArquivo))
            {
                escritor.Write(456);        //Número da Agência
                escritor.Write(546544);     //Número da Conta
                escritor.Write(4000.50);    // Saldo
                escritor.Write("Gustavo Braga");
            }
        }
    }   

    static void LeituraBinaria()
    {
        using (var fluxoDeArquivo = new FileStream("TestaEscrita.txt", FileMode.Open))
        {
            using (var leitor = new BinaryReader(fluxoDeArquivo))
            {
                var agencia = leitor.ReadInt32();
                var numeroConta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo}");

            }
        }
    }

}