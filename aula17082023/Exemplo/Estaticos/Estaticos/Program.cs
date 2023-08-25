using Estaticos;

Console.WriteLine("Hello, World!");

if (Validacao.ValidarCpf("058 .570.652-24 "))
{
    Console.WriteLine("CPF VÁLIDO!");
}
else
{
    Console.WriteLine("CPF INVÁLIDO!");
}
