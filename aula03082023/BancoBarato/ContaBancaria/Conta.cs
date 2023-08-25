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
        private Titular titular;
        private int agencia, conta;
        private string historico = "========= MOVIMENTAÇÃO =========";
        private double saldo;

        public Conta(string nome, string cpf, string email, int agencia, int conta, double saldo)
        {
            setAgencia(agencia);
            setConta(conta);
            setTitular(nome, cpf, email);           
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
        public void setTitular(string nome, string cpf, string email)
        {
            Titular titularConta = new Titular(nome, cpf, email);
            this.titular = titularConta;
        }
        public void setTitular(Titular titularConta)
        {
            this.titular = titularConta;
        }
        public void setSaldo(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Saldo Inválido");
            }
            else this.saldo = valor;
        }
        public void setHistórico(string descri,string sinal, double valor)
        {
            this.historico += $"\n" +
                $"** {descri}\n" +
                $"*** VALOR: R$ {sinal}{valor.ToString("N2")}" +
                "\n================================";
        }
        public int getAgencia()
        {
            return this.agencia;
        }
        public int getConta()
        {
            return this.conta;
        }
        public Titular getTitular()
        {
            return this.titular;
        }
        public double getSaldo()
        {
            return this.saldo;
        }
        public string getHistorico()
        {
            return this.historico;
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
                setHistórico($"Transferencia de {getTitular().getNome()}", "+", valor);
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
                    setHistórico($"Transferencia para {getTitular().getNome()}", "-", valor);
                }
            }else Console.WriteLine("Valor Não pode ser Negativo");
        }
        public override string ToString()
        {
            return $"{this.agencia}|{this.conta}|{this.titular}|{this.saldo}";
        }
    }
}
