using ListaFuncionario;
using System;

string cond = "";
List<Funcionario> lista = new List<Funcionario>();

do
{
    Console.Write($"Digite a Matricula do Funcionario: ");
    int matriculaFunc = int.Parse(Console.ReadLine());
    Console.Write($"Digite o nome do Funcionario: ");
    string nomeFunc = Console.ReadLine();
    Console.Write($"Digite o CPF do Funcionario {nomeFunc}: ");
    string cpfFunc = Console.ReadLine();
    Console.Write($"Digite o Dia da data de Nascimento do Funcionario {nomeFunc}: ");
    int dia = int.Parse(Console.ReadLine());
    Console.Write($"Digite o Mês da data de Nascimento do Funcionario {nomeFunc}: ");
    int mes = int.Parse(Console.ReadLine());
    Console.Write($"Digite o Ano da data de Nascimento do Funcionario {nomeFunc}: ");
    int ano = int.Parse(Console.ReadLine());
    DateOnly dataNascFunc = new DateOnly(ano,mes,dia);
    Console.Write($"Digite o salario do Funcionario {nomeFunc}: ");
    double salarioFunc = int.Parse(Console.ReadLine());

    Funcionario cadastro = new Funcionario(
        matriculaFunc,
        nomeFunc,
        cpfFunc,
        salarioFunc,
        dataNascFunc
        );

    lista.Add(cadastro);
    
    Console.WriteLine("Deseja cadastrar novo Funcionario?(s/sim)");
    cond = Console.ReadLine().ToUpper();

} while (cond.Equals("S")|| cond.Equals("SIM"));

int id = 0;
double maior = 0.0;
for (int i = 0; i < lista.Count; i++)
{
    if(lista[i].salario > maior)
    {
        maior = lista[i].salario;
        id = i;
    }
}

Console.WriteLine("O funcionario com Maior Salario:\n" +
    $"*NOME* {lista[id].nome}\n" +
    $"*DATA NASCIMENTO* {lista[id].dataNasc.ToString("dd/MM/yyyy")}\n" +
    $"*SALÁRIO* {lista[id].salario.ToString("C")}");
