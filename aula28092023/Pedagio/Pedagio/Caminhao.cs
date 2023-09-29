public class Caminhao : Veiculo
{
    public Caminhao(string placaVeiculo, int quantidadeEixos, int tipoVeiculo) : base(placaVeiculo, quantidadeEixos, tipoVeiculo)
    {
        this.CalcularPedagio();
    }
    public override void CalcularPedagio()
    {
        double preco = base.getQuantidadeEixo() * 7;
        base.setPrecoPedagio(preco * (1 + 0.1));
        base.CalcularDesconto();
    }
}