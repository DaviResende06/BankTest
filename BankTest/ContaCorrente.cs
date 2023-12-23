using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTest;

public class ContaCorrente
{
    public string DadosCompletoDaContaCorrente => $"Titular: {Titular}, Agência: {Agencia}, Numero: {Numero}, Saldo: {Saldo}"; //Concatenando os campos 
    public static int TotalDeContasCriada{ get; set; } // Para saber quantas contas correntes foram criadas
    public Cliente Titular { get; set; }     
    public int Agencia { get; set; }
    public int Numero { get; set; }

    private double _saldo;
    public double Saldo                         //opção para que não sejá possível atribuir saldo negativo à conta do banco
    {
        get
        {
            return _saldo;
        }
        set
        {
            if(value < 0)
            {
                return;
            }
            else
            {
                _saldo = value;
            }
        }
    }

    public ContaCorrente(int agencia, int numero, double saldo)    //construtor com algumas obrigações de dados
    {
        Agencia = agencia;
        Numero = numero;
        Saldo = saldo;
        TotalDeContasCriada++;
    }

    public double ObterSaldo()             //função para me retornar o meu saldo 
    {
        return _saldo;
    }

    public bool SacarDinheiro(double valor)       //função para sacar um valor da conta que não seja menor que o saldo para não dar divergência
    {
        if(_saldo < valor)
        {
            return false;
        }
        else
        {
            _saldo -= valor;
            return true;
        }
    }

    public void DepositarDinheiro(double valor)         //método para depositar valor desejado
    {
        Saldo += valor;
    }

    public bool TranferirDinheiro(double valor, ContaCorrente destinatario)  //função para transferir de um aconta para outra, obrigando a colocar um valor e o destino
    {
        if(_saldo < valor)
        {
            return false;
        }
        else
        {
            _saldo -= valor;
            destinatario.DepositarDinheiro(valor);   //usando o método Depositar 
            return true;
        }
    }

}
