Console.WriteLine("====================== LOJA DE ELETRÔNICOS ======================");
int op;
List<ProdutoEletronico> produtos = new List<ProdutoEletronico>();
do
{
    Console.WriteLine("\n\n$Escolha sua opção:\n" +
        "1 - Cadastrar Smartphone\n" +
        "2 - Cadastrar LapTop\n" +
        "3 - Cadastrar Camera\n" +
        "4 - Mostrar Produtos Cadastrados\n" +
        "0 - Sair");
    Console.Write("Sua Escolha: ");
    while (!int.TryParse(Console.ReadLine(), out op))
    {
        Console.Write("Apenas Numeros\n" +
                      "Sua Escolha: ");
    }
    switch (op)
    {
        default:
            Console.WriteLine("Escolha Inválida!");
            break;
        case 0:
            Console.WriteLine("Volte Sempre!");
            break;
        case 1:
            Console.WriteLine("--------- Cadastro SmartPhone ---------");

            Console.Write("Digite o Nome do Smartphone: ");
            string nome = Console.ReadLine().ToUpper();
            Console.Write("Digite o Marca do Smartphone: ");
            string marca = Console.ReadLine().ToLower();
            int anoFabric = 0;
            Console.Write("Digite o Ano de Fabricação do Smartphone: ");
            while (!int.TryParse(Console.ReadLine(), out anoFabric))
            {
                Console.Write("Digite o Ano de Fabricação do Smartphone (Somente Numero| Ex: 2010): ");
            }
            Console.Write("Digite o Sistema Operacional do Smartphone: ");
            string sistemaOperacional = Console.ReadLine().ToUpper();

            Smartphone cadSmart = new Smartphone(nome, marca, anoFabric, sistemaOperacional);

            Console.WriteLine("Adicionar mais detalhes? (S/N)");
            string _cond = Console.ReadLine().ToUpper();
            while (_cond.Equals("S") || _cond.Equals("SIM"))
            {
                Console.WriteLine("*Nova Descrição: ");
                string desc = Console.ReadLine().ToLower();

                cadSmart.Detalhes(desc);

                Console.WriteLine("Adicionar mais detalhes? (S/N)");
                _cond = Console.ReadLine().ToUpper();
            }

            produtos.Add(cadSmart);
            break;
        case 2:
            Console.WriteLine("--------- Cadastro LapTop ---------");

            Console.Write("Digite o Nome do Laptop: ");
            nome = Console.ReadLine().ToUpper();
            Console.Write("Digite o Marca do Laptop: ");
            marca = Console.ReadLine().ToLower();
            Console.Write("Digite o Ano de Fabricação do Laptop: ");
            while (!int.TryParse(Console.ReadLine(), out anoFabric))
            {
                Console.Write("Digite o Ano de Fabricação do Laptop(Somente Numero| Ex: 2002): ");
            }
            Console.Write("Digite a Memoria RAM do Laptop: ");
            string memoriaRam = Console.ReadLine().ToUpper();

            Laptop cadLaptop = new Laptop(nome, marca, anoFabric, memoriaRam);

            Console.WriteLine("Adicionar mais detalhes? (S/N)");
            _cond = Console.ReadLine().ToUpper();
            while (_cond.Equals("S") || _cond.Equals("SIM"))
            {
                Console.WriteLine("*Nova Descrição: ");
                string desc = Console.ReadLine().ToLower();

                cadLaptop.Detalhes(desc);

                Console.WriteLine("Adicionar mais detalhes? (S/N)");
                _cond = Console.ReadLine().ToUpper();
            }

            produtos.Add(cadLaptop);
            break;
        case 3:
            Console.WriteLine("--------- Cadastro Camera Fotográfica---------");
            Console.Write("Digite o Nome da Camera Fotográfica: ");
            nome = Console.ReadLine().ToUpper();
            Console.Write("Digite o Marca da Camera Fotográfica: ");
            marca = Console.ReadLine().ToLower();
            Console.Write("Digite o Ano de Fabricação da Camera Fotográfica: ");
            while (!int.TryParse(Console.ReadLine(), out anoFabric))
            {
                Console.Write("Digite o Ano de Fabricação da Camera Fotográfica(Somente Numero| Ex: 2012): ");
            }
            Console.Write("Digite a Resolução da Camera Fotográfica: ");
            string resolucao = Console.ReadLine().ToUpper();

            Camera cadCame = new Camera(nome, marca, anoFabric, resolucao);

            Console.WriteLine("Adicionar mais detalhes? (S/N)");
            _cond = Console.ReadLine().ToUpper();
            while (_cond.Equals("S") || _cond.Equals("SIM"))
            {
                Console.WriteLine("*Nova Descrição: ");
                string desc = Console.ReadLine().ToLower();

                cadCame.Detalhes(desc);

                Console.WriteLine("Adicionar mais detalhes? (S/N)");
                _cond = Console.ReadLine().ToUpper();
            }

            produtos.Add(cadCame);
            break;
        case 4:
            Console.WriteLine("\nProdutos Loja Eletrônicos");
            foreach (ProdutoEletronico produto in produtos)
            {
                Console.WriteLine($"Nome: {produto.getNome()}\n" +
                    $"Marca: {produto.getMarca()}\n" +
                    $"Ano Fabricação: {produto.getAnoFabricacao()}\n");
            }
            break;
    }
} while (op != 0);