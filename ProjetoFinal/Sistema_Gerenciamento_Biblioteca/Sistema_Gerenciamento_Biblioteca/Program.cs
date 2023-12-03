//  Alunos: Edson Fernando Souza Bezerra, Leyukezer Cruz
int op = 0, opLR = 0;
Biblioteca gerenciamento_bibliotecario = new Biblioteca();
do
{
    Console.WriteLine("============= GERENCIAMENTO BIBLIOTECARIO =============");
    Console.WriteLine("MENU:\n" +
        "1 - Gerenciar Livros e Revistas\n" +
        "2 - Usuarios\n" +
        "3 - Emprestimos\n" +
        "4 - Devoluções\n" +
        "0 - Sair\n" +
        "Sua Escolha: ");
    while (!int.TryParse(Console.ReadLine(), out op))
    {
        Console.WriteLine("** Apenas Numeros **");
        Console.WriteLine("MENU:\n" +
            "1 - Gerenciar Livros e Revistas\n" +
            "2 - Usuarios\n" +
            "3 - Emprestimos\n" +
            "4 - Devoluções\n" +
            "0 - Sair\n" +
            "Sua Escolha: ");
    }
    switch (op)
    {
        default:
            Console.WriteLine("Escolha inválida!!");
            break;
        case 0: 
            Console.WriteLine("volte sempre!");
            break;
        case 1:
            do
            {
                Console.WriteLine("========== GESTÃO DE LIVROS E REVISTAS ==========");
                Console.WriteLine("MENU:\n" +
                                  "1 - Cadastrar Livro\n" +
                                  "2 - Cadastrar Revista\n" +
                                  "0 - Sair\n" +
                                  "Sua Escolha: ");
                while (!int.TryParse(Console.ReadLine(), out opLR))
                {
                    Console.WriteLine("** Apenas Numeros **");
                    Console.WriteLine("MENU:\n" +
                                      "1 - Cadastrar Livro\n" +
                                      "2 - Cadastrar Revista\n" +
                                      "0 - Sair\n" +
                                      "Sua Escolha: ");
                }
                switch (opLR)
                {
                    default:
                        Console.WriteLine("!! Apenas opção 1 ou 2 !!");
                        break;
                    case 0:
                        break;
                    case 1:
                        bool cond = true;
                        while (cond)
                        {
                            Console.WriteLine("CADASTRO DE LIVRO");
                            Console.Write("*Digite o Nome do Livro: ");
                            string titulo_livro = Console.ReadLine().ToUpper();
                            Console.Write("*Digite o Autor do Livro: ");
                            string autor_livro = Console.ReadLine();
                            Console.Write("*Digite o Ano de Publicação do Livro: ");
                            int publicacao_livro = Convert.ToInt32(Console.ReadLine());
                            Console.Write("*Digite o Número de Paginas do Livro: ");
                            int paginas_livro = Convert.ToInt32(Console.ReadLine());

                            gerenciamento_bibliotecario.Adicionar_Livro(titulo_livro, autor_livro, paginas_livro, publicacao_livro);

                            Console.WriteLine("\nDeseja adicionar outro Livro?");
                            string respo = Console.ReadLine().ToUpper();
                            if (respo.Equals("N")|| respo.ToUpper().Equals("NAO")|| respo.Equals("NÃO"))
                            {
                                cond = false;
                            }
                        }
                        break;
                    case 2:
                        cond = true;
                        while (cond)
                        {
                            Console.WriteLine("CADASTRO DE REVISTA");
                            Console.Write("*Digite o Nome da Revista: ");
                            string titulo_revista= Console.ReadLine().ToUpper();
                            Console.Write("*Digite o Autor da Revista: ");
                            string autor_revista= Console.ReadLine();
                            Console.Write("*Digite o Ano de Publicação da Revista: ");
                            int publicacao_revista= Convert.ToInt32(Console.ReadLine());
                            Console.Write("*Digite a Edção da Revista: ");
                            int edicao_revista= Convert.ToInt32(Console.ReadLine());
                            Console.Write("*Digite o Número de Paginas da Revista: ");
                            int paginas_revista= Convert.ToInt32(Console.ReadLine());

                            gerenciamento_bibliotecario.Adicionar_Revista(titulo_revista, autor_revista, paginas_revista, publicacao_revista,edicao_revista);

                            Console.WriteLine("\nDeseja adicionar outra Revista?");
                            string respo = Console.ReadLine().ToUpper();
                            if (respo.Equals("N") || respo.ToUpper().Equals("NAO") || respo.Equals("NÃO"))
                            {
                                cond = false;
                            }
                        }
                        break;
                }
            } while (opLR != 0);
            break;
        case 2:
            do
            {
                Console.WriteLine("========== GESTÃO DE USUARIOS ==========");
                Console.WriteLine("MENU:\n" +
                                  "1 - Cadastrar Usuarios\n" +
                                  "2 - Listar Usuarios\n" +
                                  "0 - Sair\n" +
                                  "Sua Escolha: ");
                while (!int.TryParse(Console.ReadLine(), out opLR))
                {
                    Console.WriteLine("!! Digite Apenas 1 ou 2 !!");
                    Console.WriteLine("MENU:\n" +
                                      "1 - Cadastrar Usuarios\n" +
                                      "2 - Listar Usuarios\n" +
                                      "0 - Sair\n" +
                                      "Sua Escolha: ");
                }
                switch (opLR)
                {
                    default:
                        Console.WriteLine("!! Digite Apenas 1 ou 2 !!");
                        break;
                    case 0: break;
                    case 1:
                        bool cond = true;
                        while (cond)
                        {
                            Console.WriteLine("CADASTRO DE USUARIO");
                            Console.Write("*Digite o Nome do Usuario: ");
                            string nome_usu = Console.ReadLine().ToLower();
                            Console.Write("*Digite o Ano de Nascimento do Usuario: ");
                            int idade_usu = Convert.ToInt32(Console.ReadLine());

                            gerenciamento_bibliotecario.Adicionar_Usuario(nome_usu, idade_usu);

                            Console.WriteLine("\nDeseja adicionar outro Usuario?");
                            string respo = Console.ReadLine().ToUpper();
                            if (respo.Equals("N") || respo.ToUpper().Equals("NAO") || respo.Equals("NÃO"))
                            {
                                cond = false;
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("=== Lista ===");
                        gerenciamento_bibliotecario.Exibir_Usuarios();
                        break;
                }
            } while (opLR != 0);
            break;
        case 3:
            do
            {
                Console.WriteLine("========== GESTÃO DE EMPRESTIMOS ==========");
                Console.WriteLine("MENU:\n" +
                                  "1 - Ver Livros e Revistas\n" +
                                  "2 - Realizar Emprestimo\n" +
                                  "0 - Sair\n" +
                                  "Sua Escolha: ");
                while (!int.TryParse(Console.ReadLine(), out opLR))
                {
                    Console.WriteLine("!! Digite Apenas 1 ou 2 !!");
                    Console.WriteLine("MENU:\n" +
                                      "1 - Ver Livros e Revistas\n" +
                                      "2 - Realizar Emprestimo\n" +
                                      "0 - Sair\n" +
                                      "Sua Escolha: ");
                }
                switch (opLR)
                {
                    default:
                        Console.WriteLine("!! Digite Apenas 1 ou 2 !!");
                        break;
                    case 0: break;
                    case 1:
                        Console.WriteLine("=== BIBLIOTECA ===");
                        gerenciamento_bibliotecario.Exibir_Livros_Revistas();
                        break;
                    case 2:
                        bool cond = true;
                        while (cond)
                        {
                            Console.WriteLine("REALIZAR EMPRESTIMO");
                            Console.Write("*Digite o Codigo do Usuario: ");
                            int id_usu = Convert.ToInt32(Console.ReadLine());
                            Console.Write("*Digite o Codigo do Livro (0 - para nenhum livro): ");
                            int id_livro = Convert.ToInt32(Console.ReadLine());
                            Console.Write("*Digite o Codigo da Revista (0 - para nenhuma revista): ");
                            int id_revista = Convert.ToInt32(Console.ReadLine());
                            while (id_livro < 1 && id_revista < 1)
                            {
                                Console.WriteLine("!! Reserve pelo menos 1 livro ou 1 revista!!");
                                Console.Write("*Digite o Codigo do Livro (0 - para nenhum livro): ");
                                id_livro = Convert.ToInt32(Console.ReadLine());
                                Console.Write("*Digite o Codigo da Revista (0 - para nenhuma revista): ");
                                id_revista = Convert.ToInt32(Console.ReadLine());
                            }

                            Console.Write("*Digite o dia da Realização do Emprestimo: ");
                            int dia_empretimo = Convert.ToInt32(Console.ReadLine());
                            Console.Write("*Digite o dia da Realização da possivel Devolução: ");
                            int dia_devolucao_emprestimo = Convert.ToInt32(Console.ReadLine());

                            gerenciamento_bibliotecario.Registrar_Emprestimo(gerenciamento_bibliotecario.getUsuarios(id_usu), gerenciamento_bibliotecario.getLivros(id_livro),
                                gerenciamento_bibliotecario.getRevistas(id_revista), dia_empretimo, dia_devolucao_emprestimo);

                            Console.WriteLine("\nDeseja Realizar outro Emprestimo?");
                            string respo = Console.ReadLine().ToUpper();
                            if (respo.Equals("N") || respo.ToUpper().Equals("NAO") || respo.Equals("NÃO"))
                            {
                                cond = false;
                            }
                        }
                        break;
                }
            } while (opLR != 0);
            break;
        case 4:
            do
            {
                Console.WriteLine("========== GESTÃO DE DEVOLUÇÕES ==========");
                Console.WriteLine("MENU:\n" +
                                  "1 - Ver Emprestimos\n" +
                                  "2 - Realizar Devolução\n" +
                                  "0 - Sair\n" +
                                  "Sua Escolha: ");
                while (!int.TryParse(Console.ReadLine(), out opLR))
                {
                    Console.WriteLine("!! Digite Apenas 1 ou 2 !!");
                    Console.WriteLine("MENU:\n" +
                                      "1 - Ver Emprestimos\n" +
                                      "2 - Realizar Devolução\n" +
                                      "0 - Sair\n" +
                                      "Sua Escolha: ");
                }
                switch (opLR)
                {
                    default:
                        Console.WriteLine("!! Digite Apenas 1 ou 2 !!");
                        break;
                    case 0: break;
                    case 1:
                        Console.WriteLine("=== LISTA ===");
                        gerenciamento_bibliotecario.Exibir_Emprestimos();
                        break;
                    case 2:
                        bool cond = true;
                        while (cond)
                        {
                            Console.WriteLine("REALIZAR DEVOLUÇÃO");
                            Console.Write("*Digite o Codigo do Usuario: ");
                            int id_usuario = Convert.ToInt32(Console.ReadLine());
                            Console.Write("*Digite o dia da Devolução: ");
                            int dia_devolucao = Convert.ToInt32(Console.ReadLine());

                            gerenciamento_bibliotecario.Registrar_Devolucao(gerenciamento_bibliotecario.getUsuarios(id_usuario), dia_devolucao);

                            Console.WriteLine("\nDeseja Realizar outra Devolucao?");
                            string respo = Console.ReadLine().ToUpper();
                            if (respo.Equals("N") || respo.ToUpper().Equals("NAO") || respo.Equals("NÃO"))
                            {
                                cond = false;
                            }
                        }
                        break;
                }
            } while (opLR != 0);
            break;
    }
} while (op != 0);

/*  Entrega: Os alunos devem entregar o código-fonte do projeto, devidamente
comentado, explicando os blocos de código, e também, em formato de comentário,
abaixo do programa principal, citem os desafios enfrentados durante o
desenvolvimento e possíveis melhorias que poderiam ser feitas.
 *
 *DESAFIOS:
 - saber como sera o andamento da biblioteca em questao de organização, 
nao possui ideia de estoque (quantidade) dos livros e revistas inseridos, 
interpretar o bibliotecário e suas respectivas funções, delimitar e aprimorar os
feitos de multa para se encaixar com uma biblioteca, focar no que se diz respeito 
a aplicação em uma biblioteca e nao um sistema de bibliotecas. O Maior desafio foi
aplicar as referencias como usuario e livros e revistas no emprestimo, sem perder um
unico livro ou revista do programa em execucao.
*MELHORIAS:
- Poderia se ter algo como quantidade de livros/revistas caso sejam lotes, ter um 
atributo de avaliação para os livros/revistas, ter um atributo para settar a data prevista
de devolucao e armazenar a data de devolucao separadamente, ter os niveis de acesso do usuario
como: estudantes, professores, administradores, cidadao. 
 */