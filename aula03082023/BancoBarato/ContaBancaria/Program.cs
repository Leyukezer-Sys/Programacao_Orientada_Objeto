using ContaBancaria;

List<Conta> listaContas = new List<Conta>();

Console.WriteLine("------ BANCO BARATO ------");
Console.WriteLine("**PRIMEIRO ACESSO**");
Console.WriteLine("* Cadastro de Nova Conta*");
Console.Write(@"    Digite o Nome do Titular da Conta: ");
string nome = Console.ReadLine().ToUpper();

Console.Write(@"    Digite a Agencia da Conta: ");
int agencia = int.Parse(Console.ReadLine());

Console.Write(@"    Digite o Numero da Conta: ");
int conta = int.Parse(Console.ReadLine());

Console.Write(@"    Digite o Saldo Inicial da Conta: ");
double saldo = double.Parse(Console.ReadLine());

Conta contaPrincipal = new Conta(agencia,conta,nome,saldo);
int op = -1;

listaContas.Add(contaPrincipal);

do
{
    Console.Clear();
    Console.WriteLine("*Escolha uma opção:\n" +
        "1 - Depositar na Conta Bancaria\n" +
        "2 - Sacar da Conta Bancaria\n" +
        "3 - Mostrar Saldo Da Conta\n" +
        "4 - Cadastrar Nova Conta\n" +
        "5 - Mostrar Contas Secundarias\n" +
        "0 - Encerrar Operação (Sair)");
    op = int.Parse(Console.ReadLine());

    if (op == 1)
    {
        Console.Write("*Digite o Valor do Depósito: ");
        double deposito = double.Parse(Console.ReadLine());
        contaPrincipal.Depositar(deposito);
        Console.WriteLine($"Saldo Atual: {contaPrincipal.saldo.ToString("C")}");
        Console.ReadKey();  
    }
    if (op == 2)
    {
        Console.Write("*Digite o Valor do Saque: ");
        double saque = double.Parse(Console.ReadLine());
        contaPrincipal.Sacar(saque);
        Console.WriteLine($"Saldo Atual: {contaPrincipal.saldo.ToString("C")}");
        Console.ReadKey();
    }
    if (op == 3)
    {
        Console.WriteLine($"{contaPrincipal.saldo.ToString("C")}");
        Console.ReadKey();
    }
    if (op == 4)
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
    if (op == 5)
    {
        foreach (Conta contas in listaContas)
        {
            Console.WriteLine("------");
            Console.WriteLine($"*Nome do Titular: {contas.nome}\n" +
                              $"*Saldo: {contas.saldo.ToString("C")}");
        }
        Console.ReadKey();
    }
} while (op != 0);

