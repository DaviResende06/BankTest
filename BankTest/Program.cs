using System;

namespace BankTest;
class Program
{
    static void Main(string[] args)
    {

        ContaCorrente contaN1 = new(863, 1234567, 1000.00);             //primeira conta
        Cliente cliente1 = new("123.456.789-10");
        cliente1.Nome = "Davi";
        contaN1.DepositarDinheiro(500);                                 //depositar dinheiro
        contaN1.SacarDinheiro(200);                                     //sacar dinheiro

        Console.WriteLine($"Saldo do {cliente1.Nome}: {contaN1.ObterSaldo()}");    //obter saldo conta n1

        ContaCorrente contaN2 = new(777, 9876543, 1000.00);             //segunda conta
        Cliente cliente2 = new("987.654.321-10");
        cliente2.Nome = "Arthur";
        contaN2.DepositarDinheiro(1000);                                // depositar dinheiro

        Console.WriteLine($"Saldo do {cliente2.Nome}: {contaN2.ObterSaldo()}");  //obter saldo conta n2

        contaN1.TranferirDinheiro(900, contaN2);                        //Tranferir saldo de Davi para Arthur.


        Console.WriteLine($"\nSaldo do {cliente1.Nome} após tranferência : {contaN1.ObterSaldo()}");
        Console.WriteLine($"Saldo do {cliente2.Nome} após tranferência : {contaN2.ObterSaldo()}");


        Console.WriteLine($"\nTotal de contas criadas: {ContaCorrente.TotalDeContasCriada}");  // para saber o Total de Contas criadas

    }   
}
  