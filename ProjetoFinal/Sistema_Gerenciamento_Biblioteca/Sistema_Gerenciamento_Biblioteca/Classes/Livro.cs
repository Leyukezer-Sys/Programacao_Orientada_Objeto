public class Livro
{
    private string _titulo = "", _autor = "";
    private int _nPaginas = 0, _anoPublicacao = 0, _codigo;

    public Livro(int codigo_Livro, string _tituloLivro, string _autorLivro, int _numeroPaginasLivro, int _anoPublicacaoLivro)
    {
        this.setCodigo(codigo_Livro);
        this.setTitulo(_tituloLivro);
        this.setAutor(_autorLivro);
        this.setAnoDaPublicacao(_anoPublicacaoLivro);
        this.setNumeroDePaginas(_numeroPaginasLivro);
    }
    public void setCodigo(int codigoLivro) { this._codigo = codigoLivro; }
    public int getCodigo() {  return this._codigo; }
    public void setTitulo(string tituloLivro) { this._titulo = tituloLivro; }
    public string getTitulo() {  return this._titulo; }
    public void setAutor(string autorLivro) { this._autor = autorLivro; }
    public string getAutor() {  return this._autor; }
    public void setNumeroDePaginas(int numeroDePaginas) { this._nPaginas = numeroDePaginas; }
    public int getNumeroDePaginas() {  return this._nPaginas; }
    public void setAnoDaPublicacao(int anoPublicado) { this._anoPublicacao = anoPublicado; }
    public int getAnoDaPublicacao() { return this._anoPublicacao; }
}
