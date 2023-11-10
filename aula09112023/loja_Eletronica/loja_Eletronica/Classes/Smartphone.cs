public class Smartphone : ProdutoEletronico
{
    private List<string> _detalhes = new List<string>();
    private string _sistemaOperacional;
    public Smartphone(string nome, string marca, int anoFabricacao, string sistemaOperacional) : base(nome, marca, anoFabricacao)
    {
        this._sistemaOperacional = sistemaOperacional;
    }
    public void setSistemaOperacional(string sistemaOperacional)
    {
        this._sistemaOperacional = sistemaOperacional;
    }
    public string getSistemaOperacional() { return this._sistemaOperacional; }
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
