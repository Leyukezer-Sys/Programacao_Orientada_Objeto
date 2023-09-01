List<Prova> provas = new List<Prova>();
string cond = "S";
Console.WriteLine("============ Prova ============");
Console.WriteLine("Digite o nome do Aluno: ");
string nome = Console.ReadLine().ToLower();

Prova prova = new Prova(nome);

for (int i = 0; i < 5; i++)
{
    Console.Write($"Resposta da {i + 1}ª Questão do {prova.nomeAluno} (A,B,C,D,E): ");
    char resposta = Convert.ToChar(Console.ReadLine().ToUpper());
    prova.RespostaAluno(resposta);
}

Console.WriteLine($"\n Quantidade de Acertos: {prova.Acertos()}");
Console.WriteLine($"\n Nota do {prova.nomeAluno}: {prova.Nota()}");
prova.maior = prova;
provas.Add(prova);

Console.WriteLine("\nDeseja adicionar outro Aluno? (s/sim)");
cond = Console.ReadLine().ToUpper();

while (cond.Equals("SIM") || cond.Equals("S"))
{
    Console.WriteLine("============ Prova ============");
    Console.WriteLine("Digite o nome do Aluno: ");
    nome = Console.ReadLine().ToLower();

    prova.NovoAluno(nome);

    for (int i = 0; i < 5; i++)
    {
        Console.Write($"Resposta da {i + 1}ª Questão do {prova.nomeAluno} (A,B,C,D,E): ");
        char resposta = Convert.ToChar(Console.ReadLine().ToUpper());
        prova.RespostaAluno(resposta);
    }

    Console.WriteLine($"\n Quantidade de Acertos: {prova.Acertos()}");
    Console.WriteLine($"\n Nota do {prova.nomeAluno}: {prova.Nota()}");
    if (prova.notaAluno > prova.maior.notaAluno)
    {
        prova.maior = prova;
    }
    provas.Add(prova);

    Console.WriteLine("\nDeseja adicionar outro Aluno? (s/sim)");
    cond = Console.ReadLine().ToUpper();
}

Console.WriteLine("======= ALUNO NOTA 10 =======\n" +
    $"🎉🎉 {prova.maior.nomeAluno} 🎉🎉\n" +
    $"---- {prova.maior.notaAluno} Pontos ----");

