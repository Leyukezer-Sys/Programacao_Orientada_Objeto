public abstract class ProdutoEletronico
{
    private string _nome, _marca;
    private int _anoFabricacao;

    public ProdutoEletronico(string nome, string marca, int anoFabricacao)
    {
        this._nome = nome;
        this._marca = marca;
        this._anoFabricacao = anoFabricacao;
    }
    public void setNome(string nome)
    {
        this._nome = nome;
    }
    public string getNome()
    {
        return this._nome;
    }
    public void setAnoFabricacao(int anoFabricacao)
    {
        this._anoFabricacao= anoFabricacao;
    }
    public int getAnoFabricacao()
    {
        return this._anoFabricacao;
    }
    public void setMarca(string marca)
    {
        this._marca = marca;
    }
    public string getMarca()
    {
        return this._marca;
    }

    public abstract void Detalhes(string descricao);
}