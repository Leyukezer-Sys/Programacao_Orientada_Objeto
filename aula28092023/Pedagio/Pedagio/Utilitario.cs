public class Utilitario : Veiculo
{
    public Utilitario(string placaVeiculo, int quantidadeEixos, int tipoVeiculo) : base(placaVeiculo, quantidadeEixos, tipoVeiculo)
    {
        this.CalcularPedagio();
    }
    public override void CalcularPedagio()
    {
        double preco = base.getQuantidadeEixo() * 3.5;
        base.setPrecoPedagio(preco * (1 + 0.02));
        base.CalcularDesconto();
    }
}
