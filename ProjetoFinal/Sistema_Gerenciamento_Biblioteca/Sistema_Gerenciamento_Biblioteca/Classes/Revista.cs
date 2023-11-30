public class Revista : Livro
{
    private int _nEdcao = 0;
    public Revista(int _codigoRevista, string _tituloRevista, string _autorRevista, int _numeroPaginasRevista, int _anoPublicacaoRevista, int _numeroEdcaoRevista) : base(_codigoRevista, _tituloRevista, _autorRevista, _numeroPaginasRevista, _anoPublicacaoRevista)
    {
        this.setNumeroDaEdcao(_numeroEdcaoRevista);
    }
    public void setNumeroDaEdcao(int _numeroDaEdcao) { this._nEdcao = _numeroDaEdcao; }
    public int getNumeroDaEdcao() { return this._nEdcao; }
}
