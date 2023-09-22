public class Produto
{
    private double valorAquisicao, valorVenda;
    public int codigo, unidade;
    public string descricao="", tipoPesagem = "";
    public double impostoISMC, impostoIPI, lucro;

    public Produto(int codigoProd, int unidadeProd, string tipoPesagemProd, string descProd,
                   double valorAquisicaoProd, double impostoISMCProd, double impostoIPIProd, double lucroProd)
    {
        if (setValorAquisicao(valorAquisicaoProd))
        {
            this.codigo = codigoProd;
            this.unidade = unidadeProd;
            this.tipoPesagem = tipoPesagemProd;
            this.descricao = descProd;
            this.impostoISMC = impostoISMCProd / 100;
            this.impostoIPI = impostoIPIProd / 100;
            this.lucro = lucroProd / 100;
            setValorVenda();
            Console.WriteLine($"\u001b[32mCadastrado Com sucesso!\u001b[0m");
        }
        else Console.WriteLine($"\u001b[33mValor da Aquisição Inválido!\u001b[0m");
        
    }
    public bool setValorAquisicao(double valor)
    {
        if (valor < 0)
        {
            return false;
        } else this.valorAquisicao = valor;
        return true;
    }
    public double getValorAquisicao()
    {
        return  this.valorAquisicao;
    }
    public void setValorVenda()
    {
        this.valorVenda = this.valorAquisicao;
        this.valorVenda += (this.valorVenda * this.impostoISMC) + (this.valorVenda * this.impostoISMC);
        this.valorVenda += (this.valorVenda * this.lucro);
    }
    public double getValorVenda()
    {
        return this.valorVenda;
    }
}