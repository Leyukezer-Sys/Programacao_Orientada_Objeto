Voo passagem;
int quantAcentos = 0;
bool cond = false;
string resp = "N";
Console.Write("===================================\n" +
    "Digite a quantidade de Acentos que possui o Aviao: ");
string acentos = Console.ReadLine();
if (!int.TryParse(acentos, out quantAcentos))
{
    cond = true;
}
if (quantAcentos > 999 || quantAcentos < 10)
{
    cond = true;
}
while (cond)
{
    Console.Clear();
    cond = false;
    Console.WriteLine("===Digite um Numero válido====");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("!! Não pode ser menor que 10 acentos e o limite é de 999 acentos !!");
    Console.ResetColor();
    Console.WriteLine("Digite a quantidade de Assentos que possui o Aviao: ");
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
Console.Write("Digite o dia do Voo: ");
int diaVoo = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o Mês do Voo (Exem: 1 - Janeiro): ");
int mesVoo = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o Ano do Voo: ");
int anoVoo = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o Horário do Voo (00 á 23): ");
int horarioVoo = Convert.ToInt32(Console.ReadLine());

passagem = new Voo(diaVoo, mesVoo, anoVoo, horarioVoo, quantAcentos);

do
{
    cond = true;
    Console.WriteLine($"====== GUICHÊ VOO {passagem.getNumeroVoo()} ======\n" +
                      $"Escolha:\n" +
                      $"1 - Ocupar Assento(s)\n" +
                      $"2 - Verificar Assento\n" +
                      $"3 - Assentos Livres\n" +
                      $"0 - Sair");
    Console.Write("R:. ");

    int op = Convert.ToInt32(Console.ReadLine());
    if (op > 0 || op < 4)
    {
        if (op == 1)
        {
            string ocupAsesn = "N";
            do
            {
                Console.Write("Digite a quantidade de assentos que deseja ocupar: ");
                int quantAssentOcu = Convert.ToInt32(Console.ReadLine());
                if (quantAssentOcu > passagem.Vagas())
                {
                    Console.WriteLine("Assentos Esgotadas!");
                }
                else
                {

                    Console.Write("Digite o assento que deseja ocupar: ");
                    int assento = Convert.ToInt32(Console.ReadLine());
                    if (assento < 1 || assento > quantAcentos)
                    {
                        Console.WriteLine("Assento Inválido");
                    }
                    else if (passagem.Verifica(assento - 1))
                    {
                        Console.WriteLine("Assento Ocupado");
                        Console.WriteLine("Assentos Livre:\n" + passagem.AcentosVoo());
                    }
                    else
                    {
                        if (quantAssentOcu > 1)
                        {
                            string assentos = "";
                            passagem.Ocupa(assento - 1);
                            assentos += Convert.ToString(assento);
                            for (int i = 0; i < (quantAssentOcu - 1); i++)
                            {
                                passagem.Ocupa(passagem.ProximoLivre(assento - 1));
                                assentos += ", " + Convert.ToString(passagem.ProximoLivre(assento - 1));
                            }
                            Console.WriteLine($"\n====== COMPROVANTE ======\n" +
                                             $"        Assento {assentos}         \n" +
                                             $"        Voo {passagem.getNumeroVoo()}      \n" +
                                             $"    {passagem.getDataVoo()} - {passagem.getHoraVoo()}\n" +
                                             $"==========================");
                        }
                        else
                        {
                            passagem.Ocupa(assento - 1);
                            Console.WriteLine($"\n====== COMPROVANTE ======\n" +
                                             $"        Assento {assento}         \n" +
                                             $"        Voo {passagem.getNumeroVoo()}      \n" +
                                             $"    {passagem.getDataVoo()} - {passagem.getHoraVoo()}\n" +
                                             $"==========================");
                        }
                    }
                }
                Console.WriteLine("\nDeseja realizar nova Ocupação de Assento(s)?");
                ocupAsesn = Console.ReadLine().ToUpper();
            } while (ocupAsesn.Equals("S") || ocupAsesn.Equals("SIM"));

        }
        if (op == 2)
        {
            Console.Write("Digite o assento que deseja Verificar: ");
            int assento = Convert.ToInt32(Console.ReadLine());
            if (passagem.Verifica(assento - 1))
            {
                Console.WriteLine("Assento Ocupado!");
            }
            else
            {
                Console.WriteLine("Assento Livre");
            }
        }
        if (op == 3)
        {
            Console.WriteLine("\nAssentos Aviao:\n" + passagem.AcentosVoo() + "\n" +
                $"Quantidade de Assentos Livres: {passagem.Vagas()}");

        }
        if (op == 0)
        {
            cond = false;
        }
    }
    else
    {
        Console.WriteLine("!! Escolha Inválida !!");
    }
    if (cond == true)
    {
        Console.WriteLine("\nRetornar ao Menu do Voo " + passagem.getNumeroVoo() + "?");
        resp = Console.ReadLine().ToUpper();
    }

} while (resp.Equals("S") || resp.Equals("SIM"));
