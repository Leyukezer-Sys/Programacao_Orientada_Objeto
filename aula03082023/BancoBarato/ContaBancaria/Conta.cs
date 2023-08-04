using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Conta
    {
        public int agencia, conta;
        public string nome;
        public double saldo;

        public Conta(int agencia, int conta, string nome, double saldo)
        {
            this.agencia = agencia;
            this.conta = conta;
            this.nome = nome;
            this.saldo = saldo;
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor Informado não pode ser Negativo.");
            }
            else
            {
                saldo += valor;
                Console.WriteLine("Depósito Realizado com Sucesso!");
            }
        }
        public void Sacar(double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Valor Solicitado é Maior que o Saldo da Conta.");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine("Saque Realizado com Sucesso!");
            }
        }
    }
}
