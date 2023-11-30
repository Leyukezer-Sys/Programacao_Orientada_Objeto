public class Biblioteca
{
    // Campos privados para contagem dos identificadores e listas de livros, revistas, usuários e empréstimos
    private int _id_usu = 0, _id_livro = 0, _id_revista = 0;
    private List<Livro> livros = new List<Livro>();
    private List<Revista> revistas = new List<Revista>();
    private List<Usuario> usuarios = new List<Usuario>();
    private List<Emprestimo> emprestimos = new List<Emprestimo>();

    // Método para adicionar um novo livro à biblioteca
    public void Adicionar_Livro(string titulo_Livro, string autor_Livro, int numeroPaginas_Livro, int anoPublicacao_Livro)
    {
        _id_livro++;
        Livro novo_livro = new Livro(_id_livro, titulo_Livro, autor_Livro, numeroPaginas_Livro, anoPublicacao_Livro);
        livros.Add(novo_livro);
    }

    // Método para adicionar uma nova revista à biblioteca
    public void Adicionar_Revista(string titulo_Revista, string autor_Revista, int numeroPaginas_Revista, int anoPublicacao_Revista, int edicao_Revista)
    {
        _id_revista++;
        Revista nova_revista = new Revista(_id_revista, titulo_Revista, autor_Revista, numeroPaginas_Revista, anoPublicacao_Revista, edicao_Revista);
        revistas.Add(nova_revista);
    }

    // Método para adicionar um novo usuário à biblioteca
    public void Adicionar_Usuario(string nome_Usuario, int anoNascimento_Usuario)
    {
        _id_usu++;
        Usuario novo_usuario = new Usuario(_id_usu, nome_Usuario, anoNascimento_Usuario);
        usuarios.Add(novo_usuario);
    }

    // Método para registrar um novo empréstimo na biblioteca
    public void Registrar_Emprestimo(Usuario? usuario, Livro? livro_escolhido, Revista? revista_escolhida, int dia_emprestimo, int dia_devolucao_emprestimo)
    {
        Emprestimo novo_emprestimo = new Emprestimo();
        novo_emprestimo.setData_Emprestimo(dia_emprestimo);
        novo_emprestimo.setData_Devolucao(dia_devolucao_emprestimo);
        novo_emprestimo.setUsuario_Emprestimo(usuario);
        novo_emprestimo.setLivro_Revista_Emprestimo(revista_escolhida);
        novo_emprestimo.setLivro_Revista_Emprestimo(livro_escolhido);
        emprestimos.Add(novo_emprestimo);
    }

    // Método para registrar a devolução de um empréstimo
    public void Registrar_Devolucao(Usuario? usuario_devolucao, int dia_devolucao)
    {
        foreach (Emprestimo devolucao in emprestimos)
        {
            if (devolucao.getUsuario_Emprestimo().getIdUsuario() == usuario_devolucao.getIdUsuario())
            {
                devolucao.Registrar_Devolucao(dia_devolucao);
                Console.WriteLine("Devolução Realizada");
            }
            else Console.WriteLine("Usuário não encontrado...");
        }
    }

    // Método para exibir todos os livros e revistas na biblioteca
    public void Exibir_Livros_Revistas()
    {
        Console.WriteLine("-- Livros --");
        foreach (Livro livro in livros)
        {
            Console.WriteLine($"* {livro.getTitulo()} | {livro.getAutor()}\n" +
                $"- Cód: <<{livro.getCodigo()}>>\n" +
                $"- Número de Páginas: {livro.getNumeroDePaginas()}\n" +
                $"- Ano de Publicação: {livro.getAnoDaPublicacao()}");
        }
        Console.WriteLine("-- Revistas --");
        foreach (Revista revista in revistas)
        {
            Console.WriteLine($"* {revista.getTitulo()} | {revista.getNumeroDaEdicao()}ª Edição | {revista.getAutor()}\n" +
                $"- Cód: <<{revista.getCodigo()}>>\n" +
                $"- Número de Páginas: {revista.getNumeroDePaginas()}\n" +
                $"- Ano de Publicação: {revista.getAnoDaPublicacao()}");
        }
    }

    // Método para exibir todos os usuários cadastrados na biblioteca
    public void Exibir_Usuarios()
    {
        Console.WriteLine("-- Usuários Cadastrados --");
        foreach (Usuario users in usuarios)
        {
            Console.WriteLine($"* Usuário <<{users.getIdUsuario()}>>\n" +
                $"- Nome: {users.getNomeUsuario()}\n" +
                $"- Idade: {users.getIdadeUsuario()}");
        }
    }

    // Método para exibir todos os empréstimos na biblioteca
    public void Exibir_Emprestimos()
    {
        DateTime dia_atual = DateTime.Now;

        Console.WriteLine("-- EMPRÉSTIMOS --");
        foreach (Emprestimo emp in emprestimos)
        {
            Console.WriteLine($"* Empréstimo {emp.getData_Emprestimo().Day}/{emp.getData_Emprestimo().Month}/{emp.getData_Emprestimo().Year}\n" +
                $"- Nome do Usuário: {emp.getUsuario_Emprestimo().getNomeUsuario()}\n" +
                $"- Data Atual: {dia_atual.Day}/{dia_atual.Month}/{dia_atual.Year}\n" +
                $"- Data Prevista Devolução: {emp.getData_Devolucao().Day}/{emp.getData_Devolucao().Month}/{emp.getData_Devolucao().Year}");
        }
    }

    // Método para obter um usuário pelo seu ID
    public Usuario? getUsuarios(int id_usuario)
    {
        foreach (Usuario user in usuarios)
        {
            if (user.getIdUsuario() == id_usuario)
            {
                return user;
            }
        }
        Console.WriteLine("Usuário não encontrado");
        return null;
    }

    // Método para obter um livro pelo seu ID
    public Livro? getLivros(int id)
    {
        foreach (Livro liv in livros)
        {
            if (liv.getCodigo() == id)
            {
                return liv;
            }
        }
        return null;
    }

    // Método para obter uma revista pelo seu ID
    public Revista? getRevistas(int id)
    {
        foreach (Revista rev in revistas)
        {
            if (rev.getCodigo() == id)
            {
                return rev;
            }
        }
        return null;
    }
}