using Estaticos;

Console.Write("Digite um CPF: ");
string cpfUsuario = Console.ReadLine().ToLower();

if (Validacao.ValidarCpf(cpfUsuario))
{
    Console.WriteLine("CPF VÁLIDO!");
}
else
{
    Console.WriteLine("CPF INVÁLIDO!");
}
