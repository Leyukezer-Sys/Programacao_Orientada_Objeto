public class Biblioteca
{
    private int _id_usu = 0, _id_livro = 0, _id_revista = 0;
    private List<Livro> livros = new List<Livro>();
    private List<Revista> revistas = new List<Revista>();
    private List<Usuario> usuarios = new List<Usuario>();
    private List<Emprestimo> emprestimos = new List<Emprestimo>();

    public void Adicionar_Livro(string titulo_Livro, string autor_Livro, int numeroPaginas_Livro, int anoPublicacao_Livro)
    {
        _id_livro++;
        Livro novo_livro = new Livro(_id_livro,titulo_Livro, autor_Livro, numeroPaginas_Livro, anoPublicacao_Livro);
        livros.Add(novo_livro);
    }
    public void Adicionar_Revista(string titulo_Revista, string autor_Revista, int numeroPaginas_Revista, int anoPublicacao_Revista, int edcao_Revista)
    {
        _id_revista++;
        Revista nova_revista = new Revista(_id_revista,titulo_Revista, autor_Revista, numeroPaginas_Revista, anoPublicacao_Revista, edcao_Revista);
        revistas.Add(nova_revista);
    }
    public void Adicionar_Usuario(string nome_Usuario, int anoNascimento_Usuario)
    {
        _id_usu++;
        Usuario novo_usuario = new Usuario(_id_usu, nome_Usuario, anoNascimento_Usuario);
        usuarios.Add(novo_usuario);
    }
    public void Registrar_Emprestimo(Usuario? usuario, Livro? livro_escolhido, Revista? revista_escolhida,int dia_emprestimo, int dia_devolucao_emprestimo)
    {
        Emprestimo novo_emprestimo = new Emprestimo();
        novo_emprestimo.setData_Emprestimo(dia_emprestimo);
        novo_emprestimo.setData_Devolucao(dia_devolucao_emprestimo);
        novo_emprestimo.setUsuario_Emprestimo(usuario);
        novo_emprestimo.setLivro_Revista_Emprestimo(revista_escolhida);
        novo_emprestimo.setLivro_Revista_Emprestimo(livro_escolhido);
        emprestimos.Add(novo_emprestimo);
    }
    public void Registrar_Devolucao(Usuario? usuario_devolucao, int dia_devolucao)
    {
        foreach (Emprestimo devolucao in emprestimos)
        {
            if (devolucao.getUsuario_Emprestimo().getIdUsuario() == usuario_devolucao.getIdUsuario())
            {
                devolucao.Registrar_Devolucao(dia_devolucao);
                Console.WriteLine("Devolução Realizada");
            }else Console.WriteLine("Usuario nao encontrado...");
        }
    }
    public void Exibir_Livros_Revistas()
    {
        Console.WriteLine("-- Livros --");
        foreach (Livro livro in livros)
        {
            Console.WriteLine($"*{livro.getTitulo()}|{livro.getAutor()}\n" +
                $"- Cod: <<{livro.getCodigo()}>>\n" +
                $"- Numero de Paginas: {livro.getNumeroDePaginas()}\n" +
                $"- Ano de Publicação: {livro.getAnoDaPublicacao()}");
        }
        Console.WriteLine("-- Revistas --");
        foreach (Revista revista in revistas)
        {
            Console.WriteLine($"*{revista.getTitulo()}|{revista.getNumeroDaEdcao()}ª Edção|{revista.getAutor()}\n" +
                $"- Cod: <<{revista.getCodigo()}>>\n" +
                $"- Numero de Paginas: {revista.getNumeroDePaginas()}\n" +
                $"- Ano de Publicação: {revista.getAnoDaPublicacao()}");
        }
    }
    public void Exibir_Usuarios()
    {
        Console.WriteLine("-- Usuarios Cadastrados --");
        foreach (Usuario users in usuarios)
        {
            Console.WriteLine($"* Usuario <<{users.getIdUsuario()}>>\n" +
                $"- Nome: {users.getNomeUsuario()}\n" +
                $"- Idade: {users.getIdadeUsuario()}");
        }
    }
    public void Exibir_Emprestimos()
    {
        DateTime dia_atual = DateTime.Now;

        Console.WriteLine("-- EMPRESTIMOS --");
        foreach (Emprestimo emp in emprestimos)
        {
            Console.WriteLine($"* Emprestimo {emp.getData_Emprestimo().Day}/{emp.getData_Emprestimo().Month}/{emp.getData_Emprestimo().Year}\n" +
                $"- Nome do Usuario: {emp.getUsuario_Emprestimo().getNomeUsuario()}\n" +
                $"- Data Atual: {dia_atual.Day}/{dia_atual.Month}/ {dia_atual.Year}\n" +
                $"- Data Prevista Devolução: {emp.getData_Devolucao().Day}/{emp.getData_Devolucao().Month}/{emp.getData_Devolucao().Year}");
        }
    }

    public Usuario? getUsuarios(int id_usuario)
    {
        foreach (Usuario user in usuarios)
        {
            if (user.getIdUsuario() == id_usuario)
            {
                return user;
            }
        }
        Console.WriteLine("Usuario nao encontrado");
        return null;
    }
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
    public Usuario? getUsuarios(string nome)
    {
        foreach (Usuario user in usuarios)
        {
            if (user.getNomeUsuario() == nome)
            {
                return user;
            }
        }
        Console.WriteLine("Usuario nao encontrado");
        return null;
    }
}