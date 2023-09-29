public class Onibus : Veiculo
{
    public Onibus(string placaVeiculo, int quantidadeEixos, int tipoVeiculo) : base(placaVeiculo, quantidadeEixos, tipoVeiculo)
    {
        this.CalcularPedagio();
    }
    public override void CalcularPedagio()
    {
        double preco = base.getQuantidadeEixo() * 5;
        base.setPrecoPedagio(preco * (1 + 0.05));
        base.CalcularDesconto();
    }
}
