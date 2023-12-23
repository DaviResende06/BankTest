using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTest
{
    public class ContaCorrente
    {
        public string DadosCompletoDaContaCorrente => $"Titular: {Titular}, Agência: {Agencia}, Numero: {Numero}, Saldo: {Saldo}";
        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }


    }
}
