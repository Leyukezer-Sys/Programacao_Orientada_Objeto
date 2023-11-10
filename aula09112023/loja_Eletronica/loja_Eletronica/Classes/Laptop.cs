public class Laptop : ProdutoEletronico
{
    private List<string> _detalhes = new List<string>();
    private string _memoriaRAM;
    public Laptop(string nome, string marca, int anoFabricacao, string memoriaRAM) : base(nome, marca, anoFabricacao)
    {
        this._memoriaRAM = memoriaRAM;
    }
    public void setMemoriaRAM(string memoriaRAM)
    {
        this._memoriaRAM = memoriaRAM;
    }
    public string getMemoriaRAM() { return this._memoriaRAM; }
    public override void Detalhes(string descricao)
    {
        _detalhes.Add(descricao);
    }
    public void getDetalhes()
    {
        foreach (string descricao in _detalhes)
        {
            Console.WriteLine(descricao);
        }
    }
}