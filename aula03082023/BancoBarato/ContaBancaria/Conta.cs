using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Conta
    {
        private int agencia, conta;
        private string nome;
        private double saldo;

        public Conta(int agencia, int conta, string nome, double saldo)
        {
            setAgencia(agencia);
            setConta(conta);
            setNome(nome);           
            setSaldo(saldo);
        }
        public void setAgencia(int numero)
        {
            this.agencia = numero;
        }
        public void setConta(int numero)
        {
            this.conta = numero;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
            // throw new Exception("");
        }
        public void setSaldo(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Saldo Inválido");
            }
            else this.saldo = valor;
        }
        public int getAgencia()
        {
            return this.agencia;
        }
        public int getConta()
        {
            return this.conta;
        }
        public string getNome()
        {
            return this.nome;
        }
        public double getSaldo()
        {
            return this.saldo;
        }
        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor Informado não pode ser Negativo.");
            }
            else
            {
                this.saldo += valor;
                Console.WriteLine("Depósito Realizado com Sucesso!");
                Console.Write($"*Saldo Atual: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(this.saldo.ToString("C"));
                Console.ResetColor();
            }
        }
        public void Sacar(double valor)
        {
            if (valor > 0)
            {
                if (valor > saldo)
                {
                    Console.WriteLine("Valor Solicitado é Maior que o Saldo da Conta.");
                }
                else
                {
                    this.saldo -= valor;
                    Console.WriteLine("Saque Realizado com Sucesso!");
                    Console.Write($"*Saldo Atual: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(this.saldo.ToString("C"));
                    Console.ResetColor();
                }
            }else Console.WriteLine("Valor Não pode ser Negativo");
        }
        public override string ToString()
        {
            return $"{this.agencia}|{this.conta}|{this.nome}|{this.saldo}";
        }
    }
}
