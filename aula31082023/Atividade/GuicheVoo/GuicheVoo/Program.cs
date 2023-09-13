Voo passagem;
int quantAcentos = 0;
bool cond = false;
Console.Write("===================================\n" +
    "Digite a quantidade de Acentos que possui o Aviao: ");
string acentos = Console.ReadLine();
if (!int.TryParse(acentos, out quantAcentos))
{
    cond = true;
}
if (quantAcentos > 99 || quantAcentos < 10)
{
    cond = true;
}
while (cond)
{
    Console.Clear();
    cond = false;
    Console.WriteLine("===Digite um Numero válido====");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("!! Não pode ser menor que 10 acentos e o limite é de 99 acentos !!");
    Console.ResetColor();
    Console.WriteLine("Digite a quantidade de Acentos que possui o Aviao: ");
    acentos = Console.ReadLine();
    if (!int.TryParse(acentos, out quantAcentos))
    {
        cond = true;
    }
    if (quantAcentos > 99 || quantAcentos < 10)
    {
        cond = true;
    }
}
passagem = new Voo(2,09,2023,15,quantAcentos);
Console.Write("#Ocupar Acento: ");
int acento = 0;
try
{
    acento = Convert.ToInt32(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine("Apenas Numeros...");
    throw;
}
if (acento < 1 || acento > quantAcentos)
{
    Console.WriteLine("Acento Inválido");
}
else if (passagem.Verifica(acento - 1))
{
    Console.WriteLine("Acento Ocupado");
    Console.WriteLine("Acentos Livre:\n"+passagem.AcentosVoo());
}
else
{
    passagem.Ocupa(acento - 1);
    Console.WriteLine($"\n====== COMPROVANTE ======\n" +
                     $"        Acento {acento}         \n" +
                     $"        Voo {passagem.getNumeroVoo()}      \n" +
                     $"    {passagem.getDataVoo()} - {passagem.getHoraVoo()}\n" +
                     $"==========================");
}


Console.WriteLine("\nAcentos Aviao:\n" + passagem.AcentosVoo() +"\n" +
    $"Quantidade de Acentos Livres: {passagem.Vagas()}");
