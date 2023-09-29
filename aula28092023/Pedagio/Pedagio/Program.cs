using System.Diagnostics;

bool cond = true;
do
{
    Console.WriteLine("============= PEDAGIO =============");
    Console.WriteLine("Escolha qual a Categoria:\n" +
                      "1 - Passeio\n" +
                      "2 - Utilitario\n" +
                      "3 - Ônibus\n" +
                      "4 - Caminhão");
    Console.Write("Sua Escolha: ");
    int op = Convert.ToInt32(Console.ReadLine());
    if (op == 0)
    {
        Console.WriteLine("Volte Sempre!");
        cond = false;
    }else if (op == 1)
    {
        Console.Write("\nDigite a Placa do Veiculo: ");
        string placaVeiculo = Console.ReadLine().ToUpper();
        Console.Write("\nQuantidade de Eixo(s) do Veiculo: ");
        int quantidadeEixo = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nDigite o Tipo do Veiculo (1 - Pessoa Física; 2 - Pessoa Jurídica; 3 - Oficial): ");
        int tipoVeiculo = Convert.ToInt32(Console.ReadLine());

        Passeio veiculo = new Passeio(placaVeiculo, quantidadeEixo, tipoVeiculo);
        Console.WriteLine($"Valor Total A pagar: {veiculo.getValorFinal().ToString("C")}");
    }
    else if (op == 2)
    {
        Console.Write("\nDigite a Placa do Veiculo: ");
        string placaVeiculo = Console.ReadLine();
        Console.Write("\nQuantidade de Eixo(s) do Veiculo: ");
        int quantidadeEixo = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nDigite o Tipo do Veiculo (1 - Pessoa Física; 2 - Pessoa Jurídica; 3 - Oficial): ");
        int tipoVeiculo = Convert.ToInt32(Console.ReadLine());

        Utilitario veiculo = new Utilitario(placaVeiculo, quantidadeEixo, tipoVeiculo);
        Console.WriteLine($"Valor Total A pagar: {veiculo.getValorFinal().ToString("C")}");
    }
    else if (op == 3)
    {
        Console.Write("\nDigite a Placa do Veiculo: ");
        string placaVeiculo = Console.ReadLine();
        Console.Write("\nQuantidade de Eixo(s) do Veiculo: ");
        int quantidadeEixo = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nDigite o Tipo do Veiculo (1 - Pessoa Física; 2 - Pessoa Jurídica; 3 - Oficial): ");
        int tipoVeiculo = Convert.ToInt32(Console.ReadLine());

        Onibus veiculo = new Onibus(placaVeiculo, quantidadeEixo, tipoVeiculo);
        Console.WriteLine($"Valor Total A pagar: {veiculo.getValorFinal().ToString("C")}");
    }
    else if (op == 4)
    {
        Console.Write("\nDigite a Placa do Veiculo: ");
        string placaVeiculo = Console.ReadLine();
        Console.Write("\nQuantidade de Eixo(s) do Veiculo: ");
        int quantidadeEixo = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nDigite o Tipo do Veiculo (1 - Pessoa Física; 2 - Pessoa Jurídica; 3 - Oficial): ");
        int tipoVeiculo = Convert.ToInt32(Console.ReadLine());

        Caminhao veiculo = new Caminhao(placaVeiculo, quantidadeEixo, tipoVeiculo);
        Console.WriteLine($"Valor Total A pagar: {veiculo.getValorFinal().ToString("C")}");
    }
    else
    {
        Console.WriteLine("Escolha uma opção Válida!");
    }

    Console.WriteLine("Deseja Sair?");
    string condi = Console.ReadLine().ToUpper();
    if (condi.Equals("S") || condi.Equals("SIM"))
    {
        cond = false;
    }
} while (cond);