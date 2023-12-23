using System;

namespace BankTest;
class Program
{
    static void Main(string[] args)
    {
        ContaCorrente conta = new();
        conta.Titular = "davi";
        conta.Agencia = 863;
        conta.Numero = 12345676;
        conta.Saldo = 5000.00;

        Console.WriteLine(conta.DadosCompletoDaContaCorrente);
    }
}