public class Livro
{
    // Definindo campos privados para armazenar informações do livro
    private string _titulo = "", _autor = "";
    private int _nPaginas = 0, _anoPublicacao = 0, _codigo;

    // Construtor da classe Livro que recebe informações iniciais do livro
    public Livro(int codigo_Livro, string _tituloLivro, string _autorLivro, int _numeroPaginasLivro, int _anoPublicacaoLivro)
    {
        // Chamando métodos para configurar as propriedades do livro com os valores fornecidos
        this.setCodigo(codigo_Livro);
        this.setTitulo(_tituloLivro);
        this.setAutor(_autorLivro);
        this.setAnoDaPublicacao(_anoPublicacaoLivro);
        this.setNumeroDePaginas(_numeroPaginasLivro);
    }

    // Método para configurar o código do livro
    public void setCodigo(int codigoLivro) { this._codigo = codigoLivro; }

    // Método para obter o código do livro
    public int getCodigo() { return this._codigo; }

    // Método para configurar o título do livro
    public void setTitulo(string tituloLivro) { this._titulo = tituloLivro; }

    // Método para obter o título do livro
    public string getTitulo() { return this._titulo; }

    // Método para configurar o autor do livro
    public void setAutor(string autorLivro) { this._autor = autorLivro; }

    // Método para obter o autor do livro
    public string getAutor() { return this._autor; }

    // Método para configurar o número de páginas do livro
    public void setNumeroDePaginas(int numeroDePaginas) { this._nPaginas = numeroDePaginas; }

    // Método para obter o número de páginas do livro
    public int getNumeroDePaginas() { return this._nPaginas; }

    // Método para configurar o ano de publicação do livro
    public void setAnoDaPublicacao(int anoPublicado) { this._anoPublicacao = anoPublicado; }

    // Método para obter o ano de publicação do livro
    public int getAnoDaPublicacao() { return this._anoPublicacao; }
}

