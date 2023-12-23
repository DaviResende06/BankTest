using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTest
{
    public class Cliente
    {
        public string DadosCompletoDoCliente => $"Nome: {Nome}, CPF: {CPF}, Profissão: {Profissao}"; //Concatenando os campos 
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        public Cliente(string cpf)          // construtor para o tipo cliente, teoricametne através do cpf é possível adiquirir a maioria dos dados do cliente
        { 
            CPF = cpf;
        }
    }
}
