public class Camera : ProdutoEletronico
{
    private List<string> _detalhes = new List<string>();
    private string _resolucao;
    public Camera(string nome, string marca, int anoFabricacao, string resolucao) : base(nome, marca, anoFabricacao)
    {
        this._resolucao = resolucao;
    }
    public void setResulucao(string resolucao)
    {
        this._resolucao = resolucao;
    }
    public string getResolucao() { return this._resolucao; }
    public override void Detalhes(string descricao)
    {
        _detalhes.Add(descricao);
    }
    public void getDetalhes()
    {
        foreach (string detalhe in _detalhes)
        {
            Console.WriteLine(detalhe);
        }
    }
}