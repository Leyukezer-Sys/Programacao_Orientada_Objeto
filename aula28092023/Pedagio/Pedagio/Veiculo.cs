public class Veiculo
{
    private string placa;
    private int qtdEixo, tipo;
    private double precoPedagio, valorFinal, desconto;
    public Veiculo(string placaVeiculo, int quantidadeEixos, int tipoVeiculo)
    {
        this.setPlaca(placaVeiculo);
        this.setQuantidadeEixo(quantidadeEixos);
        this.setTipoVeiculo(tipoVeiculo);
        this.CalcularPedagio();
    }
    public void setPlaca(string placaVeiculo)
    {
        this.placa = placaVeiculo;
    }
    public string getPlacaVeiculo() { return this.placa; }
    public void setQuantidadeEixo(int quantidade)
    {
        this.qtdEixo = quantidade;
    }
    public int getQuantidadeEixo() { return this.qtdEixo; }
    public void setTipoVeiculo(int tipoVeiculo)
    {
        if (tipoVeiculo > 3 || tipoVeiculo < 1)
        {
            Console.WriteLine("Selecione um Tipo Válido");
        }
        else
        {
            this.tipo = tipoVeiculo;
            this.setDesconto();
        }
    }
    public int getTipoVeiculo() { return this.tipo; }
    public void setPrecoPedagio(double valorPedagio)
    {
        if (valorPedagio < 0)
        {
            Console.WriteLine("Valor não pode ser negativo");
        }
        else this.precoPedagio = valorPedagio;
    }
    public double getPrecoPedagio() {  return this.precoPedagio;}
    public void setValorFinal(double valorFinal)
    {
        if (valorFinal < 0)
        {
            Console.WriteLine("Valor não pode ser negativo");
        }
        else this.valorFinal = valorFinal;
    }
    public double getValorFinal() {  return this.valorFinal; }
    private void setDesconto()
    {
        if (this.getTipoVeiculo() == 1)
        {
            this.desconto = 0.0;
        }
        else if (this.getTipoVeiculo() == 2)
        {
            this.desconto = 0.05;
        }
        else if (this.getTipoVeiculo() == 3)
        {
            this.desconto = 1;
        }
    }
    public double getDesconto() { return this.desconto; }
    public virtual void CalcularPedagio()
    {
        this.setPrecoPedagio(this.getQuantidadeEixo()*3);
        this.CalcularDesconto();
    }
    public void CalcularDesconto()
    {
        this.setValorFinal(this.getPrecoPedagio()*(1-this.getDesconto()));
    }
}