// Definindo a classe 'Revista' que herda da classe 'Livro'
public class Revista : Livro
{
    // Definindo campo privado adicional para armazenar o número da edição da revista
    private int _nEdicao = 0;

    // Construtor da classe Revista que recebe informações iniciais da revista, chamando o construtor da classe base (Livro)
    public Revista(int _codigoRevista, string _tituloRevista, string _autorRevista, int _numeroPaginasRevista, int _anoPublicacaoRevista, int _numeroEdicaoRevista) : base(_codigoRevista, _tituloRevista, _autorRevista, _numeroPaginasRevista, _anoPublicacaoRevista)
    {
        // Chamando método para configurar o número da edição da revista
        this.setNumeroDaEdicao(_numeroEdicaoRevista);
    }

    // Método para configurar o número da edição da revista
    public void setNumeroDaEdicao(int _numeroDaEdicao) { this._nEdicao = _numeroDaEdicao; }

    // Método para obter o número da edição da revista
    public int getNumeroDaEdicao() { return this._nEdicao; }
}

