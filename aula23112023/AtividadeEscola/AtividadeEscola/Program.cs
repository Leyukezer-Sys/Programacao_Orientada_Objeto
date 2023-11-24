List<Funcionario> funcionarios = new List<Funcionario>();
int op = 0;
do
{
    Console.WriteLine("================== Escola ==================");

    Console.WriteLine("MENU:\n" +
        "1 - Cadastrar Professor\n" +
        "2 - Cadastrar Administrador\n" +
        "3 - Mostrar Funcionarios Cadastrados\n" +
        "0 - Sair");

    while (!int.TryParse(Console.ReadLine(), out op))
    {
        Console.WriteLine("Apenas Numeros!!");
        Console.WriteLine("MENU:\n" +
            "1 - Cadastrar Professor\n" +
            "2 - Cadastrar Administrador\n" +
            "3 - Mostrar Funcionarios Cadastrados\n" +
            "0 - Sair");
    }
    switch (op)
    {
        default:
            Console.WriteLine("Opção Inválida");
            break;
        case 0:
            Console.WriteLine("Volte Sempre!");
            break;
        case 1:
            Console.WriteLine("-------- Ficha Cadastro Professor --------");
            Console.Write( "* Digite o nome do Professor: ");
            string nome = Console.ReadLine();
            Console.Write( "* Digite a idade do Professor: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.Write( "* Digite o salario do Professor: R$ ");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.Write( "* Digite a disciplina do Professor: ");
            string disciplina = Console.ReadLine().ToUpper();

            Professor profe = new Professor(nome, idade, salario, disciplina);

            Console.Write( "** O professor leciona outra disciplina? \n" +
                "R: ");
            string respo = Console.ReadLine().ToUpper();
            while(respo.Equals("S")|| respo.Equals("SIM"))
            {
                Console.Write("* Digite a disciplina do Professor: ");
                disciplina = Console.ReadLine().ToUpper();
                profe.setDisciplina(disciplina);

                Console.Write("** O professor leciona outra disciplina? \n" +
                    "R: ");
                respo = Console.ReadLine().ToUpper();
            }
            profe.CalcularSalario();
            funcionarios.Add(profe);
            break;
        case 2:
            Console.WriteLine("-------- Ficha Cadastro Administrador --------");
            Console.Write( "* Digite o nome do Administrador: ");
            nome = Console.ReadLine();
            Console.Write( "* Digite a idade do Administrador: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.Write( "* Digite o salario do Administrador: R$ ");
            salario = Convert.ToDouble(Console.ReadLine());
            Console.Write( "* Digite o setor do Administrador: ");
            string setor = Console.ReadLine().ToUpper();

            Administrativo admin = new Administrativo(nome, idade, salario, setor);

            Console.Write( "** O Administrador administra outro setor? \n" +
                "R: ");
            respo = Console.ReadLine().ToUpper();
            while(respo.Equals("S")|| respo.Equals("SIM"))
            {
                Console.Write("* Digite o setor do Administrador: ");
                setor = Console.ReadLine().ToUpper();
                admin.setSetor(setor);

                Console.Write("** O Administrador administra outro setor? \n" +
                "R: ");
                respo = Console.ReadLine().ToUpper();
            }
            admin.CalcularSalario();
            funcionarios.Add(admin);
            break;
        case 3:
            Console.WriteLine("== Funcionarios da Escola:");
            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine($"Nome: {funcionario.getNome()}\n" +
                    $"Idade: {funcionario.getIdade()}\n" +
                    $"Salário: {funcionario.getSalario().ToString("C")}\n");
            }
            break;
    }
} while (op != 0);
