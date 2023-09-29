public class Passeio : Veiculo
{
    public Passeio(string placaVeiculo, int quantidadeEixos, int tipoVeiculo) : base(placaVeiculo, quantidadeEixos, tipoVeiculo)
    {
        this.CalcularPedagio();
    }
    
    public override void CalcularPedagio()
    {
        base.setPrecoPedagio(this.getQuantidadeEixo() * 3);
        base.CalcularDesconto();
    }
}
