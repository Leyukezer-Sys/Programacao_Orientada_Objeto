﻿using ContaBancaria;
using System.Security.Cryptography;


List<Conta> listaContas = new List<Conta>();
Conta contaPrincipal;

Console.WriteLine("------ BANCO BARATO ------");
Console.WriteLine("**PRIMEIRO ACESSO**");
Console.WriteLine("* Cadastro de Nova Conta*");

Console.Write(@"    Digite o Nome do Titular da Conta: ");
string nome = Console.ReadLine().ToUpper();
while (String.IsNullOrWhiteSpace(nome))
{
    Console.WriteLine(@"    !! Digite um nome Válido !!");
    Console.Write(@"    Digite o Nome do Titular da Conta: ");
    nome = Console.ReadLine().ToUpper();
}

Console.Write(@"    Digite a Agencia da Conta: ");
int agencia = 0;
while(!int.TryParse(Console.ReadLine(),out agencia))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(@"    !! Digite apenas numeros !!");
    Console.ResetColor();
    Console.Write(@"    Digite a Agencia da Conta: ");
};

Console.Write(@"    Digite o Numero da Conta: ");
int conta = 0;
while (!int.TryParse(Console.ReadLine(), out conta))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(@"    !! Digite apenas numeros !!");
    Console.ResetColor();
    Console.Write(@"    Digite o Numero da Conta: ");
};

Console.Write(@"    Digite o Saldo Inicial da Conta: ");
double saldo = 0.0;
while (!double.TryParse(Console.ReadLine(),out saldo))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(@"    !! Digite apenas numeros !!");
    Console.ResetColor();
    Console.Write(@"    Digite o Saldo Inicial da Conta: ");
}

contaPrincipal = new Conta(agencia,conta,nome,saldo);
listaContas.Add(contaPrincipal);

int op = -1;
do
{
    Console.Clear();
    Console.WriteLine($"TITULAR DA CONTA PRINCIPAL: {contaPrincipal.getNome()}");
    Console.WriteLine("*Escolha uma opção:\n" +
        "1 - Depositar na Conta Bancaria\n" +
        "2 - Sacar da Conta Bancaria\n" +
        "3 - Transferir Para outra Conta\n" +
        "4 - Mostrar Saldo Da Conta Principal\n" +
        "5 - Cadastrar Nova Conta\n" +
        "6 - Mostrar Contas Cadastradas\n" +
        "7 - Acessar outra Conta\n" +
        "0 - Encerrar Operação (Sair)");
    while (!int.TryParse(Console.ReadLine(), out op))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@"    !! Digite apenas numeros !!");
        Console.ResetColor(); 
        
        Console.Clear();
        Console.WriteLine("*Escolha uma opção:\n" +
        "1 - Depositar na Conta Bancaria\n" +
        "2 - Sacar da Conta Bancaria\n" +
        "3 - Transferir Para outra Conta\n" +
        "4 - Mostrar Saldo Da Conta Principal\n" +
        "5 - Cadastrar Nova Conta\n" +
        "6 - Mostrar Contas Cadastradas\n" +
        "7 - Acessar outra Conta\n" +
        "0 - Encerrar Operação (Sair)");
    };

    if (op == 1)
    {
        Console.Write("*Digite o Valor do Depósito: ");
        double deposito = double.Parse(Console.ReadLine());
        contaPrincipal.Depositar(deposito);
        Console.ReadKey();  
    }
    if (op == 2)
    {
        Console.Write("*Digite o Valor do Saque: ");
        double saque = double.Parse(Console.ReadLine());
        contaPrincipal.Sacar(saque);
        Console.ReadKey();
    }
    if (op == 3)
    {
        //Tranferencia
    }
    if (op == 4)
    {
        Console.WriteLine($"*Nome do Titular: {contaPrincipal.getNome()}");
        Console.WriteLine($"*Agencia da Conta: {contaPrincipal.getAgencia()}");
        Console.WriteLine($"*Número da Conta: {contaPrincipal.getConta()}");
        Console.Write($"*Saldo: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(contaPrincipal.getSaldo().ToString("C"));
        Console.ResetColor(); 
        Console.ReadKey();
    }
    if (op == 5)
    {
        string cond = "";
        do
        {
            Console.WriteLine("* Cadastro de Nova Conta*");
            Console.Write(@"    Digite o Nome do Titular da Conta: ");
            string nomeSec = Console.ReadLine().ToUpper();

            Console.Write(@"    Digite a Agencia da Conta: ");
            int agenciaSec = int.Parse(Console.ReadLine());

            Console.Write(@"    Digite o Numero da Conta: ");
            int contaSec = int.Parse(Console.ReadLine());

            Console.Write(@"    Digite o Saldo Inicial da Conta: ");
            double saldoSec = double.Parse(Console.ReadLine());

            Conta contaSecundaria = new Conta(agenciaSec, contaSec, nomeSec, saldoSec);
            listaContas.Add(contaSecundaria);

            Console.WriteLine("Deseja Cadastrar nova Conta? (s/sim)");
            cond = Console.ReadLine().ToUpper();
        } while (cond.Equals("S")||cond.Equals("SIM"));
    }
    if (op == 6)
    {
        foreach (Conta contas in listaContas)
        {
            Console.WriteLine("------");
            Console.WriteLine($"*Nome do Titular: {contas.getNome()}");
            Console.Write($"*Saldo: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(contas.getSaldo().ToString("C"));
            Console.ResetColor();
            Console.WriteLine(" ");
        }
        Console.ReadKey();
    }
    if (op == 7)
    {
        Console.WriteLine("==== ACESSAR OUTRA CONTA ====");
        Console.Write("**Digite a Agencia de Acesso: ");
        while (!int.TryParse(Console.ReadLine(), out agencia))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"    !! Digite apenas numeros !!");
            Console.ResetColor();
            Console.Write("**Digite a Agencia para o Acesso: ");
        };

        Console.Write("**Digite o Numero da Conta para o Acesso: ");
        while (!int.TryParse(Console.ReadLine(), out conta))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"    !! Digite apenas numeros !!");
            Console.ResetColor();
            Console.Write("**Digite o Numero da Conta para o Acesso: ");
        };

        foreach (Conta contas in listaContas)
        {
            if (agencia == contas.getAgencia() && conta == contas.getConta())
            {
                contaPrincipal = contas;
                Console.WriteLine("Acesso Realizado com sucesso!");
                Console.ReadKey();
            }
        }
    }
} while (op != 0);