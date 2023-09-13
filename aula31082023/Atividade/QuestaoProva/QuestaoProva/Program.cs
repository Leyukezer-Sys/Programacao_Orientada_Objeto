string cond = "S";
Prova prova;

Console.WriteLine("============ Prova ============");
Console.WriteLine("Digite o nome do Aluno: ");
string nome = Console.ReadLine().ToLower();

prova = new Prova(nome);

for (int i = 0; i < 5; i++)
{
    Console.Write($"Resposta da {i + 1}ª Questão do {prova.nomeAluno} (A,B,C,D,E): ");
    char resposta = Convert.ToChar(Console.ReadLine().ToUpper());
    prova.RespostaAluno(resposta);
}

Console.WriteLine($"\n Quantidade de Acertos: {prova.Acertos()}");
Console.WriteLine($"\n Nota do {prova.nomeAluno}: {prova.Nota()}");

prova.maior = prova;

Console.WriteLine("\nDeseja adicionar outro Aluno? (s/sim)");
cond = Console.ReadLine().ToUpper();

while (cond.Equals("SIM") || cond.Equals("S"))
{
    Console.WriteLine("============ Prova ============");
    Console.WriteLine("Digite o nome do Aluno: ");
    nome = Console.ReadLine().ToLower();
    prova = new Prova(nome, prova.maior);

    for (int i = 0; i < 5; i++)
    {
        Console.Write($"Resposta da {i + 1}ª Questão do {prova.nomeAluno} (A,B,C,D,E): ");
        char resposta = Convert.ToChar(Console.ReadLine().ToUpper());
        prova.RespostaAluno(resposta);
    }

    Console.WriteLine($"\n Quantidade de Acertos: {prova.Acertos()}");
    Console.WriteLine($"\n Nota do {prova.nomeAluno}: {prova.Nota()}");

    prova.Maior();

    Console.WriteLine("\nDeseja adicionar outro Aluno? (s/sim)");
    cond = Console.ReadLine().ToUpper();
}

Console.WriteLine("======= ALUNO NOTA 10 =======\n" +
    $"!!!!!! {prova.maior.nomeAluno} !!!!!!\n" +
    $"---- {prova.maior.Nota()} Pontos ----");

Console.ReadKey();

